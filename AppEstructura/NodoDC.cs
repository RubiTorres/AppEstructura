using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEstructura
{
  internal class NodoDC
  {
    private int dato;
    private NodoDC siguiente;
    private NodoDC atras;
    public int Dato
    {
      get { return dato; }
      set { dato = value; }
    }
    public NodoDC Siguiente
    {
      get { return siguiente; } 
      set { siguiente = value; } 
    }
    public NodoDC Atras
    {
      get { return atras; } 
      set { atras = value; } 
    }
    public NodoDC()
    {
      dato = 0;
      siguiente = null;
      atras = null;
    }
    public NodoDC(int dato, NodoDC siguiente, NodoDC atras)
    {
      this.dato = dato;
      this.siguiente = siguiente;
      this.atras = atras;
    }
    public override string ToString()
    {
      return dato + " - ";
    }
  }
}
