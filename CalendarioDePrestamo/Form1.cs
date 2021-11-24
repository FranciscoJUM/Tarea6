using AppCore.Interfaces;
using Dominio.Entidades;
using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarioDePrestamo
{
    public partial class Form1 : Form
    {
        private IAtributosServices atr { get; set; }
        public Form1(IAtributosServices atr)
        {
            this.atr = atr;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CmbEstado.Items.AddRange(Enum.GetValues(typeof(Estado))
                                             .Cast<object>()
                                             .ToArray()
                                         );
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            Estado Egas = (Estado)CmbEstado.SelectedIndex;
            decimal x = atr.Principal(NumMonto.Value, NumTasa.Value, NumTerminos.Value);
            decimal y = atr.Interes(NumMonto.Value, NumTasa.Value, NumTerminos.Value);
            Atributos xy = new Atributos()
            {
                Id = +1,
                Fecha_Pago = DateFecha.Value,
                Monto_Del_Prestamo = NumMonto.Value,
                Principal = atr.Principal(NumMonto.Value, NumTasa.Value, NumTerminos.Value),
                Interes = atr.Interes(NumMonto.Value, NumTasa.Value, NumTerminos.Value),
                Cuota = atr.Cuota(x, y),
                terminos = NumTerminos.Value,
                Tasa = NumTasa.Value,
                Estados = Egas,
                Fecha_De_Pago = DateFechadepago.Value,
                PrincipalPagado = (bool)CheckPrincipal.Checked,
                InteresPAgado = (bool)CheckInteres.Checked,
                CuotaPagada = (bool)CheckCuota.Checked,

            };
            atr.Create(xy);
            Limpiar();
            MessageBox.Show($"Se grego correctamente");
        }



        private void Limpiar()
        {
            DateFecha.Value = DateTime.Now;
            NumMonto.Value = 1;
            NumTasa.Value = 1;
            NumTerminos.Value = 1;
            DateFechadepago.Value = DateTime.Now;
            CheckPrincipal.Checked = false;
            CheckInteres.Checked = false;
            CheckCuota.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
            RichMuestra.Text = "";

            MessageBox.Show($"Se Limpio todo");
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            if (atr.GetAtrAsJson() == null)
            { RichMuestra.Text = "Actuelmente no hay registro"; }
            else { RichMuestra.Text = atr.GetAtrAsJson().ToString(); }
        }
    }
}
