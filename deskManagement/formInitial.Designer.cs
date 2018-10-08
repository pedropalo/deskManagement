namespace deskManagement
{
    partial class formInitial
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
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTeste = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblJson = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Location = new System.Drawing.Point(873, 18);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(32, 35);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Location = new System.Drawing.Point(833, 18);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 35);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panelLateral
            // 
            this.panelLateral.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelLateral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLateral.Controls.Add(this.lblUsuario);
            this.panelLateral.Controls.Add(this.lblTeste);
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(4);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(120, 493);
            this.panelLateral.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsuario.Location = new System.Drawing.Point(28, 130);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 19);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            this.lblUsuario.MouseEnter += new System.EventHandler(this.lblUsuario_MouseEnter);
            this.lblUsuario.MouseLeave += new System.EventHandler(this.lblUsuario_MouseLeave);
            // 
            // lblTeste
            // 
            this.lblTeste.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTeste.AutoSize = true;
            this.lblTeste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTeste.Location = new System.Drawing.Point(8, 427);
            this.lblTeste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(101, 19);
            this.lblTeste.TabIndex = 0;
            this.lblTeste.Text = "Configurações";
            this.lblTeste.Click += new System.EventHandler(this.lblTeste_Click);
            this.lblTeste.MouseEnter += new System.EventHandler(this.lblTeste_MouseEnter);
            this.lblTeste.MouseLeave += new System.EventHandler(this.lblTeste_MouseLeave);
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.Location = new System.Drawing.Point(120, 60);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(801, 436);
            this.panelContent.TabIndex = 3;
            // 
            // lblJson
            // 
            this.lblJson.AutoSize = true;
            this.lblJson.Location = new System.Drawing.Point(439, 18);
            this.lblJson.Name = "lblJson";
            this.lblJson.Size = new System.Drawing.Size(101, 19);
            this.lblJson.TabIndex = 4;
            this.lblJson.Text = "consultar Json";
            this.lblJson.Click += new System.EventHandler(this.lblJson_Click);
            // 
            // formInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 495);
            this.Controls.Add(this.lblJson);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnFechar);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formInitial";
            this.Text = "formInitial";
            this.Load += new System.EventHandler(this.formInitial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Label lblTeste;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblJson;
        private System.Windows.Forms.Label lblUsuario;
    }
}