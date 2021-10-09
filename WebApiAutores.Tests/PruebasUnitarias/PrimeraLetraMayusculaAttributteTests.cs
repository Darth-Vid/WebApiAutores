using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using WebApiAutores.Validaciones;
using Xunit.Sdk;

namespace WebApiAutores.Tests.PruebasUnitarias
{
    [TestClass]
    public class PrimeraLetraMayusculaAttributteTests
    {
        [TestMethod]
        public void PrimeraLetraMinuscula_DevuelveError()
        {
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            var valor = "david";
            var valContext = new ValidationContext(new { Nombre = valor });

            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);

            Assert.AreEqual("La primera letra debe ser mayuscula", resultado.ErrorMessage);
        }

        [TestMethod]
        public void ValorNulo_NoDevuelveError()
        {
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            string valor = null;
            var valContext = new ValidationContext(new { Nombre = valor });

            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);

            Assert.IsNull(resultado);
        }

        [TestMethod]
        public void ValorConPrimeraLetraMayuscula_NoDevuelveError()
        {
            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            string valor = "David";
            var valContext = new ValidationContext(new { Nombre = valor });

            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);

            Assert.IsNull(resultado);
        }
    }
}
