using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGOL
{
    internal class Documentation
    {
        #region private attributs
        private string _gamesRules;
        #endregion private attributs

        #region public method
        public Documentation(string gamesRules) 
        {
            _gamesRules = gamesRules;
        }

        public string GamesRules
        {
            get 
            { 
                return _gamesRules; 
            }
            set 
            { 
                _gamesRules = value; 
            }
        }
        #endregion public method
    }
}
