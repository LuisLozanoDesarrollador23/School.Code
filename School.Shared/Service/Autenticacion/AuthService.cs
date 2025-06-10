using System.Text;
using System.Text.Json;
using Microsoft.JSInterop;

namespace School.Shared.Service.Autenticacion;

public class AuthService
{
    private readonly HttpClient _httpClient;
    private readonly IJSRuntime _js;

    public AuthService(HttpClient httpClient, IJSRuntime js)
    {
        _httpClient = httpClient;
        _js = js;
    }

    public async Task<bool> LoginAsync(string username, string password)
    {
        var loginData = new { username, password };
        var content = new StringContent(JsonSerializer.Serialize(loginData), Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("api/token/", content); // URL de tu endpoint en Django

        if (response.IsSuccessStatusCode)
        {
            var responseContent = await response.Content.ReadAsStringAsync();
            var token = JsonDocument.Parse(responseContent).RootElement.GetProperty("access").GetString();

            await _js.InvokeVoidAsync("localStorage.setItem", "authToken", token); // Guardar el token en localStorage
            return true;
        }

        return false;
    }

    public async Task<bool> IsUserAuthenticated()
    {
        var token = await GetTokenAsync();
        return !string.IsNullOrEmpty(token);
    }

    public async Task<string> GetTokenAsync()
    {
        return await _js.InvokeAsync<string>("localStorage.getItem", "authToken");
    }

    public async Task LogoutAsync()
    {
        await _js.InvokeVoidAsync("localStorage.removeItem", "authToken");
    }
}