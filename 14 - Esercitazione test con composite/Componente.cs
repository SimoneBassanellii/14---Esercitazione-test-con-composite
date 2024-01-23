using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Esercitazione_test_con_composite
{
    public interface IComponent
    {
        void Aggiunta(IComponent comp);
        
        void Rimuovi(int index);
        
        IComponent GetChild(int index);
        
        bool Equals(object obj);
        
        string ToString();
        
        double Punteggio();
    }
}

