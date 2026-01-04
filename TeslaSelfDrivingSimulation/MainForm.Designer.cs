namespace TeslaSelfDrivingSimulation
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBattery = new System.Windows.Forms.TextBox();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.listBoxAlerts = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(170, 52);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(206, 33);
            this.txtId.TabIndex = 0;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "CarID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Range(km)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBattery
            // 
            this.txtBattery.Location = new System.Drawing.Point(170, 165);
            this.txtBattery.Name = "txtBattery";
            this.txtBattery.Size = new System.Drawing.Size(206, 33);
            this.txtBattery.TabIndex = 3;
            // 
            // txtPriority
            // 
            this.txtPriority.Location = new System.Drawing.Point(170, 229);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(206, 33);
            this.txtPriority.TabIndex = 4;
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(170, 107);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(206, 33);
            this.txtRange.TabIndex = 5;
            this.txtRange.TextChanged += new System.EventHandler(this.txtRange_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Priority(1-10)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Battery(%)";
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.Sienna;
            this.btnAddCar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCar.Location = new System.Drawing.Point(86, 509);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(213, 74);
            this.btnAddCar.TabIndex = 8;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click_1);
            // 
            // btnSimulate
            // 
            this.btnSimulate.BackColor = System.Drawing.Color.Sienna;
            this.btnSimulate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulate.ForeColor = System.Drawing.Color.White;
            this.btnSimulate.Location = new System.Drawing.Point(38, 619);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(305, 86);
            this.btnSimulate.TabIndex = 9;
            this.btnSimulate.Text = "Simulate Incident";
            this.btnSimulate.UseVisualStyleBackColor = false;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click_1);
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCars.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(527, 165);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.ReadOnly = true;
            this.dataGridViewCars.RowHeadersWidth = 62;
            this.dataGridViewCars.RowTemplate.Height = 28;
            this.dataGridViewCars.Size = new System.Drawing.Size(547, 456);
            this.dataGridViewCars.TabIndex = 10;
            // 
            // listBoxAlerts
            // 
            this.listBoxAlerts.BackColor = System.Drawing.Color.FloralWhite;
            this.listBoxAlerts.FormattingEnabled = true;
            this.listBoxAlerts.ItemHeight = 20;
            this.listBoxAlerts.Location = new System.Drawing.Point(1167, 165);
            this.listBoxAlerts.Name = "listBoxAlerts";
            this.listBoxAlerts.Size = new System.Drawing.Size(481, 444);
            this.listBoxAlerts.TabIndex = 11;
            this.listBoxAlerts.SelectedIndexChanged += new System.EventHandler(this.listBoxAlerts_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(398, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(811, 46);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tesla Autonomous Vehicle Control Panel";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRange);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBattery);
            this.groupBox1.Controls.Add(this.txtPriority);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 323);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(603, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(326, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "Active Fleet Monitoring";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(1257, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(312, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mission Control Alerts";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(32, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 33);
            this.label8.TabIndex = 16;
            this.label8.Text = "Vehicle Configaration";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeslaSelfDrivingSimulation.Properties.Resources.Screenshot_2026_01_04_163820;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1704, 742);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxAlerts);
            this.Controls.Add(this.dataGridViewCars);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.btnAddCar);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBattery;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.DataGridView dataGridViewCars;
        private System.Windows.Forms.ListBox listBoxAlerts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

