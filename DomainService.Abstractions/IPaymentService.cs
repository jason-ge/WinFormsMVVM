using DomainModel;

namespace DomainService.Abstractions
{
    public interface IPaymentService
    {
        Task<bool> PayBillerAsync(string biller, decimal amount, PaymentSource source);
    }
}
