namespace AppEstructura
{
  partial class frmArbolB
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
      this.btnClose = new System.Windows.Forms.Button();
      this.btnCerrar = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.tbPostorden = new System.Windows.Forms.TextBox();
      this.tbPreorden = new System.Windows.Forms.TextBox();
      this.tbInsertar = new System.Windows.Forms.TextBox();
      this.tbInorden = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnReiniciar = new System.Windows.Forms.Button();
      this.btnAgregar = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Red;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.Black;
      this.btnClose.Location = new System.Drawing.Point(933, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(30, 29);
      this.btnClose.TabIndex = 18;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnCerrar
      // 
      this.btnCerrar.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCerrar.Location = new System.Drawing.Point(272, 425);
      this.btnCerrar.Name = "btnCerrar";
      this.btnCerrar.Size = new System.Drawing.Size(100, 40);
      this.btnCerrar.TabIndex = 31;
      this.btnCerrar.Text = "Cerrar";
      this.btnCerrar.UseVisualStyleBackColor = true;
      this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(68, 29);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(87, 26);
      this.label4.TabIndex = 30;
      this.label4.Text = "Insertar";
      // 
      // btnEliminar
      // 
      this.btnEliminar.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEliminar.Location = new System.Drawing.Point(160, 425);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(106, 40);
      this.btnEliminar.TabIndex = 29;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
      // 
      // panel1
      // 
      this.panel1.AutoScroll = true;
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Location = new System.Drawing.Point(380, 39);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(556, 480);
      this.panel1.TabIndex = 28;
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.White;
      this.pictureBox1.Location = new System.Drawing.Point(3, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(553, 480);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // tbPostorden
      // 
      this.tbPostorden.BackColor = System.Drawing.Color.White;
      this.tbPostorden.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbPostorden.ForeColor = System.Drawing.Color.Black;
      this.tbPostorden.Location = new System.Drawing.Point(68, 339);
      this.tbPostorden.Multiline = true;
      this.tbPostorden.Name = "tbPostorden";
      this.tbPostorden.ReadOnly = true;
      this.tbPostorden.Size = new System.Drawing.Size(305, 80);
      this.tbPostorden.TabIndex = 24;
      // 
      // tbPreorden
      // 
      this.tbPreorden.BackColor = System.Drawing.Color.White;
      this.tbPreorden.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbPreorden.ForeColor = System.Drawing.Color.Black;
      this.tbPreorden.Location = new System.Drawing.Point(67, 231);
      this.tbPreorden.Multiline = true;
      this.tbPreorden.Name = "tbPreorden";
      this.tbPreorden.ReadOnly = true;
      this.tbPreorden.Size = new System.Drawing.Size(305, 80);
      this.tbPreorden.TabIndex = 25;
      // 
      // tbInsertar
      // 
      this.tbInsertar.BackColor = System.Drawing.Color.White;
      this.tbInsertar.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbInsertar.ForeColor = System.Drawing.Color.Black;
      this.tbInsertar.Location = new System.Drawing.Point(68, 58);
      this.tbInsertar.Multiline = true;
      this.tbInsertar.Name = "tbInsertar";
      this.tbInsertar.Size = new System.Drawing.Size(304, 37);
      this.tbInsertar.TabIndex = 26;
      // 
      // tbInorden
      // 
      this.tbInorden.BackColor = System.Drawing.Color.White;
      this.tbInorden.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbInorden.ForeColor = System.Drawing.Color.Black;
      this.tbInorden.Location = new System.Drawing.Point(67, 123);
      this.tbInorden.Multiline = true;
      this.tbInorden.Name = "tbInorden";
      this.tbInorden.ReadOnly = true;
      this.tbInorden.Size = new System.Drawing.Size(305, 80);
      this.tbInorden.TabIndex = 27;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(68, 314);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(99, 26);
      this.label3.TabIndex = 21;
      this.label3.Text = "Postorden";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(63, 206);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(91, 26);
      this.label2.TabIndex = 22;
      this.label2.Text = "Preorden";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(67, 98);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(82, 26);
      this.label1.TabIndex = 23;
      this.label1.Text = "Inorden";
      // 
      // btnReiniciar
      // 
      this.btnReiniciar.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnReiniciar.Location = new System.Drawing.Point(67, 471);
      this.btnReiniciar.Name = "btnReiniciar";
      this.btnReiniciar.Size = new System.Drawing.Size(305, 40);
      this.btnReiniciar.TabIndex = 19;
      this.btnReiniciar.Text = "Reiniciar";
      this.btnReiniciar.UseVisualStyleBackColor = true;
      this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
      // 
      // btnAgregar
      // 
      this.btnAgregar.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAgregar.Location = new System.Drawing.Point(67, 425);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new System.Drawing.Size(87, 40);
      this.btnAgregar.TabIndex = 20;
      this.btnAgregar.Text = "Insertar";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
      // 
      // frmArbolB
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(999, 548);
      this.Controls.Add(this.btnCerrar);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btnEliminar);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.tbPostorden);
      this.Controls.Add(this.tbPreorden);
      this.Controls.Add(this.tbInsertar);
      this.Controls.Add(this.tbInorden);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnReiniciar);
      this.Controls.Add(this.btnAgregar);
      this.Controls.Add(this.btnClose);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmArbolB";
      this.Text = "frmArbolB";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbPostorden;
        private System.Windows.Forms.TextBox tbPreorden;
        private System.Windows.Forms.TextBox tbInsertar;
        private System.Windows.Forms.TextBox tbInorden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnAgregar;
    }
}