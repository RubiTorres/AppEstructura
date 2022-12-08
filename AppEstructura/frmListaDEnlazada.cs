using System;
using System.Windows.Forms;

namespace AppEstructura
{
  public partial class frmListaDEnlazada : Form
  {
    MiListaD lista = new MiListaD();
    public frmListaDEnlazada()
    {
      InitializeComponent();
    }
    private void btnGuardar_Click(object sender, EventArgs e)
    {
      NodoLD n = new NodoLD();
      n.Dato = txtDato.Text;
      lista.Insertar(n.Dato);
      MessageBox.Show(txtDato + lista.ToString());
    }
    private void btnMostrar_Click(object sender, EventArgs e)
    {
      lista.head = lista.primero;
      while (lista.head != null)
      {
        lista.head = lista.head.Siguiente;
        lbxDato.Items.Add(Convert.ToString(lista.head.Dato));
      }
      lista.head = lista.ultimo;
      while (lista.head != null)
      {
        lista.head = lista.head.Anterior;
        lbxDato.Items.Add(Convert.ToString(lista.head.Dato));
      }
    }
    private void btnBuscar_Click(object sender, EventArgs e)
    {
      if (lista.Buscar(txtDato.Text))
      {
        MessageBox.Show("Encontrado");
      }
    }
    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
