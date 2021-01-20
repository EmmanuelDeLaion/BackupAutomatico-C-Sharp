namespace ABCBackup
{
    partial class Registros
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtBuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.txtId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtContraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCorreo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.HintForeColor = System.Drawing.Color.DimGray;
            this.txtBuscar.HintText = "Buscar por usuario";
            this.txtBuscar.isPassword = false;
            this.txtBuscar.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtBuscar.LineIdleColor = System.Drawing.Color.DimGray;
            this.txtBuscar.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtBuscar.LineThickness = 1;
            this.txtBuscar.Location = new System.Drawing.Point(382, 70);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(435, 33);
            this.txtBuscar.TabIndex = 20;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.OnValueChanged += new System.EventHandler(this.txtBuscar_OnValueChanged);
            // 
            // tablaDatos
            // 
            this.tablaDatos.AllowUserToAddRows = false;
            this.tablaDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Coolvetica Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDatos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Coolvetica Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.GridColor = System.Drawing.Color.White;
            this.tablaDatos.Location = new System.Drawing.Point(319, 110);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Coolvetica Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaDatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaDatos.Size = new System.Drawing.Size(569, 383);
            this.tablaDatos.TabIndex = 24;
            this.tablaDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDatos_CellClick);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.HintForeColor = System.Drawing.Color.White;
            this.txtId.HintText = "";
            this.txtId.isPassword = false;
            this.txtId.LineFocusedColor = System.Drawing.Color.White;
            this.txtId.LineIdleColor = System.Drawing.Color.White;
            this.txtId.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtId.LineThickness = 1;
            this.txtId.Location = new System.Drawing.Point(38, 91);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(237, 31);
            this.txtId.TabIndex = 33;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Coolvetica Rg", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 38);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ingrese la Información";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Activecolor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.BorderRadius = 0;
            this.btnActualizar.ButtonText = "Actualizar";
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.DisabledColor = System.Drawing.Color.Gray;
            this.btnActualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnActualizar.Iconimage = null;
            this.btnActualizar.Iconimage_right = null;
            this.btnActualizar.Iconimage_right_Selected = null;
            this.btnActualizar.Iconimage_Selected = null;
            this.btnActualizar.IconMarginLeft = 0;
            this.btnActualizar.IconMarginRight = 0;
            this.btnActualizar.IconRightVisible = true;
            this.btnActualizar.IconRightZoom = 0D;
            this.btnActualizar.IconVisible = true;
            this.btnActualizar.IconZoom = 90D;
            this.btnActualizar.IsTab = false;
            this.btnActualizar.Location = new System.Drawing.Point(122, 416);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Normalcolor = System.Drawing.Color.White;
            this.btnActualizar.OnHovercolor = System.Drawing.Color.White;
            this.btnActualizar.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.btnActualizar.selected = false;
            this.btnActualizar.Size = new System.Drawing.Size(80, 35);
            this.btnActualizar.TabIndex = 31;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizar.Textcolor = System.Drawing.Color.DeepSkyBlue;
            this.btnActualizar.TextFont = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.HintForeColor = System.Drawing.Color.White;
            this.txtContraseña.HintText = "";
            this.txtContraseña.isPassword = false;
            this.txtContraseña.LineFocusedColor = System.Drawing.Color.White;
            this.txtContraseña.LineIdleColor = System.Drawing.Color.White;
            this.txtContraseña.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtContraseña.LineThickness = 1;
            this.txtContraseña.Location = new System.Drawing.Point(38, 359);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(237, 31);
            this.txtContraseña.TabIndex = 30;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.White;
            this.txtCorreo.HintForeColor = System.Drawing.Color.White;
            this.txtCorreo.HintText = "";
            this.txtCorreo.isPassword = false;
            this.txtCorreo.LineFocusedColor = System.Drawing.Color.White;
            this.txtCorreo.LineIdleColor = System.Drawing.Color.White;
            this.txtCorreo.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtCorreo.LineThickness = 1;
            this.txtCorreo.Location = new System.Drawing.Point(38, 289);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(237, 31);
            this.txtCorreo.TabIndex = 29;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.HintForeColor = System.Drawing.Color.White;
            this.txtUsuario.HintText = "";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.White;
            this.txtUsuario.LineIdleColor = System.Drawing.Color.White;
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtUsuario.LineThickness = 1;
            this.txtUsuario.Location = new System.Drawing.Point(38, 216);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(237, 31);
            this.txtUsuario.TabIndex = 28;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.HintForeColor = System.Drawing.Color.White;
            this.txtNombre.HintText = "";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.White;
            this.txtNombre.LineIdleColor = System.Drawing.Color.White;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtNombre.LineThickness = 1;
            this.txtNombre.Location = new System.Drawing.Point(38, 153);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 31);
            this.txtNombre.TabIndex = 27;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.OnValueChanged += new System.EventHandler(this.txtNombre_OnValueChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.BorderRadius = 0;
            this.btnAgregar.ButtonText = "Agregar";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = null;
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = null;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 0;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = true;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = true;
            this.btnAgregar.IconZoom = 90D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(31, 416);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.Color.White;
            this.btnAgregar.OnHovercolor = System.Drawing.Color.White;
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(85, 35);
            this.btnAgregar.TabIndex = 38;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Textcolor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregar.TextFont = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::ABCBackup.Properties.Resources.cerrarApp;
            this.pictureBox5.Location = new System.Drawing.Point(861, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABCBackup.Properties.Resources.Ellipse4;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 516);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Coolvetica Rg", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(389, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(427, 57);
            this.label4.TabIndex = 39;
            this.label4.Text = "BackUp Automático";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 0;
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = null;
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 0;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 90D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(208, 416);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.White;
            this.btnEliminar.OnHovercolor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.Red;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(80, 35);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Textcolor = System.Drawing.Color.Red;
            this.btnEliminar.TextFont = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(35, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(35, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nombre:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(35, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(35, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Correo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Coolvetica Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(35, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "Contraseña:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Coolvetica Condensed Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.Location = new System.Drawing.Point(562, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 22);
            this.label10.TabIndex = 46;
            this.label10.Text = "cada 24 Hrs";
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 505);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.Registros_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registros_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBuscar;
        private System.Windows.Forms.DataGridView tablaDatos;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtId;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnActualizar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContraseña;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCorreo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}