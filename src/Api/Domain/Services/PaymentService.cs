using Api.Domain.Dtos;
using Api.Domain.Interfaces;

namespace Api.Domain.Services;

public class PaymentService : IPaymentService
{
    public Task<Guid> CreatePayment(CreatePaymentDto createPaymentDto)
    {
        return Task.FromResult(Guid.NewGuid());
    }

    public Task<PaymentSummaryDto> GetPaymentSummary()
    {
        return Task.FromResult(
            new PaymentSummaryDto
            {
                DefaultTotalPayments = new DefaultPaymentProcessorDto
                {
                    TotalRequests = 0,
                    TotalAmount = 0,
                },
                FallbackTotalPayments = new FallbackPaymentProcessorDto
                {
                    TotalRequests = 0,
                    TotalAmount = 0,
                },
            }
        );
    }
}
