using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DllLibrary
{
    public class Team
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Player> Library = new List<Player>();
        public Team(string nm, string ad)
        {
            Name = nm;
            Address = ad;
        }
        public void Show()
        {
            Console.WriteLine($"Команда: название = {Name}, адрес = {Address}");
        }
    }

    public class Player : IComparable<Player>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Player(string nm, string des)
        {
            Name = nm;
            Description = des;
        }
        public void Show()
        {
            Console.WriteLine(
                 $"Игрок: Имя = {Name}, описание = {Description}");
        }
    }
    interface IComparable
    {
        public int CompareTo(Player other)
        {
            // пробег текущего авто больше пробега переданного
            if (this.Name > other.Name) return 1;
            // пробег текущего авто меньше пробега переданного
            if (this.Name < other.Name) return -1;
            else return 0; // пробеги автомобилей равны 
        }

    }

    interface IComparable<class>
    {
    CompareTo(class other);
    }


}
