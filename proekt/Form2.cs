using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proekt
{
    public partial class dobavka : Form
    {
        List<Person> persons = new List<Person>();

        public dobavka()
        {
            InitializeComponent();        
        }
        public dobavka(List<Person> persons)
        {
            InitializeComponent();
            this.persons = persons;
        }
        public dobavka(Person person)
        {
            InitializeComponent();
            this.persons.Add(person);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try {
                DateTime.Parse(this.BDate.Text);
                Person person = new Person(
                    int.Parse(this.nomer.Text),
                    this.FIO.Text,
                    this.Sex.Text,
                    DateTime.Parse(this.BDate.Text),
                    int.Parse(this.growth.Text),
                    int.Parse(this.weight.Text),
                    this.nevrolog.Text,
                    this.lor.Text,
                    this.okylist.Text,
                    this.xiryrg.Text,
                    this.derma.Text,
                    this.pcix.Text,
                    this.stomac.Text,
                    this.terapevt.Text);
                if (person.getBd().CompareTo(DateTime.Now) > 0)
                {
                    ThrErrorBox("Неверная дата, повторите попытку");
                    return;
                }

                foreach (Person p in persons) 
                {
                    if (person.getNomer().Equals(p.getNomer()))
                    {
                        ThrErrorBox("Номер уже существует, повторите попытку");
                        return;
                    }
                }

                persons.Add(person);
                cleanPanel();

            }
            catch (Exception ex) {
                ThrErrorBox();
            }
            
        }

    
        private DialogResult ThrErrorBox()
        {
            DialogResult result = MessageBox.Show(
                "Проверьте введенные данные",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            this.TopMost = true;

            return result;

        }

        private DialogResult ThrErrorBox(string message)
        {
            DialogResult result = MessageBox.Show(
                message,
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            this.TopMost = true;
            return result;
        }

        private void cleanPanel() {
            this.nomer.Text = "";
            this.FIO.Text = "";
            this.Sex.Text = "";
            this.BDate.Text = "";
            this.growth.Text = "";
            this.weight.Text = "";
            this.nevrolog.Text = "";
            this.lor.Text = "";
            this.okylist.Text = "";
            this.xiryrg.Text = "";
            this.derma.Text = "";
            this.pcix.Text = "";
            this.stomac.Text = "";
            this.terapevt.Text = "";
        }
        public List<Person> getPersons(){
            return persons;    
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dobavka_Load(object sender, EventArgs e)
        {
           
        }

        private void BDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }
