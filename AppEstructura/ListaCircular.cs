using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEstructura
{
  internal class ListaCircular
  {
    private NodoLC head; //declaramos la cabeza o inicio de la lista de tipo nodo
    public NodoLC Head
    {
      get { return head; }
      set { head = value; }
    }
    public ListaCircular()
    {
      head = null;
    }
    public ListaCircular(NodoLC n)
    {
      head = n;
    }
    public bool Agregar(NodoLC n) //luego construimos el metodo Insertar nodo
    {
      NodoLC h = head;
      //lista vacía
      if (head == null)
      {
        n.Siguiente = n;
        head = n;
        return true;
      }
      //nuevo menor que head (insertar al inicio)
      if (n.Dato < head.Dato)
      {
        while (h.Siguiente != head)
        {
          h = h.Siguiente;
        }
        h.Siguiente = n;
        n.Siguiente = head;
        head = n;
        return true;
      }
      //insertar al final 
      while (h.Siguiente != head)
      {
        //si n.Dato es menor que h.Siguiente.Dato
        if (n.Dato < h.Siguiente.Dato) //
        {
          break; //detiene 
        }
        h = h.Siguiente;
      }

      n.Siguiente = h.Siguiente;
      h.Siguiente = n;

      return true;
    }
    public void Borrar(int dato)
    {
      NodoLC h = head;
      if (head != null)
      {
        if (head.Dato == dato)
        {
          while (h.Siguiente != head)
          {
            h = h.Siguiente;
          }
          if (head.Siguiente == head)
          {
            head = null;
            return;
          }
          head = head.Siguiente;
          h.Siguiente = head;
          return;
        }
        else
        {
          while (h.Siguiente.Dato != dato)
          {
            h = h.Siguiente;
          }
          h.Siguiente = h.Siguiente.Siguiente;
        }
      }
    }
    public bool BuscarDato(int a)
    {
      NodoLC h = head;
      if (h != null)

      {
        do
        {
          if (h.Dato == a)
          {
            return true;
          }
          h = h.Siguiente;
        } while (h != head);
      }
      return false;
    }
    public int ContarNodos()
    {
      int contador = 0;
      NodoLC h = head;
      do
      {
        contador++;
        h = h.Siguiente;
      } while (h != head);
      return contador;
    }
    public override string ToString()
    {
      string lista = "";
      NodoLC h = head;
      if (h != null)
      {
        do
        {
          lista += h.Dato + ", ";
          h = h.Siguiente;
        } while (h != head);
        lista += ".";
        lista = lista.Replace(", .", "");
        return lista;
      }
      else
      {
        return "La lista está vacía";
      }
    }
  }
}
