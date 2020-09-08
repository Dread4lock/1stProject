using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Nauka_2._0
{
    public partial class Form1 : Form
    {

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-3SAMGSO;Initial Catalog=NaukaTestDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int employeeId;


        public Form1()
        {
            InitializeComponent();
        }

        private void Clear()

        {// очистка текстбоксов
            Nametbx.Text = Surnametbx.Text = Secnametbx.Text = Datetbx.Text = Adresstbx.Text = Unittbx.Text = Abouttbx.Text = "";
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "naukaTestDBDataSet.Employees2". При необходимости она может быть перемещена или удалена.
            this.employees2TableAdapter.Fill(this.naukaTestDBDataSet.Employees2);
            Datetbx.Text = "DD.MM.YY";
            //напоминание о формате даты
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {

            Con.Open();
            try
            {// ловим ошибку аргумента или неверного формата ввода даты
                cmd = new SqlCommand("INSERT INTO Employees2 VALUES ('" + Nametbx.Text + "', '" + Surnametbx.Text + "','" + Secnametbx.Text + "','" + Datetbx.Text + "','" + Adresstbx.Text + "','" + Unittbx.Text + "','" + Abouttbx.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
                Clear();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Con.Close();
            DisplayData();
        }

        private void DisplayData()
        {//отображаем обновленный вид таблицы
            Con.Open();
            adpt = new SqlDataAdapter("Select* FROM Employees2", Con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            Con.Close();
        }

        private void Datetbx_Click(object sender, EventArgs e)
        {//очищаем дефолтный текст, который нужен только как напоминание написания формата даты
            if (Datetbx.Text == "DD.MM.YY")
            { Datetbx.Clear(); }

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            cmd = new SqlCommand("UPDATE Employees2 SET Имя='" + Nametbx.Text + "', Фамилия='" + Surnametbx.Text + "',Отчество='" + Secnametbx.Text + "',[Дата Рождения]='" + Datetbx.Text + "',Адрес='" + Adresstbx.Text + "',Отдел='" + Unittbx.Text + "',[О себе]='" + Abouttbx.Text + "'WHERE ID='" + employeeId + "' ", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated");
            Con.Close();
            DisplayData();
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {// текст из ячейки вносим в текстбоксы при двойном клике на ячейку
            employeeId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Nametbx.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Surnametbx.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Secnametbx.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Datetbx.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Adresstbx.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Unittbx.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Abouttbx.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            //уточняем ту ли кнопку хотели нажать и в случае подтверждения выполняем удаление.
            // Для удаления нажать дважды на ячейку, чтобы заполнить бокс id, который скрыт
            string message = "Are you sure?";
            string caption = "Delete?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo; DialogResult result;
            result = MessageBox.Show(message, caption, buttons);

            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    Con.Open();
                    cmd = new SqlCommand("DELETE FROM Employees2 WHERE ID='" + employeeId + "'", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    Con.Close();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
            Clear();
            DisplayData();


        }
    }
}
