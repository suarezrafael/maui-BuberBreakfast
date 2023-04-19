namespace MauiBuberBrakefastNiceLayout.Models;

public record Breakfast(
    string Name,
    string Description,
    DateTime StartDateTime,    
    DateTime EndDateTime,
    Uri ImageUrl,
    List<string> Savory,
    List<string> Sweet);
