using System.Collections.Generic;
using System.Linq;

using DTOs;

using Interfaces;

namespace Domain
{
    public class ContactEntityTaskService : ITaskService<ContactEntityDto>
    {
        private readonly Stack<List<ContactEntityDto>> undoStack = new();
        private readonly Stack<List<ContactEntityDto>> redoStack = new();

        public List<ContactEntityDto> Items => this.undoStack.Any() ? this.undoStack.Peek() : new List<ContactEntityDto>();

        public void AddItem(ContactEntityDto item)
        {
            var items = new List<ContactEntityDto>(this.Items);
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

    ////nnn???...
    //public class ContactEntityTaskService : ITaskService<ContactEntityDtoCreate>
    //{
    //    private readonly Stack<List<ContactEntityDtoCreate>> undoStack = new();
    //    private readonly Stack<List<ContactEntityDtoCreate>> redoStack = new();


    //    public List<ContactEntityDtoCreate> Items => this.undoStack.Any() ? this.undoStack.Peek() : new List<ContactEntityDtoCreate>();

    //    //public List<ContactEntityDtoCreate> UndoItems => this.undoStack.Any() ? this.undoStack.Peek() : new List<Item>();
    //    //public List<ContactEntityDtoCreate> RedoItems => this.redoStack.Any() ? this.redoStack.Peek() : new List<Item>();

    //    public void AddItem(ContactEntityDtoCreate item)
    //    {
    //        var items = new List<ContactEntityDtoCreate>(this.Items);
    //        items.Add(item);
    //        this.undoStack.Push(items);
    //    }
    //    public bool CanSave => !this.Items.Any();

    //    public bool CanRemove => this.Items.Any(item => item.IsChecked);
    //    public void RemoveDone()
    //    {
    //        if(this.CanRemove)
    //        {
    //            this.undoStack.Push(this.Items.Where(item => !item.IsChecked).ToList());
    //        }
    //    }
    //    public void Clear()
    //    {
    //        this.undoStack.Clear();
    //        this.redoStack.Clear();
    //    }

    //    public bool CanUndo => this.undoStack.Any();
    //    public void Undo()
    //    {
    //        if(this.CanUndo)
    //        {
    //            var item = this.undoStack.Pop();
    //            this.redoStack.Push(item);
    //        }
    //    }

    //    public bool CanRedo => this.redoStack.Any();
    //    public void Redo()
    //    {
    //        if(this.CanRedo)
    //        {
    //            var item = this.redoStack.Pop();
    //            this.undoStack.Push(item);
    //        }
    //    }
    //}
}
