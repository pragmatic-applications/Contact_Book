using Interfaces;

namespace Domain
{
    public class SubtractIntCommand : IAction<int>
    {
        public SubtractIntCommand()
        {
            this.Item = 0;
        }
        public SubtractIntCommand(int value)
        {
            this.Item = value;
        }

        public int Item { get; set; }

        public int AddItem(int input)
        {
            return input - this.Item;
        }
        public int Undo(int input)
        {
            return input + this.Item;
        }
    }
}
