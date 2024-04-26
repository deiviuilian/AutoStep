namespace AutoSuite
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_mapear = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            this.btn_add_text = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.lab_x = new System.Windows.Forms.Label();
            this.lab_y = new System.Windows.Forms.Label();
            this.lv_itens = new System.Windows.Forms.ListView();
            this.step = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_add_enter = new System.Windows.Forms.Button();
            this.btn_limpa1 = new System.Windows.Forms.Button();
            this.btn_importar = new System.Windows.Forms.Button();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mapear
            // 
            this.btn_mapear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mapear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_mapear.Location = new System.Drawing.Point(509, 164);
            this.btn_mapear.Name = "btn_mapear";
            this.btn_mapear.Size = new System.Drawing.Size(137, 37);
            this.btn_mapear.TabIndex = 0;
            this.btn_mapear.Text = "MAPEAR";
            this.btn_mapear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_mapear.UseVisualStyleBackColor = true;
            this.btn_mapear.Click += new System.EventHandler(this.btn_mapear_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_parar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_parar.Location = new System.Drawing.Point(509, 207);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(137, 37);
            this.btn_parar.TabIndex = 1;
            this.btn_parar.Text = "PARAR";
            this.btn_parar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // btn_add_text
            // 
            this.btn_add_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_text.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_add_text.Location = new System.Drawing.Point(152, 254);
            this.btn_add_text.Name = "btn_add_text";
            this.btn_add_text.Size = new System.Drawing.Size(175, 37);
            this.btn_add_text.TabIndex = 2;
            this.btn_add_text.Text = "ADICIONAR TEXTO";
            this.btn_add_text.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_text.UseVisualStyleBackColor = true;
            this.btn_add_text.Click += new System.EventHandler(this.btn_add_text_Click);
            // 
            // btn_start
            // 
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_start.Location = new System.Drawing.Point(343, 529);
            this.btn_start.Name = "btn_start";
            this.btn_start.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_start.Size = new System.Drawing.Size(301, 37);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "START";
            this.btn_start.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lab_x
            // 
            this.lab_x.AutoSize = true;
            this.lab_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lab_x.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lab_x.Location = new System.Drawing.Point(565, 101);
            this.lab_x.Name = "lab_x";
            this.lab_x.Size = new System.Drawing.Size(32, 25);
            this.lab_x.TabIndex = 4;
            this.lab_x.Text = "X:";
            // 
            // lab_y
            // 
            this.lab_y.AutoSize = true;
            this.lab_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lab_y.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lab_y.Location = new System.Drawing.Point(565, 126);
            this.lab_y.Name = "lab_y";
            this.lab_y.Size = new System.Drawing.Size(33, 25);
            this.lab_y.TabIndex = 5;
            this.lab_y.Text = "Y:";
            // 
            // lv_itens
            // 
            this.lv_itens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lv_itens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.step,
            this.type,
            this.value});
            this.lv_itens.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lv_itens.HideSelection = false;
            this.lv_itens.Location = new System.Drawing.Point(9, 297);
            this.lv_itens.Name = "lv_itens";
            this.lv_itens.Scrollable = false;
            this.lv_itens.Size = new System.Drawing.Size(637, 225);
            this.lv_itens.TabIndex = 6;
            this.lv_itens.UseCompatibleStateImageBehavior = false;
            this.lv_itens.View = System.Windows.Forms.View.Details;
            // 
            // step
            // 
            this.step.Text = "Etapa";
            this.step.Width = 80;
            // 
            // type
            // 
            this.type.Text = "Tipo";
            this.type.Width = 93;
            // 
            // value
            // 
            this.value.Text = "Valor";
            this.value.Width = 504;
            // 
            // btn_limpar
            // 
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_limpar.Location = new System.Drawing.Point(509, 254);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(137, 37);
            this.btn_limpar.TabIndex = 7;
            this.btn_limpar.Text = "LIMPAR TUDO";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_add_enter
            // 
            this.btn_add_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_enter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_add_enter.Location = new System.Drawing.Point(333, 254);
            this.btn_add_enter.Name = "btn_add_enter";
            this.btn_add_enter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_add_enter.Size = new System.Drawing.Size(170, 37);
            this.btn_add_enter.TabIndex = 8;
            this.btn_add_enter.Text = "TECLA ENTER";
            this.btn_add_enter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_enter.UseVisualStyleBackColor = true;
            this.btn_add_enter.Click += new System.EventHandler(this.btn_add_enter_Click);
            // 
            // btn_limpa1
            // 
            this.btn_limpa1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_limpa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_limpa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpa1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_limpa1.Location = new System.Drawing.Point(9, 254);
            this.btn_limpa1.Name = "btn_limpa1";
            this.btn_limpa1.Size = new System.Drawing.Size(137, 37);
            this.btn_limpa1.TabIndex = 9;
            this.btn_limpa1.Text = "LIMPAR ANTERIOR";
            this.btn_limpa1.UseVisualStyleBackColor = false;
            this.btn_limpa1.Click += new System.EventHandler(this.btn_limpa1_Click);
            // 
            // btn_importar
            // 
            this.btn_importar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_importar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_importar.Location = new System.Drawing.Point(9, 529);
            this.btn_importar.Name = "btn_importar";
            this.btn_importar.Size = new System.Drawing.Size(145, 37);
            this.btn_importar.TabIndex = 10;
            this.btn_importar.Text = "IMPORTAR";
            this.btn_importar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_importar.UseVisualStyleBackColor = true;
            this.btn_importar.Click += new System.EventHandler(this.btn_importar_Click);
            // 
            // btn_exportar
            // 
            this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_exportar.Location = new System.Drawing.Point(160, 529);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(167, 37);
            this.btn_exportar.TabIndex = 11;
            this.btn_exportar.Text = "EXPORTAR";
            this.btn_exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(482, 536);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(169, 536);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(511, 171);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(334, 257);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(156, 261);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(512, 212);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(37, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(12, 533);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(34, 29);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 19;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(362, 116);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(615, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(658, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.btn_importar);
            this.Controls.Add(this.btn_limpa1);
            this.Controls.Add(this.btn_add_enter);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lv_itens);
            this.Controls.Add(this.lab_y);
            this.Controls.Add(this.lab_x);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_add_text);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.btn_mapear);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "AutoStep";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mapear;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.Button btn_add_text;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lab_x;
        private System.Windows.Forms.Label lab_y;
        private System.Windows.Forms.ListView lv_itens;
        private System.Windows.Forms.ColumnHeader step;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader value;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_add_enter;
        private System.Windows.Forms.Button btn_limpa1;
        private System.Windows.Forms.Button btn_importar;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button1;
    }
}

