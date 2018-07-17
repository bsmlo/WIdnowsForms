using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rain
{
    class CountedDots
    {
        public List<int> countedDrops = new List<int>();
        public int chosedVelocity = new int();

        public CountedDots(int velocity, int counted)
        {
            chosedVelocity = velocity;
            countedDrops.Add(counted);
        }

        public void AddCounted(int counted)
        {
            countedDrops.Add(counted);
        }
    }
}
