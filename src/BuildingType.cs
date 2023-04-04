using System;

namespace Buildingcompany {
/// <summary>
/// Помещение, не обычное. Класс наследуется от Building
/// inherit Building
/// </summary>

    class BuildingType : Building {
/// <summary>
/// Переменная - тип помещения
/// </summary>
        private int type;
/// <summary>
/// Иницилизируем класс BuildingType
/// </summary>
/// <param name="type">Тип</param>
/// <param name="quantity">Кол-во кв.м</param>
/// <param name="unitСost">Стоимость</param>
        public void Init(int type, int unitСost, int quantity) {
            base.Init(unitСost, quantity);
            this.type = type;
        }
/// <summary>
/// Метод, Демонстрирующий стоимость квадратного метра помещения
/// </summary>
        public void DisplayCost() {
            System.Console.WriteLine("Стоимость квадратного метра корпуса c возможными наценками равна: " + unitСost + " тысяч рублей");
        }
/// <summary>
/// Метод, демонстрирующий количество квадратных метров
/// </summary>
        public void DisplayCount() {
            System.Console.WriteLine("В данном корпусе имеется: " + quantity + " квадратных метров");
        }
/// <summary>
/// Метод, расчитывающий стоимость помещения
/// </summary>
        public double TotalCost() {
            switch (type) {
                case 0:
                    return unitСost * quantity * 0.7;
                case 1:
                    return unitСost * quantity;
                case 2:
                    return unitСost * quantity * 1.5;
                default:
                    return 0;
            }
        }
    }
}