using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proekt
{
    public partial class Form1 : Form
    {
        dobavka db = new dobavka();
        private List<Person> listPerson = new List<Person>();
        private string fileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vvod_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            db = new dobavka(listPerson);
            db.ShowDialog();
            string[] str = null;
            int i = 0;
            foreach (Person p in listPerson)
            {
                // string[] str1 = { System.Convert.ToString(p.nomer) + " " + System.Convert.ToString(p.FIO) + " " + System.Convert.ToString(p.Sex) + " " + System.Convert.ToString(p.getBd()) + " " + System.Convert.ToString(p.growth) + " " + System.Convert.ToString(p.weight) + " " + System.Convert.ToString(p.nevrolog) + " " + System.Convert.ToString(p.lor) + " " + System.Convert.ToString(p.okylist) + " " + System.Convert.ToString(p.nevrolog) + " " + System.Convert.ToString(p.xiryrg) + " " + System.Convert.ToString(p.derma) + " " + System.Convert.ToString(p.pcix) + " " + System.Convert.ToString(p.stomac) + " " + System.Convert.ToString(p.terapevt) + '\n' };
                string[] str1 = { System.Convert.ToString(p.nomer) };
                str = str1;
                listBox1.Items.AddRange(str);
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listPerson.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void change_Click(object sender, EventArgs e)
        {
            string str = listBox1.SelectedItem.ToString();

            foreach (Person person in listPerson)
            {
                if (person.getNomer().ToString().Equals(str))
                {
                    UpdateForm change = new UpdateForm(person);
                    change.ShowDialog();
                    Person p = change.getPerson();
                    listPerson.Remove(person);
                    listPerson.Add(p);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    listBox1.Items.Add(p.getNomer());
                    return;
                }
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            foreach (Person person in listPerson)
            {
                if (person.getFIO().Contains(searchText))
                {
                    var items = listBox1.Items;
                    int counter = 0;
                    foreach (var item in items)
                    {
                        if (person.getNomer().ToString().Equals(item.ToString()))
                        {
                            listBox1.SetSelected(counter, true);
                            return;
                        }
                        counter++;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem;

            foreach (Person person in listPerson)
            {

                if (person.getNomer().ToString().Equals(selectedItem.ToString()))
                {
                    UserInfo userInfo = new UserInfo(person);
                    userInfo.setInfo(person);
                    userInfo.ShowDialog();
                }
            }

        }

        private void loadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            fileName = fileDialog.FileName;
            string file = File.ReadAllText(fileName).Trim();
            String[] rows = file.Split('\n');
            foreach (string values in rows)
            {
                String[] numbers = values.Split(' ');
                Person value = new Person(
                    Convert.ToInt32(numbers[0]), numbers[1],
                    numbers[2], Convert.ToDateTime(numbers[3]),
                    Convert.ToInt32(numbers[4]), Convert.ToInt32(numbers[5]),
                    numbers[6], numbers[7],
                    numbers[8], numbers[9],
                    numbers[10], numbers[11],
                    numbers[12], numbers[13]);

                foreach (Person p in listPerson)
                {
                    if (p.getNomer().Equals(value.getNomer()))
                    {
                        ThrErrorBox("Введенный номкр записи уже существует");
                        return;
                    }
                }

                listPerson.Add(value);
                listBox1.Items.Add(value.getNomer().ToString());

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

        private void button4_Click(object sender, EventArgs e)
        {
            string text = "";
            foreach (Person value in listPerson)
            {
                text += value.getNomer() + " " + value.getFIO() + " " + value.getSex() + " " + value.getBd().ToString("dd.MM.yyyy")
                    + " " + value.getGrougth() + " " + value.getWeigth()
                    + " " + value.getNevrolog() + " " + value.getLor() + " " + value.getOkylist()
                    + " " + value.getXiryrg() + " " + value.getDerma()
                    + " " + value.getPcix() + " " + value.getStomac() + " " + value.getTerapevt() + "\n";
            }

            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.ShowDialog();
            fileName = fileDialog.FileName;
            File.WriteAllText(fileName, text);

        }
    }
}
