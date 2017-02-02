﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.RendimientosPorDescuento.ComoUnProcedimiento;
using System;

namespace Negocio.UnitTests.RendimientosPorDescuento_Tests.ComoUnProcedimiento_Tests
{
    [TestClass]
    public class GenereElRendimientoPorDescuento_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private decimal elValorFacial;
        private decimal elValorTransadoNeto;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimiento;
        private decimal laTasaDeImpuesto;
        private bool tieneTratamientoFiscal;

        [TestMethod]
        public void GenereElRendimientoPorDescuento_ConTratamientoFiscal_LaFormula()
        {
            elResultadoEsperado = 21621.6216M;

            elValorFacial = 320000;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 8;
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            tieneTratamientoFiscal = true;
            elResultadoObtenido = CalculosDeRendimiento.GenereElRendimientoPorDescuento(
                elValorFacial,
                elValorTransadoNeto,
                laTasaDeImpuesto,
                laFechaDeVencimiento,
                laFechaActual,
                tieneTratamientoFiscal);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereElRendimientoPorDescuento_SinTratamientoFiscal_LaResta()
        {
            elResultadoEsperado = 20000;

            elValorFacial = 320000;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 8;
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            tieneTratamientoFiscal = false;
            elResultadoObtenido = CalculosDeRendimiento.GenereElRendimientoPorDescuento(
                elValorFacial,
                elValorTransadoNeto,
                laTasaDeImpuesto,
                laFechaDeVencimiento,
                laFechaActual,
                tieneTratamientoFiscal);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}