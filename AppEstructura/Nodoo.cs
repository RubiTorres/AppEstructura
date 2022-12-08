using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEstructura
{
  internal class Nodoo
  {
    private string dato;
    private Nodoo siguiente;
    public string Dato
    {
      get { return dato; }
      set { dato = value; }
    }
    public Nodoo Siguiente
    {
      get { return siguiente; }
      set { siguiente = value; }
    }
    public Nodoo()
    {
      dato = null;
      siguiente = null;
    }
    public Nodoo(string dato, Nodoo siguiente)
    {
      this.dato = dato;
      this.siguiente = siguiente;
    }
    public override string ToString()
    {
      return dato;
    }
  }
}
