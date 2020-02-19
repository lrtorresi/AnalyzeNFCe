using AnalyzeNFC_e.Modal;
using AnalyzeNFC_e.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalyzeNFC_e.Forms
{
    public partial class Form2 : Form
    {
        static string connectionstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            #region Plugins
            //Força entrar na aba1
            tabControl1.SelectTab("tabPage1");

            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            var query = con.Query<Plugins>("SELECT portal.serie, portal.nf, plugins.serie as SerieMIgrate, plugins.nf as NfMigrate FROM portal left join plugins on portal.serie = plugins.serie and portal.nf = plugins.nf order by plugins.nf").ToList();

            List<Plugins> portal = new List<Plugins>();
            ListViewItem lvwPlugins;
            foreach (Plugins item in query)
            {
                lvwPlugins = new ListViewItem(item.serie);
                lvwPlugins.SubItems.Add(item.nf);
                if (item.SerieMIgrate == null)
                {
                    item.SerieMIgrate = "Não Existe";
                    item.NfMigrate = "Não Existe";
                    lvwPlugins.SubItems.Add(item.SerieMIgrate);
                    lvwPlugins.SubItems.Add(item.NfMigrate);
                }
                else
                {
                    lvwPlugins.SubItems.Add(item.SerieMIgrate);
                    lvwPlugins.SubItems.Add(item.NfMigrate);
                }

                pluginsView.Items.Add(lvwPlugins);
            }
            lblTotalPlugins.Text = $"Total de registros: {query.Count.ToString()}";
            con.Close();
            #endregion

            #region MIGRATE
            con.Open();
            var query2 = con.Query<Migrate>("SELECT plugins.serie, plugins.nf, portal.serie as SeriePortal, portal.nf as NfPortal FROM plugins left join portal on plugins.serie = portal.serie and plugins.nf = portal.nf order by portal.nf").ToList();

            List<Migrate> migrate = new List<Migrate>();
            ListViewItem lvwMigrate;
            foreach (Migrate item in query2)
            {
                lvwMigrate = new ListViewItem(item.serie);
                lvwMigrate.SubItems.Add(item.nf);
                if (item.SeriePortal == null)
                {
                    item.SeriePortal = "Não Existe";
                    item.NfPortal = "Não Existe";
                    lvwMigrate.SubItems.Add(item.SeriePortal);
                    lvwMigrate.SubItems.Add(item.NfPortal);
                }
                else
                {
                    lvwMigrate.SubItems.Add(item.SeriePortal);
                    lvwMigrate.SubItems.Add(item.NfPortal);
                }
                migrateView.Items.Add(lvwMigrate);
            }
            lblTotalMigrate.Text = $"Total de registros: {query2.Count.ToString()}";
            con.Close();
            #endregion
        }
    }
}
