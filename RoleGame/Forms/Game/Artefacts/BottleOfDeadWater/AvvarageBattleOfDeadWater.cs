using Forms.Engine;
using RoleGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Game.Artefacts.BottleOfLivingWater
{
    internal class AvvarageBattleOfDeadWater : Artefact
    {
        public override void Perform(IGameObject aim, int power)
        {
            if (aim is CharacterMag mag)
                mag.Mana += 25;
        }
        public override string ToString()
        {
            return "Средняя бутылка мертвой воды";
        }
    }
}
