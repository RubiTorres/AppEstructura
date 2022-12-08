namespace AppEstructura
{
  partial class frmQuickSort
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
      this.button1 = new System.Windows.Forms.Button();
      this.btnQSDes = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.txtResultado = new System.Windows.Forms.TextBox();
      this.txtNum = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnQSAsc = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Red;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.Black;
      this.btnClose.Location = new System.Drawing.Point(621, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(30, 29);
      this.btnClose.TabIndex = 43;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(431, 30);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(147, 28);
      this.button1.TabIndex = 50;
      this.button1.Text = "Crear arreglo random";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnQSDes
      // 
      this.btnQSDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnQSDes.Location = new System.Drawing.Point(278, 92);
      this.btnQSDes.Name = "btnQSDes";
      this.btnQSDes.Size = new System.Drawing.Size(147, 28);
      this.btnQSDes.TabIndex = 49;
      this.btnQSDes.Text = "Ordenar descendente";
      this.btnQSDes.UseVisualStyleBackColor = true;
      this.btnQSDes.Click += new System.EventHandler(this.btnQSDes_Click);
      // 
      // btnClear
      // 
      this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClear.Location = new System.Drawing.Point(517, 92);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(61, 28);
      this.btnClear.TabIndex = 48;
      this.btnClear.Text = "Limpiar";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // txtResultado
      // 
      this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtResultado.Location = new System.Drawing.Point(117, 126);
      this.txtResultado.Multiline = true;
      this.txtResultado.Name = "txtResultado";
      this.txtResultado.ReadOnly = true;
      this.txtResultado.Size = new System.Drawing.Size(461, 228);
      this.txtResultado.TabIndex = 47;
      // 
      // txtNum
      // 
      this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNum.Location = new System.Drawing.Point(117, 64);
      this.txtNum.Name = "txtNum";
      this.txtNum.Size = new System.Drawing.Size(461, 22);
      this.txtNum.TabIndex = 46;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(114, 36);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(311, 16);
      this.label1.TabIndex = 45;
      this.label1.Text = "Ingresar números a ordenar separados por comas:";
      // 
      // btnQSAsc
      // 
      this.btnQSAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnQSAsc.Location = new System.Drawing.Point(117, 92);
      this.btnQSAsc.Name = "btnQSAsc";
      this.btnQSAsc.Size = new System.Drawing.Size(147, 28);
      this.btnQSAsc.TabIndex = 44;
      this.btnQSAsc.Text = "Ordenar ascendente";
      this.btnQSAsc.UseVisualStyleBackColor = true;
      this.btnQSAsc.Click += new System.EventHandler(this.btnQSAsc_Click);
      // 
      // frmQuickSort
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(663, 414);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnQSDes);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.txtResultado);
      this.Controls.Add(this.txtNum);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnQSAsc);
      this.Controls.Add(this.btnClose);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmQuickSort";
      this.Text = "frmQuickSort";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQSDes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQSAsc;
    }
}