using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Esercitazione_test_con_composite
{
    public class VeroFalso : Domanda
    {
        private string _testo;

        public string Testo
        {
            get { return _testo; }
            set { _testo = value; }
        }

        public VeroFalso()
        {
            Testo = "";
        }

        public VeroFalso(string testo)
        {
            Testo = testo;
        }

        public VeroFalso(VeroFalso oldDomanda)
        {
            Testo = oldDomanda.Testo;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is VeroFalso) || obj == null)
                return false;

            VeroFalso other = (VeroFalso)obj;

            return Testo == other.Testo;
        }

        public void Aggiunta(IComponent comp)
        {

        }

        public void Rimuovi(int index)
        {

        }

        public IComponent GetChild(int index)
        {
            return null;
        }

        public override string ToString()
        {
            return $"Testo domanda vero/falso: {Testo};";
        }
    }
}
