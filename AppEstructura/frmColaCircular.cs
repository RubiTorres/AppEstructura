using System;
using System.Windows.Forms;

namespace AppEstructura
{
  public partial class frmColaCircular : Form
  {
    public frmColaCircular()
    {
      InitializeComponent();
    }
    ColaCirc circular=new ColaCirc();
    private void btnAdd_Click(object sender, EventArgs e)
    {
      circular.Agregar(txtDato.Text);
      txtDato.Clear();
      txtCola.Text = circular.ToString();
    }
    private void btnDel_Click(object sender, EventArgs e)
    {
      circular.Eliminar();
      txtCola.Text = circular.ToString();
    }
    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
