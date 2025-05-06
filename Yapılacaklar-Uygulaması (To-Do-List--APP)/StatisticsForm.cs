using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Yapılacaklar_Uygulaması__To_Do_List__APP_
{
    public partial class StatisticsForm : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=root;database=todo_app;";
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                lblTotal.Text = "Toplam Görev: " + GetCount(conn, "SELECT COUNT(*) FROM tasks");
                lblCompleted.Text = "Tamamlanan: " + GetCount(conn, "SELECT COUNT(*) FROM tasks WHERE is_done = 1");
                lblIncomplete.Text = "Tamamlanmamış: " + GetCount(conn, "SELECT COUNT(*) FROM tasks WHERE is_done = 0");
                lblToday.Text = "Bugün Eklenen: " + GetCount(conn, "SELECT COUNT(*) FROM tasks WHERE DATE(date_created) = CURDATE()");
                lblLast7Days.Text = "Son 7 Gün: " + GetCount(conn, "SELECT COUNT(*) FROM tasks WHERE date_created >= CURDATE() - INTERVAL 7 DAY");
            }

            LoadChart();
        }

        private int GetCount(MySqlConnection conn, string query)
        {
            using (var cmd = new MySqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void LoadChart()
        {
            chartTasks.Series.Clear();
            chartTasks.ChartAreas.Clear();

            chartTasks.ChartAreas.Add(new ChartArea("MainArea"));
            Series series = new Series("Günlük Görev Sayısı");
            series.ChartType = SeriesChartType.Column; // Çubuk grafik
            chartTasks.Series.Add(series);

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT DATE(date_created) as task_date, COUNT(*) as task_count
            FROM tasks
            WHERE date_created >= CURDATE() - INTERVAL 6 DAY
            GROUP BY DATE(date_created)
            ORDER BY task_date";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime date = reader.GetDateTime("task_date");
                        int count = reader.GetInt32("task_count");

                        series.Points.AddXY(date.ToString("dd MMM"), count);
                    }
                }
            }
        }
    }
}
