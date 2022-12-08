using System;
using System.Windows.Forms;

namespace AppEstructura
{
  public partial class frmListaDC : Form
  {
    ListaDC miLista= new ListaDC();
    public frmListaDC()
    {
      InitializeComponent();
    }
    private void btnInsertar_Click(object sender, EventArgs e)
    {
      NodoDC n = new NodoDC();
      n.Dato = int.Parse(txtdato.Text);
      miLista.Agregar(n);
      miLista.ImprimirPU();
      txtdato.Clear();
    }
    private void btnEliminar_Click(object sender, EventArgs e)
    {
      int dato = int.Parse(txtdato.Text);
      miLista.Eliminar(dato);
      miLista.ImprimirPU();
      txtdato.Clear();
    }
    private void btnBuscar_Click(object sender, EventArgs e)
    {
      int dato = 0;
      try
      { dato = int.Parse(txtdato.Text); }
      catch
      { }
      if (miLista.Buscar(dato))
      {
        MessageBox.Show("Encontrado");
        return;
      }
      MessageBox.Show("No encontrado");
      txtdato.Clear();
    }    
  }
}

