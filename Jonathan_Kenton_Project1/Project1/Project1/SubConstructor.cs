using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class SubConstructor
    {
        public int SubSize;
        public string SubMeat;
        public List<string> SubExtras = new List<string>();
        public List<string> SubVegetables = new List<string>();
        public List<string> SubSaucesAndSeasonings = new List<string>();
        public bool SubToasted;
        public bool SubCutInHalf;
        
        public SubConstructor(int SubSize, string SubMeat, List<string> SubExtras,
            List<string> SubVegetables, List<string> SubSaucesAndSeasonings, 
            bool SubToasted, bool SubCutInHalf)
        {
            this.SubSize = SubSize;
            this.SubMeat = SubMeat;
            this.SubExtras = SubExtras;
            this.SubVegetables = SubVegetables;
            this.SubSaucesAndSeasonings = SubSaucesAndSeasonings;
            this.SubToasted = SubToasted;
            this.SubCutInHalf = SubCutInHalf;
        }

    }
}
