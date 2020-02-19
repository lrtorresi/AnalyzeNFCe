using AnalyzeNFC_e.Model;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;
using AnalyzeNFC_e.Services;
using AnalyzeNFC_e.Forms;

namespace AnalyzeNFC_e
{
    public partial class Form1 : Form
    {
        public bool validaPlugins = false;
        public bool validaPortal = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcurar1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Multiselect = false;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = Path.GetFileName(openFileDialog1.FileName);
                    string filePath = openFileDialog1.FileName;
                    lblPath.Visible = true;
                    erro1.Visible = false;
                    txtBox1.Text = filePath;

                    var importar = new Importar();
                    importar.UploadXLSOrchestra(filePath);
                    check1.Visible = true;
                    validaPlugins = true;
                }
                else
                {
                    MessageBox.Show("Selecione um arquivo!", "AnalyzeNFC_e", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    erro1.Visible = true;
                    validaPlugins = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao executar a função \nTente novamente em alguns segundos.", "AnalyzeNFC_e", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro1.Visible = true;
                validaPlugins = false;
            }
        }

        private void btnProcurar2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Multiselect = false;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string fileName = Path.GetFileName(openFileDialog1.FileName);
                    string filePath = openFileDialog1.FileName;
                    lblPath2.Visible = true;
                    error2.Visible = false;
                    txtBox2.Text = filePath;

                    var importar = new Importar();
                    importar.UploadXLSMigrate(filePath);
                    check2.Visible = true;
                    validaPortal = true;
                }
                else
                {
                    MessageBox.Show("Selecione um arquivo!", "AnalyzeNFC_e", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error2.Visible = true;
                    validaPortal = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao executar a função \nTente novamente em alguns segundos.", "AnalyzeNFC_e", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validaPortal = false;
                error2.Visible = true;
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (validaPortal == true && validaPlugins == true)
            {
                var FrmCompare = new Form2();
                FrmCompare.ShowDialog();
            }
            else
            {
                MessageBox.Show($"Os arquivos não foram validados com sucesso! \nVerique os arquivos e tente novamente em alguns segundos.", "AnalyzeNFC_e", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

