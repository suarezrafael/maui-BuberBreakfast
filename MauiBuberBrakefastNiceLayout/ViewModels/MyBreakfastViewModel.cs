using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiBuberBrakefastNiceLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBuberBrakefastNiceLayout.ViewModels;

public partial class MyBreakfastViewModel : ObservableObject
{
    [ObservableProperty]
    List<Breakfast> breakfasts;

    [ObservableProperty]
    bool isRefreshing;

    public MyBreakfastViewModel()
    {
        LoadBreakfastsAsync();
    }
    [RelayCommand]
    public async Task LoadBreakfastsAsync()
    {
        try
        {
            IsRefreshing = true;

            await Task.Delay(2000);

            Breakfasts = new()
        {
            new Breakfast(
                Name:"Vegan Sunshine",
                Description:"Vegan everything!",
                StartDateTime:DateTime.UtcNow.AddDays(1),
                EndDateTime:DateTime.UtcNow.AddDays(1).AddHours(2),
                ImageUrl: new Uri("https://images.unsplash.com/photo1633204339708-86"),
                Savory: new List<string>{ "Oatmeal","Avocado Toast","Omelet","Salac"},
                Sweet: new List<string>{"Cookie"}),
            new Breakfast(
                Name:"Vegan Sunshine",
                Description:"Vegan everything!",
                StartDateTime:DateTime.UtcNow.AddDays(1),
                EndDateTime:DateTime.UtcNow.AddDays(1).AddHours(2),
                ImageUrl: new Uri("https://images.unsplash.com/photo1633204339708-86"),
                Savory: new List<string>{ "Oatmeal","Avocado Toast","Omelet","Salac"},
                Sweet: new List<string>{"Cookie"})

        };
        }
        finally
        {
            IsRefreshing = false;
        }
    }
}

