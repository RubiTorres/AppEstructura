namespace AppEstructura
{
  partial class frmColaSimple
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
      this.btnDel = new System.Windows.Forms.Button();
      this.txtCola = new System.Windows.Forms.TextBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.txtDato = new System.Windows.Forms.TextBox();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnDel
      // 
      this.btnDel.Location = new System.Drawing.Point(71, 237);
      this.btnDel.Name = "btnDel";
      this.btnDel.Size = new System.Drawing.Size(294, 23);
      this.btnDel.TabIndex = 7;
      this.btnDel.Text = "Quitar";
      this.btnDel.UseVisualStyleBackColor = true;
      this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
      // 
      // txtCola
      // 
      this.txtCola.Location = new System.Drawing.Point(71, 69);
      this.txtCola.Multiline = true;
      this.txtCola.Name = "txtCola";
      this.txtCola.ReadOnly = true;
      this.txtCola.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtCola.Size = new System.Drawing.Size(294, 162);
      this.txtCola.TabIndex = 6;
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(261, 34);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(103, 23);
      this.btnAdd.TabIndex = 5;
      this.btnAdd.Text = "Agregar";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // txtDato
      // 
      this.txtDato.Location = new System.Drawing.Point(71, 36);
      this.txtDato.Name = "txtDato";
      this.txtDato.Size = new System.Drawing.Size(184, 20);
      this.txtDato.TabIndex = 4;
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Red;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.Black;
      this.btnClose.Location = new System.Drawing.Point(454, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(30, 29);
      this.btnClose.TabIndex = 17;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // frmColaSimple
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(496, 340);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnDel);
      this.Controls.Add(this.txtCola);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.txtDato);
      this.Cursor = System.Windows.Forms.Cursors.Default;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmColaSimple";
      this.Text = "frmColaSimple";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtCola;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnClose;
    }
}