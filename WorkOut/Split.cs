using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOut
{
    [Serializable]
    class Split
    {
        public string splitName;
        public int daysNumber;
        public string[,] dayWorkouts;

        public Split()
        {

        }
        public Split(string splitName)
        {
            this.splitName = splitName;
        }
        public Split(string splitName,int daysNumber):this(splitName)
        {
            this.daysNumber = daysNumber;
        }
        public Split(string splitName, int daysNumber,string[,] dayWorkouts) : this(splitName,daysNumber)
        {
            this.dayWorkouts = dayWorkouts;
        }

        public override string ToString()
        {
            return $"{splitName},{daysNumber.ToString()}";
        }
    }
}
