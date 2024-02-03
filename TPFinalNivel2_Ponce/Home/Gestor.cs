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
            articles = control.getArticles();

            dgvArticulos.DataSource = articles;
            dgvArticulos.Height = ((dgvArticulos.Rows.Count +1) * dgvArticulos.Rows[0].Height ) + dgvArticulos.ColumnHeadersHeight;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola desde el gestor");
            Connection con = new Connection();

            MessageBox.Show(con.Database);
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            ArticleController control = new ArticleController();
            //TODO ABRIR FORMULARIO PARA CARGA DE NUEVO ARTICULO
            Article art = new Article();
            art.Code = txtCode.Text;
            if (control.existsArticle(art))
                MessageBox.Show("Existe");
            else
                MessageBox.Show("No Existe");

            //if (control.insertArticle(null))
            //    MessageBox.Show("Se cargo con exito");
            //else
            //    MessageBox.Show("No se pudo cargar");

        }
    }
}
