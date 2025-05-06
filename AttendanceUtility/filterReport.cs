using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* 
 Angelica Bell
allows users to select filter's and generate attendence form based on the filters 
allows ysers to filter based on > 3 consecutive absences, > X number of total abcenses, and a date range
 
 */
namespace AttendanceUtility
{

    public partial class filterReport : Form
    {   //flags for what filter is selected 
        //flag for full report
        public bool fullReport = true;
        //flag for  > 3 consecutive absences report 
        public bool conAb = false;
        //flag for X number of total abcenses
        public bool moreAb = false;
        //X where > X  number of total abcenses
        public int abMin = 0;
        private Database dbobject;
        private int courseId;
        public double numWeeks;
        public double numDays;
        public DateTime semesterStart;
        public DateTime semesterEnd;

        public filterReport(Database dbobject, int profId)
        {
            InitializeComponent();
            fullRep.Checked = true;
            this.dbobject = dbobject;
            this.courseId = profId;

            semesterStart = dbobject.getSemStart(this.courseId);
            semesterEnd = dbobject.getSemEnd(this.courseId);
            //date range must be in semester start-end
            endDate.MaxDate = semesterEnd;
            endDate.Value = semesterEnd;
            endDate.MinDate = semesterStart;
            startDate.MaxDate = semesterEnd;
            startDate.Value = semesterStart;
            startDate.MinDate = semesterStart;
            //calulating number of total class days, X number of total abcenses X cant be set higer than total class days 
            numWeeks = (semesterEnd - semesterStart).TotalDays / 7;
            numDays = dbobject.countClassDays(courseId);

            numAb.Maximum = (decimal)((numWeeks) * numDays);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //saving user inputed absences for  X number of total abcenses filter
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            abMin = (int)numAb.Value;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //filters are mutual exclusive
        private void fullRep_CheckedChanged(object sender, EventArgs e)
        {
            if ((fullRep.Checked && threeAb.Checked) || (fullRep.Checked && cusAb.Checked))
            {
                threeAb.Checked = false;
                cusAb.Checked = false;
                fullReport = true;
                conAb = false;
                moreAb = false;
            }

        }
        //filters are mutual exclusive
        private void threeAb_CheckedChanged(object sender, EventArgs e)
        {
            if ((threeAb.Checked && fullRep.Checked) || (threeAb.Checked && cusAb.Checked))
            {
                fullRep.Checked = false;
                cusAb.Checked = false;
                fullReport = false;
                conAb = true;
                moreAb = false;
            }
        }
        //filters are mutual exclusive
        private void cusAb_CheckedChanged(object sender, EventArgs e)
        {
            if ((cusAb.Checked && fullRep.Checked) || (cusAb.Checked && threeAb.Checked))
            {
                fullRep.Checked = false;
                cusAb.Checked = false;
                fullReport = false;
                conAb = false;
                moreAb = true;
            }
        }

        //when cancel button is clicked form closes
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //when generate button is clicked, form is generated 
        private void generateButton_Click(object sender, EventArgs e)
        {
            //if no filters selected, full report is generated 
            if(!conAb && !moreAb && !fullReport)
            {
                fullReport = true;
                abMin = 0;
            }
            DataSet dataSet = dbobject.attendanceReport(courseId, fullReport, conAb, moreAb, abMin, semesterStart, semesterEnd);
            if (dataSet.Tables.Count > 0)
                gridDetails.DataSource = dataSet.Tables[0];
            if (dataSet.Tables.Count > 1)
                gridSummary.DataSource = dataSet.Tables[1];
            //filter selections made invisible
            fullRep.Visible = false;
            threeAb.Visible = false;
            cusAb.Visible = false;
            numAb.Visible = false;
            dateRange.Visible = false;
            startDate.Visible = false;
            endDate.Visible = false;
            cancel.Visible = false;
            generate.Visible = false;
            reportFilter.Text = "Report.";
            gridDetails.Visible = true;
            gridSummary.Visible = true;
        }
    }
}
