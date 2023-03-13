using Forms.Engine;
using RoleGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Game.Artefacts.BattleOfLivingWater
{
    internal class BigBattleOfLivingWater : Artefact
    {
        public override void Perform(IGameObject aim)
        {
            if (aim is Character character)
                character.Health += 50;
        }
    }
}
