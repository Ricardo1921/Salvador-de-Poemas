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
     }

        public string apagar()
        {
            _texto = " ";

            return _texto;
            

        }

        public void salvar(string value)
        {
            _texto = value;
            File.WriteAllText(_path , _texto);
        }

        public string MAIS()
        {
            _texto = _texto.ToUpper();
            return _texto;
        }

        public string MIN()
        {
            _texto = texto.ToLower();
            return _texto;
        }

        public string IM()
        {
            _texto = char.ToUpper
        }


    }
}
