using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas
{
    public partial class formularioInicio : Form
    {
        public formularioInicio()
        {
            InitializeComponent();
        }
        private void Menu(object AbrirFormulario)
        {
            if (this.panelContenido.Controls.Count > 0)          
                this.panelContenido.Controls.RemoveAt(0);
                Form formulario = AbrirFormulario as Form;
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                this.panelContenido.Controls.Add(formulario);
                this.panelContenido.Tag = formulario;
                formulario.Show();
            
        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            Menu(new Productos());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Menu(new AgregarProducto());
        }
    }
}
