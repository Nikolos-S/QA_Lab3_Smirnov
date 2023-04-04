using System;

namespace Buildingcompany {
/// <summary>
/// Класс Строение
/// </summary>
    class Building {
/// <summary>
/// Переменная - стоимоть квадратного метра
/// </summary>

        protected int unitСost;
/// <summary>
/// Переменная - Количество квадратных метров
/// </summary>
        protected int quantity;
/// <summary>
/// Иницилизируем класс Building
/// </ummary>
/// <param name="unitСost">Стоимость</param>
/// <param name="quantity">Кол-во кв.м</param>
        public void Init(int unitСost, int quantity) {
            this.unitСost = unitСost;
            this.quantity = quantity;
        }
/// <summary>
/// Метод, демонстрирующий стоимость квадратного метра помещения
/// </summary>
        public void DisplayCost() {
            System.Console.WriteLine("Стоимость квадратного метра обычного корпуса без возможных наценок равна: " + unitСost + " тысяч рублей");
        }
/// <summary>
/// Метод, демонстрирующий количество квадратных метров
/// </summary>
        public void DisplayCount() {
        System.Console.WriteLine("В данном корпусе имеется: " + quantity + " квадратных метров");
        }
/// <summary>
/// Метод, возвращающий общую стоимость помещения
/// </summary>
/// \f$BuildingCost = unitСost * quantity   \f$
/// <returns>Возвращает стоимость помещения</returns>
        public double TotalCost() {
            double result = unitСost * quantity;
            return result;
        }
    }
}
