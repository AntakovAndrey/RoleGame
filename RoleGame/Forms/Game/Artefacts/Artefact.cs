using Forms;
using Forms.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Game.Artefacts
{
    public abstract class Artefact
    {
        protected double power;
        protected bool renovation;
        public abstract void Perform(IGameObject aim);

    }
}
