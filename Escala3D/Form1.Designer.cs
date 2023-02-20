namespace Escala3D
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
            this.components = new System.ComponentModel.Container();
            this.ptbox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbox)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbox
            // 
            this.ptbox.BackColor = System.Drawing.Color.Black;
            this.ptbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbox.Location = new System.Drawing.Point(0, 0);
            this.ptbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbox.Name = "ptbox";
            this.ptbox.Size = new System.Drawing.Size(1200, 692);
            this.ptbox.TabIndex = 0;
            this.ptbox.TabStop = false;
            this.ptbox.Click += new System.EventHandler(this.ptbox_Click);
            this.ptbox.Paint += new System.Windows.Forms.PaintEventHandler(this.ptbox_Paint);
            this.ptbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbox_MouseDown);
            this.ptbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbox_MouseMove);
            this.ptbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbox_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.ptbox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbox;
        private System.Windows.Forms.Timer timer1;
    }
}

