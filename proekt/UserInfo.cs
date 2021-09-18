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
    public partial class UserInfo : Form
    {
        Person person;
        public UserInfo()
        {
            InitializeComponent();
        }

        public UserInfo(Person person)
        {
            InitializeComponent();
            this.person = person;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        public void setInfo(Person person)
        {
            label15.Text = person.getNomer().ToString();
            label16.Text = person.getFIO().ToString();
            label17.Text = person.getSex().ToString();
            label18.Text = person.getBd().ToString("dd.MM.yyyy");
            label19.Text = person.getGrougth().ToString();
            label20.Text = person.getWeigth().ToString();
            label21.Text = person.getNevrolog().ToString();
            label22.Text = person.getLor().ToString();
            label23.Text = person.getOkylist().ToString();
            label24.Text = person.getXiryrg().ToString();
            label25.Text = person.getDerma().ToString();
            label26.Text = person.getPcix().ToString();
            label27.Text = person.getStomac().ToString();
            label28.Text = person.getTerapevt().ToString();

        }
    }
}
