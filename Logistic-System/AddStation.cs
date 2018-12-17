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
    public partial class AddStation : Form
    {
        public AddStation()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            stationsTableAdapter1.InsertQuery(textName.Text);
            Transportation transportation = new Transportation();
            ((ISupportInitialize)(transportation)).BeginInit();
            transportation.DataSetName = "Transportation";
            transportation.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            ((ISupportInitialize)(transportation)).EndInit();
            stationsTableAdapter1.Update(transportation);
            transportation.AcceptChanges();
        }
    }
}
