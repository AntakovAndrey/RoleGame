using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleGame.Magic
{
    public interface IMagic
    {
        void PerformMagic();
        void PerformMagic(Character aimCharacter);
        void PerformMagic(double impactForce);
        void PerformMagic(Character aimCharacter, double impactForce);
    }
}
