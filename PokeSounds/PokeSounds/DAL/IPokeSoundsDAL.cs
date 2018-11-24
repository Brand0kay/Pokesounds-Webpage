using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PokeSounds.Models;

namespace PokeSounds.DAL
{
    public interface IPokeSoundsDAL
    {
        IList<Pokemon> GetSounds();

        Pokemon GetSound(string id);

        //Sprite GetSprite(string id);

        //IList<Sprite> GetSprite();
    }
}
