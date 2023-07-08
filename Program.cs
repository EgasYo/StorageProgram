// 1- Создать классы -- Ядро --> Интерфейс --> Xранилище --> Предмет, добавить графический интерфейс и лист предметов
using StorageProgram.Classes;

LoadOrSaveXML.LoadXML();

var core = new Core();
var menu = new Menu();

menu.LiteSingleHello();
core.Start();

