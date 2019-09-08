namespace Advanced.DefiningClasses.PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Execute()
        {
            var trainers = new List<Trainer>();

            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                string trainerName = input.Split()[0];
                string pokemonName = input.Split()[1];
                string pokemonElement = input.Split()[2];
                int pokemonHealth = int.Parse(input.Split()[3]);

                if (!trainers.Any(x => x.Name == trainerName))
                {
                    trainers.Add(new Trainer(trainerName));
                }

                trainers
                    .FirstOrDefault(x => x.Name == trainerName)
                    .Pokemons
                    .Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(x => x.Element == input))
                    {
                        trainer.BadgesCount++;
                    }
                    else
                    {
                        ReduceHealth(trainer.Pokemons);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.BadgesCount))
            {
                Console.WriteLine(trainer.ToString());
            }
        }

        public static void ReduceHealth(List<Pokemon> pokemons)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                pokemons[i].Health -= 10;

                if (pokemons[i].Health <= 0)
                {
                    pokemons.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
