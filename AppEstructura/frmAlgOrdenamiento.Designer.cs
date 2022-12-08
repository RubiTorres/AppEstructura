namespace AppEstructura
{
  partial class frmAlgOrdenamiento
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
      this.btnGrafos = new System.Windows.Forms.Button();
      this.btnQuickSort = new System.Windows.Forms.Button();
      this.btnSelection = new System.Windows.Forms.Button();
      this.btnInserción = new System.Windows.Forms.Button();
      this.btnBurbuja = new System.Windows.Forms.Button();
      this.btnABB = new System.Windows.Forms.Button();
      this.btnCuentas = new System.Windows.Forms.Button();
      this.btnShellSort = new System.Windows.Forms.Button();
      this.btnMezclaNatural = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnGrafos
      // 
      this.btnGrafos.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
      this.btnGrafos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGrafos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGrafos.ForeColor = System.Drawing.Color.White;
      this.btnGrafos.Location = new System.Drawing.Point(612, 37);
      this.btnGrafos.Name = "btnGrafos";
      this.btnGrafos.Size = new System.Drawing.Size(100, 75);
      this.btnGrafos.TabIndex = 20;
      this.btnGrafos.Text = "Radix";
      this.btnGrafos.UseVisualStyleBackColor = true;
      this.btnGrafos.Click += new System.EventHandler(this.btnGrafos_Click);
      // 
      // btnQuickSort
      // 
      this.btnQuickSort.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
      this.btnQuickSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnQuickSort.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnQuickSort.ForeColor = System.Drawing.Color.White;
      this.btnQuickSort.Location = new System.Drawing.Point(482, 37);
      this.btnQuickSort.Name = "btnQuickSort";
      this.btnQuickSort.Size = new System.Drawing.Size(100, 75);
      this.btnQuickSort.TabIndex = 19;
      this.btnQuickSort.Text = "Quick Sort";
      this.btnQuickSort.UseVisualStyleBackColor = true;
      this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
      // 
      // btnSelection
      // 
      this.btnSelection.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
      this.btnSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSelection.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSelection.ForeColor = System.Drawing.Color.White;
      this.btnSelection.Location = new System.Drawing.Point(352, 37);
      this.btnSelection.Name = "btnSelection";
      this.btnSelection.Size = new System.Drawing.Size(100, 75);
      this.btnSelection.TabIndex = 18;
      this.btnSelection.Text = "Selection";
      this.btnSelection.UseVisualStyleBackColor = true;
      this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
      // 
      // btnInserción
      // 
      this.btnInserción.BackColor = System.Drawing.Color.DarkSlateGray;
      this.btnInserción.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
      this.btnInserción.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnInserción.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInserción.ForeColor = System.Drawing.Color.White;
      this.btnInserción.Location = new System.Drawing.Point(222, 37);
      this.btnInserción.Name = "btnInserción";
      this.btnInserción.Size = new System.Drawing.Size(100, 75);
      this.btnInserción.TabIndex = 17;
      this.btnInserción.Text = "Insereción";
      this.btnInserción.UseVisualStyleBackColor = false;
      this.btnInserción.Click += new System.EventHandler(this.btnInserción_Click);
      // 
      // btnBurbuja
      // 
      this.btnBurbuja.BackColor = System.Drawing.Color.DarkSlateGray;
      this.btnBurbuja.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
      this.btnBurbuja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBurbuja.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBurbuja.ForeColor = System.Drawing.Color.White;
      this.btnBurbuja.Location = new System.Drawing.Point(89, 37);
      this.btnBurbuja.Name = "btnBurbuja";
      this.btnBurbuja.Size = new System.Drawing.Size(100, 75);
      this.btnBurbuja.TabIndex = 16;
      this.btnBurbuja.Text = "Burbuja";
      this.btnBurbuja.UseVisualStyleBackColor = false;
      this.btnBurbuja.Click += new System.EventHandler(this.btnBurbuja_Click);
      // 
      // btnABB
      // 
      this.btnABB.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
      this.btnABB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnABB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnABB.ForeColor = System.Drawing.Color.White;
      this.btnABB.Location = new System.Drawing.Point(482, 166);
      this.btnABB.Name = "btnABB";
      this.btnABB.Size = new System.Drawing.Size(100, 75);
      this.btnABB.TabIndex = 24;
      this.btnABB.Text = "Arbol Binario";
      this.btnABB.UseVisualStyleBackColor = true;
      this.btnABB.Click += new System.EventHandler(this.btnABB_Click);
      // 
      // btnCuentas
      // 
      this.btnCuentas.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
      this.btnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCuentas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCuentas.ForeColor = System.Drawing.Color.White;
      this.btnCuentas.Location = new System.Drawing.Point(612, 166);
      this.btnCuentas.Name = "btnCuentas";
      this.btnCuentas.Size = new System.Drawing.Size(100, 75);
      this.btnCuentas.TabIndex = 23;
      this.btnCuentas.Text = "Counting Sort";
      this.btnCuentas.UseVisualStyleBackColor = true;
      this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
      // 
      // btnShellSort
      // 
      this.btnShellSort.BackColor = System.Drawing.Color.DarkSlateGray;
      this.btnShellSort.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
      this.btnShellSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnShellSort.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnShellSort.ForeColor = System.Drawing.Color.White;
      this.btnShellSort.Location = new System.Drawing.Point(352, 166);
      this.btnShellSort.Name = "btnShellSort";
      this.btnShellSort.Size = new System.Drawing.Size(100, 75);
      this.btnShellSort.TabIndex = 22;
      this.btnShellSort.Text = "Shell Sort";
      this.btnShellSort.UseVisualStyleBackColor = false;
      // 
      // btnMezclaNatural
      // 
      this.btnMezclaNatural.BackColor = System.Drawing.Color.DarkSlateGray;
      this.btnMezclaNatural.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
      this.btnMezclaNatural.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMezclaNatural.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMezclaNatural.ForeColor = System.Drawing.Color.White;
      this.btnMezclaNatural.Location = new System.Drawing.Point(89, 166);
      this.btnMezclaNatural.Name = "btnMezclaNatural";
      this.btnMezclaNatural.Size = new System.Drawing.Size(233, 75);
      this.btnMezclaNatural.TabIndex = 26;
      this.btnMezclaNatural.Text = "Mezcla Natural-Directa";
      this.btnMezclaNatural.UseVisualStyleBackColor = false;
      this.btnMezclaNatural.Click += new System.EventHandler(this.btnMezclaNatural_Click);
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Red;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.Black;
      this.btnClose.Location = new System.Drawing.Point(746, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(30, 29);
      this.btnClose.TabIndex = 42;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // frmAlgOrdenamiento
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DarkSlateGray;
      this.ClientSize = new System.Drawing.Size(788, 434);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnMezclaNatural);
      this.Controls.Add(this.btnABB);
      this.Controls.Add(this.btnCuentas);
      this.Controls.Add(this.btnShellSort);
      this.Controls.Add(this.btnGrafos);
      this.Controls.Add(this.btnQuickSort);
      this.Controls.Add(this.btnSelection);
      this.Controls.Add(this.btnInserción);
      this.Controls.Add(this.btnBurbuja);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmAlgOrdenamiento";
      this.Text = "frmAlgOrdenamiento";
      this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.Button btnGrafos;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Button btnInserción;
        private System.Windows.Forms.Button btnBurbuja;
        private System.Windows.Forms.Button btnABB;
        private System.Windows.Forms.Button btnCuentas;
        private System.Windows.Forms.Button btnShellSort;
        private System.Windows.Forms.Button btnMezclaNatural;
    private System.Windows.Forms.Button btnClose;
  }
}