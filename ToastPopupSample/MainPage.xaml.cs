﻿namespace ToastPopupSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object? sender, EventArgs e)
    {
        ToastService.Show("Saved successfully!");
    }
}
