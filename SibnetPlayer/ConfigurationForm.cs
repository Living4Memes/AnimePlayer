using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyCustomLib.Controls;

namespace SibnetPlayer
{
      public partial class ConfigurationForm : CustomForm
      {
            public ConfigurationForm()
            {
                  InitializeComponent();

                  TopMost = Properties.Settings.Default.AlwaysOnTop;

                  pathTB.Text = Properties.Settings.Default.FilePath;
                  topMostCB.Checked = Properties.Settings.Default.AlwaysOnTop;
                  directStartCB.Checked = Properties.Settings.Default.DirectStart;
            }

            private void saveButton_Click(object sender, EventArgs e)
            {
                  Properties.Settings.Default.FilePath = pathTB.Text;
                  Properties.Settings.Default.AlwaysOnTop = topMostCB.Checked;
                  Properties.Settings.Default.DirectStart = directStartCB.Checked;

                  Properties.Settings.Default.Save();

                  this.Close();
            }

            private void discardButton_Click(object sender, EventArgs e)
            {
                  this.Close();
            }
      }
}
