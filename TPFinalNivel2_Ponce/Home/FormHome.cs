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
using frmArticle;
using helper = Helper.Helper;

namespace frmHome
{
    public partial class FormHome : Form
    {
        private Button _currentButton;
        private List<Article> _articles;
        private List<Category> _categories;
        private List<Brand> _brands;
        private Form _activeForm;
        private bool _advancedFilter;
        private Point _locationDgvArticles;

        public FormHome()
        {
            InitializeComponent();
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            this._articles = helper._GetArticles();
            this._categories = helper._GetCategories();
            this._brands = helper._GetBrands();
            this._locationDgvArticles = dgvArticles.Location;
            LoadDgv(_articles);

            //Carga de combobox para filtrar
            helper.FillDropDownBrands(_brands, cboxFilterBrand);
            helper.FillDropDownCategories(_categories, cboxFilterCategory);
            helper.FillDropDownFilterOrder(cboxFilterOrder);
            dgvArticles.Visible = false;
        }

        //----------------------------------------------
        //Procedimientos de carga de componentes

        private void LoadDgv(List<Article> articles)
        {
            if (articles == null || articles.Count == 0)
            {
                dgvArticles.Visible = false;
                lblNoData.Visible = true;
                return;
            }
            int cantRow = 10;
            lblNoData.Visible = false;
            dgvArticles.Visible = true;

            dgvArticles.DataSource = articles;
            dgvArticles.Columns["ImageUrl"].Visible = false;
            dgvArticles.Columns["Description"].Visible = false;
            dgvArticles.Columns["Id"].Width = 50;
            dgvArticles.Columns["Code"].Width = 100;
            dgvArticles.Columns["Name"].Width = 200;
            dgvArticles.Columns["BrandName"].Width = 110;
            dgvArticles.Columns["Category"].Width = 100;
            if (dgvArticles.RowCount == 0)
            {
                dgvArticles.Visible = false;
                lblNoData.Visible = true;
                return;
            }
            if (dgvArticles.RowCount <= cantRow)
            {
                dgvArticles.Height = (dgvArticles.RowCount * dgvArticles.Rows[0].Height) + dgvArticles.ColumnHeadersHeight;
            }
            else
            {
                dgvArticles.Height = (cantRow * dgvArticles.Rows[0].Height) + dgvArticles.ColumnHeadersHeight;
                dgvArticles.ScrollBars = ScrollBars.Vertical;
            }
        }

        private void LoadImagePictureBox(string path, PictureBox pbox)
        {
            try
            {
                if (path.ToLower().StartsWith("http"))
                    pbox.Load(path);
                else
                    pbox.Image = Image.FromFile(path);
            }
            catch (Exception)
            {
                pbox.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }
        private void LoadArticlesDetails()
        {
            Article art = (Article)dgvArticles.CurrentRow.DataBoundItem;
            lblNameArticleDetails.Text = art.Name;
            lblBrandArticleDetails.Text = art.BrandName.ToString();
            lblCategoryArticleDetails.Text = art.Category.ToString();
            lblCodeArticleDetails.Text = art.Code;
            txtDescriptionArticleDetails.Text = art.Description;
            lblPriceArticleDetails.Text = art.Price.ToString();
            LoadImagePictureBox(art.ImageUrl, pboxImageDetails);
        }

        //----------------------------------------------
        //Estilos para cuando el boton es activado y desactivado

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != btnSender)
                {
                    DisableButton();
                    _currentButton = (Button)btnSender;
                    _currentButton.BackColor = Color.FromArgb(75, 138, 165);
                    _currentButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control prevBtn in panelMenu.Controls)
            {
                if (prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.FromArgb(51, 51, 76);
                    prevBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        //----------------------------------------------
        //Procedimiento de apertura de formulario
        //y evento que observa cuando se cierra
        private void OpenChildForm(Form childForm, object btnSender)
        {
            ActivateButton(btnSender);

            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            if (childForm != null)
            {
                _activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                //Modificacion para el formulario de edicion de articulo
                if (childForm is FormArticle)
                {
                    //"Escuchamos" al evento Closed del formulario hijo
                    childForm.FormClosed += ChildForm_FormClosed;
                }

                //Agregamos el formulario al panel Main
                this.panelMain.Controls.Add(childForm);
                this.panelMain.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                lblTitle.Text = childForm.Text;
            }
        }
        public event EventHandler ChildFormClosed;
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Se dispara el evento ChildFormClosed cuando el formulario hijo se cierra
            ChildFormClosed?.Invoke(this, EventArgs.Empty);
        }
        private void RefreshDgv(object sender, EventArgs e)
        {
            dgvArticles.DataSource = null;
            this._articles = helper._GetArticles();
            LoadDgv(this._articles);
        }


        //----------------------------------------------
        //Funcionalidad de botones del menu de control
        private void btnNewArticle_Click(object sender, EventArgs e)
        {
            this.panelFilter.Visible = false;
            this.panelDetails.Visible = false;
            lblEditArticle.Visible = false;
            dgvArticles.Visible = false;
            btnDeleteArticle.Visible = false;

            //Le decimos al evento ChildFormClosed que queremos que haga cuando se dispare
            this.ChildFormClosed += RefreshDgv;

            OpenChildForm(new FormArticle(), sender);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.panelFilter.Visible = false;
            this.panelDetails.Visible = false;
            btnDeleteArticle.Visible = false;
            dgvArticles.Location = this._locationDgvArticles;
            dgvArticles.Visible = true;
            lblEditArticle.Visible = true;
            lblTitle.Text = "Edición de artículo";
            OpenChildForm(null, sender);

        }
        private void lblEditArticle_Click(object sender, EventArgs e)
        {
            this.panelFilter.Visible = false;
            dgvArticles.Location = this._locationDgvArticles;
            dgvArticles.Visible = false;

            Article art = (Article)dgvArticles.CurrentRow.DataBoundItem;
            FormArticle frm = new FormArticle(art);

            // Le decimos al evento ChildFormClosed que queremos que haga cuando se dispare
            //Opc 1
            //this.ChildFormClosed += (send, args) =>
            //{
            //    dgvArticles.DataSource = null;
            //    LoadDgv(helper._GetArticles());
            //};
            //Opc 2
            this.ChildFormClosed += RefreshDgv;

            OpenChildForm(frm, null);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Eliminar artículo";
            this.panelFilter.Visible = false;
            this.panelDetails.Visible = false;
            lblEditArticle.Visible = false;
            dgvArticles.Location = this._locationDgvArticles;
            dgvArticles.Visible = true;
            btnDeleteArticle.Visible = true;
            OpenChildForm(null, sender);

        }
        private void btnDeleteArticle_Click(object sender, EventArgs e)
        {
            Article article = (Article)dgvArticles.CurrentRow.DataBoundItem;

            DialogResult res = MessageBox.Show("Desea eliminar este artículo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                ArticleController controller = new ArticleController();
                if (controller.DeleteArticle(article.Id))
                {
                    List<Article> articles = this._articles.Where(art => art.Id != article.Id).ToList();
                    dgvArticles.DataSource = null;
                    LoadDgv(articles);
                    this._articles = articles;
                    MessageBox.Show("Se eliminó artículo con éxito!", "Éxito",MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Ocurrió algo inesperado. No se pudó eliminar el artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Buscar artículo";
            OpenChildForm(null, sender);
            this._advancedFilter = false;
            this.panelFilter.Visible = true;
            this.panelDetails.Visible = false;
            lblEditArticle.Visible = false;
            btnDeleteArticle.Visible = false;
            dgvArticles.Visible = true;

            if(dgvArticles.Location == this._locationDgvArticles)
                dgvArticles.Location = new Point(dgvArticles.Location.X, dgvArticles.Location.Y + 70);
   
        }

        private void btnShowArticles_Click(object sender, EventArgs e)
        {
            this.panelFilter.Visible = false;
            lblEditArticle.Visible = false;
            btnDeleteArticle.Visible = false;
            dgvArticles.Location = this._locationDgvArticles;
            lblTitle.Text = "Listado de artículos";
            OpenChildForm(null, sender);
            Article art = (Article)dgvArticles.CurrentRow.DataBoundItem;
            LoadArticlesDetails();

            dgvArticles.Visible = true;
            this.panelDetails.Visible = true;
        }

        //----------------------------------------------
        //Procedimientos de filtrado rapido y avanzado
        private void FilterArticles()
        {
            List<Article> original_list = this._articles;
            List<Article> articles = new List<Article>();
            dgvArticles.DataSource = null;
            //Si no se selecciono el filtro avanzado, hacemos un filtro rapido
            if (!_advancedFilter)
            {
                string text = txtFilterArticle.Text.ToLower();
                foreach (Article art in original_list)
                {
                    if (art.Name.ToLower().Contains(text))
                        articles.Add(art);
                }
                LoadDgv(articles);
                return;
            }

            //Filtramos articulos por marca
            if (cboxFilterBrand.SelectedIndex != 0)
            {
                int id_brand = int.Parse(cboxFilterBrand.SelectedValue.ToString());
                articles = original_list.FindAll(art => art.BrandName.Id == id_brand);

                //Filtramos los elementos por categoria de la lista ya filtrada por marca
                if(cboxFilterCategory.SelectedIndex != 0)
                {
                    int id_category = int.Parse(cboxFilterCategory.SelectedValue.ToString());
                    articles.RemoveAll(art => art.Category.Id != id_category);
                }
            }
            //Filtramos articulos por categoria
            else if(cboxFilterCategory.SelectedIndex != 0)
            {
                int id_category = int.Parse(cboxFilterCategory.SelectedValue.ToString());
                articles = original_list.FindAll(art => art.Category.Id == id_category);
            }
            //No se filtro, cargamos la lista original
            else
            {
                articles = original_list;
            }
            //Cargamos la lista de articulos en el DataGridView Articles
            LoadDgv(articles);
        }
        private void lblAdvancedFilter_Click(object sender, EventArgs e)
        {
            //Logica para mostrar los filtros disponibles
            if (!_advancedFilter)
            {
                this._advancedFilter = true;
                
                lblFilterArticle.Visible = false;
                txtFilterArticle.Visible = false;
                
                this.panelAdvancedFilter.Visible = true;
                lblAdvancedFilter.Text = "< Filtro rápido";
            }
            else
            {
                this._advancedFilter = false;

                lblFilterArticle.Visible = true;
                txtFilterArticle.Visible = true;

                this.panelAdvancedFilter.Visible = false;
                lblAdvancedFilter.Text = "Filtro avanzado >";

            }

        }
        private void txtFilterArticle_TextChanged(object sender, EventArgs e)
        {
            FilterArticles();
        }

        private void cboxFilterBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboxFilterBrand.SelectedIndex != 0)
            {
                int id_brand = (int)cboxFilterBrand.SelectedValue;
                List<Article> articles = this._articles.Where(art => id_brand == art.BrandName.Id).ToList();
                List<Category> categories = new List<Category>();

                foreach (Article art in articles)
                {
                    bool exists = false;
                    foreach(Category cat in categories)
                    {
                        if(cat.Id == art.Category.Id)
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                        categories.Add(art.Category);

                }


                if (categories.Count > 0)
                {
                    helper.FillDropDownCategories(categories, cboxFilterCategory);
                    cboxFilterOrder.Enabled = true;
                    cboxFilterCategory.Enabled = true;
                }
                else
                {
                    cboxFilterOrder.Enabled = false;
                    cboxFilterCategory.Enabled = false;
                }

            }
            else
            {
                helper.FillDropDownCategories(helper._GetCategories(), cboxFilterCategory);
                cboxFilterOrder.Enabled = true;
                cboxFilterCategory.Enabled = true;
            }
            FilterArticles();
        }

        private void cboxFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterArticles();
        }

        private void cboxFilterOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Article> list = (List<Article>)dgvArticles.DataSource;
            if (list == null || list.Count == 0) return;
            //Orden normal de la lista
            if (cboxFilterOrder.SelectedIndex == 0)
            {
                LoadDgv(list.OrderBy(art => art.Id).ToList());
                return;
            }
            //Orden de menor a mayor de la lista
            if (cboxFilterOrder.SelectedIndex == 1)
            {
                //List<Article> list = this._articles;
                dgvArticles.DataSource = null;
                LoadDgv(list.OrderBy(art => art.Price).ToList());

                return;
            }
            //Orden de mayor a menor de la lista
            if (cboxFilterOrder.SelectedIndex == 2)
            {
                //List<Article> list = this._articles;
                dgvArticles.DataSource = null;
                LoadDgv(list.OrderByDescending(art => art.Price).ToList());

                return;
            }
        }


        //----------------------------------------------
        //Procedimiento para mostrar detalles de articulos
        private void dgvArticles_SelectionChanged(object sender, EventArgs e)
        {
            if(_currentButton == btnShowArticles)
                LoadArticlesDetails();
        }

        
    }
}
