using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistic_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transportation.Senders' table. You can move, or remove it, as needed.
            this.sendersTableAdapter.Fill(this.transportation.Senders);
            // TODO: This line of code loads data into the 'transportation.Stations' table. You can move, or remove it, as needed.
            this.stationsTableAdapter.Fill(this.transportation.Stations);
            // TODO: This line of code loads data into the 'transportation.Transports' table. You can move, or remove it, as needed.
            this.transportsTableAdapter.Fill(this.transportation.Transports);
            // TODO: This line of code loads data into the 'transportation.Cargoes' table. You can move, or remove it, as needed.
            this.cargoesTableAdapter.Fill(this.transportation.Cargoes);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cargoesTableAdapter.FillBy(this.transportation.Cargoes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.cargoesTableAdapter.FillBy(this.transportation.Cargoes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.transportsTableAdapter.FillBy(this.transportation.Transports);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void CargoNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddCargo addCargo = new AddCargo();
            addCargo.ShowDialog();
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddStation addStation = new AddStation();
            addStation.ShowDialog();
        }
    }
}
