namespace AppEstructura
{
  partial class frmListaSimple
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
      this.btnEliminar = new System.Windows.Forms.Button();
      this.lblLista = new System.Windows.Forms.Label();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.txtNodo = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Red;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.Black;
      this.btnClose.Location = new System.Drawing.Point(459, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(30, 29);
      this.btnClose.TabIndex = 17;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnEliminar
      // 
      this.btnEliminar.Location = new System.Drawing.Point(315, 121);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(75, 23);
      this.btnEliminar.TabIndex = 21;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
      // 
      // lblLista
      // 
      this.lblLista.AutoSize = true;
      this.lblLista.Location = new System.Drawing.Point(246, 173);
      this.lblLista.Name = "lblLista";
      this.lblLista.Size = new System.Drawing.Size(35, 13);
      this.lblLista.TabIndex = 20;
      this.lblLista.Text = "label1";
      // 
      // btnGuardar
      // 
      this.btnGuardar.Location = new System.Drawing.Point(315, 92);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(75, 23);
      this.btnGuardar.TabIndex = 19;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // txtNodo
      // 
      this.txtNodo.Location = new System.Drawing.Point(169, 94);
      this.txtNodo.Name = "txtNodo";
      this.txtNodo.Size = new System.Drawing.Size(100, 20);
      this.txtNodo.TabIndex = 18;
      // 
      // frmListaSimple
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(501, 342);
      this.Controls.Add(this.btnEliminar);
      this.Controls.Add(this.lblLista);
      this.Controls.Add(this.btnGuardar);
      this.Controls.Add(this.txtNodo);
      this.Controls.Add(this.btnClose);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmListaSimple";
      this.Text = "frmListaSimple";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNodo;
    }
}