using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Financas;

namespace UnitTest
{
    [TestClass]
    public class FinancasUnitTest
    {
        [TestMethod]
        public void TestTotalPgto_01()
        {
            double ValorTotal = CalculoFinanceiro.CalcularEmprestimo(10000.00, 12, 0.02);
            Assert.AreEqual(12682.42, ValorTotal);
        }

        [TestMethod]
        public void TestTotalPgto_02()
        {
            double ValorTotal = CalculoFinanceiro.CalcularEmprestimo(25000.00, 6, 0.02);
            Assert.AreEqual(28154.06, ValorTotal);
        }

        [TestMethod]
        public void TestTotalPgto_03()
        {
            double ValorTotal = CalculoFinanceiro.CalcularEmprestimo(30000.00, 9, 0.02);
            Assert.AreEqual(35852.78, ValorTotal);
        }

        [TestMethod]
        public void TestTotalPgto_04()
        {
            double ValorTotal = CalculoFinanceiro.CalcularEmprestimo(11937.28, 24, 0.04);
            Assert.AreEqual(30598.88, ValorTotal);
        }

        [TestMethod]
        public void TestTotalPgto_05()
        {
            double ValorTotal = CalculoFinanceiro.CalcularEmprestimo(25000.00, 12, 0.04);
            Assert.AreEqual(40025.81, ValorTotal);
        }

        [TestMethod]
        public void TestTotalPgto_06()
        {
            double ValorTotal = CalculoFinanceiro.CalcularEmprestimo(27000.00, 3, 0.04);
            Assert.AreEqual(30371.33, ValorTotal);
        }

        [TestMethod]
        public void TestTotalPgto_07()
        {
            double ValorTotal = CalculoFinanceiro.CalcularEmprestimo(15000.00, 36, 0.06);
            Assert.AreEqual(122208.78, ValorTotal);
        }

        [TestMethod]
        public void TestTotalPgto_08()
        {
            double ValorTotal = CalculoFinanceiro.CalcularEmprestimo(22000.00, 12, 0.06);
            Assert.AreEqual(44268.32, ValorTotal);
        }

        [TestMethod]
        public void TestTotalPgto_09()
        {
            double ValorTotal = CalculoFinanceiro.CalcularEmprestimo(10000,6,0.06);
            Assert.AreEqual(14185.19,ValorTotal);
        }

    }
}
