namespace Gestosoc
{
    partial class AccessToApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessToApp));
            this.ButtonAceptar = new System.Windows.Forms.Button();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabelNewUser = new System.Windows.Forms.LinkLabel();
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelUser = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAceptar
            // 
            this.ButtonAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAceptar.ForeColor = System.Drawing.Color.Black;
            this.ButtonAceptar.Location = new System.Drawing.Point(328, 249);
            this.ButtonAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAceptar.Name = "ButtonAceptar";
            this.ButtonAceptar.Size = new System.Drawing.Size(120, 39);
            this.ButtonAceptar.TabIndex = 6;
            this.ButtonAceptar.Text = "Aceptar";
            this.ButtonAceptar.UseVisualStyleBackColor = false;
            this.ButtonAceptar.Click += new System.EventHandler(this.ButtonAceptar_Click);
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancelar.ForeColor = System.Drawing.Color.White;
            this.ButtonCancelar.Location = new System.Drawing.Point(529, 249);
            this.ButtonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(120, 39);
            this.ButtonCancelar.TabIndex = 1;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = false;
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(21, 268);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(159, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Agregar Contraseña";
            // 
            // linkLabelNewUser
            // 
            this.linkLabelNewUser.AutoSize = true;
            this.linkLabelNewUser.Location = new System.Drawing.Point(21, 231);
            this.linkLabelNewUser.Name = "linkLabelNewUser";
            this.linkLabelNewUser.Size = new System.Drawing.Size(133, 20);
            this.linkLabelNewUser.TabIndex = 8;
            this.linkLabelNewUser.TabStop = true;
            this.linkLabelNewUser.Text = "Generar Usuario";
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.Location = new System.Drawing.Point(457, 111);
            this.TextBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.Size = new System.Drawing.Size(192, 26);
            this.TextBoxUser.TabIndex = 4;
            this.TextBoxUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUser_KeyPress);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(457, 188);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(192, 26);
            this.TextBoxPassword.TabIndex = 5;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            this.TextBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Location = new System.Drawing.Point(324, 111);
            this.LabelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(67, 20);
            this.LabelUser.TabIndex = 2;
            this.LabelUser.Text = "Usuario";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(324, 188);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(95, 20);
            this.LabelPassword.TabIndex = 3;
            this.LabelPassword.Text = "Contraseña";
            // 
            // AccessToApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 355);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.linkLabelNewUser);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.ButtonAceptar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccessToApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de Usuarios ";
            this.Activated += new System.EventHandler(this.AccessToApp_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccessToApp_FormClosing);
            this.Load += new System.EventHandler(this.AccessToApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAceptar;
        private System.Windows.Forms.Button ButtonCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabelNewUser;
        private System.Windows.Forms.TextBox TextBoxUser;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Label LabelPassword;
    }
}