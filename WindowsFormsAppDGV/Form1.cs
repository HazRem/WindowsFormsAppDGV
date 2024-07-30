using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDGV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var personList = new List<Person>();
            Random rand = new Random();
            for (int i = 1; i <= 50000; i++)
            {
                var x = rand.Next(i, 50000);
                var y = rand.Next(i, 50000);
                var z = rand.Next(i, 50000);
                var q1 = rand.Next(0, 2);
                var q2 = rand.Next(0, 2);
                bool tf = q1 == 1 ? true : false;
                bool tf2 = q2 == 1 ? true : false;
                var xd = tf ? 10 : 20;
                var xdd = tf2 ? 100 : 200;
                personList.Add(new Person($"FirstName{50000-i}", $"Surname{i}", $"Title{x}", y, z, xd, xdd, tf));
            }

            innDgv1.DataSource = personList;
        }
    }


    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public int Number { get; set; }
        public int Number2 { get; set; }
        public int Number3 { get; set; }
        public int Number4 { get; set; }
        public bool TrueFalse { get; set; }
        public Person(string name, string surname, string title, int number, int number2, int number3, int number4, bool trueFalse)
        {
            Name = name;
            Surname = surname;
            Title = title;
            Number = number;
            Number2 = number2;
            Number3 = number3;
            Number4 = number4;
            TrueFalse = trueFalse;
        }
    }
}
