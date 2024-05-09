using DomainModel;
using DomainService.Abstractions;

namespace DomainService
{
    public class PaymentService: IPaymentService
    {
        public async Task<bool> PayBillerAsync(string biller, decimal amount, PaymentSource source)
        {
            await Task.Delay(1000).ConfigureAwait(false);
            return true;
        }
    }
}
