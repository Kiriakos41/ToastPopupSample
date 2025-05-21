using Mopups.Pages;
using Mopups.Services;

namespace ToastPopupSample.PopUp;

public partial class ToastPopup : PopupPage
{
    public ToastPopup(string message, int durationMilliseconds = 3000)
    {
        InitializeComponent();

        // Set the text message of the toast
        MessageLabel.Text = message;

        // Set the initial vertical position off-screen (above)
        ToastBorder.TranslationY = -100;

        // Make the toast fully transparent initially
        ToastBorder.Opacity = 0;

        // Subscribe to the Appearing event which triggers when the popup is shown
        Appearing += async (s, e) =>
        {
            // Animate the toast sliding down into view and fading in simultaneously
            await Task.WhenAll(
                ToastBorder.TranslateTo(0, 50, 400, Easing.Linear),  // Move to visible position
                ToastBorder.FadeTo(1, 200, Easing.CubicIn)          // Fade in opacity to fully visible
            );

            // Keep the toast visible for the specified duration (default 3000 ms = 3 seconds)
            await Task.Delay(durationMilliseconds);

            // Animate the toast sliding back up and fading out simultaneously
            await Task.WhenAll(
                ToastBorder.TranslateTo(0, -100, 200, Easing.CubicIn), // Move back off-screen
                ToastBorder.FadeTo(0, 200, Easing.CubicOut)            // Fade out opacity to invisible
            );

            // Remove this popup from the popup stack once animation completes
            await MopupService.Instance.RemovePageAsync(this);
        };
    }


}