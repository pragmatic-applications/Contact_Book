namespace Domain
{
    public static class BlazorGlobal
    {
        public static bool IsBS { get; set; } = false;
        public static int ItemAmount { get; set; }
        public static string AppName { get; set; } = "Don't Work";
        public static string toEmailAddress { get; set; }
        public static int ItemCount { get; private set; }

        public static void SetItemCount(int count)
        {
            if(ItemCount == 0)
            {
                ItemCount = count;
            }
        }

        public static int StudentCount { get; set; }        
    }
}
