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
                personList.Add(new Person($"FirstName{50000-i}", $"Surname{i}", $"Title{x}"));
            }
            innDgv1.DataSource = personList;
        }
    }


    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public Person(string name, string surname, string title)
        {
            Name = name;
            Surname = surname;
            Title = title;
        }
    }
}
