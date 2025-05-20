using Mopups.Services;
using ToastPopupSample.PopUp;

namespace ToastPopupSample;

public static class ToastService
{
    public static void Show(string message)
    {
        MainThread.BeginInvokeOnMainThread(async () =>
        {
            var popup = new ToastPopup(message);
            await MopupService.Instance.PushAsync(popup);
        });
    }
}
