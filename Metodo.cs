using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ex9
{
    public class Metodo
    {
        public float Valido { get; set; }
        public float Branco { get; set; }
        public float Nulo { get; set; }
        public float Vtotal => Valido + Branco + Nulo;
        
        public void Vvalido ()
        {
            Console.WriteLine($"O percentual de votos válidos é {(Valido / Vtotal) * 100}%.");
        }

        public void Vbranco()
        {
            Console.WriteLine($"O percentual de votos válidos é {(Branco / Vtotal) * 100}%.");
        }

        public void Vnulo()
        {
            Console.WriteLine($"O percentual de votos válidos é {(Nulo / Vtotal) * 100}%.");
        }
    }
}
