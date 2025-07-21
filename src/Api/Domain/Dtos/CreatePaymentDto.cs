namespace Api.Domain.Dtos;

public class CreatePaymentDto
{
    public string CorrelationId { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
