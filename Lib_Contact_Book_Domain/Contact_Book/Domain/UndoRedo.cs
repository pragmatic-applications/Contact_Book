using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class UndoRedo<T> where T : class
    {
        private readonly Stack<T> UndoStack = new();
        private readonly Stack<T> RedoStack = new();

        public bool CanUndo => this.UndoStack.Any();
        public bool CanRedo => this.UndoStack.Any();

        public void Clear()
        {
            this.UndoStack.Clear();
            this.RedoStack.Clear();
        }
        public T Undo()
        {
            if(this.CanUndo)
            {
                var item = this.UndoStack.Pop();
                this.RedoStack.Push(item);
            }

            return this.UndoStack.FirstOrDefault();
        }
        public T Redo()
        {
            if(!this.CanRedo)
            {
                return this.UndoStack.FirstOrDefault();
            }

            var item = this.RedoStack.Pop();
            this.UndoStack.Push(item);

            return this.UndoStack.FirstOrDefault();
        }

        public void AddItem(T item) => this.UndoStack.Push(item);

        public List<T> UndoItems => this.UndoStack.ToList();

        public List<T> RedoItems => this.RedoStack.ToList();
    }
}
