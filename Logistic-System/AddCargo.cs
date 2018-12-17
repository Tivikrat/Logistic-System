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
    public partial class AddCargo : Form
    {
        public AddCargo()
        {
            InitializeComponent();
        }

        private void AddCargo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transportation.Stations' table. You can move, or remove it, as needed.
            this.stationsTableAdapter.Fill(this.transportation.Stations);
            // TODO: This line of code loads data into the 'transportation.Senders' table. You can move, or remove it, as needed.
            this.sendersTableAdapter.Fill(this.transportation.Senders);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            cargoesTableAdapter1.InsertQuery((int)comboSender.SelectedValue, (int)comboDeparture.SelectedValue, (int)comboArrival.SelectedValue, (float)numericWorth.Value, 0);
            cargoesTableAdapter1.Update(transportation.Cargoes);
        }
    }
}
