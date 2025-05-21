using Mopups.Services;
using ToastPopupSample.PopUp;

namespace ToastPopupSample;

public static class ToastService
{
    public static void Show(string message, int durationMilliseconds = 3000)
    {
        MainThread.BeginInvokeOnMainThread(async () =>
        {
            var popup = new ToastPopup(message, durationMilliseconds);
            await MopupService.Instance.PushAsync(popup);
        });
    }
}
