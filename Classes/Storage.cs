namespace StorageProgram.Classes
{
    public class Storage
    {
        public static List<StorageItem> Items { get; set; }
        static Storage()
        {
            Items = new List<StorageItem>();
        }
        public static void Add(StorageItem item)
        {
            item.Id = GetNewId();
            Items.Add(item);
        }
        public static void Remove(StorageItem item)
        {
            Items.Remove(item);
        }
        public static int GetNewId()
        {
            if (Items.Count == 0) return 1;
            return Items.Max(x => x.Id) + 1;
        }
    }
}
