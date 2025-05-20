using Mopups.Pages;
using Mopups.Services;

namespace ToastPopupSample.PopUp;

public partial class ToastPopup : PopupPage
{
    public ToastPopup(string message)
    {
        InitializeComponent();
        MessageLabel.Text = message;

        // Set initial TranslationY *before* the page appears
        ToastBorder.TranslationY = -100;
        ToastBorder.Opacity = 0;

        Appearing += async (s, e) =>
        {
            // Animate slide down and fade in
            await Task.WhenAll(
                ToastBorder.TranslateTo(0, 50, 400, Easing.Linear),
                ToastBorder.FadeTo(1, 200)
            );

            await Task.Delay(2000);

            // Animate slide up and fade out
            await Task.WhenAll(
                ToastBorder.TranslateTo(0, -100, 200, Easing.CubicIn),
                ToastBorder.FadeTo(0, 200)
            );

            await MopupService.Instance.RemovePageAsync(this);
        };
    }

}