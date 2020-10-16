using FormFilm.DataAcces;
using FormFilm.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFilm
{
    public partial class Form1 : Form
    {
        public List<Film> ListFilm { get; set; }
        public List<Actor> ListActor { get; set; }

        public Form1()
        {
            InitializeComponent();
            InitCmbChoiceDiplay();
            DisplayDVG();
        }

        public void InitCmbChoiceDiplay()
        {
            cmbChoiceDisplay.DisplayMember = "Text";
            cmbChoiceDisplay.ValueMember = "Value";

            List<object> DataChoiceDisplay = new List<object>()
            {
                new { Text = "Films", Value = "Films"},
                new { Text = "Actors", Value = "Actors" }
            };

            cmbChoiceDisplay.DataSource = DataChoiceDisplay;
        }

        public void DisplayDVG()
        {
            switch (cmbChoiceDisplay.SelectedValue)
            {
                case "Films":
                    List<Film> listFilm = FilmDAO.FindAll();
                    dgvData.DataSource = listFilm;
                    break;

                case "Actors":
                    List<Actor> listActor = ActorDAO.FindAll();
                    dgvData.DataSource = listActor;
                    break;
            }
            
        }

        private void cmbChoiceDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDVG();
        }

        private void NewActorMenu_Click(object sender, EventArgs e)
        {
            FormNewActor formActor = new FormNewActor();
            formActor.ShowDialog();

            if (formActor.DialogResult == DialogResult.OK) DisplayDVG();
        }
    }
}
