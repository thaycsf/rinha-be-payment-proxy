using Api.Domain.Dtos;

namespace Api.Domain.Interfaces;

public interface IPaymentService
{
    Task<Guid> CreatePayment(CreatePaymentDto createPaymentDto);
    Task<PaymentSummaryDto> GetPaymentSummary();
}
