using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLibrary
{
    //Все округления - до 3 знаков после запятой
    public interface IFirstInterface
    {
        // Объём шара.
        // V = 4/3 * Pi * radius^3
        
        double volumeSphere(double radius);

        // Площадь треугольника через две стороны и угол между ними.
        // S = 1/2 * a * b * sin(angle)
        // Обратите внимание что Math.Sin возвращает РАДИАНЫ, а вам нужно вернуть ГРАДУСЫ
        double areaTriangle(double a, double b, double angle);

        // Вонвертер валют. Сумма умноженная на курс.
        // Не использовать знак умножения. Например "cash * course" - будет засчитано как неверно выполненное задание при проверке.
        double cashConverter(double cash, double course);

        // Камень - ножницы - бумага.
        // Human - ход человека. computer - ход компьютера.
        // Принимает строку "Камень", "Ножницы", "Бумага" в любом регистре.
        // Возвращает строку "Human victory", "Computer victory" или "Draw" в зависимости от хода.
        string StoneScissorsPaper(string human, string computer);

        // На вход строка с символами разного регистра.
        // Задача - вернуть новую строку, у которой все буквы будут в одном регистре.
        // Если букв верхнего регистра больше чем нижнего - поставить все буквы в верхний регистр.
        // Иначе - в нижний.
        string fixStringCase(string str);

        // Вернуть массив, у которого убраны все дубликаты. Пример в модуль-тесте.
        int[] removeDuplicates(int[] array);
    }

    public class FirstClass : IFirstInterface
    {
        public double areaTriangle(double a, double b, double angle)
        {
            throw new NotImplementedException();
        }

        public double cashConverter(double cash, double course)
        {
            throw new NotImplementedException();
        }

        public string fixStringCase(string str)
        {
            throw new NotImplementedException();
        }

        public int[] removeDuplicates(int[] array)
        {
            throw new NotImplementedException();
        }

        public string StoneScissorsPaper(string human, string computer)
        {
            throw new NotImplementedException();
        }

        public double volumeSphere(double radius)
        {
            throw new NotImplementedException();
        }
    }
}
