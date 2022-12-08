using System;
using System.Windows.Forms;

namespace AppEstructura
{
  public partial class frmColaSimple : Form
  {
    public frmColaSimple()
    {
      InitializeComponent();
    }
    Cola colaDinamica =new Cola();
    private void btnAdd_Click(object sender, EventArgs e)
    {
      colaDinamica.Agregar(txtDato.Text);
      txtCola.Text = colaDinamica.ToString();
      txtDato.Clear();
    }
    private void btnDel_Click(object sender, EventArgs e)
    {
      colaDinamica.Eliminar();
      txtCola.Text = colaDinamica.ToString();
    }
    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
