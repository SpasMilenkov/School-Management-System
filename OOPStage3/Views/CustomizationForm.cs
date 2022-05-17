using OOPStage3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPStage3.Views
{
    public partial class CustomizationForm : Form
    {
        protected internal byte CurrentTheme;
        public CustomizationForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer, true);

            typeof(FlowLayoutPanel).InvokeMember("DoubleBuffered",
                          BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                          null, panelNames, new object[] { true });

            typeof(FlowLayoutPanel).InvokeMember("DoubleBuffered",
              BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
              null, panelVisualization, new object[] { true });

            this.BackgroundImage = Resources.theme1;
            panelNames.BackColor = Color.FromArgb(200, 14, 65, 88);
            panelVisualization.BackColor = Color.FromArgb(200, 14, 65, 88);
            this.ForeColor = Color.White;
        }
        private void labelATheme1_Click_1(object sender, EventArgs e)
        {
            pictureBoxPreview.Image = Resources.theme1;
            panelNames.BackColor = Color.FromArgb(200, 14, 65, 88);
            panelVisualization.BackColor = Color.FromArgb(200, 14, 65, 88);
            CurrentTheme = 1;
            this.BackgroundImage = pictureBoxPreview.Image;
        }

        private void labelTheme2_Click_1(object sender, EventArgs e)
        {
            pictureBoxPreview.Image = Resources.theme2;
            panelNames.BackColor = Color.FromArgb(200, 1, 70, 112);
            panelVisualization.BackColor = Color.FromArgb(150, 1, 70, 112);
            CurrentTheme = 2;
            this.BackgroundImage = pictureBoxPreview.Image;
        }

        private void labelTheme3_Click_1(object sender, EventArgs e)
        {
            pictureBoxPreview.Image = Resources.theme3;
            panelNames.BackColor = Color.FromArgb(150, 92, 21, 51);
            panelVisualization.BackColor = Color.FromArgb(150, 92, 21, 51);
            CurrentTheme = 3;
            this.BackgroundImage = pictureBoxPreview.Image;
        }

        private void labelTheme4_Click_1(object sender, EventArgs e)
        {
            pictureBoxPreview.Image = Resources.theme4;
            panelNames.BackColor = Color.FromArgb(150, 1, 26, 93);
            panelVisualization.BackColor = Color.FromArgb(150, 1, 26, 93);
            CurrentTheme = 4;
            this.BackgroundImage = pictureBoxPreview.Image;
        }

        private void labelTheme5_Click_1(object sender, EventArgs e)
        {
            pictureBoxPreview.Image = Resources.theme5;
            panelNames.BackColor = Color.FromArgb(150, 164, 14, 97);
            panelVisualization.BackColor = Color.FromArgb(150, 164, 14, 97);
            CurrentTheme = 5;
            this.BackgroundImage = pictureBoxPreview.Image;
        }

        private void labelExit_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void labelApply_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
