using Forms.Engine;
using RoleGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Game.Artefacts.BattleOfLivingWater
{
    internal class AvvarageBattleOfLivingWater : Artefact
    {
        public override void Perform(IGameObject aim)
        {
            if (aim is Character character)
                character.Health += 25;
        }
    }
}
