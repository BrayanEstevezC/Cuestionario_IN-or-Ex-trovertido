namespace cuestionario
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lbpre = new System.Windows.Forms.Label();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.btnSig = new System.Windows.Forms.Button();
            this.lbNP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIniciar.Font = new System.Drawing.Font("MS PGothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.DeepPink;
            this.btnIniciar.Location = new System.Drawing.Point(0, 0);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(501, 38);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Start";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lbpre
            // 
            this.lbpre.AutoSize = true;
            this.lbpre.BackColor = System.Drawing.Color.Transparent;
            this.lbpre.Font = new System.Drawing.Font("MS Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpre.ForeColor = System.Drawing.Color.Cyan;
            this.lbpre.Location = new System.Drawing.Point(8, 95);
            this.lbpre.Name = "lbpre";
            this.lbpre.Size = new System.Drawing.Size(53, 19);
            this.lbpre.TabIndex = 1;
            this.lbpre.Text = "labe";
            this.lbpre.Visible = false;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonA.ForeColor = System.Drawing.Color.GhostWhite;
            this.radioButtonA.Location = new System.Drawing.Point(16, 269);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(119, 24);
            this.radioButtonA.TabIndex = 2;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "radioButton1";
            this.radioButtonA.UseVisualStyleBackColor = false;
            this.radioButtonA.Visible = false;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonB.ForeColor = System.Drawing.Color.Magenta;
            this.radioButtonB.Location = new System.Drawing.Point(16, 341);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(119, 24);
            this.radioButtonB.TabIndex = 3;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "radioButton2";
            this.radioButtonB.UseVisualStyleBackColor = false;
            this.radioButtonB.Visible = false;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonC.ForeColor = System.Drawing.Color.Magenta;
            this.radioButtonC.Location = new System.Drawing.Point(16, 396);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(119, 24);
            this.radioButtonC.TabIndex = 4;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "radioButton3";
            this.radioButtonC.UseVisualStyleBackColor = false;
            this.radioButtonC.Visible = false;
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonD.ForeColor = System.Drawing.Color.Fuchsia;
            this.radioButtonD.Location = new System.Drawing.Point(16, 448);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(119, 24);
            this.radioButtonD.TabIndex = 5;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "radioButton4";
            this.radioButtonD.UseVisualStyleBackColor = false;
            this.radioButtonD.Visible = false;
            // 
            // btnSig
            // 
            this.btnSig.BackColor = System.Drawing.Color.Transparent;
            this.btnSig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSig.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSig.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnSig.Location = new System.Drawing.Point(0, 501);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(501, 40);
            this.btnSig.TabIndex = 6;
            this.btnSig.Text = "Siguiente";
            this.btnSig.UseVisualStyleBackColor = false;
            this.btnSig.Visible = false;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // lbNP
            // 
            this.lbNP.AutoSize = true;
            this.lbNP.Location = new System.Drawing.Point(413, 45);
            this.lbNP.Name = "lbNP";
            this.lbNP.Size = new System.Drawing.Size(0, 13);
            this.lbNP.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cuestionario.Properties.Resources.HD_wallpaper_dark_background_black_background_brain_psychological_chemistry_biology_anatomy_chemical_structures_molecular_models_ipad_minimalism_blurred;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 541);
            this.Controls.Add(this.lbNP);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.lbpre);
            this.Controls.Add(this.btnIniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lbpre;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.Label lbNP;
    }
}

