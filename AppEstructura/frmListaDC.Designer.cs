namespace AppEstructura
{
  partial class frmListaDC
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
      this.txtdato = new System.Windows.Forms.TextBox();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.btnInsertar = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Red;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.Black;
      this.btnClose.Location = new System.Drawing.Point(528, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(30, 29);
      this.btnClose.TabIndex = 17;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      // 
      // txtdato
      // 
      this.txtdato.Location = new System.Drawing.Point(176, 97);
      this.txtdato.Margin = new System.Windows.Forms.Padding(2);
      this.txtdato.Name = "txtdato";
      this.txtdato.Size = new System.Drawing.Size(213, 20);
      this.txtdato.TabIndex = 21;
      // 
      // btnBuscar
      // 
      this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBuscar.Location = new System.Drawing.Point(363, 162);
      this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(98, 46);
      this.btnBuscar.TabIndex = 20;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // btnEliminar
      // 
      this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEliminar.Location = new System.Drawing.Point(226, 162);
      this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(98, 46);
      this.btnEliminar.TabIndex = 19;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
      // 
      // btnInsertar
      // 
      this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInsertar.Location = new System.Drawing.Point(92, 162);
      this.btnInsertar.Margin = new System.Windows.Forms.Padding(2);
      this.btnInsertar.Name = "btnInsertar";
      this.btnInsertar.Size = new System.Drawing.Size(98, 46);
      this.btnInsertar.TabIndex = 18;
      this.btnInsertar.Text = "Insertar ";
      this.btnInsertar.UseVisualStyleBackColor = true;
      this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(115, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(358, 24);
      this.label1.TabIndex = 25;
      this.label1.Text = "Listas doblemente circulares";
      // 
      // frmListaDC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(570, 375);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtdato);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.btnEliminar);
      this.Controls.Add(this.btnInsertar);
      this.Controls.Add(this.btnClose);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmListaDC";
      this.Text = "frmListaDC";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtdato;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label1;
    }
}