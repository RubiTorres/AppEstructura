using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEstructura
{
  internal class NodoLC
  {
    private int dato;//Los nodos almacenaran un valor entero, para este ejemplo sera datos
    private NodoLC siguiente; //Declaramos el puntero al siguiente nodo
    public int Dato //Ahora pasamos al encapsulamiento, lo cual permite obtener y establecer los valores para los nodos
    {
      get { return dato; }
      set { dato = value; }
    }
    public NodoLC Siguiente //puntero, referencia
    {
      get { return siguiente; }
      set { siguiente = value; }
    }
    public NodoLC()
    {
      dato = 0;
      siguiente = this;
    }
    public NodoLC(int dato, NodoLC siguiente)
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
