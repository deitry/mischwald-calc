﻿namespace ClassLibrary1;

public class ITopBottomCard : ICard
{
    public required ITop Top { get; init; }

    public required IBottom Bottom { get; set; }
}
