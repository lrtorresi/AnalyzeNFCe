using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace AnalyzeNFC_e.Services
{
    public class Importar
    {
        //connectString
        public static string consString = "Data Source=dev.mdc.com.br;Initial Catalog=NFCe;User Id=sa;Password=mdcvault!";


        private void UploadCSV(string FilePath)
        {
            //CSV
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + Path.GetDirectoryName(FilePath) + "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\"");
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM " + Path.GetFileName(FilePath), conn);
            DataSet ds = new DataSet("Temp");
            adapter.Fill(ds);
            DataTable tb = ds.Tables[0];

            //Gravar no BD
            string consString = "Data Source=(local);Initial Catalog=NFCe;User Id=sa;Password=Chrisrod12345";
            using (SqlConnection con = new SqlConnection(consString))
            {
                using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                {
                    //Set the database table name.
                    sqlBulkCopy.DestinationTableName = "dbo.plugins";
                    con.Open();
                    sqlBulkCopy.WriteToServer(tb);
                    con.Close();
                }
            }
        }

        public void UploadXLSOrchestra(string filePath)
        {
            string constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;""", filePath);
            OleDbConnection Econ = new OleDbConnection(constr);
            SqlConnection con = new SqlConnection(consString);
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            da = new SqlDataAdapter("truncate table plugins", con);
            da.Fill(ds);

            string Query = string.Format("Select * FROM [{0}]", "Sheet1$");
            OleDbCommand Ecom = new OleDbCommand(Query, Econ);
            Econ.Open();

            
            OleDbDataAdapter oda = new OleDbDataAdapter(Query, Econ);
            Econ.Close();//close Excel connection after adding to data set  
            oda.Fill(ds);
            DataTable Exceldt = ds.Tables[0]; //copy data set to datatable
            da.Fill(ds);
            //creating object of SqlBulkCopy      
            SqlBulkCopy objbulk = new SqlBulkCopy(con);
            //assigning Destination table name      
            objbulk.DestinationTableName = "plugins";
            //Mapping Table column    
            //objbulk.ColumnMappings.Add("[serie]", "serie");
            //objbulk.ColumnMappings.Add("nf", "nf");
            //objbulk.ColumnMappings.Add("Date", "Date");
            //objbulk.ColumnMappings.Add("Value", "Value");  

            con.Open(); //Open DataBase conection

            objbulk.WriteToServer(Exceldt); //inserting Datatable Records to DataBase con.Close(); //Close DataBase conection  
            Econ.Close();
        }

        public void UploadXLSMigrate(string filePath)
        {
            string constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;""", filePath);
            OleDbConnection Econ = new OleDbConnection(constr);
            SqlConnection con = new SqlConnection(consString);
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            da = new SqlDataAdapter("truncate table portal", con);
            da.Fill(ds);

            string Query = string.Format("Select *  FROM [{0}]", "Sheet1$");
            OleDbCommand Ecom = new OleDbCommand(Query, Econ);
            Econ.Open();


            OleDbDataAdapter oda = new OleDbDataAdapter(Query, Econ);
            Econ.Close();//close Excel connection after adding to data set  
            oda.Fill(ds);
            DataTable Exceldt = ds.Tables[0]; //copy data set to datatable
            da.Fill(ds);
            //creating object of SqlBulkCopy      
            SqlBulkCopy objbulk = new SqlBulkCopy(con);
            //assigning Destination table name      
            objbulk.DestinationTableName = "portal";
            //Mapping Table column    
            objbulk.ColumnMappings.Add("[Número]", "nf");
            objbulk.ColumnMappings.Add("Série", "serie");
            //objbulk.ColumnMappings.Add("Date", "Date");
            //objbulk.ColumnMappings.Add("Value", "Value");  

            con.Open(); //Open DataBase conection

            objbulk.WriteToServer(Exceldt); //inserting Datatable Records to DataBase con.Close(); //Close DataBase conection  
            Econ.Close();
        }
    }
}
