using System.Data;
using System.Data.SqlClient;

namespace forecast_FEB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void City_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-PF3OIHM\\SQLEXPRESS;Initial Catalog=forecastDB;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update userInput set  city=@city,state=@state,temparature=@temparature, date=@date where id=@id ", con);


            cmd.Parameters.AddWithValue("@id", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@city", comboBox2.Text);
            cmd.Parameters.AddWithValue("@state", comboBox1.Text);
            cmd.Parameters.AddWithValue("@temparature", textBox1.Text);
            cmd.Parameters.AddWithValue("@date", DateTime.Parse(dateTimePicker1.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Updated");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click_3(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-PF3OIHM\\SQLEXPRESS;Initial Catalog=forecastDB;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete userinput where id=@id ", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox9.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("sucessfully deleted NB: Click show record to update the records in the datalist");

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void IA_Click(object sender, EventArgs e)
        {

        }

        private void Add_Information_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-PF3OIHM\\SQLEXPRESS;Initial Catalog=forecastDB;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("insert into userInput  values ( @city,@state,@temparature,@date )", con);

            con.Open();

            cmd.Parameters.AddWithValue("@city", comboBox2.Text);
            cmd.Parameters.AddWithValue("@state", comboBox1.Text);
            cmd.Parameters.AddWithValue("@temparature", textBox1.Text);
            cmd.Parameters.AddWithValue("@date", DateTime.Parse(dateTimePicker1.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully saved");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void remove_all_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-PF3OIHM\\SQLEXPRESS;Initial Catalog=forecastDB;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete userinput", con);


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("sucessfully deleted All record  NB: Click show record to update the records in the datalist ");
        }

        private void show_records_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-PF3OIHM\\SQLEXPRESS;Initial Catalog=forecastDB;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from userinput", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Fetching records");
        }

        private void find_record_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-PF3OIHM\\SQLEXPRESS;Initial Catalog=forecastDB;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from userinput where id=@id ", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox9.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully fetched the record");
        }

        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}