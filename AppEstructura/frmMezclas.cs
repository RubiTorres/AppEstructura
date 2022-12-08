﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AppEstructura
{
  public partial class frmMezclas : Form
  {
    public frmMezclas()
    {
      InitializeComponent();
    }
    OperacionMezcla mezcla = new OperacionMezcla();
    int[] vector;
    public int[] Cargar(int n)
    {
      Random r = new Random();
      int valor;
      //Dar n elementos
      vector = new int[n];
      //Guardar datos en el arreglo
      for (int i = 0; i < n; i++)
      {
        valor = 0;
        valor = r.Next(1, 100);
        vector[i] = valor;
      }
      return vector;
    }
    private void btnCrear_Click(object sender, EventArgs e)
    {
      int elementos = int.Parse(txtElementos.Text);
      Cargar(elementos);
    }    
    private void btnRecAsc_Click(object sender, EventArgs e)
    {
      var timer = new Stopwatch();
      timer.Start();
      lvwOrdenado.Clear();
      int[] a = mezcla.MezclaNatural(vector);
      mezcla.Mostrar(lvwOrdenado, a);
      lblEstadisticaNombre.Text = mezcla.DatosEstadisticos();
      timer.Stop();
      TimeSpan timeTaken = timer.Elapsed;
      string foo = "Tiempo: " + timeTaken.ToString(@"m\:ss\.fff");
      lblStadistica.Text = foo;

    }
    private void button3_Click(object sender, EventArgs e)
    {
      var timer = new Stopwatch();
      timer.Start();
      lvwOrdenado.Clear();
      int[] a = mezcla.MergeSortDes(vector);
      lblEstadisticaNombre.Text = mezcla.DatosEstadisticos();
      mezcla.Mostrar(lvwOrdenado, a);
      timer.Stop();
      TimeSpan timeTaken = timer.Elapsed;
      string foo = "Tiempo: " + timeTaken.ToString(@"m\:ss\.fff");
      lblStadistica.Text = foo;
    }
    private void btnRAscendenteDirecta_Click(object sender, EventArgs e)
    {
      var timer = new Stopwatch();
      timer.Start();
      lvwOrdenado.Clear();
      int[] a = mezcla.MezclaDirecta(vector);
      lblEstadisticaNombre.Text = mezcla.DatosEstadisticos();
      mezcla.Mostrar(lvwOrdenado, a);
      timer.Stop();
      TimeSpan timeTaken = timer.Elapsed;
      string foo = "Tiempo: " + timeTaken.ToString(@"m\:ss\.fff");
      lblStadistica.Text = foo;
    }
    private void btnRDescendenteDirecta_Click(object sender, EventArgs e)
    {
      var timer = new Stopwatch();
      timer.Start();
      lvwOrdenado.Clear();
      int[] a = mezcla.MergeSortDes(vector);
      lblEstadisticaNombre.Text = mezcla.DatosEstadisticos();
      mezcla.Mostrar(lvwOrdenado, a);
      timer.Stop();
      TimeSpan timeTaken = timer.Elapsed;
      string foo = "Tiempo: " + timeTaken.ToString(@"m\:ss\.fff");
      lblStadistica.Text = foo;

    }
    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      lvwOrdenado.Clear();
      lblEstadisticaNombre.Text = "--";
      lblStadistica.Text = "--";
    }
    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    }
}
