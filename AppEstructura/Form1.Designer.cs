namespace AppEstructura
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnEDD = new System.Windows.Forms.Button();
      this.btnAlgoritmos = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnEDD
      // 
      this.btnEDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEDD.Location = new System.Drawing.Point(92, 85);
      this.btnEDD.Name = "btnEDD";
      this.btnEDD.Size = new System.Drawing.Size(400, 40);
      this.btnEDD.TabIndex = 0;
      this.btnEDD.Text = "Estructuras de datos";
      this.btnEDD.UseVisualStyleBackColor = true;
      this.btnEDD.Click += new System.EventHandler(this.btnEDD_Click);
      // 
      // btnAlgoritmos
      // 
      this.btnAlgoritmos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAlgoritmos.Location = new System.Drawing.Point(92, 176);
      this.btnAlgoritmos.Name = "btnAlgoritmos";
      this.btnAlgoritmos.Size = new System.Drawing.Size(400, 40);
      this.btnAlgoritmos.TabIndex = 1;
      this.btnAlgoritmos.Text = "Algoritmos";
      this.btnAlgoritmos.UseVisualStyleBackColor = true;
      this.btnAlgoritmos.Click += new System.EventHandler(this.btnAlgoritmos_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(585, 332);
      this.Controls.Add(this.btnAlgoritmos);
      this.Controls.Add(this.btnEDD);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button btnEDD;
        private System.Windows.Forms.Button btnAlgoritmos;
    }
}

