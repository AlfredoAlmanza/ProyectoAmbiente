namespace Ambiente
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
            this.TXT_User = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TXT_Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.CHB_Remember = new MaterialSkin.Controls.MaterialCheckBox();
            this.BTN_Login = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LBL_LP = new MaterialSkin.Controls.MaterialLabel();
            this.LBL_Register = new MaterialSkin.Controls.MaterialLabel();
            this.PNL_Incorrecto = new System.Windows.Forms.Panel();
            this.LBL_Error = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PNL_Incorrecto.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXT_User
            // 
            this.TXT_User.Depth = 0;
            this.TXT_User.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_User.Hint = "Username";
            this.TXT_User.Location = new System.Drawing.Point(29, 115);
            this.TXT_User.MouseState = MaterialSkin.MouseState.HOVER;
            this.TXT_User.Name = "TXT_User";
            this.TXT_User.PasswordChar = '\0';
            this.TXT_User.SelectedText = "";
            this.TXT_User.SelectionLength = 0;
            this.TXT_User.SelectionStart = 0;
            this.TXT_User.Size = new System.Drawing.Size(495, 28);
            this.TXT_User.TabIndex = 0;
            this.TXT_User.UseSystemPasswordChar = false;
            // 
            // TXT_Password
            // 
            this.TXT_Password.Depth = 0;
            this.TXT_Password.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Password.Hint = "Password";
            this.TXT_Password.Location = new System.Drawing.Point(29, 187);
            this.TXT_Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.TXT_Password.Name = "TXT_Password";
            this.TXT_Password.PasswordChar = '\0';
            this.TXT_Password.SelectedText = "";
            this.TXT_Password.SelectionLength = 0;
            this.TXT_Password.SelectionStart = 0;
            this.TXT_Password.Size = new System.Drawing.Size(495, 28);
            this.TXT_Password.TabIndex = 1;
            this.TXT_Password.UseSystemPasswordChar = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(15, 328);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(384, 1);
            this.materialDivider1.TabIndex = 2;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // CHB_Remember
            // 
            this.CHB_Remember.AutoSize = true;
            this.CHB_Remember.Depth = 0;
            this.CHB_Remember.Font = new System.Drawing.Font("Roboto", 10F);
            this.CHB_Remember.Location = new System.Drawing.Point(28, 253);
            this.CHB_Remember.Margin = new System.Windows.Forms.Padding(0);
            this.CHB_Remember.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CHB_Remember.MouseState = MaterialSkin.MouseState.HOVER;
            this.CHB_Remember.Name = "CHB_Remember";
            this.CHB_Remember.Ripple = true;
            this.CHB_Remember.Size = new System.Drawing.Size(143, 30);
            this.CHB_Remember.TabIndex = 4;
            this.CHB_Remember.Text = "Remember me";
            this.CHB_Remember.UseVisualStyleBackColor = true;
            // 
            // BTN_Login
            // 
            this.BTN_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Login.Depth = 0;
            this.BTN_Login.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Login.Location = new System.Drawing.Point(275, 247);
            this.BTN_Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Primary = true;
            this.BTN_Login.Size = new System.Drawing.Size(130, 42);
            this.BTN_Login.TabIndex = 5;
            this.BTN_Login.Text = "LOGIN";
            this.BTN_Login.UseVisualStyleBackColor = true;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // LBL_LP
            // 
            this.LBL_LP.AutoSize = true;
            this.LBL_LP.Depth = 0;
            this.LBL_LP.Font = new System.Drawing.Font("Roboto", 11F);
            this.LBL_LP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBL_LP.Location = new System.Drawing.Point(12, 350);
            this.LBL_LP.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBL_LP.Name = "LBL_LP";
            this.LBL_LP.Size = new System.Drawing.Size(185, 24);
            this.LBL_LP.TabIndex = 6;
            this.LBL_LP.Text = "Lost your password?";
            // 
            // LBL_Register
            // 
            this.LBL_Register.AutoSize = true;
            this.LBL_Register.Depth = 0;
            this.LBL_Register.Font = new System.Drawing.Font("Roboto", 11F);
            this.LBL_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBL_Register.Location = new System.Drawing.Point(321, 350);
            this.LBL_Register.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBL_Register.Name = "LBL_Register";
            this.LBL_Register.Size = new System.Drawing.Size(80, 24);
            this.LBL_Register.TabIndex = 7;
            this.LBL_Register.Text = "Register";
            // 
            // PNL_Incorrecto
            // 
            this.PNL_Incorrecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.PNL_Incorrecto.Controls.Add(this.LBL_Error);
            this.PNL_Incorrecto.Location = new System.Drawing.Point(-1, 158);
            this.PNL_Incorrecto.Name = "PNL_Incorrecto";
            this.PNL_Incorrecto.Size = new System.Drawing.Size(434, 76);
            this.PNL_Incorrecto.TabIndex = 8;
            this.PNL_Incorrecto.Visible = false;
            // 
            // LBL_Error
            // 
            this.LBL_Error.AutoSize = true;
            this.LBL_Error.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Error.ForeColor = System.Drawing.Color.White;
            this.LBL_Error.Location = new System.Drawing.Point(41, 29);
            this.LBL_Error.Name = "LBL_Error";
            this.LBL_Error.Size = new System.Drawing.Size(359, 24);
            this.LBL_Error.TabIndex = 0;
            this.LBL_Error.Text = "USUARIO/CONTRASEÑA INCORRECTO";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 392);
            this.Controls.Add(this.PNL_Incorrecto);
            this.Controls.Add(this.LBL_Register);
            this.Controls.Add(this.LBL_LP);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.CHB_Remember);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.TXT_Password);
            this.Controls.Add(this.TXT_User);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PNL_Incorrecto.ResumeLayout(false);
            this.PNL_Incorrecto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField TXT_User;
        private MaterialSkin.Controls.MaterialSingleLineTextField TXT_Password;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialCheckBox CHB_Remember;
        private MaterialSkin.Controls.MaterialRaisedButton BTN_Login;
        private MaterialSkin.Controls.MaterialLabel LBL_LP;
        private MaterialSkin.Controls.MaterialLabel LBL_Register;
        private System.Windows.Forms.Panel PNL_Incorrecto;
        private System.Windows.Forms.Label LBL_Error;
        private System.Windows.Forms.Timer timer1;
    }
}

