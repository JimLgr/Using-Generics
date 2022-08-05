using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenerics
{
    public class TheRange<UnknownType> where UnknownType : IComparable<UnknownType>
    {
        public UnknownType LowerBound { get; private set; }
        public UnknownType UpperBound { get; private set; }


        public TheRange(UnknownType pLowerBound, UnknownType pUpperBound)
        {
            if (pLowerBound.CompareTo(pUpperBound) >= 0) throw new ArgumentOutOfRangeException("Error la borne inférieur est plus grande que la borne suppérieur");
            
            LowerBound = pLowerBound;
            UpperBound = pUpperBound;

            
        }
        

        public bool IsIncluded(UnknownType pTemperature)
        {
            return pTemperature.CompareTo(this.LowerBound) >= 0 && pTemperature.CompareTo(this.UpperBound) <= 0;
        }

     
    }
}
