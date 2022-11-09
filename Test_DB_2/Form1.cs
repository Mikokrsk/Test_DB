using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_DB_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            update_list_Sellers();
            update_list_Buyers();
            update_list_Workers();
            update_list_Agreements();
        }
        public void update_list_Sellers()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(" Номер паспорту \t ПІБ \t\t Дата народження \t Адреса проживання \t Номер телефону");
            realtor_companyEntities2 db = new realtor_companyEntities2();
            foreach (var item in db.Sellers)
            {
                listBox1.Items.Add($"{item.Passport_num} \t {item.Full_name} \t {item.Date_of_birth.ToShortDateString()} \t\t {item.Residence_address} \t" +
               $" \t {item.Phone_number} ");
            }
        }
        public void update_list_Buyers()
        {
            listBox2.Items.Clear();
            listBox2.Items.Add(" Номер паспорту \t ПІБ \t\t Дата народження \t Адреса проживання \t Номер телефону");
            realtor_companyEntities2 db = new realtor_companyEntities2();
            foreach (var item in db.Buyers)
            {
                listBox2.Items.Add($"{item.Passport_num} \t {item.Full_name} \t {item.Date_of_birth.ToShortDateString()} \t\t {item.Residence_address} \t" +
               $" \t {item.Phone_number} ");
            }
        }
        public void update_list_Workers()
        {
            listBox3.Items.Clear();
            listBox3.Items.Add(" Номер паспорту \t ПІБ \t\t Дата народження \t Адреса проживання \t Посада \t\t Зарплата\tНомер телефону");
            realtor_companyEntities2 db = new realtor_companyEntities2();
            foreach (var item in db.Workers)
            {
                //listBox3.Items.Add(item.Passport_num + "\t" + item.Full_name + "\t" + item.Date_of_birth.ToShortDateString() + "\t" + item.Residence_address + "\t" +
                //item.Positions.Name + "\t\t" + item.Positions.Salary + "\t\t" + item.Phone_number);
                listBox3.Items.Add($"{item.Passport_num} \t {item.Full_name} \t {item.Date_of_birth.ToShortDateString()} \t\t {item.Residence_address} \t" +
               $" \t{item.Positions.Name} " + "   \t   " + $" {item.Positions.Salary}  \t\t {item.Phone_number} ");
            }
        }
        public void update_list_Agreements()
        {
            listBox4.Items.Clear();
            listBox4.Items.Add($"Дата підписання \t Адреса квартири \t\t Власник квартири \t Покупець \t Працівник компанії");
            realtor_companyEntities2 db = new realtor_companyEntities2();
            foreach (var item in db.Agreements)
            {
                listBox4.Items.Add($"{item.Date_of_holding.ToShortDateString()} " +
                 $" \t {item.Apartments.Address} " + "  \t " + $" {item.Apartments.Sellers.Full_name} \t {item.Buyers.Full_name} \t {item.Workers.Full_name}" +
                 $"\t{item.Apartments.Price}");
            } 
        }
    }
}
