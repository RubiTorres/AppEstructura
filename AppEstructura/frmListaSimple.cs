using System;
using System.Windows.Forms;

namespace AppEstructura
{
  public partial class frmListaSimple : Form
  {
    public frmListaSimple()
    {
      InitializeComponent();
    }
    NodoLS n;
    Operaciones MiLista = new Operaciones();
    private void btnGuardar_Click(object sender, EventArgs e)
    {
      n = new NodoLS();
      n.Dato = int.Parse(txtNodo.Text);
      MiLista.Agregar(n);
      lblLista.Text = MiLista.ToString();
      txtNodo.Clear();
    }
    private void btnEliminar_Click(object sender, EventArgs e)
    {
      int dato = int.Parse(txtNodo.Text);
      MiLista.Borrar(dato);
      lblLista.Text = MiLista.ToString();
      txtNodo.Clear();
    }
    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
