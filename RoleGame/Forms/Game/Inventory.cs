using Forms.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleGame
{
    public class Inventory
    {
        public int SelectedItemIndex { get; set; }
        public Inventory() 
        {
            this.inventory = new List<InventoryCell>();
        }
        protected List<InventoryCell> inventory;
        public List<InventoryCell> Cells
        { get => inventory; set => inventory = value; }
        public Inventory(List<InventoryCell> inventory)
        {
            this.inventory = inventory;
        }
        public void AddArtefact(InventoryCell artefact)
        {
            inventory.Add(artefact);
        }
        public void ToThrowOutArtefact(InventoryCell artefact)
        {
            inventory.Remove(artefact);
        }
        public void ToPassArtefact(Character character, InventoryCell artefact)
        {
            character.Inventory.AddArtefact(artefact);
            inventory.Remove(artefact);
        }
        public void UseArtefact(InventoryCell artefact,Character character,int power)
        {
            artefact.Cell.Perform(character, power);
            
        }
    }
}
