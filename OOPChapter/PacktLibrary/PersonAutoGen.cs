﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Packt.Shared
{
    public partial class Person
    {
        private string favoritePrimaryColor;
        // a property defined using C# 1 - 5 syntax
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }
        // two properties defined using C# 6+ lambda expression body syntax
        public string Greeting => $"{Name} says 'Hello!'";
        public int Age => System.DateTime.Today.Year - DateOfBirth.Year;
        public string FavoriteIceCream { get; set; } // auto-syntax

        public string FavoritePrimaryColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new ArgumentException(
                        $"{value} is not a primary color. " +
                        "Choose from: red, green, blue.");
                }
            }
        }

        public Person this[int index]
        {
            get
            {
                return Children[index]; // pass on to the List<T> indexer
            }
            set
            {
                Children[index] = value;
            }
        }
    }
}
