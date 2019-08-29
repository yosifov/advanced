﻿namespace Advanced.DefiningClasses.PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.BadgesCount = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }

        public int BadgesCount { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.BadgesCount} {this.Pokemons.Count}";
        }
    }
}
