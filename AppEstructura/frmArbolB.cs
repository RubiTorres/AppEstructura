using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AppEstructura
{
  public partial class frmArbolB : Form
  {
    ABB arbol;
    public frmArbolB()
    {
      InitializeComponent();
      arbol = new ABB();
    }
    private void btnAgregar_Click(object sender, EventArgs e)
    {
      if (String.IsNullOrEmpty(tbInsertar.Text) == false)
      {
        arbol.Insertar(tbInsertar.Text);
        Txt();
        string ruta = arbol.Graficar();
        System.Threading.Thread.Sleep(1000);
        FileStream file = new FileStream(ruta, FileMode.Open);
        Image img = Image.FromStream(file);
        pictureBox1.Image = img;
        file.Close();
      }
      tbInsertar.Clear();
    }
    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (String.IsNullOrEmpty(tbInsertar.Text) == false)
      {
        arbol.Eliminar(tbInsertar.Text);
        Txt();
        string ruta = arbol.Graficar();
        System.Threading.Thread.Sleep(1000);
        FileStream file = new FileStream(ruta, FileMode.Open);
        Image img = Image.FromStream(file);
        pictureBox1.Image = img;
        file.Close();
      }
      tbInsertar.Clear();
    }
    private void btnCerrar_Click(object sender, EventArgs e)
    {
      arbol.limpiar();
      string ruta = arbol.Graficar();
      System.Threading.Thread.Sleep(1000);
      Application.Exit();
    }
    private void btnReiniciar_Click(object sender, EventArgs e)
    {
      arbol.limpiar();
      Txt();
      string ruta = arbol.Graficar();
      System.Threading.Thread.Sleep(1000);
      FileStream file = new FileStream(ruta, FileMode.Open);
      Image img = Image.FromStream(file);
      pictureBox1.Image = img;
      file.Close();
      tbInsertar.Clear();
    }
    private void Txt()
    {
      tbInorden.Text = arbol.Inorden();
      tbPreorden.Text = arbol.Preorden();
      tbPostorden.Text = arbol.Postorden();
    }
    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
