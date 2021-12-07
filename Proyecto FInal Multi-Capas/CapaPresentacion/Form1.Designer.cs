
namespace CapaPresentacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbCerrar = new System.Windows.Forms.PictureBox();
            this.pcbConductor = new System.Windows.Forms.PictureBox();
            this.pcbAutobus = new System.Windows.Forms.PictureBox();
            this.pcbRutas = new System.Windows.Forms.PictureBox();
            this.pcbViajes = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbConductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAutobus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(694, 269);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 0;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pcbCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 38);
            this.panel1.TabIndex = 1;
            // 
            // pcbCerrar
            // 
            this.pcbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pcbCerrar.Image")));
            this.pcbCerrar.Location = new System.Drawing.Point(441, 0);
            this.pcbCerrar.Name = "pcbCerrar";
            this.pcbCerrar.Size = new System.Drawing.Size(78, 38);
            this.pcbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCerrar.TabIndex = 0;
            this.pcbCerrar.TabStop = false;
            // 
            // pcbConductor
            // 
            this.pcbConductor.Image = ((System.Drawing.Image)(resources.GetObject("pcbConductor.Image")));
            this.pcbConductor.Location = new System.Drawing.Point(135, 105);
            this.pcbConductor.Name = "pcbConductor";
            this.pcbConductor.Size = new System.Drawing.Size(103, 84);
            this.pcbConductor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbConductor.TabIndex = 2;
            this.pcbConductor.TabStop = false;
            // 
            // pcbAutobus
            // 
            this.pcbAutobus.Image = ((System.Drawing.Image)(resources.GetObject("pcbAutobus.Image")));
            this.pcbAutobus.Location = new System.Drawing.Point(268, 105);
            this.pcbAutobus.Name = "pcbAutobus";
            this.pcbAutobus.Size = new System.Drawing.Size(100, 84);
            this.pcbAutobus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAutobus.TabIndex = 3;
            this.pcbAutobus.TabStop = false;
            // 
            // pcbRutas
            // 
            this.pcbRutas.Image = ((System.Drawing.Image)(resources.GetObject("pcbRutas.Image")));
            this.pcbRutas.Location = new System.Drawing.Point(135, 209);
            this.pcbRutas.Name = "pcbRutas";
            this.pcbRutas.Size = new System.Drawing.Size(103, 93);
            this.pcbRutas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbRutas.TabIndex = 4;
            this.pcbRutas.TabStop = false;
            this.pcbRutas.Click += new System.EventHandler(this.pcbRutas_Click);
            // 
            // pcbViajes
            // 
            this.pcbViajes.Image = ((System.Drawing.Image)(resources.GetObject("pcbViajes.Image")));
            this.pcbViajes.Location = new System.Drawing.Point(268, 209);
            this.pcbViajes.Name = "pcbViajes";
            this.pcbViajes.Size = new System.Drawing.Size(100, 93);
            this.pcbViajes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbViajes.TabIndex = 5;
            this.pcbViajes.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 350);
            this.Controls.Add(this.pcbViajes);
            this.Controls.Add(this.pcbRutas);
            this.Controls.Add(this.pcbAutobus);
            this.Controls.Add(this.pcbConductor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.doubleBitmapControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbConductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAutobus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbViajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbCerrar;
        private System.Windows.Forms.PictureBox pcbConductor;
        private System.Windows.Forms.PictureBox pcbAutobus;
        private System.Windows.Forms.PictureBox pcbRutas;
        private System.Windows.Forms.PictureBox pcbViajes;
    }
}

