namespace AppEstructura
{
  partial class frmListaDEnlazada
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
      this.lbxDato = new System.Windows.Forms.ListBox();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.txtDato = new System.Windows.Forms.TextBox();
      this.lbDato = new System.Windows.Forms.Label();
      this.btnMostrar = new System.Windows.Forms.Button();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Red;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.Black;
      this.btnClose.Location = new System.Drawing.Point(536, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(30, 29);
      this.btnClose.TabIndex = 17;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // lbxDato
      // 
      this.lbxDato.FormattingEnabled = true;
      this.lbxDato.Location = new System.Drawing.Point(216, 134);
      this.lbxDato.Name = "lbxDato";
      this.lbxDato.Size = new System.Drawing.Size(120, 95);
      this.lbxDato.TabIndex = 23;
      // 
      // btnBuscar
      // 
      this.btnBuscar.Location = new System.Drawing.Point(393, 134);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(75, 23);
      this.btnBuscar.TabIndex = 22;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // txtDato
      // 
      this.txtDato.Location = new System.Drawing.Point(216, 78);
      this.txtDato.Name = "txtDato";
      this.txtDato.Size = new System.Drawing.Size(100, 20);
      this.txtDato.TabIndex = 21;
      // 
      // lbDato
      // 
      this.lbDato.AutoSize = true;
      this.lbDato.Location = new System.Drawing.Point(68, 81);
      this.lbDato.Name = "lbDato";
      this.lbDato.Size = new System.Drawing.Size(30, 13);
      this.lbDato.TabIndex = 20;
      this.lbDato.Text = "Dato";
      // 
      // btnMostrar
      // 
      this.btnMostrar.Location = new System.Drawing.Point(393, 105);
      this.btnMostrar.Name = "btnMostrar";
      this.btnMostrar.Size = new System.Drawing.Size(75, 23);
      this.btnMostrar.TabIndex = 19;
      this.btnMostrar.Text = "Mostrar";
      this.btnMostrar.UseVisualStyleBackColor = true;
      this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
      // 
      // btnGuardar
      // 
      this.btnGuardar.Location = new System.Drawing.Point(393, 76);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(75, 23);
      this.btnGuardar.TabIndex = 18;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(197, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(158, 24);
      this.label1.TabIndex = 24;
      this.label1.Text = "Listas dobles";
      // 
      // frmListaDEnlazada
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(582, 369);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lbxDato);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.txtDato);
      this.Controls.Add(this.lbDato);
      this.Controls.Add(this.btnMostrar);
      this.Controls.Add(this.btnGuardar);
      this.Controls.Add(this.btnClose);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmListaDEnlazada";
      this.Text = "frmListaDEnlazada";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbxDato;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label lbDato;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
    }
}