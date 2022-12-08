namespace AppEstructura
{
  partial class frmMezclas
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
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnLimpiar = new System.Windows.Forms.Button();
      this.btnRDescendenteDirecta = new System.Windows.Forms.Button();
      this.btnRAscendenteDirecta = new System.Windows.Forms.Button();
      this.lblEstadisticaNombre = new System.Windows.Forms.Label();
      this.lvwOrdenado = new System.Windows.Forms.ListView();
      this.lblStadistica = new System.Windows.Forms.Label();
      this.lvwMostar = new System.Windows.Forms.ListView();
      this.label1 = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.btnRecAsc = new System.Windows.Forms.Button();
      this.txtElementos = new System.Windows.Forms.TextBox();
      this.btnCrear = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(280, 181);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(111, 18);
      this.label3.TabIndex = 45;
      this.label3.Text = "Mezcla Directa:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(94, 181);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(111, 18);
      this.label2.TabIndex = 44;
      this.label2.Text = "Mezcla Natural:";
      // 
      // btnLimpiar
      // 
      this.btnLimpiar.Location = new System.Drawing.Point(566, 139);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new System.Drawing.Size(104, 23);
      this.btnLimpiar.TabIndex = 43;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
      // 
      // btnRDescendenteDirecta
      // 
      this.btnRDescendenteDirecta.Location = new System.Drawing.Point(248, 231);
      this.btnRDescendenteDirecta.Name = "btnRDescendenteDirecta";
      this.btnRDescendenteDirecta.Size = new System.Drawing.Size(161, 23);
      this.btnRDescendenteDirecta.TabIndex = 42;
      this.btnRDescendenteDirecta.Text = "Recorrido Descendente";
      this.btnRDescendenteDirecta.UseVisualStyleBackColor = true;
      this.btnRDescendenteDirecta.Click += new System.EventHandler(this.btnRDescendenteDirecta_Click);
      // 
      // btnRAscendenteDirecta
      // 
      this.btnRAscendenteDirecta.Location = new System.Drawing.Point(248, 202);
      this.btnRAscendenteDirecta.Name = "btnRAscendenteDirecta";
      this.btnRAscendenteDirecta.Size = new System.Drawing.Size(161, 23);
      this.btnRAscendenteDirecta.TabIndex = 41;
      this.btnRAscendenteDirecta.Text = "Recorrido Ascendente";
      this.btnRAscendenteDirecta.UseVisualStyleBackColor = true;
      this.btnRAscendenteDirecta.Click += new System.EventHandler(this.btnRAscendenteDirecta_Click);
      // 
      // lblEstadisticaNombre
      // 
      this.lblEstadisticaNombre.AutoSize = true;
      this.lblEstadisticaNombre.Location = new System.Drawing.Point(481, 225);
      this.lblEstadisticaNombre.Name = "lblEstadisticaNombre";
      this.lblEstadisticaNombre.Size = new System.Drawing.Size(13, 13);
      this.lblEstadisticaNombre.TabIndex = 40;
      this.lblEstadisticaNombre.Text = "--";
      // 
      // lvwOrdenado
      // 
      this.lvwOrdenado.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lvwOrdenado.HideSelection = false;
      this.lvwOrdenado.Location = new System.Drawing.Point(62, 101);
      this.lvwOrdenado.Name = "lvwOrdenado";
      this.lvwOrdenado.Size = new System.Drawing.Size(608, 35);
      this.lvwOrdenado.TabIndex = 39;
      this.lvwOrdenado.UseCompatibleStateImageBehavior = false;
      // 
      // lblStadistica
      // 
      this.lblStadistica.AutoSize = true;
      this.lblStadistica.Font = new System.Drawing.Font("Playbill", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblStadistica.Location = new System.Drawing.Point(477, 185);
      this.lblStadistica.Name = "lblStadistica";
      this.lblStadistica.Size = new System.Drawing.Size(32, 40);
      this.lblStadistica.TabIndex = 38;
      this.lblStadistica.Text = "---";
      // 
      // lvwMostar
      // 
      this.lvwMostar.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lvwMostar.HideSelection = false;
      this.lvwMostar.Location = new System.Drawing.Point(62, 63);
      this.lvwMostar.Name = "lvwMostar";
      this.lvwMostar.Size = new System.Drawing.Size(608, 38);
      this.lvwMostar.TabIndex = 37;
      this.lvwMostar.UseCompatibleStateImageBehavior = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(62, 141);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(227, 18);
      this.label1.TabIndex = 35;
      this.label1.Text = "Numero de elementos del vector:";
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(65, 231);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(161, 23);
      this.button3.TabIndex = 34;
      this.button3.Text = "Recorrido Descendente";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // btnRecAsc
      // 
      this.btnRecAsc.Location = new System.Drawing.Point(65, 202);
      this.btnRecAsc.Name = "btnRecAsc";
      this.btnRecAsc.Size = new System.Drawing.Size(161, 23);
      this.btnRecAsc.TabIndex = 33;
      this.btnRecAsc.Text = "Recorrido Ascendente";
      this.btnRecAsc.UseVisualStyleBackColor = true;
      this.btnRecAsc.Click += new System.EventHandler(this.btnRecAsc_Click);
      // 
      // txtElementos
      // 
      this.txtElementos.Location = new System.Drawing.Point(295, 142);
      this.txtElementos.Name = "txtElementos";
      this.txtElementos.Size = new System.Drawing.Size(107, 20);
      this.txtElementos.TabIndex = 32;
      // 
      // btnCrear
      // 
      this.btnCrear.Location = new System.Drawing.Point(422, 139);
      this.btnCrear.Name = "btnCrear";
      this.btnCrear.Size = new System.Drawing.Size(126, 23);
      this.btnCrear.TabIndex = 31;
      this.btnCrear.Text = "Crear Vector";
      this.btnCrear.UseVisualStyleBackColor = true;
      this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Red;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.Black;
      this.btnClose.Location = new System.Drawing.Point(652, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(30, 29);
      this.btnClose.TabIndex = 46;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // frmMezclas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(694, 339);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnLimpiar);
      this.Controls.Add(this.btnRDescendenteDirecta);
      this.Controls.Add(this.btnRAscendenteDirecta);
      this.Controls.Add(this.lblEstadisticaNombre);
      this.Controls.Add(this.lvwOrdenado);
      this.Controls.Add(this.lblStadistica);
      this.Controls.Add(this.lvwMostar);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.btnRecAsc);
      this.Controls.Add(this.txtElementos);
      this.Controls.Add(this.btnCrear);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmMezclas";
      this.Text = "frmMezclas";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRDescendenteDirecta;
        private System.Windows.Forms.Button btnRAscendenteDirecta;
        private System.Windows.Forms.Label lblEstadisticaNombre;
        private System.Windows.Forms.ListView lvwOrdenado;
        private System.Windows.Forms.Label lblStadistica;
        private System.Windows.Forms.ListView lvwMostar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRecAsc;
        private System.Windows.Forms.TextBox txtElementos;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnClose;
    }
}