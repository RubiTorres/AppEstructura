namespace AppEstructura
{
  partial class frmBurbuja
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
      this.tbComparaciones = new System.Windows.Forms.Label();
      this.lblntercambios = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.lblPasadas = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.listBox3 = new System.Windows.Forms.ListBox();
      this.btnOrdenar2 = new System.Windows.Forms.Button();
      this.lblTiempoOrdenar = new System.Windows.Forms.Label();
      this.lblTiempoGenerar = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.btnOrdenar = new System.Windows.Forms.Button();
      this.btnGenerarDatos = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtn = new System.Windows.Forms.TextBox();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // tbComparaciones
      // 
      this.tbComparaciones.AutoSize = true;
      this.tbComparaciones.Location = new System.Drawing.Point(442, 353);
      this.tbComparaciones.Name = "tbComparaciones";
      this.tbComparaciones.Size = new System.Drawing.Size(13, 13);
      this.tbComparaciones.TabIndex = 40;
      this.tbComparaciones.Text = "0";
      // 
      // lblntercambios
      // 
      this.lblntercambios.AutoSize = true;
      this.lblntercambios.Location = new System.Drawing.Point(442, 307);
      this.lblntercambios.Name = "lblntercambios";
      this.lblntercambios.Size = new System.Drawing.Size(13, 13);
      this.lblntercambios.TabIndex = 39;
      this.lblntercambios.Text = "0";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(334, 353);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(83, 13);
      this.label7.TabIndex = 38;
      this.label7.Text = "Comparaciones:";
      // 
      // lblPasadas
      // 
      this.lblPasadas.AutoSize = true;
      this.lblPasadas.Location = new System.Drawing.Point(334, 307);
      this.lblPasadas.Name = "lblPasadas";
      this.lblPasadas.Size = new System.Drawing.Size(51, 13);
      this.lblPasadas.TabIndex = 37;
      this.lblPasadas.Text = "Pasadas:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(182, 356);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(22, 13);
      this.label5.TabIndex = 36;
      this.label5.Text = "0:0";
      // 
      // listBox3
      // 
      this.listBox3.FormattingEnabled = true;
      this.listBox3.Location = new System.Drawing.Point(470, 48);
      this.listBox3.Name = "listBox3";
      this.listBox3.Size = new System.Drawing.Size(111, 238);
      this.listBox3.TabIndex = 35;
      // 
      // btnOrdenar2
      // 
      this.btnOrdenar2.Location = new System.Drawing.Point(77, 177);
      this.btnOrdenar2.Name = "btnOrdenar2";
      this.btnOrdenar2.Size = new System.Drawing.Size(100, 27);
      this.btnOrdenar2.TabIndex = 34;
      this.btnOrdenar2.Text = "DESCENDENTE";
      this.btnOrdenar2.UseVisualStyleBackColor = true;
      this.btnOrdenar2.Click += new System.EventHandler(this.btnOrdenar2_Click);
      // 
      // lblTiempoOrdenar
      // 
      this.lblTiempoOrdenar.AutoSize = true;
      this.lblTiempoOrdenar.Location = new System.Drawing.Point(182, 322);
      this.lblTiempoOrdenar.Name = "lblTiempoOrdenar";
      this.lblTiempoOrdenar.Size = new System.Drawing.Size(22, 13);
      this.lblTiempoOrdenar.TabIndex = 33;
      this.lblTiempoOrdenar.Text = "0:0";
      // 
      // lblTiempoGenerar
      // 
      this.lblTiempoGenerar.AutoSize = true;
      this.lblTiempoGenerar.Location = new System.Drawing.Point(182, 276);
      this.lblTiempoGenerar.Name = "lblTiempoGenerar";
      this.lblTiempoGenerar.Size = new System.Drawing.Size(22, 13);
      this.lblTiempoGenerar.TabIndex = 32;
      this.lblTiempoGenerar.Text = "0:0";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(74, 322);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(48, 13);
      this.label4.TabIndex = 31;
      this.label4.Text = "Ordenar:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(74, 276);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(79, 13);
      this.label3.TabIndex = 30;
      this.label3.Text = "Generar Datos:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(74, 216);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(115, 13);
      this.label2.TabIndex = 29;
      this.label2.Text = "Tiempo de ejecuccion:";
      // 
      // listBox2
      // 
      this.listBox2.FormattingEnabled = true;
      this.listBox2.Location = new System.Drawing.Point(337, 48);
      this.listBox2.Name = "listBox2";
      this.listBox2.Size = new System.Drawing.Size(111, 238);
      this.listBox2.TabIndex = 28;
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(243, 48);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(88, 238);
      this.listBox1.TabIndex = 27;
      // 
      // btnOrdenar
      // 
      this.btnOrdenar.Location = new System.Drawing.Point(77, 144);
      this.btnOrdenar.Name = "btnOrdenar";
      this.btnOrdenar.Size = new System.Drawing.Size(100, 27);
      this.btnOrdenar.TabIndex = 26;
      this.btnOrdenar.Text = "ASCENDENTE\r\n";
      this.btnOrdenar.UseVisualStyleBackColor = true;
      this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
      // 
      // btnGenerarDatos
      // 
      this.btnGenerarDatos.Location = new System.Drawing.Point(77, 100);
      this.btnGenerarDatos.Name = "btnGenerarDatos";
      this.btnGenerarDatos.Size = new System.Drawing.Size(75, 23);
      this.btnGenerarDatos.TabIndex = 25;
      this.btnGenerarDatos.Text = "GENERAR\r\n";
      this.btnGenerarDatos.UseVisualStyleBackColor = true;
      this.btnGenerarDatos.Click += new System.EventHandler(this.btnGenerarDatos_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(53, 48);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(18, 13);
      this.label1.TabIndex = 24;
      this.label1.Text = "N:\r\n";
      // 
      // txtn
      // 
      this.txtn.Location = new System.Drawing.Point(77, 48);
      this.txtn.Name = "txtn";
      this.txtn.Size = new System.Drawing.Size(100, 20);
      this.txtn.TabIndex = 23;
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Red;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.Black;
      this.btnClose.Location = new System.Drawing.Point(562, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(30, 29);
      this.btnClose.TabIndex = 41;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // frmBurbuja
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(603, 398);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.tbComparaciones);
      this.Controls.Add(this.lblntercambios);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.lblPasadas);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.listBox3);
      this.Controls.Add(this.btnOrdenar2);
      this.Controls.Add(this.lblTiempoOrdenar);
      this.Controls.Add(this.lblTiempoGenerar);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.listBox2);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.btnOrdenar);
      this.Controls.Add(this.btnGenerarDatos);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtn);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmBurbuja";
      this.Text = "frmBurbuja";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label tbComparaciones;
        private System.Windows.Forms.Label lblntercambios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPasadas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnOrdenar2;
        private System.Windows.Forms.Label lblTiempoOrdenar;
        private System.Windows.Forms.Label lblTiempoGenerar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnGenerarDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Button btnClose;
    }
}