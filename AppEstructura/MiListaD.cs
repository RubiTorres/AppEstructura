using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEstructura
{
  internal class MiListaD
  {
    public string dato;
    public NodoLD primero;
    public NodoLD ultimo;
    public NodoLD head;
    public String Dato
    {
      get { return dato; }
      set { dato = value; }
    }
    public NodoLD Primero
    {
      get { return primero; }
      set { primero = value; }
    }
    public NodoLD Ultimo
    {
      get { return ultimo; }
      set { ultimo = value; }
    }
    public NodoLD Head
    {
      get { return head; }
      set { head = value; }
    }
    public MiListaD()
    {
      dato = "";
      primero = null;
      ultimo = null;
      head = null;
    }
    public void Insertar(string dato)
    {
      NodoLD h = head;
      if (head == null)
      {
        NodoLD n = new NodoLD();
        primero = n;
        ultimo = primero;
      }
      else
      {
        NodoLD n = new NodoLD();
        ultimo.Siguiente = n;
        n.Anterior = ultimo;
        ultimo = n;
      }
    }
    public override string ToString()
    {
      NodoLD h = head;
      if (head != null)
      {
        while (h.Siguiente != null)
        {
          dato += h.ToString();
        }
      }
      return dato;
    }
    public void Borrar(string dato)
    {
      if (head != null)
      {
        if (head.Dato == dato)
        {
          head = head.Siguiente;
          return;
        }
        NodoLD h = head;
        while (h.Siguiente != null)
        {
          if (h.Siguiente.Dato == dato)
          {
            h.Siguiente = h.Siguiente.Siguiente;
            return;
          }
          h = h.Siguiente;
        }
      }
    }
    public bool Buscar(string dato)      
    {
      NodoLD h = head;
      if (head.Dato == dato)
      {
          return true;
      }
        while (h.Siguiente != null)
        {
          if (h.Siguiente.Dato == dato)
          {
            return true;
          }
          h = h.Siguiente;
        }
        return false;      
    }
  }
}
