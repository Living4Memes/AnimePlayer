namespace SibnetPlayer
{
      partial class ConfigurationForm
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
                  System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
                  this.topMostCB = new System.Windows.Forms.CheckBox();
                  this.directStartCB = new System.Windows.Forms.CheckBox();
                  this.pathLabel = new System.Windows.Forms.Label();
                  this.pathTB = new MyCustomLib.Controls.CustomTextBox();
                  this.saveButton = new MyCustomLib.Controls.CustomButton();
                  this.discardButton = new MyCustomLib.Controls.CustomButton();
                  this.SuspendLayout();
                  // 
                  // topMostCB
                  // 
                  this.topMostCB.AutoSize = true;
                  this.topMostCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                  this.topMostCB.Location = new System.Drawing.Point(20, 103);
                  this.topMostCB.Name = "topMostCB";
                  this.topMostCB.Size = new System.Drawing.Size(160, 40);
                  this.topMostCB.TabIndex = 0;
                  this.topMostCB.Text = "Top most";
                  this.topMostCB.UseVisualStyleBackColor = true;
                  // 
                  // directStartCB
                  // 
                  this.directStartCB.AutoSize = true;
                  this.directStartCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                  this.directStartCB.Location = new System.Drawing.Point(186, 103);
                  this.directStartCB.Name = "directStartCB";
                  this.directStartCB.Size = new System.Drawing.Size(184, 40);
                  this.directStartCB.TabIndex = 1;
                  this.directStartCB.Text = "Direct start";
                  this.directStartCB.UseVisualStyleBackColor = true;
                  // 
                  // pathLabel
                  // 
                  this.pathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                  this.pathLabel.Location = new System.Drawing.Point(15, 46);
                  this.pathLabel.Name = "pathLabel";
                  this.pathLabel.Size = new System.Drawing.Size(213, 36);
                  this.pathLabel.TabIndex = 2;
                  this.pathLabel.Text = "Save file path:";
                  // 
                  // pathTB
                  // 
                  this.pathTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
                  this.pathTB.BorderColor = System.Drawing.Color.Orange;
                  this.pathTB.BorderWidth = 1F;
                  this.pathTB.DrawBorder = false;
                  this.pathTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
                  this.pathTB.HorizontalIndent = 15;
                  this.pathTB.Location = new System.Drawing.Point(234, 52);
                  this.pathTB.Name = "pathTB";
                  this.pathTB.Radius = 20D;
                  this.pathTB.Size = new System.Drawing.Size(488, 28);
                  this.pathTB.Style = MyCustomLib.Controls.CustomContainerStyle.Pill;
                  this.pathTB.TabIndex = 3;
                  this.pathTB.VerticalIndent = 5;
                  // 
                  // saveButton
                  // 
                  this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
                  this.saveButton.BorderColor = System.Drawing.Color.Orange;
                  this.saveButton.BorderWidth = 1F;
                  this.saveButton.DrawBorder = false;
                  this.saveButton.Hoverable = true;
                  this.saveButton.Location = new System.Drawing.Point(376, 99);
                  this.saveButton.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(137)))), ((int)(((byte)(45)))));
                  this.saveButton.Name = "saveButton";
                  this.saveButton.Radius = 20D;
                  this.saveButton.Size = new System.Drawing.Size(170, 50);
                  this.saveButton.Style = MyCustomLib.Controls.CustomContainerStyle.Square;
                  this.saveButton.TabIndex = 4;
                  this.saveButton.Text = "Save";
                  this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
                  // 
                  // discardButton
                  // 
                  this.discardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
                  this.discardButton.BorderColor = System.Drawing.Color.Orange;
                  this.discardButton.BorderWidth = 1F;
                  this.discardButton.DrawBorder = false;
                  this.discardButton.Hoverable = true;
                  this.discardButton.Location = new System.Drawing.Point(552, 99);
                  this.discardButton.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(137)))), ((int)(((byte)(45)))));
                  this.discardButton.Name = "discardButton";
                  this.discardButton.Radius = 20D;
                  this.discardButton.Size = new System.Drawing.Size(170, 50);
                  this.discardButton.Style = MyCustomLib.Controls.CustomContainerStyle.Square;
                  this.discardButton.TabIndex = 5;
                  this.discardButton.Text = "Discard";
                  this.discardButton.Click += new System.EventHandler(this.discardButton_Click);
                  // 
                  // ConfigurationForm
                  // 
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
                  this.ClientSize = new System.Drawing.Size(729, 160);
                  this.Controls.Add(this.discardButton);
                  this.Controls.Add(this.saveButton);
                  this.Controls.Add(this.pathTB);
                  this.Controls.Add(this.pathLabel);
                  this.Controls.Add(this.directStartCB);
                  this.Controls.Add(this.topMostCB);
                  this.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                  this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                  this.Name = "ConfigurationForm";
                  this.Opacity = 1D;
                  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                  this.Text = "Settings";
                  this.Controls.SetChildIndex(this.topMostCB, 0);
                  this.Controls.SetChildIndex(this.directStartCB, 0);
                  this.Controls.SetChildIndex(this.pathLabel, 0);
                  this.Controls.SetChildIndex(this.pathTB, 0);
                  this.Controls.SetChildIndex(this.saveButton, 0);
                  this.Controls.SetChildIndex(this.discardButton, 0);
                  this.ResumeLayout(false);
                  this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.CheckBox topMostCB;
            private System.Windows.Forms.CheckBox directStartCB;
            private System.Windows.Forms.Label pathLabel;
            private MyCustomLib.Controls.CustomTextBox pathTB;
            private MyCustomLib.Controls.CustomButton saveButton;
            private MyCustomLib.Controls.CustomButton discardButton;
      }
}