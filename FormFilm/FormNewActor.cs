using FormFilm.DataAcces;
using FormFilm.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFilm
{
    public partial class FormNewActor : Form
    {
        public FormNewActor()
        {
            InitializeComponent();
            InitcmbNationality();
        }

        public void InitcmbNationality()
        {
            cmbNationality.DisplayMember = "Text";
            cmbNationality.ValueMember = "Value";

            List<object> DataNationality = new List<object>()
            {
                new { Text = "Française", Value = "Française"},
                new { Text = "Américaine", Value = "Américaine" }
            };

            cmbNationality.DataSource = DataNationality;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Actor actor = new Actor()
            {
                Name = txtbName.Text,
                FirstName = txtbFirstName.Text,
                Nationality = cmbNationality.SelectedValue.ToString(),
                DateOfBirth = txtbDateOfBirth.Text
            };

            ActorDAO.Insert(actor);

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
