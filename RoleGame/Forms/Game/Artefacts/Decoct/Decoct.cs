using Forms.Engine;
using RoleGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Game.Artefacts.Decoct
{
    internal class Decoct : Artefact
    {
        public override void Perform(IGameObject aim, int power)
        {
            if (aim is Character character)
            {
                if (character.State != characterState.normal)
                    return;
                character.State = characterState.poisoned;
            }
            
        }
        public override string ToString()
        {
            return "Декокт";
        }
    }
}
