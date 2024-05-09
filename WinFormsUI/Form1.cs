using DomainService.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using WinFormsService.Abstractions;
using WinformViewModel;

namespace WinFormsUI
{
    public partial class Form1 : Form
    {
        private BillPaymentViewModel _viewModel;
        private BindingSource billPaymentVeiwModelBindingSource;

        public Form1(IServiceProvider provider)
        {
            InitializeComponent();
            _viewModel = new BillPaymentViewModel(provider.GetRequiredService<IPopupService>(), provider.GetRequiredService<IPaymentService>());
            billPaymentVeiwModelBindingSource = new BindingSource();
            billPaymentVeiwModelBindingSource.DataSource = _viewModel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboBillers.DataSource = this._viewModel.Billers;
            cboBillers.DisplayMember = "Name";
            cboBillers.DataBindings.Add(nameof(cboBillers.SelectedIndex), _viewModel, nameof(_viewModel.SelectedBiller), false, DataSourceUpdateMode.OnPropertyChanged);
            txtAmount.DataBindings.Add(nameof(txtAmount.Text), billPaymentVeiwModelBindingSource, nameof(_viewModel.Amount), true, DataSourceUpdateMode.OnPropertyChanged, "", "C2");
            rdbCash.DataBindings.Add(nameof(rdbCash.Checked), billPaymentVeiwModelBindingSource, nameof(_viewModel.IsCashPayment), false, DataSourceUpdateMode.OnPropertyChanged);
            rdbCheque.DataBindings.Add(nameof(rdbCheque.Checked), billPaymentVeiwModelBindingSource, nameof(_viewModel.IsChequePayment), false, DataSourceUpdateMode.OnPropertyChanged);
            rdbAccount.DataBindings.Add(nameof(rdbAccount.Checked), billPaymentVeiwModelBindingSource, nameof(_viewModel.IsAccountPayment), false, DataSourceUpdateMode.OnPropertyChanged);
            btnPay.DataBindings.Add(nameof(btnPay.Command), billPaymentVeiwModelBindingSource, nameof(_viewModel.PayBillerCommand), true);
            btnPay.DataBindings.Add(nameof(btnPay.Enabled), billPaymentVeiwModelBindingSource, nameof(_viewModel.CanPay), true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}