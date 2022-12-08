namespace AppEstructura
{
  partial class frmColaPrioridad
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
      this.grbSec = new System.Windows.Forms.GroupBox();
      this.btnDel = new System.Windows.Forms.Button();
      this.txtPri = new System.Windows.Forms.TextBox();
      this.txtCola = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtDato = new System.Windows.Forms.TextBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.grbFirst = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnNum = new System.Windows.Forms.Button();
      this.txtNum = new System.Windows.Forms.TextBox();
      this.btnClose = new System.Windows.Forms.Button();
      this.grbSec.SuspendLayout();
      this.grbFirst.SuspendLayout();
      this.SuspendLayout();
      // 
      // grbSec
      // 
      this.grbSec.Controls.Add(this.btnDel);
      this.grbSec.Controls.Add(this.txtPri);
      this.grbSec.Controls.Add(this.txtCola);
      this.grbSec.Controls.Add(this.label3);
      this.grbSec.Controls.Add(this.label2);
      this.grbSec.Controls.Add(this.txtDato);
      this.grbSec.Controls.Add(this.btnAdd);
      this.grbSec.Location = new System.Drawing.Point(119, 86);
      this.grbSec.Name = "grbSec";
      this.grbSec.Size = new System.Drawing.Size(381, 343);
      this.grbSec.TabIndex = 7;
      this.grbSec.TabStop = false;
      this.grbSec.Visible = false;
      // 
      // btnDel
      // 
      this.btnDel.Location = new System.Drawing.Point(9, 289);
      this.btnDel.Name = "btnDel";
      this.btnDel.Size = new System.Drawing.Size(366, 22);
      this.btnDel.TabIndex = 7;
      this.btnDel.Text = "Eliminar";
      this.btnDel.UseVisualStyleBackColor = true;
      this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
      // 
      // txtPri
      // 
      this.txtPri.Location = new System.Drawing.Point(274, 21);
      this.txtPri.Name = "txtPri";
      this.txtPri.Size = new System.Drawing.Size(96, 20);
      this.txtPri.TabIndex = 6;
      // 
      // txtCola
      // 
      this.txtCola.Location = new System.Drawing.Point(6, 81);
      this.txtCola.Multiline = true;
      this.txtCola.Name = "txtCola";
      this.txtCola.ReadOnly = true;
      this.txtCola.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtCola.Size = new System.Drawing.Size(369, 202);
      this.txtCola.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(221, 24);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(51, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Prioridad:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 24);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(33, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Dato:";
      // 
      // txtDato
      // 
      this.txtDato.Location = new System.Drawing.Point(45, 21);
      this.txtDato.Name = "txtDato";
      this.txtDato.Size = new System.Drawing.Size(165, 20);
      this.txtDato.TabIndex = 3;
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(9, 47);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(366, 22);
      this.btnAdd.TabIndex = 3;
      this.btnAdd.Text = "Agregar";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // grbFirst
      // 
      this.grbFirst.Controls.Add(this.label1);
      this.grbFirst.Controls.Add(this.btnNum);
      this.grbFirst.Controls.Add(this.txtNum);
      this.grbFirst.Location = new System.Drawing.Point(119, 25);
      this.grbFirst.Name = "grbFirst";
      this.grbFirst.Size = new System.Drawing.Size(381, 55);
      this.grbFirst.TabIndex = 6;
      this.grbFirst.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(116, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Número de prioridades:";
      // 
      // btnNum
      // 
      this.btnNum.Location = new System.Drawing.Point(221, 19);
      this.btnNum.Name = "btnNum";
      this.btnNum.Size = new System.Drawing.Size(141, 23);
      this.btnNum.TabIndex = 2;
      this.btnNum.Text = "Aceptar";
      this.btnNum.UseVisualStyleBackColor = true;
      this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
      // 
      // txtNum
      // 
      this.txtNum.Location = new System.Drawing.Point(128, 21);
      this.txtNum.Name = "txtNum";
      this.txtNum.Size = new System.Drawing.Size(87, 20);
      this.txtNum.TabIndex = 1;
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Red;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.Black;
      this.btnClose.Location = new System.Drawing.Point(550, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(30, 29);
      this.btnClose.TabIndex = 17;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // frmColaPrioridad
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(592, 437);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.grbSec);
      this.Controls.Add(this.grbFirst);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmColaPrioridad";
      this.Text = "frmColaPrioridad";
      this.grbSec.ResumeLayout(false);
      this.grbSec.PerformLayout();
      this.grbFirst.ResumeLayout(false);
      this.grbFirst.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.GroupBox grbSec;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtPri;
        private System.Windows.Forms.TextBox txtCola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnClose;
    }
}