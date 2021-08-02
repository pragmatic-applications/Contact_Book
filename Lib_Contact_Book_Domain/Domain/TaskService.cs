using System.Collections.Generic;
using System.Linq;

using Interfaces;

namespace Domain
{
    public class TaskService : ITaskService<ContactEntity>
    {
        private readonly Stack<List<ContactEntity>> undoStack = new();
        private readonly Stack<List<ContactEntity>> redoStack = new();


        public List<ContactEntity> Items => this.undoStack.Any() ? this.undoStack.Peek() : new List<ContactEntity>();

        //public List<ContactEntity> UndoItems => this.undoStack.Any() ? this.undoStack.Peek() : new List<Item>();
        //public List<ContactEntity> RedoItems => this.redoStack.Any() ? this.redoStack.Peek() : new List<Item>();

        public void AddItem(ContactEntity item)
        {
            var items = new List<ContactEntity>(this.Items);
            items.Add(item);
            this.undoStack.Push(items);
        }
        public bool CanSave => !this.Items.Any();

        public bool CanRemove => this.Items.Any(item => item.IsChecked);
        public void RemoveDone()
        {
            if(this.CanRemove)
            {
                this.undoStack.Push(this.Items.Where(item => !item.IsChecked).ToList());
            }
        }
        public void Clear()
        {
            this.undoStack.Clear();
            this.redoStack.Clear();
        }

        public bool CanUndo => this.undoStack.Any();
        public void Undo()
        {
            if(this.CanUndo)
            {
                var item = this.undoStack.Pop();
                this.redoStack.Push(item);
            }
        }

        public bool CanRedo => this.redoStack.Any();
        public void Redo()
        {
            if(this.CanRedo)
            {
                var item = this.redoStack.Pop();
                this.undoStack.Push(item);
            }
        }
    }
}
