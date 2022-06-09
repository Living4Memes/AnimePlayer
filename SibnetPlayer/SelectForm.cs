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
      public partial class SelectForm : CustomForm
      {
            public delegate void IndexHandler(int index);
            public event IndexHandler ItemChoose;
            public SelectForm()
            {
                  InitializeComponent();

                  TopMost = Properties.Settings.Default.AlwaysOnTop;
            }

            public SelectForm(string title, List<string> variables) : this()
            {
                  label1.Text = title;
                  variables.ForEach(x => listBox1.Items.Add(x));
            }

            private void listBox1_Click(object sender, EventArgs e)
            {
                  ItemChoose?.Invoke(listBox1.SelectedIndex);
                  this.Close();
            }

            private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
            {
                  ItemChoose?.Invoke(listBox1.SelectedIndex);
                  this.Close();
            }
      }
}
