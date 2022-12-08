using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEstructura
{
  internal class NodoLD
  {
    private string dato;
    private NodoLD siguiente;
    private NodoLD anterior;
    public string Dato
    {
      get { return dato; }
      set { dato = value; }
    }    
    public NodoLD Siguiente
    {
      get { return siguiente; }
      set { siguiente = value; }
    }
    public NodoLD Anterior
    {
      get { return anterior; }
      set { anterior = value; }
    }
    public NodoLD()
    {
      dato = "";
      siguiente = null;
      anterior = null;
    }
    public NodoLD(string dato, NodoLD siguiente, NodoLD anterior)
    {
      this.dato = dato;
      this.siguiente = siguiente;
      this.anterior = anterior;
    }
    public override string ToString()
    {
      return Dato.ToString();
    }
  }
}

