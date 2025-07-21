namespace Api.Domain.Dtos;

public class PaymentSummaryDto
{
    public DefaultPaymentProcessorDto DefaultTotalPayments { get; set; } = new();
    public FallbackPaymentProcessorDto FallbackTotalPayments { get; set; } = new();
}

public class DefaultPaymentProcessorDto
{
    public int TotalRequests { get; set; }
    public decimal TotalAmount { get; set; }
}

public class FallbackPaymentProcessorDto
{
    public int TotalRequests { get; set; }
    public decimal TotalAmount { get; set; }
}
