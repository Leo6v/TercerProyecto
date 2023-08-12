namespace TercerProyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminarPostre = new System.Windows.Forms.Button();
            this.btnAgregarPostre = new System.Windows.Forms.Button();
            this.txtNuevoPostre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarIngrediente = new System.Windows.Forms.Button();
            this.btnAgregarIngrediente = new System.Windows.Forms.Button();
            this.txtNuevoIngrediente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstIngredientes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPostres = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 178);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TercerProyecto.Properties.Resources.postre;
            this.pictureBox1.Location = new System.Drawing.Point(394, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Postres";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.btnEliminarPostre);
            this.panel2.Controls.Add(this.btnAgregarPostre);
            this.panel2.Controls.Add(this.txtNuevoPostre);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnEliminarIngrediente);
            this.panel2.Controls.Add(this.btnAgregarIngrediente);
            this.panel2.Controls.Add(this.txtNuevoIngrediente);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lstIngredientes);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbPostres);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(4, 187);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 380);
            this.panel2.TabIndex = 1;
            // 
            // btnEliminarPostre
            // 
            this.btnEliminarPostre.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminarPostre.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPostre.Location = new System.Drawing.Point(542, 311);
            this.btnEliminarPostre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarPostre.Name = "btnEliminarPostre";
            this.btnEliminarPostre.Size = new System.Drawing.Size(172, 45);
            this.btnEliminarPostre.TabIndex = 11;
            this.btnEliminarPostre.Text = "Eliminar Postre";
            this.btnEliminarPostre.UseVisualStyleBackColor = false;
            this.btnEliminarPostre.Click += new System.EventHandler(this.btnEliminarPostre_Click);
            // 
            // btnAgregarPostre
            // 
            this.btnAgregarPostre.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregarPostre.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPostre.Location = new System.Drawing.Point(368, 311);
            this.btnAgregarPostre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarPostre.Name = "btnAgregarPostre";
            this.btnAgregarPostre.Size = new System.Drawing.Size(170, 45);
            this.btnAgregarPostre.TabIndex = 10;
            this.btnAgregarPostre.Text = "Agregar Postre";
            this.btnAgregarPostre.UseVisualStyleBackColor = false;
            this.btnAgregarPostre.Click += new System.EventHandler(this.btnAgregarPostre_Click);
            // 
            // txtNuevoPostre
            // 
            this.txtNuevoPostre.Location = new System.Drawing.Point(368, 271);
            this.txtNuevoPostre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNuevoPostre.Name = "txtNuevoPostre";
            this.txtNuevoPostre.Size = new System.Drawing.Size(241, 26);
            this.txtNuevoPostre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nuevo Postre:";
            // 
            // btnEliminarIngrediente
            // 
            this.btnEliminarIngrediente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminarIngrediente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarIngrediente.Location = new System.Drawing.Point(542, 217);
            this.btnEliminarIngrediente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarIngrediente.Name = "btnEliminarIngrediente";
            this.btnEliminarIngrediente.Size = new System.Drawing.Size(172, 45);
            this.btnEliminarIngrediente.TabIndex = 7;
            this.btnEliminarIngrediente.Text = "Eliminar ingrediente";
            this.btnEliminarIngrediente.UseVisualStyleBackColor = false;
            this.btnEliminarIngrediente.Click += new System.EventHandler(this.btnEliminarIngrediente_Click);
            // 
            // btnAgregarIngrediente
            // 
            this.btnAgregarIngrediente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregarIngrediente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarIngrediente.Location = new System.Drawing.Point(364, 217);
            this.btnAgregarIngrediente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarIngrediente.Name = "btnAgregarIngrediente";
            this.btnAgregarIngrediente.Size = new System.Drawing.Size(170, 45);
            this.btnAgregarIngrediente.TabIndex = 6;
            this.btnAgregarIngrediente.Text = "Agregar";
            this.btnAgregarIngrediente.UseVisualStyleBackColor = false;
            this.btnAgregarIngrediente.Click += new System.EventHandler(this.btnAgregarIngrediente_Click);
            // 
            // txtNuevoIngrediente
            // 
            this.txtNuevoIngrediente.Location = new System.Drawing.Point(368, 177);
            this.txtNuevoIngrediente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNuevoIngrediente.Name = "txtNuevoIngrediente";
            this.txtNuevoIngrediente.Size = new System.Drawing.Size(241, 26);
            this.txtNuevoIngrediente.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Agregar ingrediente:";
            // 
            // lstIngredientes
            // 
            this.lstIngredientes.FormattingEnabled = true;
            this.lstIngredientes.ItemHeight = 20;
            this.lstIngredientes.Location = new System.Drawing.Point(368, 102);
            this.lstIngredientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstIngredientes.Name = "lstIngredientes";
            this.lstIngredientes.Size = new System.Drawing.Size(241, 44);
            this.lstIngredientes.TabIndex = 3;
            this.lstIngredientes.SelectedIndexChanged += new System.EventHandler(this.lstIngredientes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingredientes:";
            // 
            // cmbPostres
            // 
            this.cmbPostres.FormattingEnabled = true;
            this.cmbPostres.Location = new System.Drawing.Point(368, 32);
            this.cmbPostres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPostres.Name = "cmbPostres";
            this.cmbPostres.Size = new System.Drawing.Size(241, 28);
            this.cmbPostres.TabIndex = 1;
            this.cmbPostres.SelectedIndexChanged += new System.EventHandler(this.cmbPostres_SelectedIndexChanged);
            this.cmbPostres.Click += new System.EventHandler(this.cmbPostres_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selecciona un postre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPostres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstIngredientes;
        private System.Windows.Forms.Button btnAgregarIngrediente;
        private System.Windows.Forms.TextBox txtNuevoIngrediente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNuevoPostre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarIngrediente;
        private System.Windows.Forms.Button btnEliminarPostre;
        private System.Windows.Forms.Button btnAgregarPostre;
    }
}

