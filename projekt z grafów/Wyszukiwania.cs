using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_z_grafów
{
    internal class Wyszukiwania
    {
        public List<int> WyszukiwanieWszerz(Wierzchlek start)
        {
            List<int> wynikiWszerz = new List<int>();
            Queue<Wierzchlek> kolejka = new Queue<Wierzchlek>();
            HashSet<Wierzchlek> odwiedzone = new HashSet<Wierzchlek>();

            if (start != null)
            {
                kolejka.Enqueue(start);
                odwiedzone.Add(start);

                while (kolejka.Count > 0)
                {
                    Wierzchlek aktualny = kolejka.Dequeue();
                    wynikiWszerz.Add(aktualny.Id);

                    foreach (Wierzchlek sasiad in aktualny.Nastpniki)
                    {
                        if (!odwiedzone.Contains(sasiad))
                        {
                            kolejka.Enqueue(sasiad);
                            odwiedzone.Add(sasiad);
                        }
                    }
                }
            }

            return wynikiWszerz;
        }

        public List<int> WyszukiwanieWGlab(Wierzchlek start)
        {
            List<int> wynikiWGlab = new List<int>();
            Stack<Wierzchlek> stos = new Stack<Wierzchlek>();
            HashSet<Wierzchlek> odwiedzone = new HashSet<Wierzchlek>();

            if (start != null)
            {
                stos.Push(start);
                odwiedzone.Add(start);

                while (stos.Count > 0)
                {
                    Wierzchlek aktualny = stos.Pop();
                    wynikiWGlab.Add(aktualny.Id);

                    foreach (Wierzchlek sasiad in aktualny.Nastpniki)
                    {
                        if (!odwiedzone.Contains(sasiad))
                        {
                            stos.Push(sasiad);
                            odwiedzone.Add(sasiad);
                        }
                    }
                }
            }

            return wynikiWGlab;
        }
    }
}
