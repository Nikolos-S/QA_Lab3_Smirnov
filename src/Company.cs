using System;

namespace Buildingcompany {
/// <summary>
/// Класс Компания(имеющая помещения)
/// </summary>
    class Company {
/// <summary>
/// Имя Компании
/// </summary>
        private String buildName;
/// <summary>
/// Первое помещение(обычное)
/// </summary>
        private Building buildFirst = new Building();
/// <summary>
/// Второе помещение(необычное)
/// </summary>
        private BuildingType buildSecond = new BuildingType();
/// <summary>
/// Инициализация класса компания
/// </summary>
/// <param name="buildName">Имя</param>
/// <param name="type">Тип</param>
/// ![Image](../images/build.jpg)
/// <param name="unitСost1">Кол-во кв.м(помещение_1)</param>
/// <param name="quantity1">Стоимость(помещение_1)</param>
/// <param name="unitСost2">Кол-во кв.м(помещение_2)</param>
/// <param name="quantity2">Стоимость(помещение_2)</param>
        public Company(String buildName, int type, int unitСost1, int quantity1, int unitСost2, int quantity2) {
            this.buildName = buildName;
            buildFirst.Init(unitСost1, quantity1);
            buildSecond.Init(type, unitСost2, quantity2);
        }
/// <summary>
/// Метод демонстрирующий имя компании
/// </summary>
        public void DisplayName() {
            System.Console.WriteLine("Компания называется: " + buildName);
        }
/// <summary>
/// Метод демонстрирующий параметры первого помещения компании
/// </summary>
        public void DisplayFirstBuild() {
            System.Console.WriteLine("Наша компания имеет первое здание с параметрами:");
            buildFirst.DisplayCost();
            buildFirst.DisplayCount();
        }
/// <summary>
/// Метод демонстрирующий параметры второго помещения компании
/// </summary>
        public void DisplaySecondBuild() {
            System.Console.WriteLine("Наша компания имеет второе здание с параметрами:");
            buildSecond.DisplayCost();
            buildSecond.DisplayCount();
        }
/// <summary>
/// Метод расчитывающий суммарную стоимость Компании
/// </summary>
        public double TotalCost() {
            return buildFirst.TotalCost() + buildSecond.TotalCost();
        }
    }
}