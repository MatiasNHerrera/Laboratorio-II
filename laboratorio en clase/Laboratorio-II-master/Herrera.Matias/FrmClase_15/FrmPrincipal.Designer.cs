namespace FrmClase_15
{
  partial class FrmPrincipal
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lstVisor = new System.Windows.Forms.ListBox();
            this.btnTraer = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(64, 47);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(160, 20);
            this.txtValor.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(299, 47);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(127, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "&Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lstVisor
            // 
            this.lstVisor.FormattingEnabled = true;
            this.lstVisor.Location = new System.Drawing.Point(64, 100);
            this.lstVisor.Name = "lstVisor";
            this.lstVisor.Size = new System.Drawing.Size(362, 238);
            this.lstVisor.TabIndex = 2;
            // 
            // btnTraer
            // 
            this.btnTraer.Location = new System.Drawing.Point(64, 373);
            this.btnTraer.Name = "btnTraer";
            this.btnTraer.Size = new System.Drawing.Size(91, 27);
            this.btnTraer.TabIndex = 3;
            this.btnTraer.Text = "&Traer";
            this.btnTraer.UseVisualStyleBackColor = true;
            this.btnTraer.Click += new System.EventHandler(this.btnTraer_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(299, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "buscar";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnTraer);
            this.Controls.Add(this.lstVisor);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtValor);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtValor;
    private System.Windows.Forms.Button btnEnviar;
    private System.Windows.Forms.ListBox lstVisor;
    private System.Windows.Forms.Button btnTraer;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
  }
}

