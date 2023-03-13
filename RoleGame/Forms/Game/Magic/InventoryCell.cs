using Forms.Game.Artefacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Game.Magic
{
    public class InventoryCell
    {
        protected Artefact cell;
        public Artefact Cell
        { get => cell;set => cell = value; }
        public InventoryCell(Artefact cell)
        {
            this.cell = cell;
        }
    }
}
