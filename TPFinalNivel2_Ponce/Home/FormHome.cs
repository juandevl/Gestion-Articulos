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
using frmArticle;

namespace frmHome
{
    public partial class FormHome : Form
    {
        private Button _currentButton;
        private Form _activeForm;
        

        public FormHome()
        {
            InitializeComponent();
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            dgvArticles.Visible = false;
            LoadDgv();
        }
        
        private void LoadDgv()
        {
            int cantRow = 10;
            ArticleController control = new ArticleController();
            List<Article> articles;
            articles = control.GetArticles();
            dgvArticles.DataSource = articles;
            dgvArticles.Columns["ImageUrl"].Visible = false;
            dgvArticles.Columns["Description"].Visible = false;
            dgvArticles.Columns["Id"].Width = 50;
            dgvArticles.Columns["Code"].Width = 100;
            dgvArticles.Columns["Name"].Width = 235;
            if(dgvArticles.RowCount < cantRow)
            {
                dgvArticles.Height = (dgvArticles.RowCount * dgvArticles.Rows[0].Height) + dgvArticles.ColumnHeadersHeight;
            }
            else
            {
                dgvArticles.Height = (cantRow * dgvArticles.Rows[0].Height) + dgvArticles.ColumnHeadersHeight;
                dgvArticles.ScrollBars = ScrollBars.Vertical;
            }
        }

        //private void btnCargarProducto_Click(object sender, EventArgs e)
        //{
        //    ArticleController control = new ArticleController();
        //    //TODO ABRIR FORMULARIO PARA CARGA DE NUEVO ARTICULO
        //    Article art = new Article();
        //    art.Code = txtCode.Text;
        //    if (control.existsArticle(art))
        //        MessageBox.Show("Existe");
        //    else
        //        MessageBox.Show("No Existe");

        //    //if (control.insertArticle(null))
        //    //    MessageBox.Show("Se cargo con exito");
        //    //else
        //    //    MessageBox.Show("No se pudo cargar");

        //}
        //Estilos para cuando el boton es presionado

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(_currentButton != btnSender)
                {
                    DisableButton();
                    _currentButton = (Button)btnSender;
                    _currentButton.BackColor = Color.FromArgb(75, 138, 165);
                    _currentButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        //Estilo base para los botones del menu
        private void DisableButton()
        {
            foreach(Control prevBtn in panelMenu.Controls)
            {
                if(prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.FromArgb(51, 51, 76);
                    prevBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(_activeForm != null)
            {
                _activeForm.Close();
            }
            ActivateButton(btnSender);
            if(childForm != null)
            {
                _activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                //Agregamos el formulario al panel Main
                this.panelMain.Controls.Add(childForm);
                this.panelMain.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                lblTitle.Text = childForm.Text;

            }
        }

        private void btnNewArticle_Click(object sender, EventArgs e)
        {
            dgvArticles.Visible = false;
            OpenChildForm(new FormArticle(), sender);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dgvArticles.Visible = false;
            Article art = (Article)dgvArticles.CurrentRow.DataBoundItem;
            OpenChildForm(new FormArticle(art), sender);
            dgvArticles.DataSource = null;
            LoadDgv();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            //lblTitle.Text = "Eliminar artículo";

        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            //lblTitle.Text = "Buscar artículo";
        }

        private void btnShowArticles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Listado de artículos";
            OpenChildForm(null, sender);
            dgvArticles.Visible = true;
        }

    }
}
