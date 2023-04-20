namespace MauiBuberBrakefastNiceLayout.Models;

public record Breakfast(
    string Name,
    string Description,
    DateTime StartDateTime,    
    DateTime EndDateTime,
    string ImageUrl,
    List<string> Savory,
    List<string> Sweet);
