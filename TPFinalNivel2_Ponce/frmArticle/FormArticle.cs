using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Models;
using Helper;

namespace frmArticle
{
    
    public partial class FormArticle : Form
    {
        private Color _ok;
        private Color _alert;
        private Color _default;
        private Color _backColorDefault;
        private Article _currentArticle;
        private bool[] _stateControls = new bool[7];
        public FormArticle()
        {
            InitializeComponent();
            this._ok = Color.FromArgb(51, 163, 91);
            this._alert = Color.FromArgb(247, 112, 107);
            this._default = Color.Black;
            this._backColorDefault = Color.White;
            this.Text = "Alta de artículo";
            this._currentArticle = null;

        }

        public FormArticle(Article updateArticle)
        {
            InitializeComponent();
            this._ok = Color.FromArgb(51, 163, 91);
            this._alert = Color.FromArgb(247, 112, 107);
            this._default = Color.Black;
            this._backColorDefault = Color.White;
            this.Text = "Actualización de artículo";
            this._currentArticle = updateArticle;
        }
        private void FillDropDownCategories()
        {
            CategoryController categoryController = new CategoryController();
            List<Category> categories = categoryController.GetCategories();
            categories.Insert(0, new Category(0, "Seleccionar"));
            cboxCategory.DataSource = categories;
            cboxCategory.ValueMember = "Id";
            cboxCategory.DisplayMember = "Description";

        }
        private void FillDropDownBrands()
        {
            BrandController brandController = new BrandController();
            List<Brand> brands = brandController.GetBrands();
            brands.Insert(0, new Brand(0, "Seleccionar"));
            cboxBrand.DataSource = brands;
            cboxBrand.ValueMember = "Id";
            cboxBrand.DisplayMember = "Description";
        }
        //Metodos de validacion
        
        private bool PriceValidation(string text)
        {
            bool hasPoint = false;
            bool isNumeric = false;
            foreach (char c in text)
            {
                //Compruebo si cada caracter es un valor numerico o no
                if (char.IsDigit(c))
                    isNumeric = true;
                else
                {
                    //Si el caracter es un punto, valido si ya existe un punto o no
                    if (c == '.' || c == ',')
                    {
                        //Si ya tiene un punto, retorna false
                        //sino, lo actualiza a true
                        if (hasPoint)
                            return false;
                        else
                            hasPoint = true;
                    }
                    else
                    {
                        isNumeric = false;
                    }

                }
            }
            //Retorna true si:
            //existe un punto, el punto no se encuentra al comienzo ni se encuentra al final del texto
            return hasPoint && 
                   isNumeric && 
                   (text.IndexOf(",") != 0 || text.IndexOf(".") != 0) && 
                   ((text.LastIndexOf(',') != text.Length - 1) || (text.LastIndexOf('.') != text.Length - 1));
        }
        private bool ValidateControls()
        {
            return !this._stateControls.Contains(false);
        }
        private void LoadImagePictureBox(string path)
        {
            try
            {
                if (path.ToLower().StartsWith("http"))
                    pboxImage.Load(path);
                else
                    pboxImage.Image = Image.FromFile(path);
            }
            catch (Exception)
            {
                pboxImage.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }


        private void FormArticle_Load(object sender, EventArgs e)
        {
            FillDropDownCategories();
            FillDropDownBrands();
            btnSaveArticle.Enabled = false;

            if (_currentArticle != null)
            {
                //Codigo para cargar el formulario con los datos de la db
                txtNameArticle.Text = _currentArticle.Name;
                txtCodeArticle.Text = _currentArticle.Code;
                txtDescriptionArticle.Text = _currentArticle.Description;
                txtImageArticle.Text = _currentArticle.ImageUrl;
                txtPriceArticle.Text = _currentArticle.Price.ToString();

                cboxBrand.SelectedValue = _currentArticle.BrandName.Id;
                cboxCategory.SelectedValue = _currentArticle.Category.Id;

            }
        }

        private void btnSaveArticle_Click(object sender, EventArgs e)
        {
            //Proceso para insertar articulo a la base de datos
            ArticleController controller = new ArticleController();
            Article art = new Article();
            art.Name = txtNameArticle.Text;
            art.Code = txtCodeArticle.Text;
            art.Description = txtDescriptionArticle.Text;
            art.Price = decimal.Parse(txtPriceArticle.Text);
            art.BrandName = (Brand)cboxBrand.SelectedItem;
            art.Category = (Category)cboxCategory.SelectedItem;
            art.ImageUrl = txtImageArticle.Text;

            if (this._currentArticle != null)
            {
                //Si se esta modificando un articulo, cargamos el id del mismo al articulo
                //nuevo que vamos a ingresar.
                art.Id = this._currentArticle.Id;
                if (controller.UpdateArticle(art))
                    MessageBox.Show("Se actualizó con éxito");
                else
                    MessageBox.Show("No fue posible realizar la acción");

            }
            else
            {
                if (controller.InsertArticle(art))
                    MessageBox.Show("Se agrego con éxito");
                else
                    MessageBox.Show("No fue posible realizar la acción");
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Validaciones de inputs
        private void txtNameArticle_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameArticle.Text))
            {
                lblNameAlert.ForeColor = this._alert;
                lblNameAlert.Text = "Campo requerido";
                this._stateControls[txtNameArticle.TabIndex] = false;
            }
            else
            {
                lblNameAlert.ForeColor = this._ok;
                lblNameAlert.Text = "Nombre válido";
                this._stateControls[txtNameArticle.TabIndex] = true;
            }

            btnSaveArticle.Enabled = ValidateControls();

        }

        private void txtCodeArticle_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCodeArticle.Text))
            {
                lblCodeAlert.ForeColor = this._alert;
                lblCodeAlert.Text = "Campo requerido";
                this._stateControls[txtCodeArticle.TabIndex] = false;
            }
            else
            {
                lblCodeAlert.ForeColor = this._ok;
                lblCodeAlert.Text = "Código válido";
                this._stateControls[txtCodeArticle.TabIndex] = true;
            }

            btnSaveArticle.Enabled = ValidateControls();

        }

        private void txtDescriptionArticle_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescriptionArticle.Text))
            {
                lblDescriptionAlert.ForeColor = this._alert;
                lblDescriptionAlert.Text = "Campo requerido";
                this._stateControls[txtDescriptionArticle.TabIndex] = false;

            }
            else
            {
                lblDescriptionAlert.ForeColor = this._ok;
                lblDescriptionAlert.Text = "Descripción válida";
                this._stateControls[txtDescriptionArticle.TabIndex] = true;
            }
            btnSaveArticle.Enabled = ValidateControls();

        }

        private void txtImageArticle_Validated(object sender, EventArgs e)
        {
            string txt = txtImageArticle.Text.ToLower();
            if(txt.StartsWith("http") || txt.StartsWith("c:\\"))
            {
                lblImageAlert.ForeColor = this._ok;
                lblImageAlert.Text = "Dirección válida";
                this._stateControls[txtImageArticle.TabIndex] = true;
                LoadImagePictureBox(txt);
            }
            else
            {
                lblImageAlert.ForeColor = this._alert;
                lblImageAlert.Text = "Dirección inválida.";
                this._stateControls[txtImageArticle.TabIndex] = false;
            }
            btnSaveArticle.Enabled = ValidateControls();
        }

        private void txtPriceArticle_Validated(object sender, EventArgs e)
        {
            if (PriceValidation(txtPriceArticle.Text))
            {
                lblPriceAlert.ForeColor = this._ok;
                lblPriceAlert.Text = "Precio válido";
                this._stateControls[txtPriceArticle.TabIndex] = true;
            }
            else
            {
                lblPriceAlert.ForeColor = this._alert;
                lblPriceAlert.Text = "Ingrese un precio válido. Use '.' como separador decimal";
                this._stateControls[txtPriceArticle.TabIndex] = false;
            }
            btnSaveArticle.Enabled = ValidateControls();

        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            string filter = "Image Files(*.jpg,*.png)|*.jpg;*.png";
            OpenFileDialog ofl = new OpenFileDialog();
            ofl.Filter = filter;
            if(ofl.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(ofl.FileName))
            {
                path = ofl.FileName;
                string filename = $"copy_{ofl.SafeFileName}";
                txtImageArticle.Text = path;
                if (CopyFileToDirectory(path, filename))
                    MessageBox.Show("Se copio con exito el archivo");
            }
            btnSaveArticle.Enabled = ValidateControls();

        }

        private void cboxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxBrand.SelectedIndex != 0)
            {
                lblBrandAlert.ForeColor = this._ok;
                lblBrandAlert.Text = "Marca válida";
                this._stateControls[cboxBrand.TabIndex] = true;
            }
            else
            {
                lblBrandAlert.ForeColor = this._alert;
                lblBrandAlert.Text = "Seleccione una marca válida";
                this._stateControls[cboxBrand.TabIndex] = true;
            }
            btnSaveArticle.Enabled = ValidateControls();
        }

        private void cboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxCategory.SelectedIndex != 0)
            {
                lblCategoryAlert.ForeColor = this._ok;
                lblCategoryAlert.Text = "Categoría válida";
                this._stateControls[cboxCategory.TabIndex] = true;
            }
            else
            {
                lblCategoryAlert.ForeColor = this._alert;
                lblCategoryAlert.Text = "Seleccione una categoría válida";
                this._stateControls[cboxCategory.TabIndex] = false;
            }
            btnSaveArticle.Enabled = ValidateControls();
        }
     
        //Metodo para copiar archivo a un directorio especifico
        private bool CopyFileToDirectory(string source_path, string file_name)
        {
            if(string.IsNullOrWhiteSpace(source_path)) return false;

            try
            {
                //Si no existe el directorio, lo creamos
                string directory = ConfigurationManager.AppSettings["destination_path"];
                if(!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                //Si el archivo existe, realizamos la copia
                string destfilename = Path.Combine(directory, file_name);
                if (File.Exists(source_path))
                {
                    if (File.Exists(destfilename))
                    {
                        DialogResult resp = MessageBox.Show("El archivo ya existe, desea reemplazarlo?","Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (resp == DialogResult.Cancel) return false;
                    }

                    File.Copy(source_path, destfilename, true);
                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hubo un error al copiar la imagen.\r\n{e.Message}", "Error");
                return false;
            }

        }
    }
}
