using System;
using System.Windows.Forms;

namespace AppEstructura
{
  public partial class frmColaPrioridad : Form
  {
    public frmColaPrioridad()
    {
      InitializeComponent();
    }
    ColaP prio = new ColaP();
    private void btnAdd_Click(object sender, EventArgs e)
    {
      NodoP nuevo = new NodoP();
      nuevo.Dato = txtDato.Text;
      nuevo.Prioridad = int.Parse(txtPri.Text);
      prio.Agregar(nuevo);
      txtDato.Text = "";
      txtPri.Text = "";
      txtCola.Text = prio.ToString();
    }
    private void btnNum_Click(object sender, EventArgs e)
    {
      prio.CrearArreglo(int.Parse(txtNum.Text));
      grbFirst.Visible = false;
      grbSec.Visible = true;
    }
    private void btnDel_Click(object sender, EventArgs e)
    {
      prio.Eliminar();
      txtCola.Text = prio.ToString();
    }
    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
