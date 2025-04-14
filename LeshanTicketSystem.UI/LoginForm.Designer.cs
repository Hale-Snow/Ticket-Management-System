namespace LeshanTicketSystem.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            text = new MaterialSkin3.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin3.Controls.MaterialLabel();
            boxid = new MaterialSkin3.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkin3.Controls.MaterialLabel();
            boxpasswd = new MaterialSkin3.Controls.MaterialTextBox2();
            materialLabel3 = new MaterialSkin3.Controls.MaterialLabel();
            login = new MaterialSkin3.Controls.MaterialButton();
            SuspendLayout();
            // 
            // text
            // 
            text.Anchor = AnchorStyles.Left;
            text.AutoSize = true;
            text.Depth = 0;
            text.Font = new Font("HarmonyOS Sans SC", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            text.FontType = MaterialSkin3.MaterialSkinManager.fontType.H4;
            text.Location = new Point(249, 108);
            text.MouseState = MaterialSkin3.MouseState.HOVER;
            text.Name = "text";
            text.Size = new Size(273, 45);
            text.TabIndex = 0;
            text.Text = "乐山票务管理系统";
            text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("HarmonyOS Sans SC", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin3.MaterialSkinManager.fontType.H5;
            materialLabel1.Location = new Point(317, 207);
            materialLabel1.MouseState = MaterialSkin3.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(121, 32);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "管理员登录";
            // 
            // boxid
            // 
            boxid.AnimateReadOnly = false;
            boxid.AutoCompleteMode = AutoCompleteMode.None;
            boxid.AutoCompleteSource = AutoCompleteSource.None;
            boxid.BackgroundImageLayout = ImageLayout.None;
            boxid.CharacterCasing = CharacterCasing.Normal;
            boxid.Depth = 0;
            boxid.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxid.HideSelection = true;
            boxid.LeadingIcon = null;
            boxid.Location = new Point(198, 361);
            boxid.MaxLength = 32767;
            boxid.MouseState = MaterialSkin3.MouseState.OUT;
            boxid.Name = "boxid";
            boxid.PasswordChar = '\0';
            boxid.PrefixSuffixText = null;
            boxid.ReadOnly = false;
            boxid.RightToLeft = RightToLeft.No;
            boxid.SelectedText = "";
            boxid.SelectionLength = 0;
            boxid.SelectionStart = 0;
            boxid.ShortcutsEnabled = true;
            boxid.Size = new Size(375, 48);
            boxid.TabIndex = 2;
            boxid.TabStop = false;
            boxid.TextAlign = HorizontalAlignment.Center;
            boxid.TrailingIcon = null;
            boxid.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("HarmonyOS Sans SC Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin3.MaterialSkinManager.fontType.H6;
            materialLabel2.Location = new Point(198, 469);
            materialLabel2.MouseState = MaterialSkin3.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(41, 26);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "密码";
            // 
            // boxpasswd
            // 
            boxpasswd.AnimateReadOnly = false;
            boxpasswd.AutoCompleteMode = AutoCompleteMode.None;
            boxpasswd.AutoCompleteSource = AutoCompleteSource.None;
            boxpasswd.BackgroundImageLayout = ImageLayout.None;
            boxpasswd.CharacterCasing = CharacterCasing.Normal;
            boxpasswd.Depth = 0;
            boxpasswd.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxpasswd.HideSelection = true;
            boxpasswd.LeadingIcon = null;
            boxpasswd.Location = new Point(198, 514);
            boxpasswd.MaxLength = 32767;
            boxpasswd.MouseState = MaterialSkin3.MouseState.OUT;
            boxpasswd.Name = "boxpasswd";
            boxpasswd.PasswordChar = '●';
            boxpasswd.PrefixSuffixText = null;
            boxpasswd.ReadOnly = false;
            boxpasswd.RightToLeft = RightToLeft.No;
            boxpasswd.SelectedText = "";
            boxpasswd.SelectionLength = 0;
            boxpasswd.SelectionStart = 0;
            boxpasswd.ShortcutsEnabled = true;
            boxpasswd.Size = new Size(375, 48);
            boxpasswd.TabIndex = 2;
            boxpasswd.TabStop = false;
            boxpasswd.TextAlign = HorizontalAlignment.Center;
            boxpasswd.TrailingIcon = null;
            boxpasswd.UseSystemPasswordChar = true;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("HarmonyOS Sans SC Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin3.MaterialSkinManager.fontType.H6;
            materialLabel3.Location = new Point(198, 311);
            materialLabel3.MouseState = MaterialSkin3.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(41, 26);
            materialLabel3.TabIndex = 3;
            materialLabel3.Text = "账号";
            // 
            // login
            // 
            login.AutoSize = false;
            login.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            login.Density = MaterialSkin3.Controls.MaterialButton.MaterialButtonDensity.Default;
            login.Depth = 0;
            login.DrawShadows = false;
            login.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Pixel);
            login.HighEmphasis = true;
            login.Icon = null;
            login.Location = new Point(317, 671);
            login.Margin = new Padding(4, 6, 4, 6);
            login.MouseState = MaterialSkin3.MouseState.HOVER;
            login.Name = "login";
            login.NoAccentTextColor = Color.Empty;
            login.Size = new Size(157, 49);
            login.TabIndex = 4;
            login.Text = "登录";
            login.Type = MaterialSkin3.Controls.MaterialButton.MaterialButtonType.Contained;
            login.UseAccentColor = false;
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 850);
            Controls.Add(login);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(boxpasswd);
            Controls.Add(boxid);
            Controls.Add(materialLabel1);
            Controls.Add(text);
            Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(800, 850);
            MinimumSize = new Size(800, 830);
            Name = "LoginForm";
            Text = "乐山票务管理系统";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin3.Controls.MaterialLabel text;
        private MaterialSkin3.Controls.MaterialLabel materialLabel1;
        private MaterialSkin3.Controls.MaterialTextBox2 boxid;
        private MaterialSkin3.Controls.MaterialLabel materialLabel2;
        private MaterialSkin3.Controls.MaterialTextBox2 boxpasswd;
        private MaterialSkin3.Controls.MaterialLabel materialLabel3;
        private MaterialSkin3.Controls.MaterialButton login;
    }
}