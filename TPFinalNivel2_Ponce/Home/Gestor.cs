using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Controllers;
using ConnectionDB;

namespace Home
{
    public partial class Gestor : Form
    {
        public Gestor()
        {
            InitializeComponent();
        }
        private void Gestor_Load(object sender, EventArgs e)
        {
            ArticleController control = new ArticleController();
            List<Article> articles;
            articles = control.articleList();

            dgvArticulos.DataSource = articles;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola desde el gestor");
            Connection con = new Connection();

            MessageBox.Show(con.Database);
        }

    }
}
