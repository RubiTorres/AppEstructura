using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEstructura
{
  public partial class frmEDD : Form
  {
    public frmEDD()
    {
      InitializeComponent();
    }
    //Estructuras
    private void btnColas_Click(object sender, EventArgs e)
    {
      btnColaCircular.Visible = true;
      btnColaDePrioridad.Visible = true;
      btnColaDoble.Visible = true;
      btnColaSimple.Visible = true;
    }
    private void btnLista_Click(object sender, EventArgs e)
    {
      btnListaDobleEnlazada.Visible = true;
      btnListaSimpcircular.Visible = true;
      btnListaCircular.Visible = true;
      btnListaS.Visible = true;
    }
    private void btnListaS_Click(object sender, EventArgs e)
    {
      frmListaSimple ColaLista = new frmListaSimple();
      ColaLista.ShowDialog();
    }
    private void btnListaCircular_Click(object sender, EventArgs e)
    {
      frmListaC ListaC = new frmListaC();
      ListaC.Show();
    }
    private void btnListaDobleEnlazada_Click(object sender, EventArgs e)
    {
      frmListaDEnlazada ListaDEnlazada = new frmListaDEnlazada();
      ListaDEnlazada.Show();
    }
    private void btnListaSimpcircular_Click(object sender, EventArgs e)
    {
      frmListaDC ListaDC = new frmListaDC();
      ListaDC.Show();
    }
    private void btnColaSimple_Click(object sender, EventArgs e)
    {
      frmColaSimple ColaSimple = new frmColaSimple();
      ColaSimple.Show();
    }
    private void btnColaDoble_Click(object sender, EventArgs e)
    {
      frmBicola BiCola = new frmBicola();
      BiCola.ShowDialog();
    }
    private void btnColaCircular_Click(object sender, EventArgs e)
    {
      frmColaCircular ColaCircular = new frmColaCircular();
      ColaCircular.ShowDialog();
    }
    private void btnColaDePrioridad_Click(object sender, EventArgs e)
    {
      frmColaPrioridad ColaP = new frmColaPrioridad();
      ColaP.Show();
    }
    private void btnArbol_Click(object sender, EventArgs e)
    {
      frmArbolB ArbolB = new frmArbolB();
      ArbolB.Show();
    }
    private void btnGrafos_Click(object sender, EventArgs e)
    {
      frmGrafos Grafos = new frmGrafos();
      Grafos.Show();
    }
    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }    

  }
}
