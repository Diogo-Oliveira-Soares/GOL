using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGOL
{
    internal class Score
    {
        #region private attributs
        private int _score;
        #endregion private attributs

        #region public method
        public Score() 
        { 

        }

        public int ShowScore
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
            }
        }
        #endregion public method
    }
}
