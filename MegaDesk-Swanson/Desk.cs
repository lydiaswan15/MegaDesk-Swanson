using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Swanson
{
    public enum DesktopMaterial
    {
        Laminate, 
        Oak, 
        Rosewood, 
        Veneer, 
        Pine
    }

    class Desk
    {
        public decimal Width { get; set; }

        public decimal Height { get; set; }

        public int NumOfDrawers { get; set; }

        public DesktopMaterial SurfaceMaterial { get; set; }
    }
}
