using Api.Domain.Dtos;
using Api.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class PaymentController(IPaymentService paymentService) : Controller
{
    private readonly IPaymentService _paymentService = paymentService;

    [HttpPost("/payments")]
    public async Task<IActionResult> CreatePayment([FromBody] CreatePaymentDto createPaymentDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var paymentId = await _paymentService.CreatePayment(createPaymentDto);
        return CreatedAtAction(nameof(CreatePayment), new { id = paymentId }, createPaymentDto);
    }

    [HttpGet("/payments-summary")]
    public async Task<IActionResult> GetPaymentSummary()
    {
        var paymentSummary = await _paymentService.GetPaymentSummary();

        if (paymentSummary == null)
            return NotFound();

        return Ok(paymentSummary);
    }
}
