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

//Lib_Contact_Book_Domain => Lib_Contact_Book_Domain
//MicroTech | Lib_MicroTech | Lib_MicroTech_Domain | Lib_MicroTech_Interface | Lib_MicroTech_xxx
