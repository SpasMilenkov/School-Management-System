using OOPStage3.Classes.Controls;
using OxyPlot;
using OOPStage3.Classes.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.Series;
using OxyPlot.Axes;
using OOPStage3.Classes;
using OOPStage3.Properties;
using OxyPlot.Legends;

namespace OOPStage3.Views
{
    public partial class FormDashboard : Form
    {
        private User _person; //instance of the user that gets passed by the first form
        private byte CurrentTheme = 1; //keeps track of the theme that has been set
        private int currentStudent = 0;

        //One Class to rule them all, One Class to find them, One Class to bring them all and in the darkness bind them.
        private readonly UserControls _userControls;
        public FormDashboard(User person, UserControls vault)
        {
            InitializeComponent();
            _userControls = vault;
            _person = person;
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);
            if (_person.MyStudents().Count > 1)
            {
                pictureBoxBack.Visible = true;
                pictureBoxNext.Visible = true;
            }
            Execute();
        }

        //loads the elements of the interface according to the type of user gets called on initialization
        /// <summary>
        /// Determines the elements shown on the form depending on the type of user that has logged in
        /// </summary>
        /// 
        //page control-  OMG
        private void Execute()
        {
            string[] baseinfo = _person.GetBaseInfo();

            Hellolabel.Text = "Hello, " + baseinfo[0];
            labelID.Text = baseinfo[1];
            panelNavigation.BackColor = Color.FromArgb(32, 34, 37);
            this.BackColor = Color.FromArgb(47, 49, 54);
            this.ForeColor = Color.White;
            labelShowGraphs.Visible = true;
            labelShowGrades.Visible = true;
            SetTheme();

            if (_person is Admin)
            {
                labelEditUsers.Visible = true;
                dataGridView1.Visible = false;
                plotViewGrades.Visible = false;
                labelShowGrades.Text = "Show list of grades";
                labelShowGraphs.Text = "Show List of users";
                listBoxParents.DataSource = _userControls.GetAllParents();
                listBoxStaffNGrades.DataSource = _userControls.GetAllProfessors();
                listBoxStudents.DataSource = _userControls.GetAllStudents();
                return;
            }
            if (_person is Parent)
            {
                var children = _person.MyStudents();
                var childinfo = children[currentStudent].GetInfo();
                var childGrades = _userControls.GetGrades(childinfo[0]);
                labelID.Visible = true;
                labelAvgMark.Text = "Average grade: " + _person.AverageGrade(childGrades).ToString();
                labelAvgMark.Visible = true;
                labelID.Text = "ID: " + childinfo[0];
                labelGroup.Visible = true;
                labelGroup.Text = "Administrative group: " + (childinfo[1]);
                List<string> subjects = new();
                foreach (string course in children[currentStudent].GetCourses())
                    subjects.AddRange(_userControls.GetSubjects(course));
                DisplayGrades(childGrades, subjects);
                Graph(childGrades, subjects);
                return;
            }
            if (_person is Professor)
            {
                labelID.Text = "Title: " + _person.GetInfo()[0];
                labelEditUsers.Visible = true;
                labelEditUsers.Text = "Edit Grades";
                List<string> mysubjects = new();
                for (int i = 1; i < _person.GetInfo().Count; i++)
                    mysubjects.Add(_person.GetInfo()[i]);
                DisplayGrades(_userControls.GetGrades(baseinfo[0]), mysubjects);
                return;
            }
            List<Grade> grades = _userControls.GetGrades(_person.GetInfo()[0]);
            List<String> plotSubjects = new();
            foreach (string course in _person.GetCourses())
                plotSubjects.AddRange(_userControls.GetSubjects(course));
            labelID.Visible = true;
            labelAvgMark.Text = "Average grade: " + _person.AverageGrade(grades).ToString();
            labelAvgMark.Visible = true;
            labelID.Text = "ID: " + _person.GetInfo()[0];
            labelGroup.Visible = true;
            labelGroup.Text = "Administrative group: " + (_person.GetInfo()[1]);
            DisplayGrades(grades, plotSubjects);
            Graph(grades, plotSubjects);

        }
        //Set the theme for the user gets called on initialization via Execute
        private void SetTheme()
        {
            this.BackgroundImage = Resources.theme1;
            panelNavigation.BackColor = Color.FromArgb(200, 14, 65, 88);
            panel1.BackColor = Color.FromArgb(200, 14, 65, 88);
            dataGridView1.BorderStyle = BorderStyle.None;
            SetGridAndPlotStyle(Color.FromArgb(14, 65, 88), Color.FromArgb(255, 153, 19), Color.FromArgb(4, 138, 214));
        }

        //displays the grades in the table gets called during initialization via the execute function
        /// <summary>
        /// Displays the grades in the datagrid panel
        /// </summary>
        private void DisplayGrades(List<Grade> grades, List<string> subjects)
        {
            dataGridView1.RowTemplate.Height = 50;
            if (_person is Professor)
            {
                var IDs = grades.Select(g => g.OwnerID).Distinct().ToList();
                List<Student> students = _userControls.FindStudents(IDs);
                foreach (string s in subjects)
                {
                    dataGridView1.Rows.Add(s);
                    foreach (Student student in students)
                    {
                        dataGridView1.Rows.Add(student.GetBaseInfo()[0],
                                                 grades
                                                    .Where(grade => grade.Subject == s)
                                                    .Select(g => g.Amount.ToString())
                                                    .DefaultIfEmpty("")
                                                    .Aggregate((f, s) => f + ", " + s));
                    }
                }
                //dataGridView1.Rows.Add(_userControls.FindStudent());

                return;
            }
            foreach (string subject in subjects)
            {
                dataGridView1.Rows.Add(subject,
                        grades.Where(g => g.Subject == subject)
                         .Select(g => g.Amount.ToString())
                         .DefaultIfEmpty("")
                         .Aggregate((f, s) => f + ", " + s));
            }
        }
        private void LabelSettings_Click(object sender, EventArgs e)
        {
            var cForm = new CustomizationForm();
            cForm.ShowDialog();
            if (cForm.DialogResult == DialogResult.OK)
            {
                switch (cForm.CurrentTheme)
                {
                    case 1:
                        panelNavigation.BackColor = Color.FromArgb(200, 14, 65, 88);
                        panel1.BackColor = Color.FromArgb(200, 14, 65, 88);
                        SetGridAndPlotStyle(Color.FromArgb(14, 65, 88), Color.FromArgb(41, 91, 114), Color.FromArgb(4, 138, 214));
                        break;
                    case 2:
                        panelNavigation.BackColor = Color.FromArgb(200, 1, 70, 112);
                        panel1.BackColor = Color.FromArgb(150, 1, 70, 112);
                        listBoxParents.BackColor = Color.FromArgb(1, 70, 112);
                        listBoxStaffNGrades.BackColor = Color.FromArgb(1, 70, 112);
                        listBoxStudents.BackColor = Color.FromArgb(1, 70, 112);
                        SetGridAndPlotStyle(Color.FromArgb(1, 70, 112), Color.FromArgb(29, 96, 138), Color.FromArgb(21, 1, 112));
                        break;
                    case 3:
                        panelNavigation.BackColor = Color.FromArgb(150, 92, 21, 51);
                        panel1.BackColor = Color.FromArgb(150, 92, 21, 51);
                        listBoxParents.BackColor = Color.FromArgb(92, 21, 51);
                        listBoxStaffNGrades.BackColor = Color.FromArgb(92, 21, 51);
                        listBoxStudents.BackColor = Color.FromArgb(92, 21, 51);
                        SetGridAndPlotStyle(Color.FromArgb(92, 21, 51), Color.FromArgb(118, 50, 79), Color.FromArgb(92, 21, 86));
                        break;
                    case 4:
                        panelNavigation.BackColor = Color.FromArgb(150, 1, 26, 93);
                        panel1.BackColor = Color.FromArgb(150, 1, 26, 93);
                        listBoxParents.BackColor = Color.FromArgb(1, 26, 93);
                        listBoxStaffNGrades.BackColor = Color.FromArgb(1, 26, 93);
                        listBoxStudents.BackColor = Color.FromArgb(1, 26, 93);
                        SetGridAndPlotStyle(Color.FromArgb(1, 26, 93), Color.FromArgb(25, 50, 119), Color.FromArgb(92, 21, 86));
                        break;
                    case 5:
                        panelNavigation.BackColor = Color.FromArgb(150, 164, 14, 97);
                        panel1.BackColor = Color.FromArgb(150, 164, 14, 97);
                        listBoxParents.BackColor = Color.FromArgb(164, 14, 97);
                        listBoxStaffNGrades.BackColor = Color.FromArgb(164, 14, 97);
                        listBoxStudents.BackColor = Color.FromArgb(164, 14, 97);
                        SetGridAndPlotStyle(Color.FromArgb(164, 14, 97), Color.FromArgb(139, 40, 94), Color.FromArgb(157, 14, 164));
                        break;
                }
                plotViewGrades.Model.Background = OxyColor.FromRgb(panelNavigation.BackColor.R, panelNavigation.BackColor.G, panelNavigation.BackColor.B);
                this.BackgroundImage = cForm.BackgroundImage;
                CurrentTheme = cForm.CurrentTheme;

            }
        }
        //adds styling to the grid panel gets called in the set theme during initialization 
        //gets called on label click setting every the user chooses a new customization for the form
        //used to syn the colors
        private void SetGridAndPlotStyle(Color mainColor, Color complementaryColor, Color thirdComplementary)
        {
            //      ----GRID STYLES----
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = mainColor;
            dataGridView1.RowsDefaultCellStyle.BackColor = thirdComplementary;
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = complementaryColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = mainColor;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.BackgroundColor = mainColor;
        }
        private void Graph(List<Grade> grades, List<string> plotSubjects)
        {
            Random rnd = new();
            plotViewGrades.Model = new();

            //      ----PLOT STYLES----      \\
            plotViewGrades.Model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                AbsoluteMaximum = 6.0,
                AbsoluteMinimum = 2,
                IsZoomEnabled = false,
            });
            plotViewGrades.Model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                AbsoluteMaximum = 12.0,
                AbsoluteMinimum = 1,
                IsZoomEnabled = false,
            });
            plotViewGrades.Model.Background = OxyColor.FromRgb(panelNavigation.BackColor.R, panelNavigation.BackColor.G, panelNavigation.BackColor.B);
            plotViewGrades.Model.TextColor = OxyColor.FromRgb(255, 255, 255);
            plotViewGrades.Model.Legends.Add(new Legend()
            {
                LegendTitle = "Legend",
                LegendPosition = LegendPosition.RightBottom,
            });
            foreach (var subject in plotSubjects)
            {
                int i = 0; //for debugging
                var gradeSeries = new LineSeries
                {
                    Title = subject,
                    MarkerType = MarkerType.Diamond,
                    MarkerSize = 5,
                    Color = OxyColor.FromRgb((byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255)),
                };

                var series = grades.Where(grade => grade.Subject == subject)
                                    .Select(item => new
                                    {
                                        gradeAmount = item.Amount,
                                        gradeSubject = item.Subject,
                                        gradeDate = item.Date,
                                    }).ToList();

                foreach (var grade in series)
                {
                    gradeSeries.Points.Add(new DataPoint(grade.gradeDate.Month + i, (double)grade.gradeAmount));
                    i++;
                }
                plotViewGrades.Model.Series.Add(gradeSeries);
            }
        }
        private void LabelCalendar_Click_1(object sender, EventArgs e)
        {
            FormCalendar calendar = new(CurrentTheme);
            calendar.ShowDialog();
        }

        private void LabelShowGraphs_Click_1(object sender, EventArgs e)
        {
            if (_person is Admin)
            {
                listBoxStaffNGrades.Visible = true;
                listBoxStudents.Visible = true;
                listBoxParents.Visible = true;
                listBoxStaffNGrades.BackColor = Color.FromArgb(panelNavigation.BackColor.R, panelNavigation.BackColor.G, panelNavigation.BackColor.B);
                listBoxStudents.BackColor = Color.FromArgb(panelNavigation.BackColor.R, panelNavigation.BackColor.G, panelNavigation.BackColor.B);
                listBoxParents.BackColor = Color.FromArgb(panelNavigation.BackColor.R, panelNavigation.BackColor.G, panelNavigation.BackColor.B);
                return;
            }
            dataGridView1.Visible = false;
            plotViewGrades.Visible = true;
        }

        private void LabelShowGrades_Click_1(object sender, EventArgs e)
        {
            if (_person is Admin)
            {
                listBoxStaffNGrades.Visible = true;
                listBoxStudents.Visible = false;
                listBoxParents.Visible = false;
                listBoxParents.BackColor = Color.FromArgb(panelNavigation.BackColor.R, panelNavigation.BackColor.G, panelNavigation.BackColor.B);
                listBoxStaffNGrades.BackColor = Color.FromArgb(panelNavigation.BackColor.R, panelNavigation.BackColor.G, panelNavigation.BackColor.B);
                listBoxStudents.BackColor = Color.FromArgb(panelNavigation.BackColor.R, panelNavigation.BackColor.G, panelNavigation.BackColor.B);
                return;
            }
            dataGridView1.Visible = true;
        }

        private void LabelEditUsers_Click_1(object sender, EventArgs e)
        {
            EditsForm addUser = new(_userControls, panelNavigation.BackColor, _person);
            addUser.BackgroundImage = this.BackgroundImage;
            addUser.ShowDialog();
            _userControls.SaveUserData();
        }

        private void FormDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            _userControls.SaveUserData();
            _userControls.SaveCourseData();
            _userControls.SaveGradesData();
        }

        private void pictureBoxBack_Click_1(object sender, EventArgs e)
        {
            if (currentStudent == 0)
                return;


            dataGridView1.Rows.Clear();
            currentStudent--;
            Execute();
        }

        private void pictureBoxNext_Click_1(object sender, EventArgs e)
        {
            if (currentStudent == _person.MyStudents().Count)
            {
                currentStudent = 0;
                return;
            }
            currentStudent++;
            dataGridView1.Rows.Clear();
            Execute();
        }

        private void listBoxStaffNGrades_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxStaffNGrades.SelectedItems == null)
                return;
            FormInfo formInfo = new();
            formInfo.ShowDialog();
        }

        private void listBoxStudents_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedItem == null)
                return;
            FormInfo formInfo = new();
            formInfo.ShowDialog();
        }

        private void listBoxParents_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxParents.SelectedItem == null)
                return;
            FormInfo formInfo = new();
            formInfo.ShowDialog();
        }
    }
}