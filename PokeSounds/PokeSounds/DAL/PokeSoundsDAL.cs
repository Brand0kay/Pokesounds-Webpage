using PokeSounds.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace PokeSounds.DAL
{
    public class PokeSoundsDAL : IPokeSoundsDAL
    {

        int i = 1;

        static private List<Pokemon> Pokemon = new List<Pokemon>()
        {
            
            new Pokemon() {Id = "001", Name = "Bulbasaur", ImageURL = "1.png", AudioPath ="001 - Bulbasaur"},
            new Pokemon() {Id = "002", Name = "Ivysaur", ImageURL = "2.png", AudioPath ="002 - Ivysaur.wav"},
            new Pokemon() {Id = "003", Name = "Venusaur", ImageURL = "3.png", AudioPath ="003 - Venusaur.wav"},
            new Pokemon() {Id = "004", Name = "Charmander", ImageURL = "4.png"},
            new Pokemon() {Id = "005", Name = "Charmeleon", ImageURL = "5.png"},
            new Pokemon() {Id = "006", Name = "Charizard", ImageURL = "6.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "007", Name = "Squirtle", ImageURL = "7.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "008", Name = "Wartortle", ImageURL = "8.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "009", Name = "Blastoise", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "010", Name = "Caterpie", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "011", Name = "Metapod", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "012", Name = "Butterfree", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "013", Name = "Weedle", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "014", Name = "Kakuna", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "015", Name = "Beedrill", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "016", Name = "Pidgey", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "017", Name = "Pidgeotto", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "018", Name = "Pidgeot", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "019", Name = "Rattata", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "020", Name = "Raticate", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "021", Name = "Spearow", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "022", Name = "Fearow", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "023", Name = "Ekans", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "023", Name = "Pikachu", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "023", Name = "Pikachu", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "024", Name = "Raichu", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "025", Name = "Sandshrew", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "026", Name = "Sandslash", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "027", Name = "Nidoran(F)", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "028", Name = "Nidorina", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "029", Name = "Nidoqueen", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "030", Name = "Nidoran(M)", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "031", Name = "Nidorino", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "032", Name = "Nidoking", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "033", Name = "Clefairy", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "034", Name = "Clefable", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "035", Name = "Vulpix", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "036", Name = "Ninetales", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "037", Name = "Jigglypuff", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "038", Name = "Wigglytuff", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "039", Name = "Zubat", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "040", Name = "Golbat", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "041", Name = "Oddish", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "042", Name = "Gloom", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "043", Name = "Vileplume", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "044", Name = "Paras", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "045", Name = "Parasect", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Venonat", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Venomoth", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Diglett", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Dugtrio", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Meowth", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Persian", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Psyduck", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Golduck", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Mankey", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Primeape", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Growlithe", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Arcanine", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Poliwag", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Poliwhirl", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Poliwrath", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Abra", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Kadabra", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Alakazam", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Machop", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Machoke", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Machamp", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Bellsprout", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Weepinbell", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Victreebel", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Tentacool", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Tentacruel", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Geodude", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Graveler", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Golem", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Ponyta", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Rapidash", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Slowpoke", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Slowbro", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Magnemite", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Magneton", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Farfetch'd", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Doduo", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Dodrio", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Seel", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Dewgong", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Grimer", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Muk", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Shellder", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Cloyster", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Gastly", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Haunter", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Gengar", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Onix", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Drowzee", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Hypno", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Krabby", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Kingler", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Voltorb", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Electrode", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Exeggcute", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Exeggutor", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Cubone", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Marowak", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Hitmonlee", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Hitmonchan", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Lickitung", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Koffing", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Weezing", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Rhyhorn", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Rhydon", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Chansey", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Tangela", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Kangaskhan", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Horsea", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Seadra", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Goldeen", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Seaking", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Staryu", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Starmie", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Mr. Mime", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Scyther", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Jynx", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Electabuzz", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Magmar", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Pinsir", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Tauros", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Magikarp", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Gyarados", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Lapras", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Ditto", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Eevee", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Vaporeon", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Jolteon", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Flareon", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Porygon", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Omanyte", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Omastar", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Kabuto", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Kabutops", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Aerodactyl", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Snorlax", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Articuno", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Zapdos", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Moltres", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Dratini", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Dragonair", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Dragonite", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Mewtwo", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},
            new Pokemon() {Id = "001", Name = "Mew", ImageURL = "1.png", AudioPath ="001 - Bulbasaur.wav"},

        };

        public IList<Pokemon> GetSounds()
        {
            return Pokemon;
        }

        //static PokeSoundsDAL()
        //{
        //    string path = Path.Combine(
        //        Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
        //        @"Audio");

        //    string[] files = File.ReadAllLines(path);
            
        //    for (int i = 1; i <= 151; i++)
        //    {
        //        sounds.Add(new Sound() { Id = i.ToString(), Name = "Bulbasaur", ImageURL = "/images/" + i +".png"});
        //    }          
        //}

        public Pokemon GetSound(string id)
        {
            foreach(var sound in Pokemon)
            {
                if (sound.Id == id)
                {
                    return sound;
                }             
            }
            return null;
        }
    }
}
