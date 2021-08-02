using Interfaces;

namespace Domain
{
    public class AddIntCommand : IAction<int>
    {
        public AddIntCommand() => this.Item = 0;
        public AddIntCommand(int value) => this.Item = value;

        public int Item { get; set; }

        public int AddItem(int item) => item + this.Item;
        public int Undo(int item) => item - this.Item;
    }
}
