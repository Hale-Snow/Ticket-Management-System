namespace LeshanTicketSystem.UI
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            materialTabControl1 = new MaterialSkin3.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            SeachEnter = new MaterialSkin3.Controls.MaterialButton();
            ticketSearchBox = new MaterialSkin3.Controls.MaterialTextBox2();
            insert = new MaterialSkin3.Controls.MaterialButton();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            order_id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            sex = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            id_card = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            update = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            TouristPage = new TabPage();
            touristcombo = new MaterialSkin3.Controls.MaterialComboBox();
            touristEnter = new MaterialSkin3.Controls.MaterialButton();
            SeachTourist = new MaterialSkin3.Controls.MaterialTextBox2();
            touristGridView = new DataGridView();
            t_id = new DataGridViewTextBoxColumn();
            t_name = new DataGridViewTextBoxColumn();
            t_sex = new DataGridViewTextBoxColumn();
            t_phone = new DataGridViewTextBoxColumn();
            t_idcard = new DataGridViewTextBoxColumn();
            t_status = new DataGridViewTextBoxColumn();
            block = new DataGridViewButtonColumn();
            t_delete = new DataGridViewButtonColumn();
            ChartPage = new TabPage();
            formsPlotTickets = new ScottPlot.WinForms.FormsPlot();
            tabPage4 = new TabPage();
            formsPlotRevenue = new ScottPlot.WinForms.FormsPlot();
            adminManage = new TabPage();
            deletePass = new MaterialSkin3.Controls.MaterialButton();
            enterPass = new MaterialSkin3.Controls.MaterialButton();
            newPassword = new MaterialSkin3.Controls.MaterialTextBox2();
            Originalpassword = new MaterialSkin3.Controls.MaterialTextBox2();
            materialLabel3 = new MaterialSkin3.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin3.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin3.Controls.MaterialLabel();
            adminList = new MaterialSkin3.Controls.MaterialComboBox();
            other = new TabPage();
            exit = new MaterialSkin3.Controls.MaterialButton();
            loginout = new MaterialSkin3.Controls.MaterialButton();
            restart = new MaterialSkin3.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            TouristPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)touristGridView).BeginInit();
            ChartPage.SuspendLayout();
            tabPage4.SuspendLayout();
            adminManage.SuspendLayout();
            other.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(TouristPage);
            materialTabControl1.Controls.Add(ChartPage);
            materialTabControl1.Controls.Add(tabPage4);
            materialTabControl1.Controls.Add(adminManage);
            materialTabControl1.Controls.Add(other);
            materialTabControl1.Depth = 0;
            materialTabControl1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(6, 67);
            materialTabControl1.MouseState = MaterialSkin3.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1300, 727);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(SeachEnter);
            tabPage1.Controls.Add(ticketSearchBox);
            tabPage1.Controls.Add(insert);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.ImageKey = "订单.png";
            tabPage1.Location = new Point(4, 42);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1292, 681);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "订票管理";
            // 
            // SeachEnter
            // 
            SeachEnter.AutoSize = false;
            SeachEnter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SeachEnter.Density = MaterialSkin3.Controls.MaterialButton.MaterialButtonDensity.Default;
            SeachEnter.Depth = 0;
            SeachEnter.HighEmphasis = true;
            SeachEnter.Icon = null;
            SeachEnter.Location = new Point(890, 27);
            SeachEnter.Margin = new Padding(4, 6, 4, 6);
            SeachEnter.MouseState = MaterialSkin3.MouseState.HOVER;
            SeachEnter.Name = "SeachEnter";
            SeachEnter.NoAccentTextColor = Color.Empty;
            SeachEnter.Size = new Size(119, 34);
            SeachEnter.TabIndex = 3;
            SeachEnter.Text = "搜索";
            SeachEnter.Type = MaterialSkin3.Controls.MaterialButton.MaterialButtonType.Contained;
            SeachEnter.UseAccentColor = false;
            SeachEnter.UseVisualStyleBackColor = true;
            SeachEnter.Click += SeachEnter_Click;
            // 
            // ticketSearchBox
            // 
            ticketSearchBox.AnimateReadOnly = false;
            ticketSearchBox.AutoCompleteMode = AutoCompleteMode.None;
            ticketSearchBox.AutoCompleteSource = AutoCompleteSource.None;
            ticketSearchBox.BackgroundImageLayout = ImageLayout.None;
            ticketSearchBox.CharacterCasing = CharacterCasing.Normal;
            ticketSearchBox.Depth = 0;
            ticketSearchBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ticketSearchBox.HideSelection = true;
            ticketSearchBox.Hint = "姓名 电话  编号 身份证 进行查询";
            ticketSearchBox.LeadingIcon = null;
            ticketSearchBox.Location = new Point(359, 24);
            ticketSearchBox.MaxLength = 32767;
            ticketSearchBox.MouseState = MaterialSkin3.MouseState.OUT;
            ticketSearchBox.Name = "ticketSearchBox";
            ticketSearchBox.PasswordChar = '\0';
            ticketSearchBox.PrefixSuffixText = null;
            ticketSearchBox.ReadOnly = false;
            ticketSearchBox.RightToLeft = RightToLeft.No;
            ticketSearchBox.SelectedText = "";
            ticketSearchBox.SelectionLength = 0;
            ticketSearchBox.SelectionStart = 0;
            ticketSearchBox.ShortcutsEnabled = true;
            ticketSearchBox.Size = new Size(513, 48);
            ticketSearchBox.TabIndex = 2;
            ticketSearchBox.TabStop = false;
            ticketSearchBox.TextAlign = HorizontalAlignment.Center;
            ticketSearchBox.TrailingIcon = null;
            ticketSearchBox.UseSystemPasswordChar = false;
            ticketSearchBox.TextChanged += ticketSearchBox_TextChanged_1;
            // 
            // insert
            // 
            insert.AutoSize = false;
            insert.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            insert.Density = MaterialSkin3.Controls.MaterialButton.MaterialButtonDensity.Default;
            insert.Depth = 0;
            insert.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            insert.HighEmphasis = true;
            insert.Icon = null;
            insert.Location = new Point(1144, 27);
            insert.Margin = new Padding(4, 6, 4, 6);
            insert.MouseState = MaterialSkin3.MouseState.HOVER;
            insert.Name = "insert";
            insert.NoAccentTextColor = Color.Empty;
            insert.Size = new Size(109, 36);
            insert.TabIndex = 1;
            insert.Text = "插入";
            insert.Type = MaterialSkin3.Controls.MaterialButton.MaterialButtonType.Contained;
            insert.UseAccentColor = false;
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, order_id, name, sex, phone, id_card, price, update, delete });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.Location = new Point(-9, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1308, 588);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            id.DefaultCellStyle = dataGridViewCellStyle1;
            id.HeaderText = "序号";
            id.MinimumWidth = 8;
            id.Name = "id";
            // 
            // order_id
            // 
            order_id.DataPropertyName = "order_id";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            order_id.DefaultCellStyle = dataGridViewCellStyle2;
            order_id.HeaderText = "编号";
            order_id.MinimumWidth = 8;
            order_id.Name = "order_id";
            // 
            // name
            // 
            name.DataPropertyName = "name";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            name.DefaultCellStyle = dataGridViewCellStyle3;
            name.HeaderText = "名字";
            name.MinimumWidth = 8;
            name.Name = "name";
            // 
            // sex
            // 
            sex.DataPropertyName = "sex";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sex.DefaultCellStyle = dataGridViewCellStyle4;
            sex.HeaderText = "性别";
            sex.MinimumWidth = 8;
            sex.Name = "sex";
            // 
            // phone
            // 
            phone.DataPropertyName = "phone";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            phone.DefaultCellStyle = dataGridViewCellStyle5;
            phone.HeaderText = "电话";
            phone.MinimumWidth = 8;
            phone.Name = "phone";
            // 
            // id_card
            // 
            id_card.DataPropertyName = "id_card";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            id_card.DefaultCellStyle = dataGridViewCellStyle6;
            id_card.HeaderText = "身份证";
            id_card.MinimumWidth = 8;
            id_card.Name = "id_card";
            // 
            // price
            // 
            price.DataPropertyName = "price";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            price.DefaultCellStyle = dataGridViewCellStyle7;
            price.HeaderText = "价格";
            price.MinimumWidth = 8;
            price.Name = "price";
            // 
            // update
            // 
            update.HeaderText = "修改";
            update.MinimumWidth = 8;
            update.Name = "update";
            update.Text = "修改";
            update.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            delete.HeaderText = "删除";
            delete.MinimumWidth = 8;
            delete.Name = "delete";
            delete.Text = "删除";
            delete.UseColumnTextForButtonValue = true;
            // 
            // TouristPage
            // 
            TouristPage.BackColor = Color.White;
            TouristPage.Controls.Add(touristcombo);
            TouristPage.Controls.Add(touristEnter);
            TouristPage.Controls.Add(SeachTourist);
            TouristPage.Controls.Add(touristGridView);
            TouristPage.ImageKey = "人.png";
            TouristPage.Location = new Point(4, 42);
            TouristPage.Name = "TouristPage";
            TouristPage.Padding = new Padding(3);
            TouristPage.Size = new Size(1292, 681);
            TouristPage.TabIndex = 1;
            TouristPage.Text = "游客管理";
            // 
            // touristcombo
            // 
            touristcombo.AutoResize = false;
            touristcombo.BackColor = Color.FromArgb(255, 255, 255);
            touristcombo.Depth = 0;
            touristcombo.DrawMode = DrawMode.OwnerDrawVariable;
            touristcombo.DropDownHeight = 174;
            touristcombo.DropDownStyle = ComboBoxStyle.DropDownList;
            touristcombo.DropDownWidth = 121;
            touristcombo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            touristcombo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            touristcombo.FormattingEnabled = true;
            touristcombo.IntegralHeight = false;
            touristcombo.ItemHeight = 43;
            touristcombo.Items.AddRange(new object[] { "正常", "拉黑", "恢复" });
            touristcombo.Location = new Point(164, 22);
            touristcombo.MaxDropDownItems = 4;
            touristcombo.MouseState = MaterialSkin3.MouseState.OUT;
            touristcombo.Name = "touristcombo";
            touristcombo.Size = new Size(250, 49);
            touristcombo.StartIndex = 2;
            touristcombo.TabIndex = 3;
            touristcombo.SelectedIndexChanged += touristcombo_SelectedIndexChanged;
            // 
            // touristEnter
            // 
            touristEnter.AutoSize = false;
            touristEnter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            touristEnter.Density = MaterialSkin3.Controls.MaterialButton.MaterialButtonDensity.Default;
            touristEnter.Depth = 0;
            touristEnter.HighEmphasis = true;
            touristEnter.Icon = null;
            touristEnter.Location = new Point(1035, 23);
            touristEnter.Margin = new Padding(4, 6, 4, 6);
            touristEnter.MouseState = MaterialSkin3.MouseState.HOVER;
            touristEnter.Name = "touristEnter";
            touristEnter.NoAccentTextColor = Color.Empty;
            touristEnter.Size = new Size(170, 42);
            touristEnter.TabIndex = 2;
            touristEnter.Text = "查询";
            touristEnter.Type = MaterialSkin3.Controls.MaterialButton.MaterialButtonType.Contained;
            touristEnter.UseAccentColor = false;
            touristEnter.UseVisualStyleBackColor = true;
            touristEnter.Click += touristEnter_Click;
            // 
            // SeachTourist
            // 
            SeachTourist.AnimateReadOnly = false;
            SeachTourist.AutoCompleteMode = AutoCompleteMode.None;
            SeachTourist.AutoCompleteSource = AutoCompleteSource.None;
            SeachTourist.BackgroundImageLayout = ImageLayout.None;
            SeachTourist.CharacterCasing = CharacterCasing.Normal;
            SeachTourist.Depth = 0;
            SeachTourist.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            SeachTourist.HideSelection = true;
            SeachTourist.Hint = "姓名 身份证 电话 查询";
            SeachTourist.LeadingIcon = null;
            SeachTourist.Location = new Point(511, 23);
            SeachTourist.MaxLength = 32767;
            SeachTourist.MouseState = MaterialSkin3.MouseState.OUT;
            SeachTourist.Name = "SeachTourist";
            SeachTourist.PasswordChar = '\0';
            SeachTourist.PrefixSuffixText = null;
            SeachTourist.ReadOnly = false;
            SeachTourist.RightToLeft = RightToLeft.No;
            SeachTourist.SelectedText = "";
            SeachTourist.SelectionLength = 0;
            SeachTourist.SelectionStart = 0;
            SeachTourist.ShortcutsEnabled = true;
            SeachTourist.Size = new Size(426, 48);
            SeachTourist.TabIndex = 1;
            SeachTourist.TabStop = false;
            SeachTourist.TextAlign = HorizontalAlignment.Left;
            SeachTourist.TrailingIcon = null;
            SeachTourist.UseSystemPasswordChar = false;
            SeachTourist.TextChanged += SeachTourist_TextChanged;
            // 
            // touristGridView
            // 
            touristGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            touristGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            touristGridView.Columns.AddRange(new DataGridViewColumn[] { t_id, t_name, t_sex, t_phone, t_idcard, t_status, block, t_delete });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            touristGridView.DefaultCellStyle = dataGridViewCellStyle9;
            touristGridView.Location = new Point(-6, 86);
            touristGridView.Name = "touristGridView";
            touristGridView.RowHeadersWidth = 62;
            touristGridView.Size = new Size(1308, 599);
            touristGridView.TabIndex = 0;
            touristGridView.CellContentClick += touristGridView_CellContentClick;
            touristGridView.DataBindingComplete += touristGridView_DataBindingComplete;
            touristGridView.Enter += touristGridView_Enter;
            // 
            // t_id
            // 
            t_id.DataPropertyName = "id";
            t_id.HeaderText = "序号";
            t_id.MinimumWidth = 8;
            t_id.Name = "t_id";
            // 
            // t_name
            // 
            t_name.DataPropertyName = "name";
            t_name.HeaderText = "姓名";
            t_name.MinimumWidth = 8;
            t_name.Name = "t_name";
            // 
            // t_sex
            // 
            t_sex.DataPropertyName = "sex";
            t_sex.HeaderText = "性别";
            t_sex.MinimumWidth = 8;
            t_sex.Name = "t_sex";
            // 
            // t_phone
            // 
            t_phone.DataPropertyName = "phone";
            t_phone.HeaderText = "电话";
            t_phone.MinimumWidth = 8;
            t_phone.Name = "t_phone";
            // 
            // t_idcard
            // 
            t_idcard.DataPropertyName = "id_card";
            t_idcard.HeaderText = "身份证";
            t_idcard.MinimumWidth = 8;
            t_idcard.Name = "t_idcard";
            // 
            // t_status
            // 
            t_status.DataPropertyName = "t_status";
            t_status.HeaderText = "状态";
            t_status.MinimumWidth = 8;
            t_status.Name = "t_status";
            // 
            // block
            // 
            block.HeaderText = "拉黑";
            block.MinimumWidth = 8;
            block.Name = "block";
            block.Text = "拉黑";
            block.UseColumnTextForButtonValue = true;
            // 
            // t_delete
            // 
            t_delete.HeaderText = "删除";
            t_delete.MinimumWidth = 8;
            t_delete.Name = "t_delete";
            t_delete.Text = "删除";
            t_delete.UseColumnTextForButtonValue = true;
            // 
            // ChartPage
            // 
            ChartPage.BackColor = Color.White;
            ChartPage.Controls.Add(formsPlotTickets);
            ChartPage.ImageKey = "统计图.png";
            ChartPage.Location = new Point(4, 42);
            ChartPage.Name = "ChartPage";
            ChartPage.Padding = new Padding(3);
            ChartPage.Size = new Size(1292, 681);
            ChartPage.TabIndex = 2;
            ChartPage.Text = "每日售票";
            // 
            // formsPlotTickets
            // 
            formsPlotTickets.DisplayScale = 1.5F;
            formsPlotTickets.Location = new Point(60, 8);
            formsPlotTickets.Name = "formsPlotTickets";
            formsPlotTickets.Size = new Size(1229, 716);
            formsPlotTickets.TabIndex = 0;
            formsPlotTickets.Enter += formsPlotTickets_Enter;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.White;
            tabPage4.Controls.Add(formsPlotRevenue);
            tabPage4.ImageKey = "统计图.png";
            tabPage4.Location = new Point(4, 42);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1292, 681);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "日售票额";
            // 
            // formsPlotRevenue
            // 
            formsPlotRevenue.DisplayScale = 1.5F;
            formsPlotRevenue.Location = new Point(39, 9);
            formsPlotRevenue.Name = "formsPlotRevenue";
            formsPlotRevenue.Size = new Size(1257, 723);
            formsPlotRevenue.TabIndex = 0;
            formsPlotRevenue.Enter += formsPlotRevenue_Enter;
            // 
            // adminManage
            // 
            adminManage.BackColor = Color.White;
            adminManage.Controls.Add(deletePass);
            adminManage.Controls.Add(enterPass);
            adminManage.Controls.Add(newPassword);
            adminManage.Controls.Add(Originalpassword);
            adminManage.Controls.Add(materialLabel3);
            adminManage.Controls.Add(materialLabel2);
            adminManage.Controls.Add(materialLabel1);
            adminManage.Controls.Add(adminList);
            adminManage.ImageKey = "管理员认证.png";
            adminManage.Location = new Point(4, 42);
            adminManage.Name = "adminManage";
            adminManage.Padding = new Padding(3);
            adminManage.Size = new Size(1292, 681);
            adminManage.TabIndex = 4;
            adminManage.Text = "管理员管理";
            adminManage.Enter += adminManage_Enter;
            // 
            // deletePass
            // 
            deletePass.AutoSize = false;
            deletePass.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deletePass.BackColor = Color.DarkGray;
            deletePass.Density = MaterialSkin3.Controls.MaterialButton.MaterialButtonDensity.Default;
            deletePass.Depth = 0;
            deletePass.HighEmphasis = true;
            deletePass.Icon = null;
            deletePass.Location = new Point(650, 557);
            deletePass.Margin = new Padding(4, 6, 4, 6);
            deletePass.MouseState = MaterialSkin3.MouseState.HOVER;
            deletePass.Name = "deletePass";
            deletePass.NoAccentTextColor = Color.Empty;
            deletePass.Size = new Size(164, 52);
            deletePass.TabIndex = 5;
            deletePass.Text = "删除用户";
            deletePass.Type = MaterialSkin3.Controls.MaterialButton.MaterialButtonType.Outlined;
            deletePass.UseAccentColor = false;
            deletePass.UseVisualStyleBackColor = false;
            deletePass.Click += deletePass_Click;
            // 
            // enterPass
            // 
            enterPass.AutoSize = false;
            enterPass.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            enterPass.Density = MaterialSkin3.Controls.MaterialButton.MaterialButtonDensity.Default;
            enterPass.Depth = 0;
            enterPass.HighEmphasis = true;
            enterPass.Icon = null;
            enterPass.Location = new Point(434, 557);
            enterPass.Margin = new Padding(4, 6, 4, 6);
            enterPass.MouseState = MaterialSkin3.MouseState.HOVER;
            enterPass.Name = "enterPass";
            enterPass.NoAccentTextColor = Color.Empty;
            enterPass.Size = new Size(164, 52);
            enterPass.TabIndex = 4;
            enterPass.Text = "确定修改";
            enterPass.Type = MaterialSkin3.Controls.MaterialButton.MaterialButtonType.Contained;
            enterPass.UseAccentColor = false;
            enterPass.UseVisualStyleBackColor = true;
            enterPass.Click += enterPass_Click;
            // 
            // newPassword
            // 
            newPassword.AnimateReadOnly = false;
            newPassword.AutoCompleteMode = AutoCompleteMode.None;
            newPassword.AutoCompleteSource = AutoCompleteSource.None;
            newPassword.BackgroundImageLayout = ImageLayout.None;
            newPassword.CharacterCasing = CharacterCasing.Normal;
            newPassword.Depth = 0;
            newPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            newPassword.HideSelection = true;
            newPassword.LeadingIcon = null;
            newPassword.Location = new Point(434, 432);
            newPassword.MaxLength = 32767;
            newPassword.MouseState = MaterialSkin3.MouseState.OUT;
            newPassword.Name = "newPassword";
            newPassword.PasswordChar = '●';
            newPassword.PrefixSuffixText = null;
            newPassword.ReadOnly = false;
            newPassword.RightToLeft = RightToLeft.No;
            newPassword.SelectedText = "";
            newPassword.SelectionLength = 0;
            newPassword.SelectionStart = 0;
            newPassword.ShortcutsEnabled = true;
            newPassword.Size = new Size(380, 48);
            newPassword.TabIndex = 3;
            newPassword.TabStop = false;
            newPassword.TextAlign = HorizontalAlignment.Left;
            newPassword.TrailingIcon = null;
            newPassword.UseSystemPasswordChar = true;
            // 
            // Originalpassword
            // 
            Originalpassword.AnimateReadOnly = false;
            Originalpassword.AutoCompleteMode = AutoCompleteMode.None;
            Originalpassword.AutoCompleteSource = AutoCompleteSource.None;
            Originalpassword.BackgroundImageLayout = ImageLayout.None;
            Originalpassword.CharacterCasing = CharacterCasing.Normal;
            Originalpassword.Depth = 0;
            Originalpassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Originalpassword.HideSelection = true;
            Originalpassword.LeadingIcon = null;
            Originalpassword.Location = new Point(434, 290);
            Originalpassword.MaxLength = 32767;
            Originalpassword.MouseState = MaterialSkin3.MouseState.OUT;
            Originalpassword.Name = "Originalpassword";
            Originalpassword.PasswordChar = '●';
            Originalpassword.PrefixSuffixText = null;
            Originalpassword.ReadOnly = false;
            Originalpassword.RightToLeft = RightToLeft.No;
            Originalpassword.SelectedText = "";
            Originalpassword.SelectionLength = 0;
            Originalpassword.SelectionStart = 0;
            Originalpassword.ShortcutsEnabled = true;
            Originalpassword.Size = new Size(380, 48);
            Originalpassword.TabIndex = 2;
            Originalpassword.TabStop = false;
            Originalpassword.TextAlign = HorizontalAlignment.Left;
            Originalpassword.TrailingIcon = null;
            Originalpassword.UseSystemPasswordChar = true;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("HarmonyOS Sans SC Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin3.MaterialSkinManager.fontType.H6;
            materialLabel3.Location = new Point(434, 392);
            materialLabel3.MouseState = MaterialSkin3.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(61, 26);
            materialLabel3.TabIndex = 1;
            materialLabel3.Text = "新密码";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("HarmonyOS Sans SC Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin3.MaterialSkinManager.fontType.H6;
            materialLabel2.Location = new Point(434, 249);
            materialLabel2.MouseState = MaterialSkin3.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(101, 26);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "输入原密码";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("HarmonyOS Sans SC Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin3.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(434, 119);
            materialLabel1.MouseState = MaterialSkin3.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(101, 26);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "选择管理员";
            // 
            // adminList
            // 
            adminList.AutoResize = false;
            adminList.BackColor = Color.FromArgb(255, 255, 255);
            adminList.Depth = 0;
            adminList.DrawMode = DrawMode.OwnerDrawVariable;
            adminList.DropDownHeight = 174;
            adminList.DropDownStyle = ComboBoxStyle.DropDownList;
            adminList.DropDownWidth = 121;
            adminList.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            adminList.ForeColor = Color.FromArgb(222, 0, 0, 0);
            adminList.FormattingEnabled = true;
            adminList.IntegralHeight = false;
            adminList.ItemHeight = 43;
            adminList.Location = new Point(434, 158);
            adminList.MaxDropDownItems = 4;
            adminList.MouseState = MaterialSkin3.MouseState.OUT;
            adminList.Name = "adminList";
            adminList.Size = new Size(380, 49);
            adminList.StartIndex = 0;
            adminList.TabIndex = 0;
            // 
            // other
            // 
            other.BackColor = Color.White;
            other.Controls.Add(exit);
            other.Controls.Add(loginout);
            other.Controls.Add(restart);
            other.ImageKey = "业务进度跟踪.png";
            other.Location = new Point(4, 42);
            other.Name = "other";
            other.Padding = new Padding(3);
            other.Size = new Size(1292, 681);
            other.TabIndex = 6;
            other.Text = "登出";
            // 
            // exit
            // 
            exit.AutoSize = false;
            exit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exit.BackColor = Color.RosyBrown;
            exit.Density = MaterialSkin3.Controls.MaterialButton.MaterialButtonDensity.Default;
            exit.Depth = 0;
            exit.HighEmphasis = true;
            exit.Icon = null;
            exit.Location = new Point(529, 467);
            exit.Margin = new Padding(4, 6, 4, 6);
            exit.MouseState = MaterialSkin3.MouseState.HOVER;
            exit.Name = "exit";
            exit.NoAccentTextColor = Color.Empty;
            exit.Size = new Size(246, 54);
            exit.TabIndex = 0;
            exit.Text = "退出";
            exit.Type = MaterialSkin3.Controls.MaterialButton.MaterialButtonType.Contained;
            exit.UseAccentColor = false;
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // loginout
            // 
            loginout.AutoSize = false;
            loginout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginout.Density = MaterialSkin3.Controls.MaterialButton.MaterialButtonDensity.Default;
            loginout.Depth = 0;
            loginout.HighEmphasis = true;
            loginout.Icon = null;
            loginout.Location = new Point(529, 281);
            loginout.Margin = new Padding(4, 6, 4, 6);
            loginout.MouseState = MaterialSkin3.MouseState.HOVER;
            loginout.Name = "loginout";
            loginout.NoAccentTextColor = Color.Empty;
            loginout.Size = new Size(246, 54);
            loginout.TabIndex = 0;
            loginout.Text = "登出";
            loginout.Type = MaterialSkin3.Controls.MaterialButton.MaterialButtonType.Contained;
            loginout.UseAccentColor = false;
            loginout.UseVisualStyleBackColor = true;
            loginout.Click += loginout_Click;
            // 
            // restart
            // 
            restart.AutoSize = false;
            restart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            restart.Density = MaterialSkin3.Controls.MaterialButton.MaterialButtonDensity.Default;
            restart.Depth = 0;
            restart.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            restart.HighEmphasis = true;
            restart.Icon = null;
            restart.Location = new Point(529, 101);
            restart.Margin = new Padding(4, 6, 4, 6);
            restart.MouseState = MaterialSkin3.MouseState.HOVER;
            restart.Name = "restart";
            restart.NoAccentTextColor = Color.Empty;
            restart.Size = new Size(246, 54);
            restart.TabIndex = 0;
            restart.Text = "重启";
            restart.Type = MaterialSkin3.Controls.MaterialButton.MaterialButtonType.Contained;
            restart.UseAccentColor = false;
            restart.UseVisualStyleBackColor = true;
            restart.Click += restart_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "订单.png");
            imageList1.Images.SetKeyName(1, "管理员认证.png");
            imageList1.Images.SetKeyName(2, "人.png");
            imageList1.Images.SetKeyName(3, "设置.png");
            imageList1.Images.SetKeyName(4, "统计图.png");
            imageList1.Images.SetKeyName(5, "修改.png");
            imageList1.Images.SetKeyName(6, "业务进度跟踪.png");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 800);
            Controls.Add(materialTabControl1);
            DrawerAutoShow = true;
            DrawerBackgroundWithAccent = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            MaximizeBox = false;
            MaximumSize = new Size(1312, 800);
            Name = "MainForm";
            Text = "管理员";
            Load += MainForm_Load;
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            TouristPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)touristGridView).EndInit();
            ChartPage.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            adminManage.ResumeLayout(false);
            adminManage.PerformLayout();
            other.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin3.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage TouristPage;
        private TabPage ChartPage;
        private TabPage tabPage4;
        private TabPage adminManage;
        private TabPage other;
        private ImageList imageList1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn order_id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn sex;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn id_card;
        private DataGridViewTextBoxColumn price;
        private DataGridViewButtonColumn update;
        private DataGridViewButtonColumn delete;
        private MaterialSkin3.Controls.MaterialButton insert;
        private MaterialSkin3.Controls.MaterialTextBox2 ticketSearchBox;
        private MaterialSkin3.Controls.MaterialButton SeachEnter;
        private DataGridView touristGridView;
        private DataGridViewTextBoxColumn id_t;
        private DataGridViewTextBoxColumn t_name;
        private DataGridViewTextBoxColumn t_sex;
        private DataGridViewTextBoxColumn t_phone;
        private DataGridViewTextBoxColumn t_idcard;
        private DataGridViewTextBoxColumn t_status;
        private DataGridViewButtonColumn block;
        private DataGridViewButtonColumn t_delete;
        private DataGridViewTextBoxColumn t_id;
        private MaterialSkin3.Controls.MaterialButton touristEnter;
        private MaterialSkin3.Controls.MaterialTextBox2 SeachTourist;
        private MaterialSkin3.Controls.MaterialComboBox touristcombo;
        private ScottPlot.WinForms.FormsPlot formsPlotTickets;
        private ScottPlot.WinForms.FormsPlot formsPlotRevenue;
        private MaterialSkin3.Controls.MaterialTextBox2 Originalpassword;
        private MaterialSkin3.Controls.MaterialLabel materialLabel2;
        private MaterialSkin3.Controls.MaterialLabel materialLabel1;
        private MaterialSkin3.Controls.MaterialComboBox adminList;
        private MaterialSkin3.Controls.MaterialTextBox2 newPassword;
        private MaterialSkin3.Controls.MaterialLabel materialLabel3;
        private MaterialSkin3.Controls.MaterialButton enterPass;
        private MaterialSkin3.Controls.MaterialButton deletePass;
        private MaterialSkin3.Controls.MaterialButton exit;
        private MaterialSkin3.Controls.MaterialButton loginout;
        private MaterialSkin3.Controls.MaterialButton restart;
    }
}