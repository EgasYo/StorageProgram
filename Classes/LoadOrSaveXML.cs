using System.Xml.Serialization;

namespace StorageProgram.Classes
{
    public static class LoadOrSaveXML
    {
        public static void LoadXML()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<StorageItem>));
                using (FileStream fileStream = new FileStream("L:\\Proj\\StorageProgram\\StorageXML.xml", FileMode.Open))
                {
                    Storage.Items = serializer.Deserialize(fileStream) as List<StorageItem>;
                }
                //Console.WriteLine("\n Данные успешно загружены из XML файла.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n Ошибка при загрузке данных из XML файла: {ex.Message}");
            }
        }

        public static void SaveXML()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<StorageItem>));
                using (FileStream fileStream = new FileStream("L:\\Proj\\StorageProgram\\StorageXML.xml", FileMode.Create))
                {
                    serializer.Serialize(fileStream, Storage.Items);
                }
                LoadXML();
                //Console.WriteLine("\n Данные успешно сохранены в XML файл.");
            }
            catch (Exception ex) { Console.WriteLine($"\n Ошибка при сохранении данных в XML файл: {ex.Message}"); }
        }
    }
}
