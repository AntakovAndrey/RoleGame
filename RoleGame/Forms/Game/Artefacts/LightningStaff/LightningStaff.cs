using Forms.Engine;
using RoleGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Game.Artefacts.LightningStaff
{
    internal class LightningStaff : Artefact
    {
        public override void Perform(IGameObject aim,int power)
        {
            if (aim is Character character)
            {
                if(this.power-power<0)
                    return;
                character.Health-=power;
                this.power-=power;
            }
            
        }
        public override string ToString()
        {
            return "Посох молния";
        }
    }
}
