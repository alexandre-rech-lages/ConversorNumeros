using ConversorNumero.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConversorNumeros.Testes
{

    //CLASSES DE EQUIVALENCIA

    // 1) unidade
    // 2) dezena
    // 3) dezena e unidade
    // 4) centena
    // 5) centena e dezena
    // 6) centena e dezena e unidade
    // 7) unidade milhar
    // 8) unidade milhar centena
    // 9) unidade milhar centena e dezena
    // 10) unidade milhar centena e dezena e unidade

    [TestClass]
    public class ConversorNumeroArabicoTest
    {
        ConversorNumeroArabico conversor;

        public ConversorNumeroArabicoTest()
        {
            conversor = new ConversorNumeroArabico();
        }

        [TestMethod]
        [DataRow(1,"I")][DataRow(2,"II")][DataRow(3,"III")][DataRow(4,"IV")][DataRow(5,"V")]
        [DataRow(6,"VI")][DataRow(7,"VII")][DataRow(8,"VIII")][DataRow(9,"IX")]        
        public void Deve_converter_unidade_arabico(int numero, string resultadoEsperado)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterParaRomano(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow(10, "X")][DataRow(20, "XX")][DataRow(30, "XXX")][DataRow(40, "XL")][DataRow(50, "L")]
        [DataRow(60, "LX")][DataRow(70, "LXX")][DataRow(80, "LXXX")][DataRow(90, "XC")]
        public void Deve_converter_apenas_dezena_arabico(int numero, string resultadoEsperado)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterParaRomano(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    
        [TestMethod]
        [DataRow(10, "X")][DataRow(11, "XI")][DataRow(12, "XII")][DataRow(13, "XIII")][DataRow(14, "XIV")][DataRow(15, "XV")]
        [DataRow(16, "XVI")][DataRow(17, "XVII")][DataRow(18, "XVIII")][DataRow(19, "XIX")][DataRow(20, "XX")]
        public void Deve_converter_dezena_e_unidade_arabico(int numero, string resultadoEsperado)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterParaRomano(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
       
        [TestMethod]
        [DataRow(100, "C")]
        [DataRow(200, "CC")]
        [DataRow(300, "CCC")]
        [DataRow(400, "CD")]
        [DataRow(500, "D")]
        [DataRow(600, "DC")]
        [DataRow(700, "DCC")]
        [DataRow(800, "DCCC")]
        [DataRow(900, "CM")]
        public void Deve_converter_apenas_centena_arabico(int numero, string resultadoEsperado)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterParaRomano(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow(110, "CX")]
        [DataRow(210, "CCX")]
        [DataRow(310, "CCCX")]
        [DataRow(410, "CDX")]
        [DataRow(510, "DX")]
        [DataRow(610, "DCX")]
        [DataRow(710, "DCCX")]
        [DataRow(810, "DCCCX")]
        [DataRow(910, "CMX")]
        public void Deve_converter_centena_e_dezena_arabico(int numero, string resultadoEsperado)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterParaRomano(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow(111, "CXI")]
        [DataRow(211, "CCXI")]
        [DataRow(311, "CCCXI")]
        [DataRow(411, "CDXI")]
        [DataRow(511, "DXI")]
        [DataRow(611, "DCXI")]
        [DataRow(711, "DCCXI")]
        [DataRow(811, "DCCCXI")]
        [DataRow(911, "CMXI")]
        public void Deve_converter_centena_e_dezena_e_unidade_arabico(int numero, string resultadoEsperado)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterParaRomano(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }


        [TestMethod]
        [DataRow(1000, "M")]
        [DataRow(2000, "MM")]
        [DataRow(3000, "MMM")]
        [DataRow(4000, "ĪV̄")]
        [DataRow(5000, "V̄")]
        [DataRow(6000, "V̄Ī")]
        [DataRow(7000, "V̄ĪĪ")]
        [DataRow(8000, "V̄ĪĪĪ")]
        [DataRow(9000, "ĪX̄")]
        public void Deve_converter_apenas_unidade_milhar_arabico(int numero, string resultadoEsperado)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterParaRomano(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow(1100, "MC")]
        [DataRow(2100, "MMC")]
        [DataRow(3100, "MMMC")]
        [DataRow(4100, "ĪV̄C")]
        [DataRow(5100, "V̄C")]
        [DataRow(6100, "V̄ĪC")]
        [DataRow(7100, "V̄ĪĪC")]
        [DataRow(8100, "V̄ĪĪĪC")]
        [DataRow(9100, "ĪX̄C")]
        public void Deve_converter_unidade_milhar_e_centena_arabico(int numero, string resultadoEsperado)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterParaRomano(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow(1110, "MCX")]
        [DataRow(2110, "MMCX")]
        [DataRow(3110, "MMMCX")]
        [DataRow(4110, "ĪV̄CX")]
        [DataRow(5110, "V̄CX")]
        [DataRow(6110, "V̄ĪCX")]
        [DataRow(7110, "V̄ĪĪCX")]
        [DataRow(8110, "V̄ĪĪĪCX")]
        [DataRow(9110, "ĪX̄CX")]
        public void Deve_converter_unidade_milhar_e_centena_e_dezena_arabico(int numero, string resultadoEsperado)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterParaRomano(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow(1111, "MCXI")]
        [DataRow(2111, "MMCXI")]
        [DataRow(3111, "MMMCXI")]
        [DataRow(4111, "ĪV̄CXI")]
        [DataRow(5111, "V̄CXI")]
        [DataRow(6111, "V̄ĪCXI")]
        [DataRow(7111, "V̄ĪĪCXI")]
        [DataRow(8111, "V̄ĪĪĪCXI")]
        [DataRow(9111, "ĪX̄CXI")]
        public void Deve_converter_unidade_milhar_e_centena_e_dezena_unidade_arabico(int numero, string resultadoEsperado)
        {
            //cenário - arrange
            int numeroArabico = numero;

            //ação - action 
            var resultado = conversor.ConverterParaRomano(numeroArabico);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
