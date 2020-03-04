using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacionII_estadistica
{
    public partial class Parcial : Form
    {
        ConversionesParcial objConversor = new ConversionesParcial();
        public Parcial()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            lblRespuesta.Text = objConversor.conversiones(cboTipo.SelectedIndex, cboDe.SelectedIndex,
                    cboA.SelectedIndex, double.Parse(txtValor.Text)).ToString();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        
        {
           
                cboDe.Items.Clear();
                cboA.Items.Clear();

                cboDe.Items.AddRange(objConversor.Conversor[cboTipo.SelectedIndex]);
                cboA.Items.AddRange(objConversor.Conversor[cboTipo.SelectedIndex]);
            }
            
        }
    }
    

