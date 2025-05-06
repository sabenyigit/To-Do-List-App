using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Yapılacaklar_Uygulaması__To_Do_List__APP_
{
    public partial class EditTaskForm : Form
    {
        private int taskId;
        private string connectionString = "server=localhost;uid=root;pwd=root;database=todo_app;";

        // Yapıcı metodun düzenlenmesi
        public EditTaskForm(int id, string description, bool isDone)
        {
            InitializeComponent();
            taskId = id;
            txtEditDescription.Text = description;
            chkEditIsDone.Checked = isDone;
        }

        private void EditTaskForm_Load(object sender, EventArgs e)
        {
            // Burada başka bir şey yapmaya gerek yok.
        }

        // "Kaydet" butonuna tıklanınca yapılacak işlemler
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string newDesc = txtEditDescription.Text.Trim();
            bool isDone = chkEditIsDone.Checked;

            if (string.IsNullOrEmpty(newDesc))
            {
                MessageBox.Show("Görev açıklaması boş olamaz.");
                return;
            }

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE tasks SET description = @desc, is_done = @done WHERE id = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@desc", newDesc);
                    cmd.Parameters.AddWithValue("@done", isDone);
                    cmd.Parameters.AddWithValue("@id", taskId);
                    cmd.ExecuteNonQuery();
                }
            }

            // Değişiklikleri kaydettikten sonra, formu kapatıyoruz
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
