﻿using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordMustangCreator:Creator
    {
        public override Vehicle create()
        {
            var builder = new CarBuilder();
            return builder.SetModel("Mustang").SetColor("Red").Build();
        }
    }
}
