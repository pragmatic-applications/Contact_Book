using System.Collections.Generic;

namespace Domain
{
    public class UndoRedoTask<T> where T : class
    {
        private UndoRedo<T> UndoRedo = new();

        public bool ChangeRequired { get; set; }

        public T Undo()
        {
            this.ChangeRequired = false;

            return this.UndoRedo.Undo();
        }
        public T Redo()
        {
            this.ChangeRequired = false;

            return this.UndoRedo.Redo();
        }

        public void AddItem(T item) => this.UndoRedo.AddItem(item);
        public List<T> UndoItems => this.UndoRedo.UndoItems;
        public List<T> RedoItems => this.UndoRedo.RedoItems;
        public bool CanUndo => this.UndoRedo.CanUndo;
        public bool CanRedo => this.UndoRedo.CanRedo;
    }
}
