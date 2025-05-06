using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Angelica Bell
 * allows user to upload a csv 
 * file is displayed in datagrid 
 * after confirmation of changes CSV is added to database 
 */
namespace AttendanceUtility
{
    public partial class csv : Form
    {
        private string filePath;
        private Database dbobject;
        private DataTable csvTable = new DataTable();
        public csv(Database dbobject)
        {
            this.dbobject = dbobject;
            InitializeComponent();
        }

        private void csvUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openCSV = new OpenFileDialog();
            //processes CSV bASEED ON TAB DELIMITING
            if (openCSV.ShowDialog() == DialogResult.OK)
            {
                filePath = openCSV.FileName;
                string[] data = File.ReadAllLines(filePath);
                string[] fields;
                fields = data[0].Split(new char[] { '\t' });
                int col = fields.GetLength(0);

                for (int i = 0; i < col; i++)
                {
                    csvTable.Columns.Add(fields[i].ToLower(), typeof(String));

                }
                DataRow row;
                for (int i = 1; i < data.GetLength(0); i++)
                {
                    fields = data[i].Split(new char[] { '\t' });
                    row = csvTable.NewRow();
                    for (int x = 0; x < col; x++)
                    {
                        row[x] = fields[x];
                    }
                    csvTable.Rows.Add(row);
                }
                AttendanceDataGrid.DataSource = csvTable;
                confirmChanges.Visible = true;

            }
        }

        //asks yser for confirmation
        private void confirmChanges_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show(
                "Confirming will add students to your class",
                "Confirm Change",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                dbobject.insertAttendenceRec(csvTable);

            }
            else
            {
                confirmChanges.Visible = false;
            }

        }

        private void csv_Load(object sender, EventArgs e)
        {

        }
    }
}
