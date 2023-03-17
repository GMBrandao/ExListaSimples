using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExListaSimples
{
    internal class ListItem
    {
        public Item Begin { get; set; }
        public Item End { get; set; }

        public ListItem()
        {
            Begin = null;
            End = null;
            Console.WriteLine("Lista criada com sucesso");
        }

        public void InsertItem(Item aux)
        {
            if (IsEmpty())
            {
                Begin = aux;
                End = aux;
            }
            else
            {
                if (aux.Value < Begin.Value)
                {
                    InsertFirst(aux);
                }
                else
                {
                    if (aux.Value > End.Value)
                    {
                        InsertLast(aux);
                    }
                    else
                    {
                        InsertMiddle(aux);
                    }
                }
            }
            Console.WriteLine($"Item {aux.Value} inserido");
        }

        private void InsertMiddle(Item middle)
        {
            Item aux = Begin;
            Item aux2 = aux.Next;

            while (aux2 != null)
            {
                if (middle.Value <= aux2.Value)
                {
                    middle.Next = aux2;
                    aux.Next = middle;
                    return;
                }
                else
                {
                    aux = aux2;
                    aux2 = aux2.Next;
                }
            }
            middle.Next = aux.Next;
            aux.Next = middle;
            aux2 = aux.Next;

        }

        private void InsertLast(Item last)
        {
            End.Next = last;
            End = last;
        }

        private void InsertFirst(Item aux)
        {
            aux.Next = Begin;
            Begin = aux;
        }

        public void PrintList()
        {
            Item aux = Begin;
            if (IsEmpty())
            {
                Console.WriteLine("Lista vazia");
            }
            else if (Begin.Value == End.Value)
            {
                Console.WriteLine("\nLista:");
                Console.WriteLine(aux.ToString());
                Console.WriteLine("Fim da lista...\n");
                return;
            }
            else
            {
                Console.WriteLine("\nLista:");
                while (aux != null)
                {
                    Console.Write(aux.ToString());
                    aux = aux.Next;
                }
                Console.WriteLine("Fim da lista...\n");
            }
        }

        public bool IsEmpty()
        {
            if (Begin == null) return true; return false;
        }
    }
}
