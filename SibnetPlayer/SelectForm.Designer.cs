namespace SibnetPlayer
{
      partial class SelectForm
      {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                  if (disposing && (components != null))
                  {
                        components.Dispose();
                  }
                  base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                  System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
                  this.listBox1 = new System.Windows.Forms.ListBox();
                  this.label1 = new System.Windows.Forms.Label();
                  this.SuspendLayout();
                  // 
                  // listBox1
                  // 
                  this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
                  this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                  this.listBox1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                  this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                  this.listBox1.FormattingEnabled = true;
                  this.listBox1.ItemHeight = 36;
                  this.listBox1.Location = new System.Drawing.Point(9, 76);
                  this.listBox1.Name = "listBox1";
                  this.listBox1.Size = new System.Drawing.Size(529, 324);
                  this.listBox1.TabIndex = 0;
                  this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
                  this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
                  // 
                  // label1
                  // 
                  this.label1.BackColor = System.Drawing.Color.Transparent;
                  this.label1.Dock = System.Windows.Forms.DockStyle.Top;
                  this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                  this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                  this.label1.Location = new System.Drawing.Point(0, 39);
                  this.label1.Name = "label1";
                  this.label1.Size = new System.Drawing.Size(547, 36);
                  this.label1.TabIndex = 1;
                  this.label1.Text = "Title";
                  this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                  // 
                  // SelectForm
                  // 
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
                  this.ClientSize = new System.Drawing.Size(547, 411);
                  this.Controls.Add(this.listBox1);
                  this.Controls.Add(this.label1);
                  this.CustomFormBorderStyle = MyCustomLib.Controls.CustomFormBorderStyle.FixedDialog;
                  this.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                  this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                  this.Name = "SelectForm";
                  this.Opacity = 1D;
                  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                  this.Text = "Select";
                  this.Controls.SetChildIndex(this.label1, 0);
                  this.Controls.SetChildIndex(this.listBox1, 0);
                  this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.ListBox listBox1;
            private System.Windows.Forms.Label label1;
      }
}