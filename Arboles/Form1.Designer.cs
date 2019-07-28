namespace Arboles
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRecorrido = new System.Windows.Forms.TextBox();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnEn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(99, 90);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar nodo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(99, 49);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 2;
            // 
            // txtRecorrido
            // 
            this.txtRecorrido.Location = new System.Drawing.Point(41, 152);
            this.txtRecorrido.Multiline = true;
            this.txtRecorrido.Name = "txtRecorrido";
            this.txtRecorrido.Size = new System.Drawing.Size(158, 108);
            this.txtRecorrido.TabIndex = 3;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(226, 152);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 4;
            this.btnPre.Text = "Pre";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(226, 197);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(75, 23);
            this.btnPos.TabIndex = 5;
            this.btnPos.Text = "Pos";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // btnEn
            // 
            this.btnEn.Location = new System.Drawing.Point(226, 237);
            this.btnEn.Name = "btnEn";
            this.btnEn.Size = new System.Drawing.Size(75, 23);
            this.btnEn.TabIndex = 6;
            this.btnEn.Text = "En";
            this.btnEn.UseVisualStyleBackColor = true;
            this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 281);
            this.Controls.Add(this.btnEn);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.txtRecorrido);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRecorrido;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnEn;
    }
}

