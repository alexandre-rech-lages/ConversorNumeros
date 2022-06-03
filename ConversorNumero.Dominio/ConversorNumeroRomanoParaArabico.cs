using System;
using System.Collections.Generic;

namespace ConversorNumero.Dominio
{
    public class ConversorNumeroRomanoParaArabico
    {
        Dictionary<string, int> numeros = new Dictionary<string, int>();

        public ConversorNumeroRomanoParaArabico()
        {
            numeros.Add("", 0);
            numeros.Add("I", 1);
            numeros.Add("II", 2);
            numeros.Add("III", 3);
            numeros.Add("IV", 4);
            numeros.Add("V", 5);
            numeros.Add("VI", 6);
            numeros.Add("VII", 7);
            numeros.Add("VIII", 8);
            numeros.Add("IX", 9);
            numeros.Add("X", 10);


        }

        public int Converter(string numeroRomano)
        {
            #region primeira tentantiva do 20 ao 30
            //if (numeroRomano.StartsWith("XX"))
            //{
            //    numeroRomano = numeroRomano.Substring(1);
            //    return numeros[numeroRomano] + 20;
            //}
            #endregion

            if (numeroRomano.StartsWith("X"))
            {
                int numeroBase;

                if (numeroRomano.StartsWith("XXX"))
                {
                    numeroRomano = numeroRomano.Substring(3);
                    numeroBase = 30;
                }
                else if (numeroRomano.StartsWith("XX"))
                {
                    numeroRomano = numeroRomano.Substring(2);
                    numeroBase = 20;
                }
                else
                {
                    numeroRomano = numeroRomano.Substring(1);
                    numeroBase = 10;
                }

                return numeros[numeroRomano] + numeroBase;
            }

            return numeros[numeroRomano];
        }

    }
}
