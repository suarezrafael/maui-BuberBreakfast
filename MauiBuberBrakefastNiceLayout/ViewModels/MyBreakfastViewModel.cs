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
                Name:"Luz do sol Vegano",
                Description:"Todos ingredientes veganos! Junte-se a nós para um café da manhã saudável cheio de pratos veganos e biscoitos",
                StartDateTime:DateTime.UtcNow.AddDays(1),
                EndDateTime:DateTime.UtcNow.AddDays(1).AddHours(2),
                ImageUrl: "cafe1.jpg",
                Savory: new List<string>{ "Aveia", "Bery","Omelete"},
                Sweet: new List<string>{"Cookie"}),
            new Breakfast(
                Name:"Café da manhã @Suarez's",
                Description:"Oi, eu sou o Rafael. Eu serei seu chef no domingo!",
                StartDateTime:DateTime.UtcNow.AddDays(1),
                EndDateTime:DateTime.UtcNow.AddDays(1).AddHours(2),
                ImageUrl: "cafe2.jpg",
                Savory: new List<string>{ "Sanduiche","Salada"},
                Sweet: new List<string>{"Paqueca","Waffle"})

        };
        }
        finally
        {
            IsRefreshing = false;
        }
    }
}

