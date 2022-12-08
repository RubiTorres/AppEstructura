namespace AppEstructura
{
  partial class frmBicola
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
      this.btnDelH = new System.Windows.Forms.Button();
      this.btnDelT = new System.Windows.Forms.Button();
      this.txtCola = new System.Windows.Forms.TextBox();
      this.btnAddT = new System.Windows.Forms.Button();
      this.btnAddH = new System.Windows.Forms.Button();
      this.txtDato = new System.Windows.Forms.TextBox();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnDelH
      // 
      this.btnDelH.Location = new System.Drawing.Point(134, 340);
      this.btnDelH.Name = "btnDelH";
      this.btnDelH.Size = new System.Drawing.Size(124, 23);
      this.btnDelH.TabIndex = 11;
      this.btnDelH.Text = "Eliminar Frente";
      this.btnDelH.UseVisualStyleBackColor = true;
      // 
      // btnDelT
      // 
      this.btnDelT.Location = new System.Drawing.Point(264, 340);
      this.btnDelT.Name = "btnDelT";
      this.btnDelT.Size = new System.Drawing.Size(124, 23);
      this.btnDelT.TabIndex = 10;
      this.btnDelT.Text = "Eliminar Final";
      this.btnDelT.UseVisualStyleBackColor = true;
      // 
      // txtCola
      // 
      this.txtCola.Location = new System.Drawing.Point(134, 130);
      this.txtCola.Multiline = true;
      this.txtCola.Name = "txtCola";
      this.txtCola.ReadOnly = true;
      this.txtCola.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtCola.Size = new System.Drawing.Size(254, 204);
      this.txtCola.TabIndex = 9;
      // 
      // btnAddT
      // 
      this.btnAddT.Location = new System.Drawing.Point(264, 89);
      this.btnAddT.Name = "btnAddT";
      this.btnAddT.Size = new System.Drawing.Size(124, 23);
      this.btnAddT.TabIndex = 8;
      this.btnAddT.Text = "Agregar Final";
      this.btnAddT.UseVisualStyleBackColor = true;
      // 
      // btnAddH
      // 
      this.btnAddH.Location = new System.Drawing.Point(134, 89);
      this.btnAddH.Name = "btnAddH";
      this.btnAddH.Size = new System.Drawing.Size(124, 23);
      this.btnAddH.TabIndex = 7;
      this.btnAddH.Text = "Agregar Frente";
      this.btnAddH.UseVisualStyleBackColor = true;
      // 
      // txtDato
      // 
      this.txtDato.Location = new System.Drawing.Point(134, 63);
      this.txtDato.Name = "txtDato";
      this.txtDato.Size = new System.Drawing.Size(254, 20);
      this.txtDato.TabIndex = 6;
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Red;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.Black;
      this.btnClose.Location = new System.Drawing.Point(483, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(30, 29);
      this.btnClose.TabIndex = 12;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // frmBicola
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(525, 451);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnDelH);
      this.Controls.Add(this.btnDelT);
      this.Controls.Add(this.txtCola);
      this.Controls.Add(this.btnAddT);
      this.Controls.Add(this.btnAddH);
      this.Controls.Add(this.txtDato);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmBicola";
      this.Text = "Bicola";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnDelH;
        private System.Windows.Forms.Button btnDelT;
        private System.Windows.Forms.TextBox txtCola;
        private System.Windows.Forms.Button btnAddT;
        private System.Windows.Forms.Button btnAddH;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnClose;
    }
}