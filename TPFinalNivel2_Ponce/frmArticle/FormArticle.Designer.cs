namespace frmArticle
{
    partial class FormArticle
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
            this.btnSaveArticle = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNameArticle = new System.Windows.Forms.TextBox();
            this.txtCodeArticle = new System.Windows.Forms.TextBox();
            this.txtDescriptionArticle = new System.Windows.Forms.TextBox();
            this.txtImageArticle = new System.Windows.Forms.TextBox();
            this.txtPriceArticle = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.cboxBrand = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblNameAlert = new System.Windows.Forms.Label();
            this.lblCodeAlert = new System.Windows.Forms.Label();
            this.lblDescriptionAlert = new System.Windows.Forms.Label();
            this.lblImageAlert = new System.Windows.Forms.Label();
            this.lblPriceAlert = new System.Windows.Forms.Label();
            this.lblBrandAlert = new System.Windows.Forms.Label();
            this.lblCategoryAlert = new System.Windows.Forms.Label();
            this.pboxImage = new System.Windows.Forms.PictureBox();
            this.lblPrevImagen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlertValidation = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveArticle
            // 
            this.btnSaveArticle.AutoSize = true;
            this.btnSaveArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnSaveArticle.FlatAppearance.BorderSize = 0;
            this.btnSaveArticle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(138)))), ((int)(((byte)(200)))));
            this.btnSaveArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveArticle.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveArticle.ForeColor = System.Drawing.Color.White;
            this.btnSaveArticle.Location = new System.Drawing.Point(86, 494);
            this.btnSaveArticle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveArticle.Name = "btnSaveArticle";
            this.btnSaveArticle.Padding = new System.Windows.Forms.Padding(10);
            this.btnSaveArticle.Size = new System.Drawing.Size(156, 55);
            this.btnSaveArticle.TabIndex = 8;
            this.btnSaveArticle.Text = "Guardar artículo";
            this.btnSaveArticle.UseVisualStyleBackColor = false;
            this.btnSaveArticle.Click += new System.EventHandler(this.btnSaveArticle_Click);
            this.btnSaveArticle.MouseEnter += new System.EventHandler(this.btnSaveArticle_MouseEnter);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(138)))), ((int)(((byte)(200)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(290, 494);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10);
            this.btnCancel.Size = new System.Drawing.Size(97, 55);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNameArticle
            // 
            this.txtNameArticle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameArticle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameArticle.Location = new System.Drawing.Point(86, 74);
            this.txtNameArticle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameArticle.MaxLength = 50;
            this.txtNameArticle.Name = "txtNameArticle";
            this.txtNameArticle.Size = new System.Drawing.Size(293, 27);
            this.txtNameArticle.TabIndex = 0;
            this.txtNameArticle.Validated += new System.EventHandler(this.txtNameArticle_Validated);
            // 
            // txtCodeArticle
            // 
            this.txtCodeArticle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodeArticle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeArticle.Location = new System.Drawing.Point(86, 163);
            this.txtCodeArticle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodeArticle.MaxLength = 50;
            this.txtCodeArticle.Name = "txtCodeArticle";
            this.txtCodeArticle.Size = new System.Drawing.Size(293, 27);
            this.txtCodeArticle.TabIndex = 1;
            this.txtCodeArticle.Validated += new System.EventHandler(this.txtCodeArticle_Validated);
            // 
            // txtDescriptionArticle
            // 
            this.txtDescriptionArticle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescriptionArticle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionArticle.Location = new System.Drawing.Point(86, 255);
            this.txtDescriptionArticle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescriptionArticle.MaxLength = 150;
            this.txtDescriptionArticle.Name = "txtDescriptionArticle";
            this.txtDescriptionArticle.Size = new System.Drawing.Size(293, 27);
            this.txtDescriptionArticle.TabIndex = 2;
            this.txtDescriptionArticle.Validated += new System.EventHandler(this.txtDescriptionArticle_Validated);
            // 
            // txtImageArticle
            // 
            this.txtImageArticle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImageArticle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImageArticle.Location = new System.Drawing.Point(86, 334);
            this.txtImageArticle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtImageArticle.MaxLength = 1000;
            this.txtImageArticle.Name = "txtImageArticle";
            this.txtImageArticle.Size = new System.Drawing.Size(293, 27);
            this.txtImageArticle.TabIndex = 3;
            this.txtImageArticle.Validated += new System.EventHandler(this.txtImageArticle_Validated);
            // 
            // txtPriceArticle
            // 
            this.txtPriceArticle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriceArticle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceArticle.Location = new System.Drawing.Point(86, 425);
            this.txtPriceArticle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPriceArticle.MaxLength = 100;
            this.txtPriceArticle.Name = "txtPriceArticle";
            this.txtPriceArticle.Size = new System.Drawing.Size(293, 27);
            this.txtPriceArticle.TabIndex = 4;
            this.txtPriceArticle.Validated += new System.EventHandler(this.txtPriceArticle_Validated);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(86, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 19);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Nombre:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(86, 141);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(60, 19);
            this.lblCode.TabIndex = 9;
            this.lblCode.Text = "Código: ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(86, 233);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(88, 19);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Descripción: ";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(86, 313);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(62, 19);
            this.lblImage.TabIndex = 13;
            this.lblImage.Text = "Imagen: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(86, 403);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 19);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Precio:";
            // 
            // cboxCategory
            // 
            this.cboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Location = new System.Drawing.Point(461, 163);
            this.cboxCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(293, 27);
            this.cboxCategory.TabIndex = 6;
            this.cboxCategory.Validated += new System.EventHandler(this.cboxCategory_Validated);
            // 
            // cboxBrand
            // 
            this.cboxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBrand.FormattingEnabled = true;
            this.cboxBrand.Location = new System.Drawing.Point(461, 74);
            this.cboxBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxBrand.Name = "cboxBrand";
            this.cboxBrand.Size = new System.Drawing.Size(293, 27);
            this.cboxBrand.TabIndex = 5;
            this.cboxBrand.Validated += new System.EventHandler(this.cboxBrand_Validated);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(466, 52);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(51, 19);
            this.lblBrand.TabIndex = 18;
            this.lblBrand.Text = "Marca:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(466, 141);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(71, 19);
            this.lblCategory.TabIndex = 20;
            this.lblCategory.Text = "Categoría:";
            // 
            // lblNameAlert
            // 
            this.lblNameAlert.AutoSize = true;
            this.lblNameAlert.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAlert.ForeColor = System.Drawing.Color.Black;
            this.lblNameAlert.Location = new System.Drawing.Point(86, 104);
            this.lblNameAlert.Name = "lblNameAlert";
            this.lblNameAlert.Size = new System.Drawing.Size(195, 19);
            this.lblNameAlert.TabIndex = 8;
            this.lblNameAlert.Text = "Ingrese el nombre del artículo.";
            // 
            // lblCodeAlert
            // 
            this.lblCodeAlert.AutoSize = true;
            this.lblCodeAlert.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeAlert.ForeColor = System.Drawing.Color.Black;
            this.lblCodeAlert.Location = new System.Drawing.Point(86, 193);
            this.lblCodeAlert.Name = "lblCodeAlert";
            this.lblCodeAlert.Size = new System.Drawing.Size(195, 19);
            this.lblCodeAlert.TabIndex = 10;
            this.lblCodeAlert.Text = "Ingrese un valor alfanúmerico.";
            // 
            // lblDescriptionAlert
            // 
            this.lblDescriptionAlert.AutoSize = true;
            this.lblDescriptionAlert.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionAlert.ForeColor = System.Drawing.Color.Black;
            this.lblDescriptionAlert.Location = new System.Drawing.Point(86, 285);
            this.lblDescriptionAlert.Name = "lblDescriptionAlert";
            this.lblDescriptionAlert.Size = new System.Drawing.Size(217, 19);
            this.lblDescriptionAlert.TabIndex = 12;
            this.lblDescriptionAlert.Text = "Ingrese la descripción del artículo.";
            // 
            // lblImageAlert
            // 
            this.lblImageAlert.AutoSize = true;
            this.lblImageAlert.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageAlert.ForeColor = System.Drawing.Color.Black;
            this.lblImageAlert.Location = new System.Drawing.Point(86, 365);
            this.lblImageAlert.Name = "lblImageAlert";
            this.lblImageAlert.Size = new System.Drawing.Size(233, 19);
            this.lblImageAlert.TabIndex = 15;
            this.lblImageAlert.Text = "Ingrese una URL o una imagen local.";
            // 
            // lblPriceAlert
            // 
            this.lblPriceAlert.AutoSize = true;
            this.lblPriceAlert.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceAlert.ForeColor = System.Drawing.Color.Black;
            this.lblPriceAlert.Location = new System.Drawing.Point(86, 456);
            this.lblPriceAlert.Name = "lblPriceAlert";
            this.lblPriceAlert.Size = new System.Drawing.Size(367, 19);
            this.lblPriceAlert.TabIndex = 17;
            this.lblPriceAlert.Text = "Ingresa un número con decimales. Usa \'.\' como separador.";
            // 
            // lblBrandAlert
            // 
            this.lblBrandAlert.AutoSize = true;
            this.lblBrandAlert.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandAlert.ForeColor = System.Drawing.Color.Black;
            this.lblBrandAlert.Location = new System.Drawing.Point(466, 104);
            this.lblBrandAlert.Name = "lblBrandAlert";
            this.lblBrandAlert.Size = new System.Drawing.Size(205, 19);
            this.lblBrandAlert.TabIndex = 19;
            this.lblBrandAlert.Text = "Seleccione la marca del artículo.";
            // 
            // lblCategoryAlert
            // 
            this.lblCategoryAlert.AutoSize = true;
            this.lblCategoryAlert.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryAlert.ForeColor = System.Drawing.Color.Black;
            this.lblCategoryAlert.Location = new System.Drawing.Point(466, 193);
            this.lblCategoryAlert.Name = "lblCategoryAlert";
            this.lblCategoryAlert.Size = new System.Drawing.Size(222, 19);
            this.lblCategoryAlert.TabIndex = 21;
            this.lblCategoryAlert.Text = "Seleccione la categoría del artítulo.";
            // 
            // pboxImage
            // 
            this.pboxImage.Location = new System.Drawing.Point(470, 273);
            this.pboxImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pboxImage.MaximumSize = new System.Drawing.Size(310, 270);
            this.pboxImage.Name = "pboxImage";
            this.pboxImage.Size = new System.Drawing.Size(304, 270);
            this.pboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImage.TabIndex = 25;
            this.pboxImage.TabStop = false;
            // 
            // lblPrevImagen
            // 
            this.lblPrevImagen.AutoSize = true;
            this.lblPrevImagen.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevImagen.Location = new System.Drawing.Point(466, 251);
            this.lblPrevImagen.Name = "lblPrevImagen";
            this.lblPrevImagen.Size = new System.Drawing.Size(176, 19);
            this.lblPrevImagen.TabIndex = 22;
            this.lblPrevImagen.Text = "Previsualización de imagen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(138, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "(URL o Imagen local)";
            // 
            // lblAlertValidation
            // 
            this.lblAlertValidation.AutoSize = true;
            this.lblAlertValidation.Location = new System.Drawing.Point(86, 557);
            this.lblAlertValidation.Name = "lblAlertValidation";
            this.lblAlertValidation.Size = new System.Drawing.Size(180, 19);
            this.lblAlertValidation.TabIndex = 26;
            this.lblAlertValidation.Text = "Completa todos los campos";
            this.lblAlertValidation.Visible = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnSelectImage.FlatAppearance.BorderSize = 0;
            this.btnSelectImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(138)))), ((int)(((byte)(200)))));
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImage.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImage.ForeColor = System.Drawing.Color.White;
            this.btnSelectImage.Location = new System.Drawing.Point(386, 329);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(39, 36);
            this.btnSelectImage.TabIndex = 7;
            this.btnSelectImage.Text = "+";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // FormArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(861, 629);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.lblAlertValidation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrevImagen);
            this.Controls.Add(this.pboxImage);
            this.Controls.Add(this.lblCategoryAlert);
            this.Controls.Add(this.lblBrandAlert);
            this.Controls.Add(this.lblPriceAlert);
            this.Controls.Add(this.lblImageAlert);
            this.Controls.Add(this.lblDescriptionAlert);
            this.Controls.Add(this.lblCodeAlert);
            this.Controls.Add(this.lblNameAlert);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.cboxBrand);
            this.Controls.Add(this.cboxCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPriceArticle);
            this.Controls.Add(this.txtImageArticle);
            this.Controls.Add(this.txtDescriptionArticle);
            this.Controls.Add(this.txtCodeArticle);
            this.Controls.Add(this.txtNameArticle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveArticle);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormArticle";
            this.Padding = new System.Windows.Forms.Padding(15, 42, 15, 42);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de artículo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveArticle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNameArticle;
        private System.Windows.Forms.TextBox txtCodeArticle;
        private System.Windows.Forms.TextBox txtDescriptionArticle;
        private System.Windows.Forms.TextBox txtImageArticle;
        private System.Windows.Forms.TextBox txtPriceArticle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.ComboBox cboxBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblNameAlert;
        private System.Windows.Forms.Label lblCodeAlert;
        private System.Windows.Forms.Label lblDescriptionAlert;
        private System.Windows.Forms.Label lblImageAlert;
        private System.Windows.Forms.Label lblPriceAlert;
        private System.Windows.Forms.Label lblBrandAlert;
        private System.Windows.Forms.Label lblCategoryAlert;
        private System.Windows.Forms.PictureBox pboxImage;
        private System.Windows.Forms.Label lblPrevImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlertValidation;
        private System.Windows.Forms.Button btnSelectImage;
    }
}

