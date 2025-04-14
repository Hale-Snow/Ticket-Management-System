using ScottPlot;
using System.Data;
using MaterialSkin3.Controls;
using LeshanTicketSystem.BLL;
using LeshanTicketSystem.Model;
using LeshanTicketSystem.UI.Utils;
using ScottPlot.TickGenerators;
using System;




namespace LeshanTicketSystem.UI
{

    public partial class MainForm : MaterialForm
    {
        private OrderService orderService;
        public MainForm()
        {
            InitializeComponent();
            orderService = new OrderService();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // 加载数据并绑定到 DataGridView
                LoadOrders();

                //DgvHelper.AutoResizeHeight(dataGridView1);
            }
            catch (ApplicationException ex)
            {
                // 捕获并显示错误消息
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrders()
        {
            DataTable ordersData = orderService.GetOrders();
            dataGridView1.DataSource = ordersData;
            DgvHelper.AlignDataGridView(dataGridView1);
            DgvHelper.AutoResizeHeight(dataGridView1); // 自动调整高度
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["order_id"].Value);

                var confirm = MessageBox.Show("确认删除该订单吗？", "提示", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (OrderBLL.DeleteOrderById(id))
                    {
                        MessageBox.Show("删除成功！");
                        LoadOrders(); // 重新加载数据
                                      // DgvHelper.AutoResizeHeight(dataGridView1); // 自动调整高度

                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
            }

            if (e.RowIndex < 0 || dataGridView1.Columns[e.ColumnIndex].Name != "update")
                return;

            try
            {
                var order = new Order
                {
                    OrderId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["order_id"].Value),
                    Name = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString(),
                    Phone = dataGridView1.Rows[e.RowIndex].Cells["phone"].Value.ToString(),
                    IdCard = dataGridView1.Rows[e.RowIndex].Cells["id_card"].Value.ToString(),
                    Sex = dataGridView1.Rows[e.RowIndex].Cells["sex"].Value.ToString(),
                    Price = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["price"].Value)
                };

                if (OrderBLL.UpdateOrder(order))
                {
                    MessageBox.Show("更新成功！");
                    LoadOrders(); // 重新加载数据

                }
                else
                {
                    MessageBox.Show("更新失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新出错：" + ex.Message);
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            if (row == null)
            {
                MessageBox.Show("请选择一行数据！");
                return;
            }

            try
            {
                var order = new Order
                {
                    OrderId = Convert.ToInt32(row.Cells["order_id"].Value ?? 0),
                    Name = row.Cells["name"].Value?.ToString() ?? "",
                    Phone = row.Cells["phone"].Value?.ToString() ?? "",
                    IdCard = row.Cells["id_card"].Value?.ToString() ?? "",
                    Sex = row.Cells["sex"].Value?.ToString() ?? "",
                    Price = Convert.ToDecimal(row.Cells["price"].Value ?? 0)
                };

                if (OrderBLL.InsertOrder(order))
                {
                    MessageBox.Show("插入成功！");
                    LoadOrders(); // 刷新表格
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("未知错误: " + ex.Message);
            }
        }

        private void SeachEnter_Click(object sender, EventArgs e)
        {
            string keyword = ticketSearchBox.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("请输入搜索内容！");
                return;
            }

            // 调用 BLL 获取搜索结果
            DataTable result = OrderBLL.SearchOrders(keyword);
            dataGridView1.DataSource = result;
            DgvHelper.AutoResizeHeight(dataGridView1);
        }

        //监听搜索框，如果改变，则自动刷新为全部数据
        private void ticketSearchBox_TextChanged_1(object sender, EventArgs e)
        {
            string keyword = ticketSearchBox.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadOrders(); // 恢复全部数据
            }
        }


        //
        private TouristBLL touristService = new TouristBLL();
        private void LoadTourists()
        {
            try
            {

                DataTable tourists = touristService.GetTouristList();
                touristGridView.DataSource = tourists;
                DgvHelper.AlignDataGridView(touristGridView);
                DgvHelper.AutoResizeHeight(touristGridView);
                HighlightBlockedRows();
                //MessageBox.Show("共加载 " + tourists.Rows.Count + " 条游客数据");
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载游客信息失败: " + ex.Message);
            }
        }



        private void touristGridView_Enter(object sender, EventArgs e)
        {
            LoadTourists();
            HighlightBlockedRows();
        }

        //游客信息删除

        private void touristGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = touristGridView.Rows[e.RowIndex];
            string idCard = row.Cells["t_idcard"].Value?.ToString();

            if (touristGridView.Columns[e.ColumnIndex].Name == "t_delete")
            {
                if (MessageBox.Show("确认删除该游客？", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (TouristBLL.DeleteTouristByIdCard(idCard))
                    {
                        MessageBox.Show("删除成功！");
                        LoadTourists(); // 重新加载
                    }
                }
            }
            else if (touristGridView.Columns[e.ColumnIndex].Name == "block")
            {
                string statusText = row.Cells["t_status"].Value?.ToString();
                int currentStatus = statusText == "拉黑" ? 1 : 0;
                int newStatus = currentStatus == 0 ? 1 : 0;

                try
                {
                    if (TouristBLL.UpdateTouristStatus(idCard, newStatus))
                    {
                        MessageBox.Show(newStatus == 1 ? "已拉黑！" : "已取消拉黑！");
                        LoadTourists();
                    }
                    else
                    {
                        MessageBox.Show("状态更新失败！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("更新状态失败: " + ex.Message);
                }
            }
        }

        //根据0和1来判断是否拉黑变红
        private void HighlightBlockedRows()
        {
            foreach (DataGridViewRow row in touristGridView.Rows)
            {
                if (row.Cells["t_status"].Value?.ToString() == "拉黑")
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                }
                else
                {
                    // 可选：还原正常行颜色  
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
            }
        }


        private void touristGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void touristEnter_Click(object sender, EventArgs e)
        {
            string keyword = SeachTourist.Text.Trim();
            string status = touristcombo.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(keyword) && string.IsNullOrEmpty(status))
            {
                LoadTourists(); // 全部加载
                return;
            }

            try
            {
                DataTable results = touristService.SearchTourists(keyword, status);
                touristGridView.DataSource = results;

                DgvHelper.AlignDataGridView(touristGridView);
                DgvHelper.AutoResizeHeight(touristGridView);
                HighlightBlockedRows(); // 拉黑行变红
            }
            catch (Exception ex)
            {
                MessageBox.Show("搜索失败：" + ex.Message);
            }
        }




        private void SeachTourist_TextChanged(object sender, EventArgs e)
        {
            touristEnter_Click(sender, e); // 复用点击搜索按钮时的逻
        }

        private void touristcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 判断是否选择了 "恢复"
            if (touristcombo.SelectedItem?.ToString() == "恢复")
            {
                SeachTourist.Clear();  // 清空搜索框
                touristcombo.SelectedItem = null;  // 清空 ComboBox 的选择
                LoadTourists();  // 恢复所有数据
            }
            else
            {
                // 如果没有选择恢复，执行搜索操作
                touristEnter_Click(sender, e);
            }
        }


        private void formsPlotTickets_Enter(object sender, EventArgs e)
        {
            LoadTicketChart();
        }
        private void LoadTicketChart()
        {
            // 1. 准备数据
            var manager = new SalesChartManager();
            DataTable salesData = manager.GetSalesData();

            List<double> ticketCounts = new List<double>();
            List<string> dateLabels = new List<string>();

            foreach (DataRow row in salesData.Rows)
            {
                int adult = Convert.ToInt32(row["adult_tickets"]);
                int child = Convert.ToInt32(row["child_tickets"]);
                ticketCounts.Add(adult + child);
                dateLabels.Add(Convert.ToDateTime(row["sale_date"]).ToString("MM-dd"));
            }

            // 2. 清除旧图表
            formsPlotTickets.Plot.Clear();



            // 3. 添加柱状图
            double[] positions = Enumerable.Range(0, ticketCounts.Count).Select(i => (double)i).ToArray();
            var barPlot = formsPlotTickets.Plot.Add.Bars(positions, ticketCounts.ToArray());
            Random random = new Random();
            List<System.Drawing.Color> colorlist = ColorHelper.GetAllColorList();
            int index = 0;
            foreach (var bar in barPlot.Bars)
            {
                bar.Label = bar.Value.ToString();
                //bar.FillColor = ScottPlot.Color.FromHex(String.Format("#{0:X6}", random.Next(0x1000000)));//完全颜色随机（三选一）
                //bar.FillColor = GetCommonColorList()[index];//精选常用颜色（三选一，index初始化0，后续index++）
                bar.FillColor = ScottPlot.Color.FromColor(colorlist[random.Next(colorlist.Count)]);//精选颜色随机（三选一）
                index++;
            }




            // 4.2 设置标题
            var title = formsPlotTickets.Plot.Add.Text("每日总票数", 3, 200);
            title.LabelFontName = "宋体";
            title.LabelFontSize = 20;
            title.LabelBold = true;
            title.LabelAlignment = Alignment.UpperCenter;

            // 4.3 设置坐标轴标签字体
            formsPlotTickets.Plot.Axes.Bottom.Label.Text = "日期";
            formsPlotTickets.Plot.Axes.Bottom.Label.FontName = "宋体";
            formsPlotTickets.Plot.Axes.Bottom.Label.FontSize = 20;

            formsPlotTickets.Plot.Axes.Left.Label.Text = "票数";
            formsPlotTickets.Plot.Axes.Left.Label.FontName = "宋体";
            formsPlotTickets.Plot.Axes.Left.Label.FontSize = 20;

            // 4.4 设置刻度标签字体
            formsPlotTickets.Plot.Axes.Bottom.TickLabelStyle.FontName = "宋体";
            formsPlotTickets.Plot.Axes.Bottom.TickLabelStyle.FontSize = 18;
            formsPlotTickets.Plot.Axes.Left.TickLabelStyle.FontName = "宋体";
            formsPlotTickets.Plot.Axes.Left.TickLabelStyle.FontSize = 18;
            // --------------------------------------------------


            foreach (var bar in barPlot.Bars)
            {
                bar.Label = bar.Value.ToString();


            }
            barPlot.ValueLabelStyle.Bold = true;
            barPlot.ValueLabelStyle.FontSize = 18;

            // 5. 设置刻度标签
            var ticks = positions.Zip(dateLabels, (pos, label) => new Tick(pos, label)).ToArray();
            formsPlotTickets.Plot.Axes.Bottom.TickGenerator = new NumericManual(ticks);

            // 6. 调整坐标轴范围
            formsPlotTickets.Plot.Axes.Bottom.Min = -10;
            formsPlotTickets.Plot.Axes.Bottom.Max = ticketCounts.Count + 8;
            barPlot.ValueLabelStyle.Bold = true;
            barPlot.ValueLabelStyle.FontSize = 18;

            // 7. 保存图表图片
            //formsPlotTickets.Plot.Save("chart_debug.png", 800, 600);

            // 6. 调整坐标轴范围
            formsPlotTickets.Plot.Axes.Bottom.Min = -3;
            formsPlotTickets.Plot.Axes.Bottom.Max = ticketCounts.Count + 3;

            // 8. 刷新图表
            formsPlotTickets.Refresh();
        }

        //日售票额

        private void formsPlotRevenue_Enter(object sender, EventArgs e)
        {
            LoadRevenueChart();  // 当用户进入此选项卡时加载销售额图表
        }

        private void LoadRevenueChart()
        {
            // 1. 准备数据
            var manager = new SalesChartManager();
            DataTable salesData = manager.GetSalesData();

            List<double> revenueAmounts = new List<double>();
            List<string> dateLabels = new List<string>();

            foreach (DataRow row in salesData.Rows)
            {
                // 获取销售额（成人票 * 80 + 儿童票 * 40）
                decimal totalAmount = Convert.ToDecimal(row["total_amount"]);
                revenueAmounts.Add((double)totalAmount);
                dateLabels.Add(Convert.ToDateTime(row["sale_date"]).ToString("MM-dd"));
            }

            // 2. 清除旧图表
            formsPlotRevenue.Plot.Clear();

            //List<double> xlist = new List<double>();
            //for (int i = 0; i < revenueAmounts.Count; i++)
            //{
            //    var width = 20;//调整横坐标间隔（间接调柱形图宽度，值越大 柱形图宽度越窄）
            //    xlist.Add((double)i * width);
            //}


            // 3. 添加柱状图
            double[] positions = Enumerable.Range(0, revenueAmounts.Count).Select(i => (double)i).ToArray();
            var barPlot = formsPlotRevenue.Plot.Add.Bars(positions, revenueAmounts.ToArray());

            Random random = new Random();
            List<System.Drawing.Color> colorlist = ColorHelper.GetAllColorList();
            int index = 0;
            foreach (var bar in barPlot.Bars)
            {
                bar.Label = bar.Value.ToString();
                //bar.FillColor = ScottPlot.Color.FromHex(String.Format("#{0:X6}", random.Next(0x1000000)));//完全颜色随机（三选一）
                //bar.FillColor = GetCommonColorList()[index];//精选常用颜色（三选一，index初始化0，后续index++）
                bar.FillColor = ScottPlot.Color.FromColor(colorlist[random.Next(colorlist.Count)]);//精选颜色随机（三选一）
                index++;
            }
            //barPlot.Color = Colors.Green;  // 使用绿色表示销售额


            // 4.2 设置标题
            var title = formsPlotRevenue.Plot.Add.Text("每日销售额", 3, 4000);
            title.LabelFontName = "宋体";
            title.LabelFontSize = 20;
            title.LabelBold = true;
            title.LabelAlignment = Alignment.UpperCenter;

            // 4.3 设置坐标轴标签字体
            formsPlotRevenue.Plot.Axes.Bottom.Label.Text = "日期";
            formsPlotRevenue.Plot.Axes.Bottom.Label.FontName = "宋体";
            formsPlotRevenue.Plot.Axes.Bottom.Label.FontSize = 20;

            formsPlotRevenue.Plot.Axes.Left.Label.Text = "销售额";
            formsPlotRevenue.Plot.Axes.Left.Label.FontName = "宋体";
            formsPlotRevenue.Plot.Axes.Left.Label.FontSize = 20;

            // 4.4 设置刻度标签字体
            formsPlotRevenue.Plot.Axes.Bottom.TickLabelStyle.FontName = "宋体";
            formsPlotRevenue.Plot.Axes.Bottom.TickLabelStyle.FontSize = 18;
            formsPlotRevenue.Plot.Axes.Left.TickLabelStyle.FontName = "宋体";
            formsPlotRevenue.Plot.Axes.Left.TickLabelStyle.FontSize = 18;

            // 5. 设置刻度标签
            var ticks = positions.Zip(dateLabels, (pos, label) => new Tick(pos, label)).ToArray();
            formsPlotRevenue.Plot.Axes.Bottom.TickGenerator = new NumericManual(ticks);

            foreach (var bar in barPlot.Bars)
            {
                bar.Label = bar.Value.ToString();
            }
            barPlot.ValueLabelStyle.Bold = true;
            barPlot.ValueLabelStyle.FontSize = 18;
            // 6. 调整坐标轴范围
            formsPlotRevenue.Plot.Axes.Bottom.Min = -3;
            formsPlotRevenue.Plot.Axes.Bottom.Max = revenueAmounts.Count + 3;
            // 7. 刷新图表
            formsPlotRevenue.Refresh();
        }


        //管理员管理
        private AdminBLL bll = new AdminBLL();
        private void adminManage_Enter(object sender, EventArgs e)
        {
            adminList.DataSource = bll.GetAdminList();
        }

        private void enterPass_Click(object sender, EventArgs e)
        {
            string uid = adminList.SelectedItem?.ToString();
            string oldPwd = Originalpassword.Text;
            string newPwd = newPassword.Text;

            if (string.IsNullOrWhiteSpace(uid) || string.IsNullOrWhiteSpace(oldPwd) || string.IsNullOrWhiteSpace(newPwd))
            {
                MessageBox.Show("请填写完整信息！");
                return;
            }

            if (bll.UpdatePassword(uid, oldPwd, newPwd))
            {

                if (Session.CurrentAdmin != null && Session.CurrentAdmin.Uid == uid)
                {
                    // 判断当前登录管理员
                    MessageBox.Show($"您正在修改您账号{Session.CurrentAdmin.Uid}密码！");
                }
                MessageBox.Show("密码修改成功！");
                Originalpassword.Clear();
                newPassword.Clear();

                this.Hide();
                Application.Restart();
            }
            else
            {
                MessageBox.Show("原密码错误或新密码与原密码一致！");
            }
        }

        private void deletePass_Click(object sender, EventArgs e)
        {
            string uid = adminList.SelectedItem?.ToString(); // 当前选择的管理员ID
            string oldPwd = Originalpassword.Text;

            if (string.IsNullOrWhiteSpace(uid) || string.IsNullOrWhiteSpace(oldPwd))
            {
                MessageBox.Show("请输入原密码！");
                return;
            }

            // 调用 BLL 删除管理员逻辑
            if (bll.DeleteAdmin(uid, oldPwd))
            {

                // 判断是否是当前登录的管理员
                if (Session.CurrentAdmin != null && Session.CurrentAdmin.Uid == uid)
                {
                    // 删除的是当前登录管理员，重启程序
                    MessageBox.Show($"您已删除当前账号{Session.CurrentAdmin.Uid}，系统将自动重启！");
                    Application.Restart();
                    return;
                }
                MessageBox.Show("管理员已删除！");

                // 清空输入框，刷新列表
                Originalpassword.Clear();
                newPassword.Clear();

                // 重新加载管理员列表
                adminList.DataSource = bll.GetAdminList();
                //adminList.DisplayMember = "Uid"; // 假设你用 Admin 对象填充的
            }
            else
            {
                MessageBox.Show("原密码错误，删除失败！");
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void loginout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
