using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Yapılacaklar_Uygulaması__To_Do_List__APP_
{
    public partial class Form1 : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=root;database=todo_app;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void button1_Click(object sender, EventArgs e) // Görev Ekle
        {
            string task = txtTask.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                AddTask(task);
                txtTask.Clear();
                LoadTasks();
            }
            else
            {
                MessageBox.Show("Lütfen bir görev girin.");
            }
        }

        private void button3_Click(object sender, EventArgs e) // Tamamlandı
        {
            if (lstTasks.SelectedIndex != -1)
            {
                int taskId = GetSelectedTaskId();
                if (taskId != -1)
                {
                    using (var conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE tasks SET is_done = 1 WHERE id = @id";
                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", taskId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadTasks();
                }
            }
            else
            {
                MessageBox.Show("Lütfen tamamlandı olarak işaretlenecek bir görev seçin.");
            }
        }

        private void button4_Click(object sender, EventArgs e) // Tarihe göre filtrele
        {
            DateTime selectedDate = dtpFilter.Value.Date;
            lstTasks.Items.Clear();

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, description, date_created, is_done FROM tasks WHERE DATE(date_created) = @date ORDER BY date_created DESC";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", selectedDate.ToString("yyyy-MM-dd"));
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string desc = reader.GetString("description");
                            DateTime date = reader.GetDateTime("date_created");
                            bool done = reader.GetBoolean("is_done");

                            string status = done ? "[✓]" : "[ ]";
                            lstTasks.Items.Add($"{status} {date.ToShortDateString()} - {desc} (ID: {id})");
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e) // Filtreyi temizle
        {
            LoadTasks();
        }

        private void button6_Click(object sender, EventArgs e) // İstatistik ekranı
        {
            StatisticsForm statsForm = new StatisticsForm();
            statsForm.ShowDialog();
        }

        // Yardımcı fonksiyonlar
        private void AddTask(string task)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO tasks (description, date_created) VALUES (@desc, @date)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@desc", task);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void DeleteTask(int taskId)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM tasks WHERE id = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", taskId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadTasks()
        {
            lstTasks.Items.Clear();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, description, date_created, is_done FROM tasks ORDER BY date_created DESC";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string desc = reader.GetString("description");
                        DateTime date = reader.GetDateTime("date_created");
                        bool done = reader.GetBoolean("is_done");

                        string status = done ? "[✓]" : "[ ]";
                        lstTasks.Items.Add($"{status} {date.ToShortDateString()} - {desc} (ID: {id})");
                    }
                }
            }
        }

        private int GetSelectedTaskId()
        {
            string selectedItem = lstTasks.SelectedItem.ToString();
            int startIndex = selectedItem.LastIndexOf("(ID: ") + 5;
            int endIndex = selectedItem.LastIndexOf(")");
            string idStr = selectedItem.Substring(startIndex, endIndex - startIndex);

            return int.TryParse(idStr, out int taskId) ? taskId : -1;
        }

        private string GetDescriptionById(int id)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT description FROM tasks WHERE id = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteScalar()?.ToString();
                }
            }
        }

        private bool GetIsDoneById(int id)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT is_done FROM tasks WHERE id = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return Convert.ToBoolean(cmd.ExecuteScalar());
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string task = txtTask.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                AddTask(task);
                txtTask.Clear();
                LoadTasks();
            }
            else
            {
                MessageBox.Show("Lütfen bir görev girin.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                int taskId = GetSelectedTaskId();
                if (taskId != -1)
                {
                    DeleteTask(taskId);
                    LoadTasks();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir görev seçin.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                int taskId = GetSelectedTaskId();
                if (taskId != -1)
                {
                    string desc = GetDescriptionById(taskId);
                    bool isDone = GetIsDoneById(taskId);

                    var editForm = new EditTaskForm(taskId, desc, isDone);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadTasks();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlenecek bir görev seçin.");
            }
        }
    }
}
