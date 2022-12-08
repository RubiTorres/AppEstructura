using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEstructura
{
  internal class NodoLS
  {
    private int dato;
    private NodoLS siguiente;

    //Propiedades
    public int Dato
    {
      get { return dato; }
      set { dato = value; }
    }
    public NodoLS Siguiente
    {
      get { return siguiente; }
      set { siguiente = value; }
    }

    //Constructor
    public NodoLS()
    {
      dato = 0;
      siguiente = null;
    }

    public NodoLS(int dato, NodoLS siguiente)
    {
      this.dato = dato;
      this.siguiente = siguiente;
    }

    public override string ToString()
    {
      return dato + "";
    }
  }
}
