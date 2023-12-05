using System.Xml.Linq;

namespace ClassGOL
{
    public class Player
    {
        #region private attributs
        private string _name;
        #endregion private attributs

        #region public method
        public Player(string name)
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        #endregion public method

    }
}
