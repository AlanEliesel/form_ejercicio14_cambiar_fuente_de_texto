namespace form_ejercicio14_cambiar_fuente_de_texto
{
    partial class Form1
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
            this.tbr_tamaño = new System.Windows.Forms.TrackBar();
            this.lbl_texto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_tamaño)).BeginInit();
            this.SuspendLayout();
            // 
            // tbr_tamaño
            // 
            this.tbr_tamaño.Location = new System.Drawing.Point(117, 286);
            this.tbr_tamaño.Maximum = 50;
            this.tbr_tamaño.Name = "tbr_tamaño";
            this.tbr_tamaño.Size = new System.Drawing.Size(559, 69);
            this.tbr_tamaño.TabIndex = 0;
            this.tbr_tamaño.Scroll += new System.EventHandler(this.tbr_tamaño_Scroll);
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.lbl_texto.Location = new System.Drawing.Point(188, 109);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(52, 20);
            this.lbl_texto.TabIndex = 1;
            this.lbl_texto.Text = "Texto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.tbr_tamaño);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbr_tamaño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbr_tamaño;
        private System.Windows.Forms.Label lbl_texto;
    }
}

