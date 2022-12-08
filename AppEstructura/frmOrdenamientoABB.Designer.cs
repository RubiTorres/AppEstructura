namespace AppEstructura
{
  partial class frmOrdenamientoABB
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
      this.txtCantidad = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.btnIngresar = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.txtSinOrdenar = new System.Windows.Forms.TextBox();
      this.txtInorden = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.btnInvertidos = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtCantidad
      // 
      this.txtCantidad.Location = new System.Drawing.Point(21, 44);
      this.txtCantidad.Name = "txtCantidad";
      this.txtCantidad.Size = new System.Drawing.Size(139, 20);
      this.txtCantidad.TabIndex = 0;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(21, 19);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(145, 13);
      this.label4.TabIndex = 1;
      this.label4.Text = "Ingrese la cantidad de digitos";
      // 
      // btnIngresar
      // 
      this.btnIngresar.Location = new System.Drawing.Point(21, 76);
      this.btnIngresar.Name = "btnIngresar";
      this.btnIngresar.Size = new System.Drawing.Size(64, 45);
      this.btnIngresar.TabIndex = 2;
      this.btnIngresar.Text = "ingresar";
      this.btnIngresar.UseVisualStyleBackColor = true;
      this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(202, 19);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(61, 13);
      this.label5.TabIndex = 3;
      this.label5.Text = "Sin ordenar";
      // 
      // txtSinOrdenar
      // 
      this.txtSinOrdenar.Location = new System.Drawing.Point(202, 44);
      this.txtSinOrdenar.Name = "txtSinOrdenar";
      this.txtSinOrdenar.Size = new System.Drawing.Size(234, 20);
      this.txtSinOrdenar.TabIndex = 4;
      // 
      // txtInorden
      // 
      this.txtInorden.Location = new System.Drawing.Point(202, 101);
      this.txtInorden.Name = "txtInorden";
      this.txtInorden.Size = new System.Drawing.Size(234, 20);
      this.txtInorden.TabIndex = 6;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(202, 76);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(59, 13);
      this.label6.TabIndex = 5;
      this.label6.Text = "Ordenados";
      // 
      // btnInvertidos
      // 
      this.btnInvertidos.Location = new System.Drawing.Point(95, 76);
      this.btnInvertidos.Name = "btnInvertidos";
      this.btnInvertidos.Size = new System.Drawing.Size(64, 45);
      this.btnInvertidos.TabIndex = 7;
      this.btnInvertidos.Text = "invertidos";
      this.btnInvertidos.UseVisualStyleBackColor = true;
      this.btnInvertidos.Click += new System.EventHandler(this.btnInvertidos_Click);
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Red;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.Black;
      this.btnClose.Location = new System.Drawing.Point(418, 3);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(30, 29);
      this.btnClose.TabIndex = 17;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // frmOrdenamientoABB
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(453, 136);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnInvertidos);
      this.Controls.Add(this.txtInorden);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtSinOrdenar);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.btnIngresar);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtCantidad);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmOrdenamientoABB";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }
    #endregion
    private System.Windows.Forms.TextBox txtCantidad;
    private System.Windows.Forms.TextBox txtSinOrdenar;
    private System.Windows.Forms.TextBox txtInorden;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnIngresar;
    private System.Windows.Forms.Button btnInvertidos;
        private System.Windows.Forms.Button btnClose;
    }
}