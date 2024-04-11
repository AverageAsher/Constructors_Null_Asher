// Game.cs
using System;

public class Game
{
    public string Title { get; set; }
    public string Genre { get; set; }

    // Constructor with default parameter values
    public Game(string title = "Unknown Title", string genre = "Casual")
    {
        Title = title;
        Genre = genre;
    }
}