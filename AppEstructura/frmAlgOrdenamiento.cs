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
  public partial class frmAlgOrdenamiento : Form
  {
    public frmAlgOrdenamiento()
    {
      InitializeComponent();
    }
    private void btnBurbuja_Click(object sender, EventArgs e)
    {
      frmBurbuja burbuja = new frmBurbuja();
      burbuja.ShowDialog(); 
    }
    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    private void btnInserción_Click(object sender, EventArgs e)
    {
      frmInsercion insercion = new frmInsercion();
      insercion.ShowDialog();
    }
    private void btnSelection_Click(object sender, EventArgs e)
    {
      frmSeleccion seleccion = new frmSeleccion();
      seleccion.Show();
    }
    private void btnQuickSort_Click(object sender, EventArgs e)
    {
      frmQuickSort Quick = new frmQuickSort();
      Quick.Show();
    }
    private void btnGrafos_Click(object sender, EventArgs e)
    {
      frmRadix R = new frmRadix();
      R.Show();
    }
    private void btnCuentas_Click(object sender, EventArgs e)
    {      
      frmCounting C = new frmCounting();
      C.Show();
    }
    private void btnMezclaNatural_Click(object sender, EventArgs e)
    {
      frmMezclas Mn=new frmMezclas();
      Mn.Show();
    }
    private void btnABB_Click(object sender, EventArgs e)
    {
      frmOrdenamientoABB ABB = new frmOrdenamientoABB();
      ABB.Show();
    }
  }
}
