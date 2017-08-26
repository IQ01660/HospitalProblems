using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalProblemForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // initial Sectors 
            Sector onkology = new Sector("Onkology");
            Sector dermatology = new Sector("Dermatology");
            Sector surgery = new Sector("Surgery");
            foreach (var item in SectorHolder.sectors)
            {
                this.sectorRemoveSelector.Items.Add(item.Name);
                this.addingDoctorSectorSelector1.Items.Add(item.Name);
                this.removingDoctorSectorSelector.Items.Add(item.Name);
            }
        }
        // to add a sector
        private void addSectorBtn_Click(object sender, EventArgs e)
        {
            SectorHolder.sectors.Add(new Sector(this.sectorAddInput.Text));
            this.sectorRemoveSelector.Items.Add(this.sectorAddInput.Text);
            this.addingDoctorSectorSelector1.Items.Add(this.sectorAddInput.Text);
            this.removingDoctorSectorSelector.Items.Add(this.sectorAddInput.Text);
        }
        // to remove a sector
        private void sectorRemoveBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SectorHolder.sectors.Count; i++)
            {
                if (SectorHolder.sectors[i].Name == this.sectorRemoveSelector.SelectedItem.ToString())
                {
                    SectorHolder.sectors.Remove(SectorHolder.sectors[i]);
                }
            }
            this.sectorRemoveSelector.Items.Remove(this.sectorRemoveSelector.SelectedItem);
            // clearing all items from doctor sector selectors
            this.addingDoctorSectorSelector1.Items.Clear();
            this.removingDoctorSectorSelector.Items.Clear();
            // adding all necessary initial sector selectors
            foreach (var item in SectorHolder.sectors)
            {
                this.addingDoctorSectorSelector1.Items.Add(item.Name);
                this.removingDoctorSectorSelector.Items.Add(item.Name);
            }
        }
        // adding a doctor
        private void addDoctorBtn_Click(object sender, EventArgs e)
        {
            DoctorHolder.doctors.Add(new Doctor(this.addDoctorName.Text, this.addDoctorID.Text, this.addingDoctorSectorSelector1.SelectedItem.ToString()));
        }
        // selecting a field for a doctor
        private void removeDoctorBtn_Click(object sender, EventArgs e)
        {
            this.removingDoctorSelector.Items.Clear();
            foreach (var item in DoctorHolder.doctors)
            {
                if(item.FieldSector == this.removingDoctorSectorSelector.SelectedItem.ToString())
                {
                    this.removingDoctorSelector.Items.Add(item.Name);
                }
            }
        }
        // removing a doctor
        private void eventuallyRemoveDoctor_Click(object sender, EventArgs e)
        {
            for (int j =0;j < DoctorHolder.doctors.Count; j++)
            {
                if(DoctorHolder.doctors[j].Name == this.removingDoctorSectorSelector.SelectedIndex.ToString())
                DoctorHolder.doctors.Remove(DoctorHolder.doctors[j]);
            }
            this.removingDoctorSelector.Items.Remove(this.removingDoctorSelector.SelectedItem);
        }
    }
    // list of all sectors
    class SectorHolder
    {
        static public List<Sector> sectors = new List<Sector>();
    }
    // list of all doctors
    class DoctorHolder
    {
        static public List<Doctor> doctors = new List<Doctor>();
    }
    class Sector
    {
        public string Name;
        public Sector(string _name)
        {
            this.Name = _name;
            SectorHolder.sectors.Add(this);
        }
    }
    class Doctor
    {
        public string Name;
        public string ID;
        public string FieldSector;
        public Doctor(string _name , string _id , string _field)
        {
            this.Name = _name;
            this.ID = _id;
            this.FieldSector = _field;
          
        }
    }
}
