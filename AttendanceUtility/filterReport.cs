using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceUtility
{

    public partial class filterReport : Form
    {
        public bool fullReport = true;
        public bool conAb = false;
        public bool moreAb = false;
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
            endDate.MaxDate = semesterEnd;
            endDate.Value = semesterEnd;
            endDate.MinDate = semesterStart;
            startDate.MaxDate = semesterEnd;
            startDate.Value = semesterStart;
            startDate.MinDate = semesterStart;
            numWeeks = (semesterEnd - semesterStart).TotalDays / 7;
            numDays = dbobject.countClassDays(courseId);

            numAb.Maximum = (decimal)((numWeeks)*numDays);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            abMin = (int)numAb.Value;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void TodayButton_Click(object sender, EventArgs e)
        {
            DataSet dataSet = dbobject.attendanceReport(courseId, fullReport, conAb, moreAb, abMin, semesterStart, semesterEnd);
            if(dataSet.Tables.Count > 0)
                gridDetails.DataSource = dataSet.Tables[0];
            if (dataSet.Tables.Count > 1)
                gridSummary.DataSource = dataSet.Tables[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void fullRep_CheckedChanged(object sender, EventArgs e)
        {
            if((fullRep.Checked && threeAb.Checked ) || (fullRep.Checked && cusAb.Checked))
            {
                threeAb.Checked = false;
                cusAb.Checked = false;
                fullReport = true;
                conAb = false;
                moreAb = false;
            }

        }

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
    }
}
