using School.Shared.Transferencia.ResponseApi;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace School.Shared.Service;

public class ApiClient
{
    private string token { get; set; } =
        "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ0b2tlbl90eXBlIjoiYWNjZXNzIiwiZXhwIjoxNzMxNjYzNTQ4LCJpYXQiOjE3MzE1NzcxNDgsImp0aSI6ImJkMTE3NmJlOTE1ODQzMzg4ZTRkYmFkNTgxZjg4NDg3IiwidXNlcl9pZCI6MX0.cUH3BlRjVCrTwk2ekfEBm_WDjfGl7Vf18o41s8mY4Po";

    /// <summary>
    /// Permite realizar la consulta de una entidad por su identificador.
    /// </summary>
    public async Task<ResponseGets> ConsultarRegistros(string entidad, int? id = null)
    {
        ResponseGets responseClient = new();

        try
        {
            var url = $"{CommonValues.ApiUrl}{entidad}/";
            if (id.HasValue)
            {
                url += $"{id}/";
            }

            HttpClient _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.GetAsync(url);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                responseClient.Data = jsonResponse;
                responseClient.Success = true;
            }
            else
            {
                responseClient.Message = jsonResponse;
                responseClient.Success = false;
            }
        }
        catch (Exception ex)
        {
            responseClient.Message = ex.Message;
            responseClient.Success = false;
        }

        return responseClient;
    }

    /// <summary>
    /// Permite enviar una solicitud POST a un API.
    /// </summary>
    public async Task<ResponsePost> CrearRegistro(string entidad, object content)
    {
        ResponsePost responseClient = new();
        try
        {
            HttpClient _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PostAsJsonAsync($"{CommonValues.ApiUrl}{entidad}/", content);
            if (response.IsSuccessStatusCode)
            {
                responseClient.Success = true;
            }
            else
            {
                responseClient.Message = await response.Content.ReadAsStringAsync();
                responseClient.Success = false;
            }
        }
        catch (Exception ex)
        {
            responseClient.Message = ex.Message;
            responseClient.Success = false;
        }

        return responseClient;
    }

    /// <summary>
    /// Permite enviar una solicitud PUT para actualizar un registro.
    /// </summary>
    public async Task<ResponsePost> ActualizarRegistro(string entidad, int id, object content)
    {
        ResponsePost responseClient = new();
        try
        {
            HttpClient _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PutAsJsonAsync($"{CommonValues.ApiUrl}{entidad}/{id}/", content);

            if (response.IsSuccessStatusCode)
            {
                responseClient.Success = true;
            }
            else
            {
                responseClient.Message = await response.Content.ReadAsStringAsync();
                responseClient.Success = false;
            }
        }
        catch (Exception ex)
        {
            responseClient.Message = ex.Message;
            responseClient.Success = false;
        }

        return responseClient;
    }

    /// <summary>
    /// Permite enviar una solicitud DELETE para eliminar un registro.
    /// </summary>
    public async Task<ResponsePost> EliminarRegistro(string entidad, int id)
    {
        ResponsePost responseClient = new();
        try
        {
            HttpClient _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.DeleteAsync($"{CommonValues.ApiUrl}{entidad}/{id}/");

            if (response.IsSuccessStatusCode)
            {
                responseClient.Success = true;
            }
            else
            {
                responseClient.Message = await response.Content.ReadAsStringAsync();
                responseClient.Success = false;
            }
        }
        catch (Exception ex)
        {
            responseClient.Message = ex.Message;
            responseClient.Success = false;
        }

        return responseClient;
    }
}