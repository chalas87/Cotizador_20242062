namespace WinFormsApp7;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    // Escribe los valores en el cuadro "Totales"
    private void MostrarTotales(decimal subtotal, decimal descuento, decimal itbis, decimal servicio, decimal total)
    {
        lblSudtotal0.Text = subtotal.ToString("N2");
        lblDescuento0.Text = descuento.ToString("N2");
        lblITBIS0.Text = itbis.ToString("N2");
        lblSERVICIOS0.Text = servicio.ToString("N2");
        lblTotal0.Text = total.ToString("N2");
    }

    // 1. IMPERATIVO: la receta, paso a paso
    private void btnImperativo_Click(object sender, EventArgs e)
    {
        string huesped = txtHuesped.Text;
        int noches = (int)nudNoches.Value;
        decimal tarifa = nudTarifa.Value;
        if (chkTemporadaAlta.Checked)
        {
            tarifa = tarifa * 1.25m;
        }

        decimal subtotal = noches * tarifa;
        decimal descuento = 0m;
        if (noches >= 7)
        {
            descuento = subtotal * 0.10m;
        }
        decimal baseImponible = subtotal - descuento;
        decimal itbis = baseImponible * 0.18m;
        decimal servicio = baseImponible * 0.10m;
        decimal total = baseImponible + itbis + servicio;

        MostrarTotales(subtotal, descuento, itbis, servicio, total);
        lstResultados.Items.Add($"[Imperativo] {huesped}: US$ {total:N2}");
    }

    // 2. OBJETOS: el dato sabe calcularse solo
    private void btnObjetos_Click(object sender, EventArgs e)
    {
        var reserva = new Reserva
        {
            Huesped = txtHuesped.Text,
            Noches = (int)nudNoches.Value,
            TarifaPorNoche = nudTarifa.Value,
            TemporadaAlta = chkTemporadaAlta.Checked
        };

        MostrarTotales(reserva.Subtotal, reserva.Descuento, reserva.Itbis, reserva.Servicio, reserva.Total);
        lstResultados.Items.Add($"[Objetos]    {reserva.Huesped}: US$ {reserva.Total:N2}");
    }

    // 3. FUNCIONAL: funciones pequeñas que se combinan
    private void btnFuncional_Click(object sender, EventArgs e)
    {
        Func<int, decimal, decimal> calcSubtotal = (n, t) => n * t;
        Func<int, decimal, decimal> calcDescuento = (n, s) => n >= 7 ? s * 0.10m : 0m;
        Func<decimal, decimal> calcItbis = b => b * 0.18m;
        Func<decimal, decimal> calcServicio = b => b * 0.10m;
        Func<decimal, decimal> conImpuestos = b => b * 1.28m;

        Func<int, decimal, decimal> calcTotal = (n, t) =>
        {
            decimal sub = calcSubtotal(n, t);
            decimal desc = calcDescuento(n, sub);
            return conImpuestos(sub - desc);
        };

        int noches = (int)nudNoches.Value;
        decimal tarifa = chkTemporadaAlta.Checked ? nudTarifa.Value * 1.25m : nudTarifa.Value;

        decimal subtotal = calcSubtotal(noches, tarifa);
        decimal descuento = calcDescuento(noches, subtotal);
        decimal baseImponible = subtotal - descuento;
        decimal total = calcTotal(noches, tarifa);

        MostrarTotales(subtotal, descuento, calcItbis(baseImponible), calcServicio(baseImponible), total);
        lstResultados.Items.Add($"[Funcional]  {txtHuesped.Text}: US$ {total:N2}");
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        lstResultados.Items.Clear();
        MostrarTotales(0, 0, 0, 0, 0);
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}