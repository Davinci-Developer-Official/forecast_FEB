namespace forecast_FEB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            textBox10 = new TextBox();
            id = new Label();
            clear = new Button();
            Add_Information = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            state = new Label();
            label1 = new Label();
            temp_in_F = new Label();
            City = new Label();
            weather_information = new Label();
            label3 = new Label();
            panel2 = new Panel();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            Region = new Label();
            Wi = new Label();
            IA = new Label();
            SD = new Label();
            ND = new Label();
            MN = new Label();
            AvarageTemparature = new Label();
            dataGridView1 = new DataGridView();
            find_record = new Button();
            remove_record = new Button();
            show_records = new Button();
            textBox9 = new TextBox();
            highest_temperature = new Button();
            lowest_temp = new Button();
            remove_all = new Button();
            close = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(textBox10);
            panel1.Controls.Add(id);
            panel1.Controls.Add(clear);
            panel1.Controls.Add(Add_Information);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(state);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(temp_in_F);
            panel1.Controls.Add(City);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 313);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Minneapolis", "Fargo", "San Diego", "Des Moines", "Milwaukee" });
            comboBox2.Location = new Point(131, 55);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 19;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(121, 19);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "use id to update record";
            textBox10.Size = new Size(131, 23);
            textBox10.TabIndex = 18;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(26, 19);
            id.Name = "id";
            id.Size = new Size(17, 15);
            id.TabIndex = 17;
            id.Text = "id";
            // 
            // clear
            // 
            clear.Location = new Point(152, 236);
            clear.Name = "clear";
            clear.Size = new Size(90, 23);
            clear.TabIndex = 5;
            clear.Text = "Update record";
            clear.UseVisualStyleBackColor = true;
            clear.Click += button2_Click;
            // 
            // Add_Information
            // 
            Add_Information.Location = new Point(7, 236);
            Add_Information.Name = "Add_Information";
            Add_Information.Size = new Size(110, 23);
            Add_Information.TabIndex = 16;
            Add_Information.Text = "Add record";
            Add_Information.UseVisualStyleBackColor = true;
            Add_Information.Click += Add_Information_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "MN", "ND", "SD", "IA", "WI" });
            comboBox1.Location = new Point(131, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 135);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " between -22 F and 400F ";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(52, 167);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 173);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 9;
            label2.Text = "Date";
            // 
            // state
            // 
            state.AutoSize = true;
            state.Location = new Point(15, 93);
            state.Name = "state";
            state.Size = new Size(33, 15);
            state.TabIndex = 7;
            state.Text = "State";
            state.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 48);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
            // 
            // temp_in_F
            // 
            temp_in_F.AutoSize = true;
            temp_in_F.Location = new Point(3, 138);
            temp_in_F.Name = "temp_in_F";
            temp_in_F.Size = new Size(63, 15);
            temp_in_F.TabIndex = 4;
            temp_in_F.Text = "Temp(in F)";
            temp_in_F.Click += label1_Click_3;
            // 
            // City
            // 
            City.AutoSize = true;
            City.Location = new Point(15, 63);
            City.Name = "City";
            City.Size = new Size(28, 15);
            City.TabIndex = 1;
            City.Text = "City";
            City.Click += City_Click;
            // 
            // weather_information
            // 
            weather_information.AutoSize = true;
            weather_information.Location = new Point(12, 9);
            weather_information.Name = "weather_information";
            weather_information.Size = new Size(117, 15);
            weather_information.TabIndex = 2;
            weather_information.Text = "Weather Information";
            weather_information.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 328);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(Region);
            panel2.Controls.Add(Wi);
            panel2.Controls.Add(IA);
            panel2.Controls.Add(SD);
            panel2.Controls.Add(ND);
            panel2.Controls.Add(MN);
            panel2.Controls.Add(AvarageTemparature);
            panel2.Location = new Point(374, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 287);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(130, 237);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 11;
            textBox8.Text = "  32.65 F";
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(130, 190);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 10;
            textBox7.Text = "  25.28 F";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(130, 150);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 9;
            textBox6.Text = "  101.23 F";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(130, 114);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 5;
            textBox5.Text = " 98.30 F";
            textBox5.TextChanged += textBox5_TextChanged_1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(130, 73);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            textBox4.Text = "  -978 F";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 37);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            textBox3.Text = "    82.91 F\r\n";
            textBox3.TextChanged += textBox3_TextChanged_2;
            // 
            // Region
            // 
            Region.AutoSize = true;
            Region.Location = new Point(27, 245);
            Region.Name = "Region";
            Region.Size = new Size(44, 15);
            Region.TabIndex = 6;
            Region.Text = "Region";
            // 
            // Wi
            // 
            Wi.AutoSize = true;
            Wi.Location = new Point(30, 198);
            Wi.Name = "Wi";
            Wi.Size = new Size(21, 15);
            Wi.TabIndex = 5;
            Wi.Text = "WI";
            Wi.Click += label4_Click_3;
            // 
            // IA
            // 
            IA.AutoSize = true;
            IA.Location = new Point(33, 158);
            IA.Name = "IA";
            IA.Size = new Size(18, 15);
            IA.TabIndex = 4;
            IA.Text = "IA";
            IA.Click += IA_Click;
            // 
            // SD
            // 
            SD.AutoSize = true;
            SD.Location = new Point(33, 113);
            SD.Name = "SD";
            SD.Size = new Size(21, 15);
            SD.TabIndex = 3;
            SD.Text = "SD";
            SD.Click += label4_Click_2;
            // 
            // ND
            // 
            ND.AutoSize = true;
            ND.Location = new Point(30, 76);
            ND.Name = "ND";
            ND.Size = new Size(24, 15);
            ND.TabIndex = 2;
            ND.Text = "ND";
            ND.Click += label4_Click_1;
            // 
            // MN
            // 
            MN.AutoSize = true;
            MN.Location = new Point(25, 45);
            MN.Name = "MN";
            MN.Size = new Size(27, 15);
            MN.TabIndex = 1;
            MN.Text = "MN";
            // 
            // AvarageTemparature
            // 
            AvarageTemparature.AutoSize = true;
            AvarageTemparature.Location = new Point(3, 0);
            AvarageTemparature.Name = "AvarageTemparature";
            AvarageTemparature.Size = new Size(119, 15);
            AvarageTemparature.TabIndex = 0;
            AvarageTemparature.Text = "Avarage Temparature";
            AvarageTemparature.Click += label4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(64, 356);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(535, 154);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // find_record
            // 
            find_record.Location = new Point(251, 538);
            find_record.Name = "find_record";
            find_record.Size = new Size(95, 23);
            find_record.TabIndex = 13;
            find_record.Text = "find Record";
            find_record.UseVisualStyleBackColor = true;
            find_record.Click += find_record_Click;
            // 
            // remove_record
            // 
            remove_record.Location = new Point(377, 537);
            remove_record.Name = "remove_record";
            remove_record.Size = new Size(102, 23);
            remove_record.TabIndex = 14;
            remove_record.Text = "Remove Record";
            remove_record.UseVisualStyleBackColor = true;
            remove_record.Click += button1_Click;
            // 
            // show_records
            // 
            show_records.Location = new Point(511, 537);
            show_records.Name = "show_records";
            show_records.Size = new Size(93, 23);
            show_records.TabIndex = 15;
            show_records.Text = "show records";
            show_records.UseVisualStyleBackColor = true;
            show_records.Click += show_records_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(27, 538);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "enter record id to interract";
            textBox9.Size = new Size(165, 23);
            textBox9.TabIndex = 16;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // highest_temperature
            // 
            highest_temperature.Location = new Point(27, 588);
            highest_temperature.Name = "highest_temperature";
            highest_temperature.Size = new Size(131, 23);
            highest_temperature.TabIndex = 17;
            highest_temperature.Text = "Highest Temparature";
            highest_temperature.UseVisualStyleBackColor = true;
            highest_temperature.Click += button1_Click_1;
            // 
            // lowest_temp
            // 
            lowest_temp.Location = new Point(184, 588);
            lowest_temp.Name = "lowest_temp";
            lowest_temp.Size = new Size(130, 23);
            lowest_temp.TabIndex = 18;
            lowest_temp.Text = "Lowest Temparature";
            lowest_temp.UseVisualStyleBackColor = true;
            // 
            // remove_all
            // 
            remove_all.Location = new Point(377, 588);
            remove_all.Name = "remove_all";
            remove_all.Size = new Size(75, 23);
            remove_all.TabIndex = 19;
            remove_all.Text = "Remove All";
            remove_all.UseVisualStyleBackColor = true;
            remove_all.Click += remove_all_Click;
            // 
            // close
            // 
            close.Location = new Point(504, 584);
            close.Name = "close";
            close.Size = new Size(72, 24);
            close.TabIndex = 20;
            close.Text = "close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 649);
            Controls.Add(close);
            Controls.Add(remove_all);
            Controls.Add(lowest_temp);
            Controls.Add(highest_temperature);
            Controls.Add(textBox9);
            Controls.Add(show_records);
            Controls.Add(remove_record);
            Controls.Add(find_record);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(weather_information);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Forecast Form";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label City;
        private Label weather_information;
        private Label temp_in_F;
        private Label state;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Button Add_Information;
        private Button clear;
        private Label AvarageTemparature;
        private Label ND;
        private Label MN;
        private Label SD;
        private Label Wi;
        private Label IA;
        private Label Region;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private DataGridView dataGridView1;
        private Button find_record;
        private Button remove_record;
        private Button show_records;
        private TextBox textBox9;
        private Button highest_temperature;
        private Button lowest_temp;
        private Button remove_all;
        private Button close;
        private Label id;
        private TextBox textBox10;
        private ComboBox comboBox2;
    }
}