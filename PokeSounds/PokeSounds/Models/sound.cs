using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeSounds.Models
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string Id { get; set; }
        public string AudioPath { get; set; }
    }
}
