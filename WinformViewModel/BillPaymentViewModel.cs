using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DomainModel;
using DomainService.Abstractions;
using WinFormsService.Abstractions;

namespace WinformViewModel
{
    public partial class BillPaymentViewModel : ObservableObject
    {
        private int _selectedBiller;
        [ObservableProperty]
        private decimal? _amount;
        private PaymentSource _source;
        private bool _canPay;
        private IPopupService _popupService;
        private IPaymentService _paymentService;

        public BillPaymentViewModel(IPopupService popupService, IPaymentService paymentService)
        {
            Billers =
            [
                new Biller() { Id = -1, Name="-- Please select a biller to pay --"},
                new Biller() { Id = 1, Name="Rogers"},
                new Biller() { Id = 2, Name="Bell Canada"}
            ];
            _selectedBiller = 0;
            _popupService = popupService;
            _paymentService = paymentService;
        }

        public bool CanPay
        {
            get
            {
                var canPayNow = SelectedBiller > 0 && Amount != null && Source != PaymentSource.None;
                if (canPayNow != _canPay)
                {
                    _canPay = canPayNow;
                    OnPropertyChanged();
                }
                return _canPay;
            }
        }

        /// <summary>
        ///  Method that is executed when the command is invoked.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanPay))]
        public async Task PayBiller()
        {
            if (await _paymentService.PayBillerAsync(Billers[SelectedBiller].Name, Amount.Value, Source))
            {
                _popupService.ShowMessage("Payment Successful", $"Paid {string.Format("{0:C2}", Amount)} to biller {Billers[SelectedBiller].Name} with {Source}");
            }
            else
            {
                _popupService.ShowError("Payment failed", $"Failed to pay {string.Format("{0:C2}", Amount)} to biller {Billers[SelectedBiller].Name} with {Source}");
            }
        }

        public List<Biller> Billers { get; }

        public int SelectedBiller
        {
            get => _selectedBiller;
            set
            {
                if (_selectedBiller == value)
                {
                    return;
                }

                _selectedBiller = value;
                if (_selectedBiller == 0)
                {
                    Amount = null;
                    _source = PaymentSource.None;
                }

                // Notify the UI that the property has changed.
                OnPropertyChanged();
            }
        }

        public bool IsCashPayment
        {
            get { return Source == PaymentSource.Cash; }
            set
            {
                if (value && Source != PaymentSource.Cash)
                {
                    Source = PaymentSource.Cash;
                }
            }
        }

        public bool IsChequePayment
        {
            get { return Source == PaymentSource.Cheque; }
            set
            {
                if (value && Source != PaymentSource.Cheque)
                {
                    Source = PaymentSource.Cheque;
                }
            }
        }

        public bool IsAccountPayment
        {
            get { return Source == PaymentSource.Account; }
            set
            {
                if (value && Source != PaymentSource.Account)
                {
                    Source = PaymentSource.Account;
                }
            }
        }

        public PaymentSource Source
        {
            get { return this._source; }
            set
            {
                if (this._source == value)
                    return;

                this._source = value;
                OnPropertyChanged(nameof(IsCashPayment));
                OnPropertyChanged(nameof(IsChequePayment));
                OnPropertyChanged(nameof(IsAccountPayment));
            }
        }
    }
}