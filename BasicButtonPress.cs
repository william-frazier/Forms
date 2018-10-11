using System;

public partial class BasicButtonPress : ContentPage
{
    public BasicButtonPresss()
    {
        InitializeComponent();
    }

    async void OnRouteClick(object sender, EventArgs args)
    {
        await label.RelRotateTo(360, 1000);
    }
}