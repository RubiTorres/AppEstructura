using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEstructura
{
  internal class NodoA
  {
    public int dato { get; set; }
    public NodoA izquierdo { get; set; }
    public NodoA derecho { get; set; }

    public NodoA(int dato)
    {
      this.dato = dato;
      this.izquierdo = null;
      this.derecho = null;
    }
  }
}
