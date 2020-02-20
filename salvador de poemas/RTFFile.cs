using System.IO;
using System.Windows.Forms;

namespace salvador_de_poemas
{
    class RTFFile
    {
        private string _path = Application.StartupPath + "\\Resources\\9.txt";
        private string _texto;

        public string texto
        {
            get
            {
                _texto = File.ReadAllText(_path);
                return _texto;
            }
            set { _texto = value; }
        }

        public void apagar()
        
    }
}
