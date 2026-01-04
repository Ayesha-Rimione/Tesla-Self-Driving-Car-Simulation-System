using System;
using System.Windows.Forms;
using TeslaSelfDrivingSimulation.Controllers;
using TeslaSelfDrivingSimulation.Models;

namespace TeslaSelfDrivingSimulation
{
    public partial class MainForm : Form
    {
        FleetController controller = new FleetController();

        public MainForm()
        {
            InitializeComponent();
            controller.OnAlert += message =>
            {
                listBoxAlerts.Items.Add($"{DateTime.Now}: {message}");
            };
        }

        private void btnSimulate_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewCars.CurrentRow == null) return;

            AutonomousCar car =
                (AutonomousCar)dataGridViewCars.CurrentRow.DataBoundItem;

            controller.SimulateIncident(car);
            dataGridViewCars.Refresh();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnAddCar_Click_1(object sender, EventArgs e)
        {
            try
            {
                AutonomousCar car = new AutonomousCar
                {
                    CarId = txtId.Text,
                    RangeKm = double.Parse(txtRange.Text),
                    BatteryPercentage = int.Parse(txtBattery.Text),
                    MissionPriority = int.Parse(txtPriority.Text),
                    Status = CarStatus.InMission
                };

                controller.AddCar(car);

                dataGridViewCars.DataSource = null;
                dataGridViewCars.DataSource = controller.GetActiveCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRange_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBoxAlerts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
