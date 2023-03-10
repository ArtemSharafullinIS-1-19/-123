using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace пробник
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Class1 class1 = new Class1();


        public class bugalter
        {
            public string fio;
            public int age;
            public string time;
            public double zp;
            public string let;

            public bugalter(string fIO, int age, string time, double zp, string let)
            {
                fio = fIO;
                this.age = age;
                this.time = time;
                this.zp = zp;
                this.let = let;
            }

        }
        public class admin
        {
            public string fio;
            public int age;
            public string time;
            public double zp;
            public string let;

            public admin(string fio, int age, string time, double zp, string let)
            {
                this.fio = fio;
                this.age = age;
                this.time = time;
                this.zp = zp;
                this.let = let;
            }
        }

        public class sisadmin
        {
            public string fio;
            public int age;
            public string time;
            public double zp;
            public string let;

            public sisadmin(string fio, int age, string time, double zp, string let)
            {
                this.fio = fio;
                this.age = age;
                this.time = time;
                this.zp = zp;
                this.let = let;
            }
        }
        List<admin> admins = new List<admin>();
        List<sisadmin> sisadmins = new List<sisadmin>();
        List<bugalter> bugalters = new List<bugalter>();
        private void Form1_Load(object sender, EventArgs e)
        {

            //Бухгалтеры
           
            dataGridView1.AllowUserToAddRows = false;

            bugalters.Add(new bugalter("Рожков Александр Сергеевич", 32, "12,2 часа", 30500, "3 года"));
            bugalters.Add(new bugalter("Жолудева Анастасия Григорьевна", 27, "10 часов", 28000, "5 лет"));
            bugalters.Add(new bugalter("Фулатов Андрей Васильевич", 24, "14 часов", 34000, "1 год"));
            bugalters.Add(new bugalter("Фаритов Азамат Бараметович", 35, "7 часов", 25000, "8 лет"));
            bugalters.Add(new bugalter("Тырков Назар Артёмович", 37, "12 часа", 30000, "10 лет"));

            DataTable table1 = new DataTable();

            table1.Columns.Add("ФИО", typeof(string));
            table1.Columns.Add("Возраст", typeof(int));
            table1.Columns.Add("Смена в часах", typeof(string));
            table1.Columns.Add("Зарплата в месяц", typeof(int));
            table1.Columns.Add("Лет работы", typeof(string));

            DataGridViewComboBoxCell combo = new DataGridViewComboBoxCell();

            for(int i = 0; i < bugalters.Count; i++)
            {
                table1.Rows.Add(bugalters[i].fio, bugalters[i].age, bugalters[i].time, bugalters[i].zp, bugalters[i].let);
            }

            dataGridView1.DataSource = table1;

            //Админы

            admins.Add(new admin("Косяк Павел Александрович", 41, "15 часов", 60000, "7 лет"));
            admins.Add(new admin("Морпех Владислав Васильевич", 31, "10 часов", 44000, "5 лет"));
            admins.Add(new admin("Фулатов Андрей Васильевич", 24, "14 часов", 34000, "1 год"));
            admins.Add(new admin("Фаритов Азамат Бараметович", 35, "7 часов", 25000, "8 лет"));
            admins.Add(new admin("Тырков Назар Артёмович", 37, "12 часа", 30000, "10 лет"));

            DataTable table2 = new DataTable();

            table2.Columns.Add("ФИО", typeof(string));
            table2.Columns.Add("Возраст", typeof(int));
            table2.Columns.Add("Смена в часах", typeof(string));
            table2.Columns.Add("Зарплата в месяц", typeof(int));
            table2.Columns.Add("Лет работы", typeof(string));

            for (int i = 0; i < admins.Count; i++)
            {
                table2.Rows.Add(admins[i].fio, admins[i].age, admins[i].time, admins[i].zp, admins[i].let);
            }

            dataGridView1.DataSource = table2;

            //Сисадмины
            sisadmins.Add(new sisadmin("Пахомов Влад", 41, "15 часов", 60000, "7 лет"));
            sisadmins.Add(new sisadmin("Морпех Владислав Васильевич", 31, "10 часов", 44000, "5 лет"));
            sisadmins.Add(new sisadmin("Фулатов Андрей Васильевич", 24, "14 часов", 34000, "1 год"));
            sisadmins.Add(new sisadmin("Фаритов Азамат Бараметович", 35, "7 часов", 25000, "8 лет"));
            sisadmins.Add(new sisadmin("Тырков Назар Артёмович", 37, "12 часа", 30000, "10 лет"));

            DataTable table3 = new DataTable();

            table3.Columns.Add("ФИО", typeof(string));
            table3.Columns.Add("Возраст", typeof(int));
            table3.Columns.Add("Смена в часах", typeof(string));
            table3.Columns.Add("Зарплата в месяц", typeof(int));
            table3.Columns.Add("Лет работы", typeof(string));

            for (int i = 0; i < admins.Count; i++)
            {
                table3.Rows.Add(sisadmins[i].fio, sisadmins[i].age, sisadmins[i].time, sisadmins[i].zp, sisadmins[i].let);
            }

            dataGridView1.DataSource = table3;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
