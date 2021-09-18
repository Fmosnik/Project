using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proekt
{
    public partial class UpdateForm : Form
    {
        private Person person;
        public UpdateForm()
        {
            InitializeComponent();
        }
        public UpdateForm(Person person)
        {
            InitializeComponent();
            this.person = person;
            setValues();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
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
                this.person = person; 
                this.Close();
            }
            catch (Exception ex)
            {
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

        private void setValues() {

            nomer.Text = person.getNomer().ToString();
            FIO.Text = person.getFIO().ToString();
            Sex.Text = person.getSex().ToString();
            BDate.Text = person.getBd().ToString("dd.MM.yyyy");
            growth.Text = person.getGrougth().ToString();
            weight.Text = person.getWeigth().ToString();
            nevrolog.Text = person.getNevrolog().ToString();
            lor.Text = person.getLor().ToString();
            okylist.Text = person.getOkylist().ToString();
            xiryrg.Text = person.getXiryrg().ToString();
            derma.Text = person.getDerma().ToString();
            pcix.Text = person.getPcix().ToString();
            stomac.Text = person.getStomac().ToString();
            terapevt.Text = person.getTerapevt().ToString();

        }
        public Person getPerson()
        {
            return person;
        }

        private void nomer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
