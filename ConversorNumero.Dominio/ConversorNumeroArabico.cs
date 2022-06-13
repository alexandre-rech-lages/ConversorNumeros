using System;
using System.Collections.Generic;

namespace ConversorNumero.Dominio
{
    public class ConversorNumeroArabico
    {
        Dictionary<int, string> unidades = new Dictionary<int, string>();
        Dictionary<int, string> dezenas = new Dictionary<int, string>();
        Dictionary<int, string> centenas = new Dictionary<int, string>();
        Dictionary<int, string> milhares = new Dictionary<int, string>();

        public ConversorNumeroArabico()
        {
            string[] unidadesRomanas = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] dezenasRomanas = { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] centenasRomanas = { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] milharesRomanas = { "M", "MM", "MMM", "ĪV̄", "V̄", "V̄Ī", "V̄ĪĪ", "V̄ĪĪĪ", "ĪX̄" };

            unidades = new Dictionary<int, string>();

            for (int i = 0; i < 9; i++)
            {
                unidades[i + 1] = unidadesRomanas[i];
                dezenas[i + 1] = dezenasRomanas[i];
                centenas[i + 1] = centenasRomanas[i];
                milhares[i + 1] = milharesRomanas[i];
            }
        }

        public string ConverterParaRomano(int numeroArabico) //CCXI - 211
        {
            string digitos = numeroArabico.ToString();

            string numeroRomano = "";

            if (digitos.Length >= 1)
                numeroRomano = ObterNumeroRomano(digitos, ClasseNumeroRomano.Unidade);

            if (digitos.Length >= 2)
                numeroRomano = ObterNumeroRomano(digitos, ClasseNumeroRomano.Dezena) + numeroRomano;

            if (digitos.Length >= 3)
                numeroRomano = ObterNumeroRomano(digitos, ClasseNumeroRomano.Centena) + numeroRomano;

            if (digitos.Length >= 4)
                numeroRomano = ObterNumeroRomano(digitos, ClasseNumeroRomano.UnidadeMilhar) + numeroRomano;

            return numeroRomano;
        }

        enum ClasseNumeroRomano
        {
            Unidade, Dezena, Centena, UnidadeMilhar
        }

        private string ObterNumeroRomano(string digitos, ClasseNumeroRomano classe)
        {
            int posicao;
            Dictionary<int, string> numeros = new Dictionary<int, string>();

            switch (classe)
            {
                case ClasseNumeroRomano.Unidade: posicao = 1; numeros = unidades; break;

                case ClasseNumeroRomano.Dezena: posicao = 2; numeros = dezenas; break;

                case ClasseNumeroRomano.Centena: posicao = 3; numeros = centenas; break;

                case ClasseNumeroRomano.UnidadeMilhar: posicao = 4; numeros = milhares; break;

                default: posicao = 0; break;
            }

            string numeroRomano = "";

            int digito = (int)char.GetNumericValue(digitos[digitos.Length - posicao]);

            if (numeros.ContainsKey(digito))
                numeroRomano = numeros[digito] + numeroRomano;

            return numeroRomano;
        }
    }
}