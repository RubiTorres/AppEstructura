using System;
using System.Windows.Forms;

namespace AppEstructura
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    private void btnEDD_Click(object sender, EventArgs e)
      {
      frmEDD EDD = new frmEDD();
      EDD.Show();
      }
    private void btnAlgoritmos_Click(object sender, EventArgs e)
    {
      frmAlgOrdenamiento Alg = new frmAlgOrdenamiento();
      Alg.Show(); 
    }
  }
}
