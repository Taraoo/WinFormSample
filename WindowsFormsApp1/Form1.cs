using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            dataGridView1.Columns.Add(column);
            dataGridView1.Columns[0].ReadOnly = false;

            // カラム名を指定
            DataGridViewTextBoxColumn colname1 = new DataGridViewTextBoxColumn();
            colname1.Name = "name1";
            dataGridView1.Columns.Add(colname1);

            DataGridViewTextBoxColumn colname2 = new DataGridViewTextBoxColumn();
            colname2.Name = "name2";
            dataGridView1.Columns.Add(colname2);

            DataGridViewTextBoxColumn colname3 = new DataGridViewTextBoxColumn();
            colname3.Name = "name3";
            dataGridView1.Columns.Add(colname3);

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                c.HeaderCell.Style.BackColor = Color.LightGray;
                c.HeaderCell.Style.SelectionBackColor = Color.LightGray;
            }
                

            // データを追加
            dataGridView1.Rows.Add(true, 90, "田中　一郎", "A");
            dataGridView1.Rows.Add(false, 50, "鈴木　二郎", "A");
            dataGridView1.Rows.Add(false, 90, "佐藤　三郎", "B");
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(@"C:\Users\81805\Desktop\abc", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently,
                Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing);

            Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(@"C:\Users\81805\Desktop\abv", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
    Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently,
    Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing);
        }
    }
}
