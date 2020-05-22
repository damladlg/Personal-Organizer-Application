using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelab2
{
    class CareTakerPersonalInfo
    {
        private readonly LinkedList<MementoPersonalInfo> Undos = new LinkedList<MementoPersonalInfo>();
        private readonly Stack<MementoPersonalInfo> Redos = new Stack<MementoPersonalInfo>();

        public int Capacity { get; set; }
        public int RedoesQuantity { get; set; }
        public MementoPersonalInfo this[string UndoesOrRedoes]
        {
            get
            {
                switch (UndoesOrRedoes)
                {
                    case "Undo":
                        Redos.Push(Undos.Last.Value);
                        MementoPersonalInfo state = Undos.Last.Value;
                        Undos.RemoveLast();
                        Capacity = Undos.Count;
                        RedoesQuantity = Redos.Count;
                        return state;
                    case "Redo":
                        Undos.AddLast(Redos.Pop());
                        Capacity = Undos.Count;
                        RedoesQuantity = Redos.Count;
                        return Undos.Last.Value;
                    default:
                        Capacity = Undos.Count;
                        RedoesQuantity = Redos.Count;
                        return null;
                }
            }
        }

        public void Add(MementoPersonalInfo memento)
        {
            if (Undos.Count < 256)
                Undos.AddLast(memento);
            else
            {
                Undos.RemoveFirst();
                Undos.AddLast(memento);
            }
            Capacity = Undos.Count;
            RedoesQuantity = Redos.Count;
        }

        public void Clear()
        {
            if (Redos.Count != 0)
            {
                Undos.AddLast(Redos.Pop());
                Capacity = Undos.Count;
                Redos.Clear();
            }
            RedoesQuantity = 0;
        }
    }
}