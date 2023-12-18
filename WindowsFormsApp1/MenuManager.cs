using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class MenuManager : Form
    {
        private Mall CurrentMall;
        public MenuManager()
        {
            InitializeComponent();
            Model1 model = new Model1();
            label2.Text = AutorizationForm.Enter_User.First_Name + " " + AutorizationForm.Enter_User.Second_Name + " " + AutorizationForm.Enter_User.Middle_Name;
            label3.Text = model.Workers.First(x => x.Role == AutorizationForm.Enter_User.Role).Role;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMall formMall = new FormMall();
            formMall.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutorizationForm Authorizationform = new AutorizationForm();
            Authorizationform.Show();
            this.Close();
        }
    }
}
