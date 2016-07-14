using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayFun_
{
    class Cuts
    {
        public int minimumNumberOfCuts (int stickLength) {

            int cutsCount = 0;
            
            // If stick is of length one it can't be cut
            if (stickLength <= 1)
            {
                return cutsCount;
            }

            cutsCount = 1;
            int potentialPieces = 2;

            // Until the stick is of the correct length, double the number of potential pieces
            while (potentialPieces < stickLength)
            {
                potentialPieces *= 2;
                cutsCount++;
            }

            return cutsCount;
        }

    }
}
