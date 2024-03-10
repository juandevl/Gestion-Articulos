namespace frmHome
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnShowArticles = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNewArticle = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblNameCompany = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblNoData = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblAdvancedFilter = new System.Windows.Forms.Label();
            this.lblFilterArticle = new System.Windows.Forms.Label();
            this.txtFilterArticle = new System.Windows.Forms.TextBox();
            this.panelAdvancedFilter = new System.Windows.Forms.Panel();
            this.lblFilterCategory = new System.Windows.Forms.Label();
            this.lblFilterOrder = new System.Windows.Forms.Label();
            this.cboxFilterCategory = new System.Windows.Forms.ComboBox();
            this.lblFilterBrand = new System.Windows.Forms.Label();
            this.cboxFilterOrder = new System.Windows.Forms.ComboBox();
            this.cboxFilterBrand = new System.Windows.Forms.ComboBox();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.lblPriceArticleDetails = new System.Windows.Forms.Label();
            this.lblPriceDetails = new System.Windows.Forms.Label();
            this.txtDescriptionArticleDetails = new System.Windows.Forms.TextBox();
            this.lblCategoryArticleDetails = new System.Windows.Forms.Label();
            this.lblCodeArticleDetails = new System.Windows.Forms.Label();
            this.lblBrandArticleDetails = new System.Windows.Forms.Label();
            this.lblNameArticleDetails = new System.Windows.Forms.Label();
            this.lblImageDetails = new System.Windows.Forms.Label();
            this.pboxImageDetails = new System.Windows.Forms.PictureBox();
            this.lblCategoryDetails = new System.Windows.Forms.Label();
            this.lblBrandDetails = new System.Windows.Forms.Label();
            this.lblCodeDetails = new System.Windows.Forms.Label();
            this.lblDescriptionDetails = new System.Windows.Forms.Label();
            this.lblNameDetails = new System.Windows.Forms.Label();
            this.lblEditArticle = new System.Windows.Forms.Label();
            this.btnDeleteArticle = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelAdvancedFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImageDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnShowArticles);
            this.panelMenu.Controls.Add(this.btnFilter);
            this.panelMenu.Controls.Add(this.btnDelete);
            this.panelMenu.Controls.Add(this.btnEdit);
            this.panelMenu.Controls.Add(this.btnNewArticle);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(210, 718);
            this.panelMenu.TabIndex = 2;
            // 
            // btnShowArticles
            // 
            this.btnShowArticles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowArticles.FlatAppearance.BorderSize = 0;
            this.btnShowArticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowArticles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnShowArticles.Image = global::Home.Properties.Resources.show;
            this.btnShowArticles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowArticles.Location = new System.Drawing.Point(0, 436);
            this.btnShowArticles.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowArticles.Name = "btnShowArticles";
            this.btnShowArticles.Padding = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.btnShowArticles.Size = new System.Drawing.Size(210, 90);
            this.btnShowArticles.TabIndex = 5;
            this.btnShowArticles.Text = "   Ver artículos";
            this.btnShowArticles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowArticles.UseVisualStyleBackColor = true;
            this.btnShowArticles.Click += new System.EventHandler(this.btnShowArticles_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnFilter.Image = global::Home.Properties.Resources.search;
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(0, 346);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.btnFilter.Size = new System.Drawing.Size(210, 90);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "   Buscar artículo";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnDelete.Image = global::Home.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(0, 256);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.btnDelete.Size = new System.Drawing.Size(210, 90);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "   Eliminar artículo";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnEdit.Image = global::Home.Properties.Resources.edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(0, 166);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.btnEdit.Size = new System.Drawing.Size(210, 90);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "   Editar artículo";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNewArticle
            // 
            this.btnNewArticle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewArticle.FlatAppearance.BorderSize = 0;
            this.btnNewArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewArticle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnNewArticle.Image = global::Home.Properties.Resources.add;
            this.btnNewArticle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewArticle.Location = new System.Drawing.Point(0, 76);
            this.btnNewArticle.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewArticle.Name = "btnNewArticle";
            this.btnNewArticle.Padding = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.btnNewArticle.Size = new System.Drawing.Size(210, 90);
            this.btnNewArticle.TabIndex = 1;
            this.btnNewArticle.Text = "Nuevo artículo";
            this.btnNewArticle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewArticle.UseVisualStyleBackColor = true;
            this.btnNewArticle.Click += new System.EventHandler(this.btnNewArticle_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panelLogo.Controls.Add(this.lblNameCompany);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(210, 76);
            this.panelLogo.TabIndex = 0;
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNameCompany.AutoSize = true;
            this.lblNameCompany.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblNameCompany.Location = new System.Drawing.Point(17, 26);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(176, 23);
            this.lblNameCompany.TabIndex = 0;
            this.lblNameCompany.Text = "Gestion de Artículos";
            // 
            // panelTitle
            // 
            this.panelTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(210, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(941, 76);
            this.panelTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lblTitle.Location = new System.Drawing.Point(411, 22);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(118, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Principal";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnDeleteArticle);
            this.panelMain.Controls.Add(this.lblNoData);
            this.panelMain.Controls.Add(this.panelFilter);
            this.panelMain.Controls.Add(this.dgvArticles);
            this.panelMain.Controls.Add(this.panelDetails);
            this.panelMain.Controls.Add(this.lblEditArticle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(210, 76);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(941, 642);
            this.panelMain.TabIndex = 4;
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoData.Location = new System.Drawing.Point(331, 85);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Padding = new System.Windows.Forms.Padding(25);
            this.lblNoData.Size = new System.Drawing.Size(279, 73);
            this.lblNoData.TabIndex = 2;
            this.lblNoData.Text = "No hay datos para mostrar.";
            this.lblNoData.Visible = false;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.Transparent;
            this.panelFilter.Controls.Add(this.lblAdvancedFilter);
            this.panelFilter.Controls.Add(this.lblFilterArticle);
            this.panelFilter.Controls.Add(this.txtFilterArticle);
            this.panelFilter.Controls.Add(this.panelAdvancedFilter);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(941, 90);
            this.panelFilter.TabIndex = 1;
            this.panelFilter.Visible = false;
            // 
            // lblAdvancedFilter
            // 
            this.lblAdvancedFilter.AutoSize = true;
            this.lblAdvancedFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdvancedFilter.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Underline);
            this.lblAdvancedFilter.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAdvancedFilter.Location = new System.Drawing.Point(26, 66);
            this.lblAdvancedFilter.Name = "lblAdvancedFilter";
            this.lblAdvancedFilter.Size = new System.Drawing.Size(122, 20);
            this.lblAdvancedFilter.TabIndex = 3;
            this.lblAdvancedFilter.Text = "Filtro avanzado>";
            this.lblAdvancedFilter.Click += new System.EventHandler(this.lblAdvancedFilter_Click);
            // 
            // lblFilterArticle
            // 
            this.lblFilterArticle.AutoSize = true;
            this.lblFilterArticle.Location = new System.Drawing.Point(18, 9);
            this.lblFilterArticle.Name = "lblFilterArticle";
            this.lblFilterArticle.Size = new System.Drawing.Size(133, 20);
            this.lblFilterArticle.TabIndex = 27;
            this.lblFilterArticle.Text = "Nombre artículo:";
            // 
            // txtFilterArticle
            // 
            this.txtFilterArticle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterArticle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterArticle.Location = new System.Drawing.Point(18, 30);
            this.txtFilterArticle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterArticle.MaxLength = 50;
            this.txtFilterArticle.Name = "txtFilterArticle";
            this.txtFilterArticle.Size = new System.Drawing.Size(204, 27);
            this.txtFilterArticle.TabIndex = 2;
            this.txtFilterArticle.TextChanged += new System.EventHandler(this.txtFilterArticle_TextChanged);
            // 
            // panelAdvancedFilter
            // 
            this.panelAdvancedFilter.BackColor = System.Drawing.Color.Transparent;
            this.panelAdvancedFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelAdvancedFilter.Controls.Add(this.lblFilterCategory);
            this.panelAdvancedFilter.Controls.Add(this.lblFilterOrder);
            this.panelAdvancedFilter.Controls.Add(this.cboxFilterCategory);
            this.panelAdvancedFilter.Controls.Add(this.lblFilterBrand);
            this.panelAdvancedFilter.Controls.Add(this.cboxFilterOrder);
            this.panelAdvancedFilter.Controls.Add(this.cboxFilterBrand);
            this.panelAdvancedFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdvancedFilter.Location = new System.Drawing.Point(0, 0);
            this.panelAdvancedFilter.Name = "panelAdvancedFilter";
            this.panelAdvancedFilter.Size = new System.Drawing.Size(941, 90);
            this.panelAdvancedFilter.TabIndex = 28;
            this.panelAdvancedFilter.Visible = false;
            // 
            // lblFilterCategory
            // 
            this.lblFilterCategory.AutoSize = true;
            this.lblFilterCategory.Location = new System.Drawing.Point(375, 9);
            this.lblFilterCategory.Name = "lblFilterCategory";
            this.lblFilterCategory.Size = new System.Drawing.Size(84, 20);
            this.lblFilterCategory.TabIndex = 24;
            this.lblFilterCategory.Text = "Categoría:";
            // 
            // lblFilterOrder
            // 
            this.lblFilterOrder.AutoSize = true;
            this.lblFilterOrder.Location = new System.Drawing.Point(598, 9);
            this.lblFilterOrder.Name = "lblFilterOrder";
            this.lblFilterOrder.Size = new System.Drawing.Size(103, 20);
            this.lblFilterOrder.TabIndex = 26;
            this.lblFilterOrder.Text = "Ordenar por:";
            // 
            // cboxFilterCategory
            // 
            this.cboxFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFilterCategory.FormattingEnabled = true;
            this.cboxFilterCategory.Location = new System.Drawing.Point(375, 29);
            this.cboxFilterCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxFilterCategory.Name = "cboxFilterCategory";
            this.cboxFilterCategory.Size = new System.Drawing.Size(191, 28);
            this.cboxFilterCategory.TabIndex = 23;
            this.cboxFilterCategory.SelectedIndexChanged += new System.EventHandler(this.cboxFilterCategory_SelectedIndexChanged);
            // 
            // lblFilterBrand
            // 
            this.lblFilterBrand.AutoSize = true;
            this.lblFilterBrand.Location = new System.Drawing.Point(152, 9);
            this.lblFilterBrand.Name = "lblFilterBrand";
            this.lblFilterBrand.Size = new System.Drawing.Size(58, 20);
            this.lblFilterBrand.TabIndex = 21;
            this.lblFilterBrand.Text = "Marca:";
            // 
            // cboxFilterOrder
            // 
            this.cboxFilterOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFilterOrder.FormattingEnabled = true;
            this.cboxFilterOrder.Location = new System.Drawing.Point(598, 29);
            this.cboxFilterOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxFilterOrder.Name = "cboxFilterOrder";
            this.cboxFilterOrder.Size = new System.Drawing.Size(191, 28);
            this.cboxFilterOrder.TabIndex = 25;
            this.cboxFilterOrder.SelectedIndexChanged += new System.EventHandler(this.cboxFilterOrder_SelectedIndexChanged);
            // 
            // cboxFilterBrand
            // 
            this.cboxFilterBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFilterBrand.FormattingEnabled = true;
            this.cboxFilterBrand.Location = new System.Drawing.Point(152, 29);
            this.cboxFilterBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxFilterBrand.Name = "cboxFilterBrand";
            this.cboxFilterBrand.Size = new System.Drawing.Size(191, 28);
            this.cboxFilterBrand.TabIndex = 20;
            this.cboxFilterBrand.SelectedIndexChanged += new System.EventHandler(this.cboxFilterBrand_SelectedIndexChanged);
            // 
            // dgvArticles
            // 
            this.dgvArticles.AllowUserToAddRows = false;
            this.dgvArticles.AllowUserToDeleteRows = false;
            this.dgvArticles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArticles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArticles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvArticles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvArticles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticles.GridColor = System.Drawing.SystemColors.Control;
            this.dgvArticles.Location = new System.Drawing.Point(61, 46);
            this.dgvArticles.MultiSelect = false;
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvArticles.RowHeadersVisible = false;
            this.dgvArticles.RowHeadersWidth = 51;
            this.dgvArticles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvArticles.RowTemplate.Height = 24;
            this.dgvArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticles.ShowCellErrors = false;
            this.dgvArticles.ShowCellToolTips = false;
            this.dgvArticles.ShowEditingIcon = false;
            this.dgvArticles.ShowRowErrors = false;
            this.dgvArticles.Size = new System.Drawing.Size(819, 150);
            this.dgvArticles.TabIndex = 0;
            this.dgvArticles.Visible = false;
            this.dgvArticles.SelectionChanged += new System.EventHandler(this.dgvArticles_SelectionChanged);
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelDetails.Controls.Add(this.lblPriceArticleDetails);
            this.panelDetails.Controls.Add(this.lblPriceDetails);
            this.panelDetails.Controls.Add(this.txtDescriptionArticleDetails);
            this.panelDetails.Controls.Add(this.lblCategoryArticleDetails);
            this.panelDetails.Controls.Add(this.lblCodeArticleDetails);
            this.panelDetails.Controls.Add(this.lblBrandArticleDetails);
            this.panelDetails.Controls.Add(this.lblNameArticleDetails);
            this.panelDetails.Controls.Add(this.lblImageDetails);
            this.panelDetails.Controls.Add(this.pboxImageDetails);
            this.panelDetails.Controls.Add(this.lblCategoryDetails);
            this.panelDetails.Controls.Add(this.lblBrandDetails);
            this.panelDetails.Controls.Add(this.lblCodeDetails);
            this.panelDetails.Controls.Add(this.lblDescriptionDetails);
            this.panelDetails.Controls.Add(this.lblNameDetails);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDetails.Location = new System.Drawing.Point(0, 342);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Padding = new System.Windows.Forms.Padding(10);
            this.panelDetails.Size = new System.Drawing.Size(941, 300);
            this.panelDetails.TabIndex = 30;
            this.panelDetails.Visible = false;
            // 
            // lblPriceArticleDetails
            // 
            this.lblPriceArticleDetails.AutoSize = true;
            this.lblPriceArticleDetails.Location = new System.Drawing.Point(93, 120);
            this.lblPriceArticleDetails.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPriceArticleDetails.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblPriceArticleDetails.Name = "lblPriceArticleDetails";
            this.lblPriceArticleDetails.Size = new System.Drawing.Size(21, 20);
            this.lblPriceArticleDetails.TabIndex = 14;
            this.lblPriceArticleDetails.Text = "...";
            // 
            // lblPriceDetails
            // 
            this.lblPriceDetails.AutoSize = true;
            this.lblPriceDetails.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPriceDetails.Location = new System.Drawing.Point(32, 120);
            this.lblPriceDetails.Name = "lblPriceDetails";
            this.lblPriceDetails.Size = new System.Drawing.Size(63, 20);
            this.lblPriceDetails.TabIndex = 13;
            this.lblPriceDetails.Text = "Precio: ";
            // 
            // txtDescriptionArticleDetails
            // 
            this.txtDescriptionArticleDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescriptionArticleDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDescriptionArticleDetails.Location = new System.Drawing.Point(141, 165);
            this.txtDescriptionArticleDetails.MaximumSize = new System.Drawing.Size(425, 60);
            this.txtDescriptionArticleDetails.MaxLength = 150;
            this.txtDescriptionArticleDetails.Multiline = true;
            this.txtDescriptionArticleDetails.Name = "txtDescriptionArticleDetails";
            this.txtDescriptionArticleDetails.ReadOnly = true;
            this.txtDescriptionArticleDetails.Size = new System.Drawing.Size(425, 22);
            this.txtDescriptionArticleDetails.TabIndex = 12;
            this.txtDescriptionArticleDetails.Text = "...";
            // 
            // lblCategoryArticleDetails
            // 
            this.lblCategoryArticleDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCategoryArticleDetails.AutoSize = true;
            this.lblCategoryArticleDetails.Location = new System.Drawing.Point(413, 72);
            this.lblCategoryArticleDetails.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCategoryArticleDetails.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblCategoryArticleDetails.Name = "lblCategoryArticleDetails";
            this.lblCategoryArticleDetails.Size = new System.Drawing.Size(21, 20);
            this.lblCategoryArticleDetails.TabIndex = 10;
            this.lblCategoryArticleDetails.Text = "...";
            // 
            // lblCodeArticleDetails
            // 
            this.lblCodeArticleDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodeArticleDetails.AutoSize = true;
            this.lblCodeArticleDetails.Location = new System.Drawing.Point(400, 28);
            this.lblCodeArticleDetails.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCodeArticleDetails.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblCodeArticleDetails.Name = "lblCodeArticleDetails";
            this.lblCodeArticleDetails.Size = new System.Drawing.Size(21, 20);
            this.lblCodeArticleDetails.TabIndex = 9;
            this.lblCodeArticleDetails.Text = "...";
            // 
            // lblBrandArticleDetails
            // 
            this.lblBrandArticleDetails.AutoSize = true;
            this.lblBrandArticleDetails.Location = new System.Drawing.Point(93, 74);
            this.lblBrandArticleDetails.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBrandArticleDetails.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblBrandArticleDetails.Name = "lblBrandArticleDetails";
            this.lblBrandArticleDetails.Size = new System.Drawing.Size(21, 20);
            this.lblBrandArticleDetails.TabIndex = 8;
            this.lblBrandArticleDetails.Text = "...";
            // 
            // lblNameArticleDetails
            // 
            this.lblNameArticleDetails.AutoSize = true;
            this.lblNameArticleDetails.Location = new System.Drawing.Point(169, 28);
            this.lblNameArticleDetails.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNameArticleDetails.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblNameArticleDetails.Name = "lblNameArticleDetails";
            this.lblNameArticleDetails.Size = new System.Drawing.Size(21, 20);
            this.lblNameArticleDetails.TabIndex = 7;
            this.lblNameArticleDetails.Text = "...";
            // 
            // lblImageDetails
            // 
            this.lblImageDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImageDetails.AutoSize = true;
            this.lblImageDetails.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblImageDetails.Location = new System.Drawing.Point(598, 28);
            this.lblImageDetails.Name = "lblImageDetails";
            this.lblImageDetails.Size = new System.Drawing.Size(71, 20);
            this.lblImageDetails.TabIndex = 6;
            this.lblImageDetails.Text = "Imagen: ";
            // 
            // pboxImageDetails
            // 
            this.pboxImageDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxImageDetails.Location = new System.Drawing.Point(598, 51);
            this.pboxImageDetails.Name = "pboxImageDetails";
            this.pboxImageDetails.Size = new System.Drawing.Size(240, 220);
            this.pboxImageDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImageDetails.TabIndex = 5;
            this.pboxImageDetails.TabStop = false;
            // 
            // lblCategoryDetails
            // 
            this.lblCategoryDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCategoryDetails.AutoSize = true;
            this.lblCategoryDetails.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCategoryDetails.Location = new System.Drawing.Point(331, 72);
            this.lblCategoryDetails.Name = "lblCategoryDetails";
            this.lblCategoryDetails.Size = new System.Drawing.Size(88, 20);
            this.lblCategoryDetails.TabIndex = 4;
            this.lblCategoryDetails.Text = "Categoría: ";
            // 
            // lblBrandDetails
            // 
            this.lblBrandDetails.AutoSize = true;
            this.lblBrandDetails.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBrandDetails.Location = new System.Drawing.Point(32, 74);
            this.lblBrandDetails.Name = "lblBrandDetails";
            this.lblBrandDetails.Size = new System.Drawing.Size(62, 20);
            this.lblBrandDetails.TabIndex = 3;
            this.lblBrandDetails.Text = "Marca: ";
            // 
            // lblCodeDetails
            // 
            this.lblCodeDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodeDetails.AutoSize = true;
            this.lblCodeDetails.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCodeDetails.Location = new System.Drawing.Point(331, 28);
            this.lblCodeDetails.Name = "lblCodeDetails";
            this.lblCodeDetails.Size = new System.Drawing.Size(71, 20);
            this.lblCodeDetails.TabIndex = 2;
            this.lblCodeDetails.Text = "Código: ";
            // 
            // lblDescriptionDetails
            // 
            this.lblDescriptionDetails.AutoSize = true;
            this.lblDescriptionDetails.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescriptionDetails.Location = new System.Drawing.Point(32, 166);
            this.lblDescriptionDetails.Name = "lblDescriptionDetails";
            this.lblDescriptionDetails.Size = new System.Drawing.Size(103, 20);
            this.lblDescriptionDetails.TabIndex = 1;
            this.lblDescriptionDetails.Text = "Descripción: ";
            // 
            // lblNameDetails
            // 
            this.lblNameDetails.AutoSize = true;
            this.lblNameDetails.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNameDetails.Location = new System.Drawing.Point(32, 28);
            this.lblNameDetails.Name = "lblNameDetails";
            this.lblNameDetails.Size = new System.Drawing.Size(133, 20);
            this.lblNameDetails.TabIndex = 0;
            this.lblNameDetails.Text = "Nombre artículo:";
            // 
            // lblEditArticle
            // 
            this.lblEditArticle.AutoSize = true;
            this.lblEditArticle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditArticle.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Underline);
            this.lblEditArticle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblEditArticle.Location = new System.Drawing.Point(57, 329);
            this.lblEditArticle.Name = "lblEditArticle";
            this.lblEditArticle.Size = new System.Drawing.Size(113, 20);
            this.lblEditArticle.TabIndex = 29;
            this.lblEditArticle.Text = "Editar artículo>";
            this.lblEditArticle.Visible = false;
            this.lblEditArticle.Click += new System.EventHandler(this.lblEditArticle_Click);
            // 
            // btnDeleteArticle
            // 
            this.btnDeleteArticle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btnDeleteArticle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteArticle.FlatAppearance.BorderSize = 0;
            this.btnDeleteArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteArticle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteArticle.Location = new System.Drawing.Point(415, 320);
            this.btnDeleteArticle.Name = "btnDeleteArticle";
            this.btnDeleteArticle.Padding = new System.Windows.Forms.Padding(5);
            this.btnDeleteArticle.Size = new System.Drawing.Size(110, 38);
            this.btnDeleteArticle.TabIndex = 31;
            this.btnDeleteArticle.Text = "Eliminar";
            this.btnDeleteArticle.UseVisualStyleBackColor = true;
            this.btnDeleteArticle.Visible = false;
            this.btnDeleteArticle.Click += new System.EventHandler(this.btnDeleteArticle_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1151, 718);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 765);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelAdvancedFilter.ResumeLayout(false);
            this.panelAdvancedFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImageDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnNewArticle;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowArticles;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNameCompany;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.TextBox txtFilterArticle;
        private System.Windows.Forms.Label lblAdvancedFilter;
        private System.Windows.Forms.Label lblFilterBrand;
        private System.Windows.Forms.ComboBox cboxFilterBrand;
        private System.Windows.Forms.Label lblFilterCategory;
        private System.Windows.Forms.ComboBox cboxFilterCategory;
        private System.Windows.Forms.Label lblFilterArticle;
        private System.Windows.Forms.Label lblFilterOrder;
        private System.Windows.Forms.ComboBox cboxFilterOrder;
        private System.Windows.Forms.Panel panelAdvancedFilter;
        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.Label lblEditArticle;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label lblCodeDetails;
        private System.Windows.Forms.Label lblDescriptionDetails;
        private System.Windows.Forms.Label lblNameDetails;
        private System.Windows.Forms.PictureBox pboxImageDetails;
        private System.Windows.Forms.Label lblCategoryDetails;
        private System.Windows.Forms.Label lblBrandDetails;
        private System.Windows.Forms.Label lblImageDetails;
        private System.Windows.Forms.Label lblNameArticleDetails;
        private System.Windows.Forms.Label lblCategoryArticleDetails;
        private System.Windows.Forms.Label lblCodeArticleDetails;
        private System.Windows.Forms.Label lblBrandArticleDetails;
        private System.Windows.Forms.TextBox txtDescriptionArticleDetails;
        private System.Windows.Forms.Label lblPriceArticleDetails;
        private System.Windows.Forms.Label lblPriceDetails;
        private System.Windows.Forms.Button btnDeleteArticle;
    }
}

