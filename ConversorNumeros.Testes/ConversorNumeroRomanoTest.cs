using ConversorNumero.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConversorNumeros.Testes
{
    
    [TestClass]
    public class ConversorNumeroRomanoTest 
    {
        private ConversorNumeroRomano conversor;

        public ConversorNumeroRomanoTest()
        {
            conversor = new ConversorNumeroRomano();
        }

        #region classe de equivalencia 01 - Unidade
        [TestMethod]
        [DataRow("I",1)]
        [DataRow("II", 2)]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("V", 5)]
        [DataRow("VI", 6)]
        [DataRow("VII", 7)]
        [DataRow("VIII", 8)]
        [DataRow("IX", 9)]
        [DataRow("X", 10)]                
        public void Deve_converter_numeros_romanos_do_1_ao_10(string numero, int resultadoEsperado)
        {
            //cenário - arrange
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterParaArabico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        #endregion

        #region classe de equivalencia 02 - Dezena
        [TestMethod]
        [DataRow("X", 10)]
        [DataRow("XX", 20)]
        [DataRow("XXX", 30)]
        [DataRow("XL", 40)]
        [DataRow("L", 50)]
        [DataRow("LX", 60)]
        [DataRow("LXX", 70)]
        [DataRow("LXXX", 80)]
        [DataRow("XC", 90)]
        public void Deve_converter_dezenas_romanos_do_10_ao_90(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterParaArabico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        #endregion

        #region classe de equivalencia 03 - Dezena e Unidade
        [TestMethod]
        [DataRow("XI", 11)]
        [DataRow("XII", 12)]
        [DataRow("XIII", 13)]
        [DataRow("XIV", 14)]
        [DataRow("XV", 15)]
        [DataRow("XVI", 16)]
        [DataRow("XVII", 17)]
        [DataRow("XVIII", 18)]
        [DataRow("XIX", 19)]
        [DataRow("XX", 20)]
        public void Deve_converter_numeros_romanos_do_11_ao_20(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterParaArabico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }


        [TestMethod]
        [DataRow("XXI", 21)]
        [DataRow("XXII", 22)]
        [DataRow("XXIII", 23)]
        [DataRow("XXIV", 24)]
        [DataRow("XXV", 25)]
        [DataRow("XXVI", 26)]
        [DataRow("XXVII", 27)]
        [DataRow("XXVIII", 28)]
        [DataRow("XXIX", 29)]
        [DataRow("XXX", 30)]
        public void Deve_converter_numeros_romanos_do_21_ao_30(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterParaArabico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("XXXI", 31)]
        [DataRow("XXXII", 32)]
        [DataRow("XXXIII", 33)]
        [DataRow("XXXIV", 34)]
        [DataRow("XXXV", 35)]
        [DataRow("XXXVI", 36)]
        [DataRow("XXXVII", 37)]
        [DataRow("XXXVIII", 38)]
        [DataRow("XXXIX", 39)]
        [DataRow("XL", 40)]
        public void Deve_converter_numeros_romanos_do_31_ao_40(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterParaArabico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("XLI", 41)]
        [DataRow("XLII", 42)]
        [DataRow("XLIII", 43)]
        [DataRow("XLIV", 44)]
        [DataRow("XLV", 45)]
        [DataRow("XLVI", 46)]
        [DataRow("XLVII", 47)]
        [DataRow("XLVIII", 48)]
        [DataRow("XLIX", 49)]
        [DataRow("L", 50)]
        public void Deve_converter_numeros_romanos_do_41_ao_50(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterParaArabico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("LI", 51)]
        [DataRow("LII", 52)]
        [DataRow("LIII", 53)]
        [DataRow("LIV", 54)]
        [DataRow("LV", 55)]
        [DataRow("LVI", 56)]
        [DataRow("LVII", 57)]
        [DataRow("LVIII", 58)]
        [DataRow("LIX", 59)]
        [DataRow("LX", 60)]
        public void Deve_converter_numeros_romanos_do_51_ao_60(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterParaArabico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("LXI", 61)]
        [DataRow("LXII", 62)]
        [DataRow("LXIII", 63)]
        [DataRow("LXIV", 64)]
        [DataRow("LXV", 65)]
        [DataRow("LXVI", 66)]
        [DataRow("LXVII", 67)]
        [DataRow("LXVIII", 68)]
        [DataRow("LXIX", 69)]
        [DataRow("LXX", 70)]
        public void Deve_converter_numeros_romanos_do_61_ao_70(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterParaArabico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("LXXI", 71)]
        [DataRow("LXXII", 72)]
        [DataRow("LXXIII", 73)]
        [DataRow("LXXIV", 74)]
        [DataRow("LXXV", 75)]
        [DataRow("LXXVI", 76)]
        [DataRow("LXXVII", 77)]
        [DataRow("LXXVIII", 78)]
        [DataRow("LXXIX", 79)]
        [DataRow("LXXX", 80)]
        public void Deve_converter_numeros_romanos_do_71_ao_80(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterParaArabico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }


        [TestMethod]
        [DataRow("LXXXI", 81)]
        [DataRow("LXXXII", 82)]
        [DataRow("LXXXIII", 83)]
        [DataRow("LXXXIV", 84)]
        [DataRow("LXXXV", 85)]
        [DataRow("LXXXVI", 86)]
        [DataRow("LXXXVII", 87)]
        [DataRow("LXXXVIII", 88)]
        [DataRow("LXXXIX", 89)]
        [DataRow("XC", 90)]
        public void Deve_converter_numeros_romanos_do_81_ao_90(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterParaArabico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("XCI", 91)]
        [DataRow("XCII", 92)]
        [DataRow("XCIII", 93)]
        [DataRow("XCIV", 94)]
        [DataRow("XCV", 95)]
        [DataRow("XCVI", 96)]
        [DataRow("XCVII", 97)]
        [DataRow("XCVIII", 98)]
        [DataRow("XCIX", 99)]
        [DataRow("C", 100)]
        public void Deve_converter_numeros_romanos_do_91_ao_100(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterParaArabico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        #endregion

        #region classe de equivalencia 04 - Centena e Unidade
        [TestMethod]
        [DataRow("CI", 101)]
        [DataRow("CII", 102)]
        [DataRow("CIII", 103)]
        [DataRow("CIV", 104)]
        [DataRow("CV", 105)]
        [DataRow("CVI", 106)]
        [DataRow("CVII", 107)]
        [DataRow("CVIII", 108)]
        [DataRow("CIX", 109)]
        [DataRow("CX", 110)]
        public void Deve_converter_numeros_romanos_do_101_ao_110(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterParaArabico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        #endregion

        #region classe de equivalencia 05 - Centena, Dezena e Unidade
        [TestMethod]
        [DataRow("CXI", 111)]
        [DataRow("CXII", 112)]
        [DataRow("CXIII", 113)]
        [DataRow("CXIV", 114)]
        [DataRow("CXV", 115)]
        [DataRow("CXVI", 116)]
        [DataRow("CXVII", 117)]
        [DataRow("CXVIII", 118)]
        [DataRow("CXIX", 119)]
        [DataRow("CXX", 120)]
        public void Deve_converter_numeros_romanos_do_111_ao_120(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterParaArabico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        #endregion

        #region classe de equivalencia 06 - Milhar e Unidade

        [TestMethod]
        [DataRow("M", 1000)]
        [DataRow("MI", 1001)]
        [DataRow("MII", 1002)]
        [DataRow("MIII", 1003)]
        [DataRow("MIV", 1004)]
        [DataRow("MV", 1005)]
        [DataRow("MVI", 1006)]
        [DataRow("MVII", 1007)]
        [DataRow("MVIII", 1008)]
        [DataRow("MIX", 1009)]
        public void Deve_converter_numeros_romanos_do_1001_ao_1010(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterParaArabico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        #endregion

        #region classe de equivalencia 07 - Milhar, Centena, Dezena
        [TestMethod]
        [DataRow("MC", 1100)]
        [DataRow("MCX", 1110)]
        [DataRow("MCXX", 1120)]
        [DataRow("MCXXX", 1130)]
        [DataRow("MCXL", 1140)]
        [DataRow("MCL", 1150)]
        [DataRow("MCLX", 1160)]
        [DataRow("MCLXX", 1170)]
        [DataRow("MCLXXX", 1180)]
        [DataRow("MCXC", 1190)]
        [DataRow("MCC", 1200)]
        public void Deve_converter_numeros_romanos_do_1111_ao_1120(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterParaArabico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        #endregion

        #region classe de equivalencia 08 - Milhar, Centena, Dezena e Unidade
        [TestMethod]
        [DataRow("V̄CXI", 5111)]
        [DataRow("V̄CXII", 5112)]
        [DataRow("V̄CXIII", 5113)]
        [DataRow("V̄CXIV", 5114)]
        [DataRow("V̄CXV", 5115)]
        [DataRow("V̄CXVI", 5116)]
        [DataRow("V̄CXVII", 5117)]
        [DataRow("V̄CXVIII", 5118)]
        [DataRow("V̄CXIX", 5119)]
        [DataRow("V̄CXX", 5120)]
        public void Deve_converter_numeros_romanos_do_5111_ao_5120(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.ConverterParaArabico(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        #endregion
    }
}
