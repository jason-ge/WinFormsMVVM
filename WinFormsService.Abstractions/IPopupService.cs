namespace WinFormsService.Abstractions
{
    public interface IPopupService
    {
        void ShowMessage(string title,  string message);
        void ShowError(string title, string message);
    }
}
