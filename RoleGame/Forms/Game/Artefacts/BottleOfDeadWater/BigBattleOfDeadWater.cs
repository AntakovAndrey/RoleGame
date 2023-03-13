using Forms.Engine;
using RoleGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Game.Artefacts.BottleOfLivingWater
{
    internal class BigBattleOfDeadWater : Artefact
    {
        public override void Perform(IGameObject aim, int power)
        {
            if (aim is CharacterMag mag)
                mag.Mana += 50;
        }
        public override string ToString()
        {
            return "Большая бутылка мертвой воды";
        }
    }
    
}
