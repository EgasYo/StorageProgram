namespace StorageProgram.Classes
{
    public class Core
    {
        public Menu Menu { get; set; }
        public Core()
        {
            Menu = new Menu();
        }
        public void Start()
        {
            Menu.GetMenu();
            //var value = ReadValue();
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.Clear();
            if (keyInfo.KeyChar == '1')
            {
                VaultСontentsEntering();
            }
            else if (keyInfo.KeyChar == '2')
            {
                ExpectedDeliveriesEntering();
            }
            else if (keyInfo.KeyChar == '3')
            {
                EmployeeDatabaseEntering();
            }
            else { Start(); }
        }
        public void VaultСontentsEntering()
        {
            Menu.GetVaultСontents();
            ConsoleKeyInfo keyInfo2 = Console.ReadKey();
            Console.Clear();
            if (keyInfo2.KeyChar == '1')
            {
                Menu.GetAllItems(Storage.Items);
                Menu.GetOnlyBack();
                ConsoleKeyInfo keyInfo3 = Console.ReadKey();
                Console.Clear();
                if (keyInfo3.KeyChar == '1') { VaultСontentsEntering(); }
                else { VaultСontentsEntering(); } // Пока-что

            }
            else if (keyInfo2.KeyChar == '2')
            {
                Menu.GetAllItems(Storage.Items);
                Menu.GetEditMenu();
                ConsoleKeyInfo keyInfo4 = Console.ReadKey();
                Console.Clear();
                if (keyInfo4.KeyChar == '1') // (Добавить)
                {
                    Menu.GetPlusOrMinusItem();
                    string newItem = Console.ReadLine();
                    Menu.GetNumberOfItems(newItem);
                    int newNumberItems = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Storage.Add(new StorageItem { Title = newItem, Amount = newNumberItems });
                    LoadOrSaveXML.SaveXML();
                    VaultСontentsEntering();
                }
                else if (keyInfo4.KeyChar == '2') // (Удалить)
                {
                    Menu.GetPlusOrMinusItem();
                    IdDelete();
                }
                else if (keyInfo4.KeyChar == '3') // (Назад)
                {
                    VaultСontentsEntering();
                }
                else { VaultСontentsEntering(); } // Пока-что
            }
            else if (keyInfo2.KeyChar == '3')
            {
                Start();
            }
            else
            {
                VaultСontentsEntering();
            }
        }
        public void ExpectedDeliveriesEntering()
        {
            Menu.GetExpectedDeliveries();
            ConsoleKeyInfo keyInfo2 = Console.ReadKey();
            Console.Clear();
            if (keyInfo2.KeyChar == '1')
            {

            }
            else if (keyInfo2.KeyChar == '2')
            {

            }
            else if (keyInfo2.KeyChar == '3')
            {
                Start();
            }
            else
            {
                ExpectedDeliveriesEntering();
            }
        }
        public void EmployeeDatabaseEntering()
        {
            Menu.GetEmployeeDatabase();
            ConsoleKeyInfo keyInfo2 = Console.ReadKey();
            Console.Clear();
            if (keyInfo2.KeyChar == '1')
            {

            }
            else if (keyInfo2.KeyChar == '2')
            {

            }
            else if (keyInfo2.KeyChar == '3')
            {
                Start();
            }
            else
            {
                EmployeeDatabaseEntering();
            }
        }
        public void IdDelete()
        {
            int idToDelete;
            if (int.TryParse(Console.ReadLine(), out idToDelete))
            {
                StorageItem itemToRemove = Storage.Items.FirstOrDefault(item => item.Id == idToDelete);
                if (itemToRemove != null)
                {
                    Storage.Remove(itemToRemove);
                    LoadOrSaveXML.SaveXML();
                    Console.Clear();
                    Console.WriteLine("\n Элемент успешно удален\n\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n Ошибка: Элемент с указанным ID не найден");
                }
                VaultСontentsEntering();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n Ошибка: Введите целочисленный ID элемента");
                VaultСontentsEntering();
            }
        }
        //public string ReadValue() { return Console.ReadLine()!; }
    }
}
