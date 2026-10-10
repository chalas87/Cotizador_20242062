using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7
{
    public class Reserva
    {
        // Datos de entrada
        public string Huesped { get; set; } = "";
        public int Noches { get; set; }
        public decimal TarifaPorNoche { get; set; }
        public bool TemporadaAlta { get; set; }

        // Cálculos: la reserva sabe hacerlos sola
        public decimal Subtotal => Noches * TarifaPorNoche * (TemporadaAlta ? 1.25m : 1m);
        public decimal Descuento => Noches >= 7 ? Subtotal * 0.10m : 0m;
        public decimal BaseImponible => Subtotal - Descuento;
        public decimal Itbis => BaseImponible * 0.18m;
        public decimal Servicio => BaseImponible * 0.10m;
        public decimal Total => BaseImponible + Itbis + Servicio;
    }
}
