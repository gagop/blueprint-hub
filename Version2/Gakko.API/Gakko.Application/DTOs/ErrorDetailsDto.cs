using System.Text.Json;

namespace Gakko.Application.DTOs;

public class ErrorDetailsDto
{
    public int StatusCode { get; set; }
    public string Message { get; set; }
    public string ExceptionMessage { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}