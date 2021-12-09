
namespace AppLoteria
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
            this.bntGane = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntGane
            // 
            this.bntGane.Cursor = System.Windows.Forms.Cursors.Default;
            this.bntGane.Location = new System.Drawing.Point(625, 298);
            this.bntGane.Margin = new System.Windows.Forms.Padding(2);
            this.bntGane.Name = "bntGane";
            this.bntGane.Size = new System.Drawing.Size(105, 45);
            this.bntGane.TabIndex = 0;
            this.bntGane.Text = "Victoria!!";
            this.bntGane.UseVisualStyleBackColor = true;
            this.bntGane.Click += new System.EventHandler(this.bntGane_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 609);
            this.Controls.Add(this.bntGane);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntGane;
    }
}

