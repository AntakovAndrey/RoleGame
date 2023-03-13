using Forms.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Game.Artefacts
{
    internal interface IArtefact
    {
        void Perform(IGameObject aim);
    }
}
