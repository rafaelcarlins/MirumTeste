using Microsoft.VisualStudio.TestTools.UnitTesting;
using MirumTeste.ApplicationCore.Entity;
using MirumTeste.ApplicationCore.Interface.Services;
using System.Collections.Generic;

namespace UnitTestProjectMirum
{
    [TestClass]
    public class UnitTest1
    {

        private readonly ICargoServices _cargoService;

        public UnitTest1(ICargoServices cargoService)
        {
            _cargoService = cargoService;
        }

        [TestMethod]
        public void TestMethod1()
        {
            Cargo cargo = new Cargo();
            List<Cargo> cargos = new List<Cargo>();
            IEnumerable<Cargo> cargosRetornoFuncao;
            cargo.Id = 1;
            cargo.Funcao = "Teste";
            cargo.SalarioBase = 1;
            cargos.Add(cargo);

            cargosRetornoFuncao = _cargoService.ObterTodos();


            _cargoService.Adicionar(cargo);
            Assert.AreEqual(cargosRetornoFuncao, cargos);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Cargo cargo = new Cargo();
            List<Cargo> cargos = new List<Cargo>();
            List<Pessoa> pessoas = new List<Pessoa>();
            IEnumerable<Cargo> cargosRetornoFuncao;
            cargo.Id = 1;
            cargo.Funcao = "Teste";
            cargo.SalarioBase = 1;
            cargos.Add(cargo);

            cargosRetornoFuncao = _cargoService.ObterTodos();


            _cargoService.Adicionar(cargo);
            Assert.AreEqual(cargosRetornoFuncao, pessoas);
        }
    }
}
