using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEstructura
{
  internal class NodoC
  {
    private string dato;
    private NodoC siguiente;
    public string Dato
    {
      get { return dato; }
      set { dato = value; }
    }
    public NodoC Siguiente
    {
      get { return siguiente; }
      set { siguiente = value; }
    }
    public NodoC()
    {
      dato = null;
      siguiente = null;
    }
    public override string ToString()
    {
      return dato;
    }
  }
}
