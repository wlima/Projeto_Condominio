using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using BLL;

namespace Testes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsMorador m = new clsMorador();
            dalMorador mor = new dalMorador();
            m.Nome = "Jessica Ramalho";
            m.CPF = "56842170321";
            m.RG = "7984521451";
            mor.Inserir(m);

        }
    }
}
