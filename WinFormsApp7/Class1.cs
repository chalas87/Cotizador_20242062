using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7
{
    public class Reserva
    {

        private const decimal TasaItbis = 0.18m;
        private const decimal tasaServicio = 0.10m;
        private const decimal tasaDescuanto = 0.10m;
        private const decimal RecargoTemporadaAlta = 0.25m;
        private const int NochesParaDescuento = 7;

        public decimal Sudtotal => EstemporadaAlta
            ? Noches * TarifaPorNoche * (1 + RecargoTemporadaAlta)
            : Noches * TarifaPorNoche;

        public decimal Descuento =>
            NochesParaDescuento >= NochesParaDescuento ? Sudtotal * tasaDescuanto : 0m;

        public decimal BaseImponible => Sudtotal - Descuento;

        public decimal Itbis => BaseImponible * tasaServicio;
         
        public decimal servicio => BaseImponible* tasaServicio;

        public decimal Total => BaseImponible + Itbis + servicio;





}
