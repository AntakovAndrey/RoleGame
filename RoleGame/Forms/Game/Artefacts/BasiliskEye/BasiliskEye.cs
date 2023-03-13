using Forms.Engine;
using RoleGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Game.Artefacts.BasiliskEye
{
    internal class BasiliskEye : Artefact
    {
        public override void Perform(IGameObject aim, int power)
        {
            if (aim is Character character)
            {
                if (character.State == characterState.dead)
                    return;
                character.State = characterState.paralyzed;
            }
        }
    }
}
