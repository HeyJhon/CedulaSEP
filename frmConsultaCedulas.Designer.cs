namespace CedulaSEP
{
    partial class frmConsultaCedulas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerCedula = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txt3_Nia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt9_Curp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt4_Nombre = new System.Windows.Forms.TextBox();
            this.txt4_ApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txt4_ApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCedulas = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.txtGrado = new System.Windows.Forms.ComboBox();
            this.txtGrupo = new System.Windows.Forms.ComboBox();
            this.txtTodos = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscaPorGrupos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCedulas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnVerCedula);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txt3_Nia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt9_Curp);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt4_Nombre);
            this.groupBox1.Controls.Add(this.txt4_ApellidoMaterno);
            this.groupBox1.Controls.Add(this.txt4_ApellidoPaterno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1490, 141);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESE UNO O MAS CAMPOS PARA BUSCAR";
            // 
            // btnVerCedula
            // 
            this.btnVerCedula.Enabled = false;
            this.btnVerCedula.Location = new System.Drawing.Point(250, 98);
            this.btnVerCedula.Name = "btnVerCedula";
            this.btnVerCedula.Size = new System.Drawing.Size(172, 29);
            this.btnVerCedula.TabIndex = 22;
            this.btnVerCedula.Text = "Cargar Cedula";
            this.btnVerCedula.UseVisualStyleBackColor = true;
            this.btnVerCedula.Click += new System.EventHandler(this.btnVerCedula_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(29, 98);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(172, 29);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txt3_Nia
            // 
            this.txt3_Nia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt3_Nia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt3_Nia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt3_Nia.Location = new System.Drawing.Point(29, 34);
            this.txt3_Nia.Name = "txt3_Nia";
            this.txt3_Nia.Size = new System.Drawing.Size(253, 27);
            this.txt3_Nia.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "NIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt9_Curp
            // 
            this.txt9_Curp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt9_Curp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt9_Curp.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt9_Curp.Location = new System.Drawing.Point(1165, 34);
            this.txt9_Curp.Name = "txt9_Curp";
            this.txt9_Curp.Size = new System.Drawing.Size(255, 27);
            this.txt9_Curp.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1269, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "CURP";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt4_Nombre
            // 
            this.txt4_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt4_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt4_Nombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt4_Nombre.Location = new System.Drawing.Point(835, 34);
            this.txt4_Nombre.Name = "txt4_Nombre";
            this.txt4_Nombre.Size = new System.Drawing.Size(278, 27);
            this.txt4_Nombre.TabIndex = 6;
            // 
            // txt4_ApellidoMaterno
            // 
            this.txt4_ApellidoMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt4_ApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt4_ApellidoMaterno.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt4_ApellidoMaterno.Location = new System.Drawing.Point(559, 34);
            this.txt4_ApellidoMaterno.Name = "txt4_ApellidoMaterno";
            this.txt4_ApellidoMaterno.Size = new System.Drawing.Size(259, 27);
            this.txt4_ApellidoMaterno.TabIndex = 5;
            // 
            // txt4_ApellidoPaterno
            // 
            this.txt4_ApellidoPaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt4_ApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt4_ApellidoPaterno.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt4_ApellidoPaterno.Location = new System.Drawing.Point(288, 34);
            this.txt4_ApellidoPaterno.Name = "txt4_ApellidoPaterno";
            this.txt4_ApellidoPaterno.Size = new System.Drawing.Size(255, 27);
            this.txt4_ApellidoPaterno.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(931, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "NOMBRE(S)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "APELLIDO MATERNO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "APELLIDO PATERNO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvCedulas
            // 
            this.dgvCedulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCedulas.Location = new System.Drawing.Point(12, 272);
            this.dgvCedulas.Name = "dgvCedulas";
            this.dgvCedulas.RowHeadersWidth = 51;
            this.dgvCedulas.RowTemplate.Height = 29;
            this.dgvCedulas.Size = new System.Drawing.Size(1490, 328);
            this.dgvCedulas.TabIndex = 5;
            this.dgvCedulas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCedulas_CellClick);
            this.dgvCedulas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCedulas_CellContentDoubleClick);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(1321, 606);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(181, 51);
            this.btnExportar.TabIndex = 6;
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // txtGrado
            // 
            this.txtGrado.FormattingEnabled = true;
            this.txtGrado.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.txtGrado.Location = new System.Drawing.Point(23, 40);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(151, 25);
            this.txtGrado.TabIndex = 23;
            this.txtGrado.Text = "1";
            // 
            // txtGrupo
            // 
            this.txtGrupo.FormattingEnabled = true;
            this.txtGrupo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.txtGrupo.Location = new System.Drawing.Point(180, 40);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(151, 25);
            this.txtGrupo.TabIndex = 24;
            this.txtGrupo.Text = "A";
            // 
            // txtTodos
            // 
            this.txtTodos.AutoSize = true;
            this.txtTodos.Location = new System.Drawing.Point(356, 44);
            this.txtTodos.Name = "txtTodos";
            this.txtTodos.Size = new System.Drawing.Size(72, 21);
            this.txtTodos.TabIndex = 25;
            this.txtTodos.Text = "TODOS";
            this.txtTodos.UseVisualStyleBackColor = true;
            this.txtTodos.CheckedChanged += new System.EventHandler(this.txtTodos_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscaPorGrupos);
            this.groupBox2.Controls.Add(this.txtTodos);
            this.groupBox2.Controls.Add(this.txtGrado);
            this.groupBox2.Controls.Add(this.txtGrupo);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1490, 98);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSQUEDA POR GRADO Y GRUPO";
            // 
            // btnBuscaPorGrupos
            // 
            this.btnBuscaPorGrupos.Location = new System.Drawing.Point(470, 39);
            this.btnBuscaPorGrupos.Name = "btnBuscaPorGrupos";
            this.btnBuscaPorGrupos.Size = new System.Drawing.Size(172, 29);
            this.btnBuscaPorGrupos.TabIndex = 26;
            this.btnBuscaPorGrupos.Text = "Consultar";
            this.btnBuscaPorGrupos.UseVisualStyleBackColor = true;
            this.btnBuscaPorGrupos.Click += new System.EventHandler(this.btnBuscaPorGrupos_Click);
            // 
            // frmConsultaCedulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1284, 669);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvCedulas);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultaCedulas";
            this.Text = "Consulta de Cedulas";
            this.Load += new System.EventHandler(this.frmConsultaCedulas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCedulas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt3_Nia;
        private Label label1;
        private TextBox txt9_Curp;
        private Label label10;
        private TextBox txt4_Nombre;
        private TextBox txt4_ApellidoMaterno;
        private TextBox txt4_ApellidoPaterno;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnBuscar;
        private DataGridView dgvCedulas;
        private Button btnVerCedula;
        private Button btnExportar;
        private CheckBox txtTodos;
        private ComboBox txtGrupo;
        private ComboBox txtGrado;
        private GroupBox groupBox2;
        private Button btnBuscaPorGrupos;
    }
}