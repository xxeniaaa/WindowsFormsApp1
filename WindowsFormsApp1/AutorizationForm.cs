using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }
        public static Workers Enter_User;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enter_User = null;
            Model1 model1 = new Model1();
            Enter_User = model1.Workers.FirstOrDefault(x => x.Login == textBox1.Text && x.Password == textBox2.Text);
            if (Enter_User != null)
            {
                switch (Enter_User.Role)
                {
                    case "Администратор":
                        FormMenu formMenu = new FormMenu();
                        formMenu.ShowDialog();
                        break;
                    case "Менеджер А":
                        MenuManager formManagerA = new MenuManager();
                        formManagerA.ShowDialog();

                        break;
                    case "Менеджер С":
                        MenuManager formManagerC = new MenuManager();
                        formManagerC.ShowDialog();
                        break;
                    default: throw new Exception("Роль не найдена!");
                }
            }
        }
    }
}
