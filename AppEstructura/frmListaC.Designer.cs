namespace AppEstructura
{
  partial class frmListaC
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
      this.btnVaciarLista = new System.Windows.Forms.Button();
      this.btnContar = new System.Windows.Forms.Button();
      this.txtEliminar = new System.Windows.Forms.TextBox();
      this.btnEliminarNodo = new System.Windows.Forms.Button();
      this.lblLista = new System.Windows.Forms.Label();
      this.txtNodo = new System.Windows.Forms.TextBox();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnVaciarLista
      // 
      this.btnVaciarLista.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnVaciarLista.Location = new System.Drawing.Point(287, 216);
      this.btnVaciarLista.Name = "btnVaciarLista";
      this.btnVaciarLista.Size = new System.Drawing.Size(89, 53);
      this.btnVaciarLista.TabIndex = 17;
      this.btnVaciarLista.Text = "Vaciar lista";
      this.btnVaciarLista.UseVisualStyleBackColor = true;
      this.btnVaciarLista.Click += new System.EventHandler(this.btnVaciarLista_Click);
      // 
      // btnContar
      // 
      this.btnContar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnContar.Location = new System.Drawing.Point(287, 144);
      this.btnContar.Name = "btnContar";
      this.btnContar.Size = new System.Drawing.Size(89, 30);
      this.btnContar.TabIndex = 16;
      this.btnContar.Text = "Contar";
      this.btnContar.UseVisualStyleBackColor = true;
      this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
      // 
      // txtEliminar
      // 
      this.txtEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEliminar.Location = new System.Drawing.Point(167, 111);
      this.txtEliminar.Name = "txtEliminar";
      this.txtEliminar.Size = new System.Drawing.Size(114, 26);
      this.txtEliminar.TabIndex = 15;
      // 
      // btnEliminarNodo
      // 
      this.btnEliminarNodo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEliminarNodo.Location = new System.Drawing.Point(287, 111);
      this.btnEliminarNodo.Name = "btnEliminarNodo";
      this.btnEliminarNodo.Size = new System.Drawing.Size(89, 30);
      this.btnEliminarNodo.TabIndex = 14;
      this.btnEliminarNodo.Text = "Eliminar dato";
      this.btnEliminarNodo.UseVisualStyleBackColor = true;
      this.btnEliminarNodo.Click += new System.EventHandler(this.btnEliminarNodo_Click);
      // 
      // lblLista
      // 
      this.lblLista.AutoSize = true;
      this.lblLista.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLista.Location = new System.Drawing.Point(387, 74);
      this.lblLista.Name = "lblLista";
      this.lblLista.Size = new System.Drawing.Size(14, 20);
      this.lblLista.TabIndex = 13;
      this.lblLista.Text = "-";
      // 
      // txtNodo
      // 
      this.txtNodo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNodo.Location = new System.Drawing.Point(167, 74);
      this.txtNodo.Name = "txtNodo";
      this.txtNodo.Size = new System.Drawing.Size(114, 26);
      this.txtNodo.TabIndex = 12;
      // 
      // btnGuardar
      // 
      this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGuardar.Location = new System.Drawing.Point(287, 72);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(89, 30);
      this.btnGuardar.TabIndex = 11;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Red;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.Black;
      this.btnClose.Location = new System.Drawing.Point(572, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(30, 29);
      this.btnClose.TabIndex = 18;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // frmListaC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(614, 370);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnVaciarLista);
      this.Controls.Add(this.btnContar);
      this.Controls.Add(this.txtEliminar);
      this.Controls.Add(this.btnEliminarNodo);
      this.Controls.Add(this.lblLista);
      this.Controls.Add(this.txtNodo);
      this.Controls.Add(this.btnGuardar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmListaC";
      this.Text = "frmListaC";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnVaciarLista;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button btnEliminarNodo;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnClose;
    }
}