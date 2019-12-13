using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TietokoneWindowsForms
{
    public partial class Form1 : Form
    {
        ServiceReference1.ServiceClient obj = new ServiceReference1.ServiceClient();
        public Form1()
        {
            InitializeComponent();
            UpdateCPUBrands();
            UpdateGPUSeries();
            UpdateMOBOBrands();
            UpdateRAMBrands();
            UpdatePSUBrands();
            UpdateCaseBrands();
            dsComputers = UpdateComputersFromDatabase();
        }

        private void clearAll() // Clears all info
        {
            //CPU
            comboBoxCPUBrand.ResetText();
            comboBoxCPUModel.ResetText();
            labelCPUCores.ResetText();
            labelCPUThreads.ResetText();
            labelCPUClockSpeed.ResetText();
            labelCPUID.ResetText();

            //GPU
            comboBoxGPUSeries.ResetText();
            comboBoxGPU.ResetText();
            labelGPUID.ResetText();

            //MOBO
            comboBoxMOBOBrand.ResetText();
            comboBoxMOBOModel.ResetText();
            labelMOBOID.ResetText();

            //RAM
            comboBoxRAMBrand.ResetText();
            comboBoxRAMModel.ResetText();
            textBoxRAMAmount.ResetText();
            labelRAMID.ResetText();

            //PSU
            comboBoxPSUBrand.ResetText();
            comboBoxPSUModel.ResetText();
            labelPSUPower.ResetText();
            labelPSUID.ResetText();

            //CASE
            comboBoxCaseBrand.ResetText();
            comboBoxCaseModel.ResetText();
            labelCaseID.ResetText();

            //COMPUTER
            labelComputerID.ResetText();
            CurrentID = -1;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void buttonSaveAsNew_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference1.ComputerDetails computerDetails = new ServiceReference1.ComputerDetails();
                computerDetails.GPUID = Convert.ToInt32(labelGPUID.Text);
                computerDetails.CPUID = Convert.ToInt32(labelCPUID.Text);
                computerDetails.MOBOID = Convert.ToInt32(labelMOBOID.Text);
                computerDetails.RAMID = Convert.ToInt32(labelRAMID.Text);
                computerDetails.RAMamount = Convert.ToInt32(textBoxRAMAmount.Text);
                computerDetails.PSUID = Convert.ToInt32(labelPSUID.Text);
                computerDetails.CASEID = Convert.ToInt32(labelCaseID.Text);
                obj.InsertComputerDetails(computerDetails);

                dsComputers = UpdateComputersFromDatabase();

                MessageBox.Show("Information saved successfully!", "Save complete!");
            }
            catch
            {
                MessageBox.Show("There was an error", "Error");
            }
        }

        private DataSet UpdateComputersFromDatabase()
        {
            DataSet dsComputers = new DataSet();
            dsComputers = obj.SelectAllComputers();
            dataGridView1.DataSource = dsComputers.Tables[0];
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            return dsComputers;
        }


        //CPU

        private void UpdateCPUBrands()
        {
            DataSet dsDisCPU = new DataSet();
            dsDisCPU = obj.SelectAllDistinctFromCPU();

            dataGridView1.DataSource = dsDisCPU.Tables[0];
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            comboBoxCPUBrand.DataSource = dsDisCPU.Tables[0];
            comboBoxCPUBrand.DisplayMember = "Merkki";
            comboBoxCPUBrand.ValueMember = "Merkki";
        }

        private void comboBoxCPUBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsCpuModelsByBrand = new DataSet();

            dsCpuModelsByBrand = obj.SelectAllByBrandCPU(comboBoxCPUBrand.Text);
            dataGridView1.DataSource = dsCpuModelsByBrand.Tables[0];

            comboBoxCPUModel.DataSource = dsCpuModelsByBrand.Tables[0];
            comboBoxCPUModel.DisplayMember = "Prosessori";
            comboBoxCPUModel.ValueMember = "Id";
        }

        private void comboBoxCPUModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsCpuById = new DataSet();
            dsCpuById = obj.SelectByIdFromCPU(Convert.ToInt32(comboBoxCPUModel.SelectedValue));
            labelCPUID.Text = comboBoxCPUModel.SelectedValue.ToString();
            labelCPUCores.Text = Convert.ToString(dsCpuById.Tables[0].Rows[0].Field<byte>(3));
            labelCPUThreads.Text = Convert.ToString(dsCpuById.Tables[0].Rows[0].Field<byte>(4));
            labelCPUClockSpeed.Text = Convert.ToString(dsCpuById.Tables[0].Rows[0].Field<decimal>(5) + " GHz");
        }


        //GPU

        private void UpdateGPUSeries()
        {
            DataSet dsDisGPU = new DataSet();
            dsDisGPU = obj.SelectAllDistinctFromGPU();

            dataGridView1.DataSource = dsDisGPU.Tables[0];
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            comboBoxGPUSeries.DataSource = dsDisGPU.Tables[0];
            comboBoxGPUSeries.DisplayMember = "Sarja";
            comboBoxGPUSeries.ValueMember = "Sarja";
        }

        private void comboBoxGPUSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsGpuModelsBySeries = new DataSet();

            dsGpuModelsBySeries = obj.SelectAllBySeriesGPU(comboBoxGPUSeries.Text);
            dataGridView1.DataSource = dsGpuModelsBySeries.Tables[0];

            comboBoxGPU.DataSource = dsGpuModelsBySeries.Tables[0];
            comboBoxGPU.DisplayMember = "GraphicsCard";
            comboBoxGPU.ValueMember = "Id";
        }

        private void comboBoxGPU_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelGPUID.Text = comboBoxGPU.SelectedValue.ToString();
        }


        //MOBO

        private void UpdateMOBOBrands()
        {
            DataSet dsDisMOBO = new DataSet();
            dsDisMOBO = obj.SelectAllDistinctFromMOBO();

            dataGridView1.DataSource = dsDisMOBO.Tables[0];
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            comboBoxMOBOBrand.DataSource = dsDisMOBO.Tables[0];
            comboBoxMOBOBrand.DisplayMember = "Merkki";
            comboBoxMOBOBrand.ValueMember = "Merkki";
        }

        private void comboBoxMOBOBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsMoboModelsByBrand = new DataSet();

            dsMoboModelsByBrand = obj.SelectAllByBrandMOBO(comboBoxMOBOBrand.Text);
            dataGridView1.DataSource = dsMoboModelsByBrand.Tables[0];

            comboBoxMOBOModel.DataSource = dsMoboModelsByBrand.Tables[0];
            comboBoxMOBOModel.DisplayMember = "Malli";
            comboBoxMOBOModel.ValueMember = "Id";
        }

        private void comboBoxMOBOModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelMOBOID.Text = comboBoxMOBOModel.SelectedValue.ToString();

        }


        //RAM

        private void UpdateRAMBrands()
        {
            DataSet dsDisRam = new DataSet();
            dsDisRam = obj.SelectAllDistinctFromRAM();

            dataGridView1.DataSource = dsDisRam.Tables[0];
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            comboBoxRAMBrand.DataSource = dsDisRam.Tables[0];
            comboBoxRAMBrand.DisplayMember = "Merkki";
            comboBoxRAMBrand.ValueMember = "Merkki";
        }

        private void comboBoxRAMBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds = obj.SelectAllByBrandRAM(comboBoxRAMBrand.Text);
            dataGridView1.DataSource = ds.Tables[0];

            comboBoxRAMModel.DataSource = ds.Tables[0];
            comboBoxRAMModel.DisplayMember = "ClockSpeedMHZ";
            comboBoxRAMModel.ValueMember = "Id";
        }

        private void comboBoxRAMModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelRAMID.Text = comboBoxRAMModel.SelectedValue.ToString();
        }

        //PSU

        private void UpdatePSUBrands()
        {
            DataSet ds = new DataSet();
            ds = obj.SelectAllDistinctFromPSU();

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            comboBoxPSUBrand.DataSource = ds.Tables[0];
            comboBoxPSUBrand.DisplayMember = "Merkki";
            comboBoxPSUBrand.ValueMember = "Merkki";
        }

        private void comboBoxPSUBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds = obj.SelectAllByBrandPSU(comboBoxPSUBrand.Text);
            dataGridView1.DataSource = ds.Tables[0];

            comboBoxPSUModel.DataSource = ds.Tables[0];
            comboBoxPSUModel.DisplayMember = "Malli";
            comboBoxPSUModel.ValueMember = "Id";
        }

        private void comboBoxPSUModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = obj.SelectPowerByIdFromPSU(Convert.ToInt32(comboBoxPSUModel.SelectedValue));
            labelPSUID.Text = comboBoxPSUModel.SelectedValue.ToString();
            labelPSUPower.Text = Convert.ToString(ds.Tables[0].Rows[0].Field<int>(0) + " W");
        }

        //Case

        private void UpdateCaseBrands()
        {
            DataSet ds = new DataSet();
            ds = obj.SelectAllDistinctFromCase();

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            comboBoxCaseBrand.DataSource = ds.Tables[0];
            comboBoxCaseBrand.DisplayMember = "Merkki";
            comboBoxCaseBrand.ValueMember = "Merkki";
        }

        private void comboBoxCaseBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds = obj.SelectAllByBrandCase(comboBoxCaseBrand.Text);
            dataGridView1.DataSource = ds.Tables[0];

            comboBoxCaseModel.DataSource = ds.Tables[0];
            comboBoxCaseModel.DisplayMember = "Malli";
            comboBoxCaseModel.ValueMember = "Id";
        }

        private void comboBoxCaseModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCaseID.Text = comboBoxCaseModel.SelectedValue.ToString();
        }

        DataSet dsComputers;
        int CurrentID = -1;

        private void Form1_Activated(object sender, EventArgs e)
        {
            clearAll();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            CurrentID++;

            if (CurrentID >= dsComputers.Tables[0].Rows.Count)
            {
                CurrentID = 0;
            }

            labelComputerID.Text = dsComputers.Tables[0].Rows[CurrentID].Field<int>(0).ToString();

            comboBoxCPUBrand.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(4);
            comboBoxCPUModel.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(5);

            comboBoxGPUSeries.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(1);
            comboBoxGPU.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(2);

            comboBoxMOBOBrand.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(10);
            comboBoxMOBOModel.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(11);

            comboBoxRAMBrand.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(13);
            comboBoxRAMModel.Text = dsComputers.Tables[0].Rows[CurrentID].Field<int>(14).ToString();
            textBoxRAMAmount.Text = dsComputers.Tables[0].Rows[CurrentID].Field<int>(15).ToString();

            comboBoxCaseBrand.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(17);
            comboBoxCaseModel.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(18);

            comboBoxPSUBrand.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(20);
            comboBoxPSUModel.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(21);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            CurrentID--;

            if (CurrentID == -1)
            {
                CurrentID = dsComputers.Tables[0].Rows.Count-1;
            }

            labelComputerID.Text = dsComputers.Tables[0].Rows[CurrentID].Field<int>(0).ToString();

            comboBoxCPUBrand.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(4);
            comboBoxCPUModel.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(5);

            comboBoxGPUSeries.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(1);
            comboBoxGPU.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(2);

            comboBoxMOBOBrand.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(10);
            comboBoxMOBOModel.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(11);

            comboBoxRAMBrand.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(13);
            comboBoxRAMModel.Text = dsComputers.Tables[0].Rows[CurrentID].Field<int>(14).ToString();
            textBoxRAMAmount.Text = dsComputers.Tables[0].Rows[CurrentID].Field<int>(15).ToString();

            comboBoxCaseBrand.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(17);
            comboBoxCaseModel.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(18);

            comboBoxPSUBrand.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(20);
            comboBoxPSUModel.Text = dsComputers.Tables[0].Rows[CurrentID].Field<string>(21);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = obj.DeleteComputerById(Convert.ToInt32(labelComputerID.Text));
                MessageBox.Show(msg, "!");
                dsComputers = UpdateComputersFromDatabase();
            }
            catch
            {
                MessageBox.Show("Error", "!");
            }
        }
    }
}