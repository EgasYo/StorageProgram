namespace StorageProgram.Classes
{
    public class Menu
    {
        public string line = "----------------------------------------";

        public void LiteSingleHello()
        {
            Console.Write("\n                                                   PUPA-PROGRAM LTD\n                                                     Представляет:");
        }
        public void GetMenu()
        {
            Console.Write($"\n\n{line}\n 1. Содержимое хранилища склада\n\n 2. Ожидаемые поставки\n\n 3. База данных сотрудников\n\n{line}\n Ввод: ");
        }
        public void GetVaultСontents()
        {

            Console.Write($" Содержимое хранилища склада\n{line}\n 1. Просмотр\n 2. Редактирование\n 3. Назад\n{line}\n Ввод: ");
        }
        public void GetExpectedDeliveries()
        {

            Console.WriteLine($" Ожидаемые поставки\n{line}\n 1. Просмотр\n 2. Редактирование\n 3. Назад");
        }
        public void GetEmployeeDatabase()
        {

            Console.WriteLine($"База данных сотрудников\n{line}\n 1. Просмотр\n 2. Редактирование\n 3. Назад");
        }
        public void GetAllItems(IEnumerable<StorageItem> storageItems)
        {
            Console.Clear(); /*\n Все предметы в хранении на складе сейчас:*/
            Console.WriteLine($"\n № |  Название продукта  |  Количество\n{line}");
            foreach (var item in storageItems)
            {
                Console.WriteLine($" {item.Id} | {item.Title} | {item.Amount}");
            }
        }
        public void GetOnlyBack()
        {
            Console.Write("\n 1. Назад\n\n Ввод: ");
        }
        public void GetEditMenu()
        {
            Console.Write("\n 1. Добавить\n 2. Удалить \n 3. Назад\n\n Ввод: ");
        }
        public void GetPlusOrMinusItem()
        {
            Console.Write("\n Введите номер предмета: ");
        }
        public int GetPageStorage(StorageItem item)
        {
            Console.WriteLine($"Номер товара: {item.Id}");
            if (item != null)
            {
                Console.WriteLine($" Товар: {item.Title}\n ?. Назад ");
                return item.Id;
            }
            else
            {
                Console.WriteLine($"Товар по номеру не обнаружен");
                return 0;
            }
        }
        public void GetNumberOfItems(string newItem)
        {
            Console.Clear();
            Console.Write($"\n Количество предметов \"{newItem}\": ");
        }
    }
}
