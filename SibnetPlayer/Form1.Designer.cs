
namespace SibnetPlayer
{
      partial class Form1
      {
            /// <summary>
            /// Обязательная переменная конструктора.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Освободить все используемые ресурсы.
            /// </summary>
            /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
            protected override void Dispose(bool disposing)
            {
                  if (disposing && (components != null))
                  {
                        components.Dispose();
                  }
                  base.Dispose(disposing);
            }

            #region Код, автоматически созданный конструктором форм Windows

            /// <summary>
            /// Требуемый метод для поддержки конструктора — не изменяйте 
            /// содержимое этого метода с помощью редактора кода.
            /// </summary>
            private void InitializeComponent()
            {
                  System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
                  this.animeTitleLabel = new System.Windows.Forms.Label();
                  this.episodeNumberLabel = new System.Windows.Forms.Label();
                  this.previousEpisodeButton = new MyCustomLib.Controls.CustomButton();
                  this.nextEpisodeButton = new MyCustomLib.Controls.CustomButton();
                  this.label1 = new System.Windows.Forms.Label();
                  this.button1 = new MyCustomLib.Controls.CustomButton();
                  this.button2 = new MyCustomLib.Controls.CustomButton();
                  this.SuspendLayout();
                  // 
                  // animeTitleLabel
                  // 
                  this.animeTitleLabel.BackColor = System.Drawing.Color.Transparent;
                  this.animeTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
                  this.animeTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                  this.animeTitleLabel.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                  this.animeTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                  this.animeTitleLabel.Location = new System.Drawing.Point(0, 39);
                  this.animeTitleLabel.Name = "animeTitleLabel";
                  this.animeTitleLabel.Size = new System.Drawing.Size(641, 44);
                  this.animeTitleLabel.TabIndex = 1;
                  this.animeTitleLabel.Text = "Название";
                  this.animeTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                  this.animeTitleLabel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.animeTitleLabel_MouseDoubleClick);
                  // 
                  // episodeNumberLabel
                  // 
                  this.episodeNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                  this.episodeNumberLabel.Location = new System.Drawing.Point(308, 86);
                  this.episodeNumberLabel.Name = "episodeNumberLabel";
                  this.episodeNumberLabel.Size = new System.Drawing.Size(79, 49);
                  this.episodeNumberLabel.TabIndex = 2;
                  this.episodeNumberLabel.Text = "9999";
                  this.episodeNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                  this.episodeNumberLabel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.episodeNumberLabel_MouseDoubleClick);
                  // 
                  // previousEpisodeButton
                  // 
                  this.previousEpisodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
                  this.previousEpisodeButton.BorderColor = System.Drawing.Color.Orange;
                  this.previousEpisodeButton.BorderWidth = 1F;
                  this.previousEpisodeButton.DrawBorder = false;
                  this.previousEpisodeButton.Hoverable = true;
                  this.previousEpisodeButton.Location = new System.Drawing.Point(269, 86);
                  this.previousEpisodeButton.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(137)))), ((int)(((byte)(45)))));
                  this.previousEpisodeButton.Name = "previousEpisodeButton";
                  this.previousEpisodeButton.Radius = 16.5D;
                  this.previousEpisodeButton.Size = new System.Drawing.Size(33, 50);
                  this.previousEpisodeButton.Style = MyCustomLib.Controls.CustomContainerStyle.Square;
                  this.previousEpisodeButton.TabIndex = 3;
                  this.previousEpisodeButton.Text = "<";
                  this.previousEpisodeButton.Click += new System.EventHandler(this.previousEpisodeButton_Click);
                  // 
                  // nextEpisodeButton
                  // 
                  this.nextEpisodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
                  this.nextEpisodeButton.BorderColor = System.Drawing.Color.Orange;
                  this.nextEpisodeButton.BorderWidth = 1F;
                  this.nextEpisodeButton.DrawBorder = false;
                  this.nextEpisodeButton.Hoverable = true;
                  this.nextEpisodeButton.Location = new System.Drawing.Point(393, 86);
                  this.nextEpisodeButton.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(137)))), ((int)(((byte)(45)))));
                  this.nextEpisodeButton.Name = "nextEpisodeButton";
                  this.nextEpisodeButton.Radius = 16.5D;
                  this.nextEpisodeButton.Size = new System.Drawing.Size(33, 50);
                  this.nextEpisodeButton.Style = MyCustomLib.Controls.CustomContainerStyle.Square;
                  this.nextEpisodeButton.TabIndex = 4;
                  this.nextEpisodeButton.Text = ">";
                  this.nextEpisodeButton.Click += new System.EventHandler(this.nextEpisodeButton_Click);
                  // 
                  // label1
                  // 
                  this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                  this.label1.Location = new System.Drawing.Point(8, 92);
                  this.label1.Name = "label1";
                  this.label1.Size = new System.Drawing.Size(260, 36);
                  this.label1.TabIndex = 5;
                  this.label1.Text = "Текущий эпизод:";
                  // 
                  // button1
                  // 
                  this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
                  this.button1.BorderColor = System.Drawing.Color.Orange;
                  this.button1.BorderWidth = 1F;
                  this.button1.DrawBorder = false;
                  this.button1.Hoverable = true;
                  this.button1.Location = new System.Drawing.Point(432, 86);
                  this.button1.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(137)))), ((int)(((byte)(45)))));
                  this.button1.Name = "button1";
                  this.button1.Radius = 20D;
                  this.button1.Size = new System.Drawing.Size(50, 50);
                  this.button1.Style = MyCustomLib.Controls.CustomContainerStyle.Square;
                  this.button1.TabIndex = 6;
                  this.button1.Text = "O";
                  this.button1.Click += new System.EventHandler(this.button1_Click);
                  // 
                  // button2
                  // 
                  this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
                  this.button2.BorderColor = System.Drawing.Color.Orange;
                  this.button2.BorderWidth = 1F;
                  this.button2.DrawBorder = false;
                  this.button2.Hoverable = true;
                  this.button2.Location = new System.Drawing.Point(488, 86);
                  this.button2.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(137)))), ((int)(((byte)(45)))));
                  this.button2.Name = "button2";
                  this.button2.Radius = 20D;
                  this.button2.Size = new System.Drawing.Size(142, 50);
                  this.button2.Style = MyCustomLib.Controls.CustomContainerStyle.Square;
                  this.button2.TabIndex = 7;
                  this.button2.Text = "Config";
                  this.button2.Click += new System.EventHandler(this.button2_Click);
                  // 
                  // Form1
                  // 
                  this.AllowDrop = true;
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
                  this.ClientSize = new System.Drawing.Size(641, 146);
                  this.Controls.Add(this.animeTitleLabel);
                  this.Controls.Add(this.button2);
                  this.Controls.Add(this.button1);
                  this.Controls.Add(this.label1);
                  this.Controls.Add(this.nextEpisodeButton);
                  this.Controls.Add(this.previousEpisodeButton);
                  this.Controls.Add(this.episodeNumberLabel);
                  this.CustomFormBorderStyle = MyCustomLib.Controls.CustomFormBorderStyle.Fixed;
                  this.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                  this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                  this.Name = "Form1";
                  this.Opacity = 1D;
                  this.Text = "Anime player";
                  this.Transition = true;
                  this.TransitionDelay = ((ushort)(200));
                  this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
                  this.Load += new System.EventHandler(this.Form1_Load);
                  this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
                  this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
                  this.DragLeave += new System.EventHandler(this.Form1_DragLeave);
                  this.Controls.SetChildIndex(this.episodeNumberLabel, 0);
                  this.Controls.SetChildIndex(this.previousEpisodeButton, 0);
                  this.Controls.SetChildIndex(this.nextEpisodeButton, 0);
                  this.Controls.SetChildIndex(this.label1, 0);
                  this.Controls.SetChildIndex(this.button1, 0);
                  this.Controls.SetChildIndex(this.button2, 0);
                  this.Controls.SetChildIndex(this.animeTitleLabel, 0);
                  this.ResumeLayout(false);

            }

            #endregion
            private System.Windows.Forms.Label animeTitleLabel;
            private System.Windows.Forms.Label episodeNumberLabel;
            private MyCustomLib.Controls.CustomButton previousEpisodeButton;
            private MyCustomLib.Controls.CustomButton nextEpisodeButton;
            private System.Windows.Forms.Label label1;
            private MyCustomLib.Controls.CustomButton button1;
            private MyCustomLib.Controls.CustomButton button2;
      }
}

