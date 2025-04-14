using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeshanTicketSystem.UI.Utils
{
    public class DgvHelper
    {

        public static void AlignDataGridView(DataGridView dgv)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        // 自动调整 DataGridView 高度适配内容
        public static void AutoResizeHeight(DataGridView dgv, int maxHeight = 500)
        {
            int totalHeight = dgv.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgv.Rows)
                totalHeight += row.Height;

            dgv.Height = Math.Min(totalHeight + 2, maxHeight); // +2美化一下
        }

        // 删除一行数据（通过主键 ID）
        public static void DeleteSelectedRow(DataGridView dgv, Func<int, bool> deleteAction, Action refreshAction)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择一行进行删除");
                return;
            }

            var row = dgv.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["id"].Value);

            var confirm = MessageBox.Show("确定要删除这条记录吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                bool success = deleteAction(id);
                if (success)
                {
                    MessageBox.Show("删除成功！");
                    refreshAction?.Invoke();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        // 插入数据（简单方式，可扩展为弹窗输入）
        public static void InsertRow(Func<bool> insertAction, Action refreshAction)
        {
            bool success = insertAction();
            if (success)
            {
                MessageBox.Show("添加成功！");
                refreshAction?.Invoke();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }
    }
}
