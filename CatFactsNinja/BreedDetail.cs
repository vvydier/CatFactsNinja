﻿using System;
namespace CatFactsNinja
{
    public class BreedDetail
    {
        public string Breed { get; set; }
        public string Country { get; set; }
        public string Origin { get; set; }
        public string Coat { get; set; }
        public string Pattern { get; set; }


        public override string ToString()
        {
            return Breed;
        }
    }
}
