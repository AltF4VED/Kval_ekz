using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using DllLibrary;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Team t = new Team("Орлы", "г.Москва");
            t.Show();

            Player p1 = new Player("Кузнецов К.О.","Быстро бегает");
            t.Library.Add(p1);
            Player p2 = new Player("Васильев С.И.","Выносливый");
            t.Library.Add(p2);
            Player p3 = new Player("Николаев В.А.", "Сильный");
            t.Library.Add(p3);
            Player p4 = new Player("Денисов С.О.", "Хорошо ловит мячи");
            t.Library.Add(p4);
            Player p5 = new Player("Федотов М.Ю.", "Лидер");
            t.Library.Add(p5);

            t.Library.Sort();
            foreach (Player player in t.Library)
            {
                t.Show();
            }

            Console.ReadKey();
        }
    }
}
