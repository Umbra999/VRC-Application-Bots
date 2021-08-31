
namespace ChromaticaAPI
{
    partial class AppBots
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
            this.WorldLaggerToggle = new System.Windows.Forms.CheckBox();
            this.JoinButton = new System.Windows.Forms.Button();
            this.StartBotsButton = new System.Windows.Forms.Button();
            this.RC2SelectedButton = new System.Windows.Forms.Button();
            this.OrbitSelectedButton = new System.Windows.Forms.Button();
            this.PlayerList = new System.Windows.Forms.ComboBox();
            this.BlockAllButton = new System.Windows.Forms.Button();
            this.ClickTPToggle = new System.Windows.Forms.CheckBox();
            this.ChangeAvatarButton = new System.Windows.Forms.Button();
            this.AvatarIDTextbox = new System.Windows.Forms.TextBox();
            this.RotateLeftButton = new System.Windows.Forms.Button();
            this.RotateRightButton = new System.Windows.Forms.Button();
            this.EventCachingDCToggle = new System.Windows.Forms.CheckBox();
            this.SpinbotToggle = new System.Windows.Forms.CheckBox();
            this.SpinbotSpeedTextbox = new System.Windows.Forms.TextBox();
            this.SetSpinbotSpeed = new System.Windows.Forms.Button();
            this.MoveForwardButton = new System.Windows.Forms.Button();
            this.MoveBackwardButton = new System.Windows.Forms.Button();
            this.MoveLeftButton = new System.Windows.Forms.Button();
            this.MoveRightButton = new System.Windows.Forms.Button();
            this.PrefabNameTextbox = new System.Windows.Forms.TextBox();
            this.SpamInstantiatePrefabToggle = new System.Windows.Forms.CheckBox();
            this.UnmutedToggle = new System.Windows.Forms.CheckBox();
            this.EarrapeMicToggle = new System.Windows.Forms.CheckBox();
            this.TargetFramerateTextbox = new System.Windows.Forms.TextBox();
            this.SetTargetFramerateButton = new System.Windows.Forms.Button();
            this.WestCoastLaggerToggle = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // WorldLaggerToggle
            // 
            this.WorldLaggerToggle.AutoSize = true;
            this.WorldLaggerToggle.Location = new System.Drawing.Point(12, 103);
            this.WorldLaggerToggle.Name = "WorldLaggerToggle";
            this.WorldLaggerToggle.Size = new System.Drawing.Size(75, 21);
            this.WorldLaggerToggle.TabIndex = 0;
            this.WorldLaggerToggle.Text = "Lagger";
            this.WorldLaggerToggle.UseVisualStyleBackColor = true;
            this.WorldLaggerToggle.CheckedChanged += new System.EventHandler(this.WorldLaggerToggle_CheckedChanged);
            // 
            // JoinButton
            // 
            this.JoinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.JoinButton.Location = new System.Drawing.Point(12, 14);
            this.JoinButton.Name = "JoinButton";
            this.JoinButton.Size = new System.Drawing.Size(116, 34);
            this.JoinButton.TabIndex = 1;
            this.JoinButton.Text = "Join";
            this.JoinButton.UseVisualStyleBackColor = false;
            this.JoinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // StartBotsButton
            // 
            this.StartBotsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.StartBotsButton.Location = new System.Drawing.Point(123, 14);
            this.StartBotsButton.Name = "StartBotsButton";
            this.StartBotsButton.Size = new System.Drawing.Size(116, 34);
            this.StartBotsButton.TabIndex = 2;
            this.StartBotsButton.Text = "Start Bots";
            this.StartBotsButton.UseVisualStyleBackColor = false;
            this.StartBotsButton.Click += new System.EventHandler(this.StartBotsButton_Click);
            // 
            // RC2SelectedButton
            // 
            this.RC2SelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RC2SelectedButton.Location = new System.Drawing.Point(12, 44);
            this.RC2SelectedButton.Name = "RC2SelectedButton";
            this.RC2SelectedButton.Size = new System.Drawing.Size(116, 34);
            this.RC2SelectedButton.TabIndex = 3;
            this.RC2SelectedButton.Text = "RC2 Selected";
            this.RC2SelectedButton.UseVisualStyleBackColor = false;
            this.RC2SelectedButton.Click += new System.EventHandler(this.RC2SelectedButton_Click);
            // 
            // OrbitSelectedButton
            // 
            this.OrbitSelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.OrbitSelectedButton.Location = new System.Drawing.Point(123, 44);
            this.OrbitSelectedButton.Name = "OrbitSelectedButton";
            this.OrbitSelectedButton.Size = new System.Drawing.Size(116, 34);
            this.OrbitSelectedButton.TabIndex = 4;
            this.OrbitSelectedButton.Text = "Orbit Selected";
            this.OrbitSelectedButton.UseVisualStyleBackColor = false;
            this.OrbitSelectedButton.Click += new System.EventHandler(this.OrbitSelectedButton_Click);
            // 
            // PlayerList
            // 
            this.PlayerList.FormattingEnabled = true;
            this.PlayerList.Location = new System.Drawing.Point(513, 52);
            this.PlayerList.Name = "PlayerList";
            this.PlayerList.Size = new System.Drawing.Size(246, 24);
            this.PlayerList.TabIndex = 7;
            this.PlayerList.SelectedIndexChanged += new System.EventHandler(this.PlayerList_SelectedIndexChanged);
            // 
            // BlockAllButton
            // 
            this.BlockAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BlockAllButton.Location = new System.Drawing.Point(513, 12);
            this.BlockAllButton.Name = "BlockAllButton";
            this.BlockAllButton.Size = new System.Drawing.Size(246, 34);
            this.BlockAllButton.TabIndex = 8;
            this.BlockAllButton.Text = "Block All Except Target";
            this.BlockAllButton.UseVisualStyleBackColor = false;
            this.BlockAllButton.Click += new System.EventHandler(this.BlockAllButton_Click);
            // 
            // ClickTPToggle
            // 
            this.ClickTPToggle.AutoSize = true;
            this.ClickTPToggle.Checked = true;
            this.ClickTPToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ClickTPToggle.Location = new System.Drawing.Point(12, 130);
            this.ClickTPToggle.Name = "ClickTPToggle";
            this.ClickTPToggle.Size = new System.Drawing.Size(98, 21);
            this.ClickTPToggle.TabIndex = 9;
            this.ClickTPToggle.Text = "ClickTP [T]";
            this.ClickTPToggle.UseVisualStyleBackColor = true;
            this.ClickTPToggle.CheckedChanged += new System.EventHandler(this.ClickTPToggle_CheckedChanged);
            // 
            // ChangeAvatarButton
            // 
            this.ChangeAvatarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChangeAvatarButton.Location = new System.Drawing.Point(12, 157);
            this.ChangeAvatarButton.Name = "ChangeAvatarButton";
            this.ChangeAvatarButton.Size = new System.Drawing.Size(132, 34);
            this.ChangeAvatarButton.TabIndex = 10;
            this.ChangeAvatarButton.Text = "Change Avatar";
            this.ChangeAvatarButton.UseVisualStyleBackColor = false;
            this.ChangeAvatarButton.Click += new System.EventHandler(this.ChangeAvatarButton_Click);
            // 
            // AvatarIDTextbox
            // 
            this.AvatarIDTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AvatarIDTextbox.Location = new System.Drawing.Point(151, 163);
            this.AvatarIDTextbox.Name = "AvatarIDTextbox";
            this.AvatarIDTextbox.Size = new System.Drawing.Size(117, 22);
            this.AvatarIDTextbox.TabIndex = 11;
            this.AvatarIDTextbox.Text = "Avatar ID";
            // 
            // RotateLeftButton
            // 
            this.RotateLeftButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RotateLeftButton.Location = new System.Drawing.Point(513, 88);
            this.RotateLeftButton.Name = "RotateLeftButton";
            this.RotateLeftButton.Size = new System.Drawing.Size(125, 34);
            this.RotateLeftButton.TabIndex = 12;
            this.RotateLeftButton.Text = "Rotate Left";
            this.RotateLeftButton.UseVisualStyleBackColor = false;
            this.RotateLeftButton.Click += new System.EventHandler(this.RotateLeftButton_Click);
            // 
            // RotateRightButton
            // 
            this.RotateRightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RotateRightButton.Location = new System.Drawing.Point(634, 88);
            this.RotateRightButton.Name = "RotateRightButton";
            this.RotateRightButton.Size = new System.Drawing.Size(125, 34);
            this.RotateRightButton.TabIndex = 13;
            this.RotateRightButton.Text = "Rotate Right";
            this.RotateRightButton.UseVisualStyleBackColor = false;
            this.RotateRightButton.Click += new System.EventHandler(this.RotateRightButton_Click);
            // 
            // EventCachingDCToggle
            // 
            this.EventCachingDCToggle.AutoSize = true;
            this.EventCachingDCToggle.Location = new System.Drawing.Point(93, 103);
            this.EventCachingDCToggle.Name = "EventCachingDCToggle";
            this.EventCachingDCToggle.Size = new System.Drawing.Size(144, 21);
            this.EventCachingDCToggle.TabIndex = 14;
            this.EventCachingDCToggle.Text = "Event Caching DC";
            this.EventCachingDCToggle.UseVisualStyleBackColor = true;
            this.EventCachingDCToggle.CheckedChanged += new System.EventHandler(this.EventCachingDCToggle_CheckedChanged);
            // 
            // SpinbotToggle
            // 
            this.SpinbotToggle.AutoSize = true;
            this.SpinbotToggle.Location = new System.Drawing.Point(12, 202);
            this.SpinbotToggle.Name = "SpinbotToggle";
            this.SpinbotToggle.Size = new System.Drawing.Size(78, 21);
            this.SpinbotToggle.TabIndex = 15;
            this.SpinbotToggle.Text = "Spinbot";
            this.SpinbotToggle.UseVisualStyleBackColor = true;
            this.SpinbotToggle.CheckedChanged += new System.EventHandler(this.SpinbotToggle_CheckedChanged);
            // 
            // SpinbotSpeedTextbox
            // 
            this.SpinbotSpeedTextbox.Location = new System.Drawing.Point(245, 200);
            this.SpinbotSpeedTextbox.Name = "SpinbotSpeedTextbox";
            this.SpinbotSpeedTextbox.Size = new System.Drawing.Size(52, 22);
            this.SpinbotSpeedTextbox.TabIndex = 16;
            this.SpinbotSpeedTextbox.Text = "20";
            // 
            // SetSpinbotSpeed
            // 
            this.SetSpinbotSpeed.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SetSpinbotSpeed.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.SetSpinbotSpeed.Location = new System.Drawing.Point(93, 196);
            this.SetSpinbotSpeed.Name = "SetSpinbotSpeed";
            this.SetSpinbotSpeed.Size = new System.Drawing.Size(146, 31);
            this.SetSpinbotSpeed.TabIndex = 17;
            this.SetSpinbotSpeed.Text = "Set Spin Speed";
            this.SetSpinbotSpeed.UseVisualStyleBackColor = false;
            this.SetSpinbotSpeed.Click += new System.EventHandler(this.SetSpinbotSpeed_Click);
            // 
            // MoveForwardButton
            // 
            this.MoveForwardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MoveForwardButton.Location = new System.Drawing.Point(513, 120);
            this.MoveForwardButton.Name = "MoveForwardButton";
            this.MoveForwardButton.Size = new System.Drawing.Size(125, 34);
            this.MoveForwardButton.TabIndex = 18;
            this.MoveForwardButton.Text = "Move Forward";
            this.MoveForwardButton.UseVisualStyleBackColor = false;
            this.MoveForwardButton.Click += new System.EventHandler(this.MoveForwardButton_Click);
            // 
            // MoveBackwardButton
            // 
            this.MoveBackwardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MoveBackwardButton.Location = new System.Drawing.Point(634, 120);
            this.MoveBackwardButton.Name = "MoveBackwardButton";
            this.MoveBackwardButton.Size = new System.Drawing.Size(125, 34);
            this.MoveBackwardButton.TabIndex = 19;
            this.MoveBackwardButton.Text = "Move Backward";
            this.MoveBackwardButton.UseVisualStyleBackColor = false;
            this.MoveBackwardButton.Click += new System.EventHandler(this.MoveBackwardButton_Click);
            // 
            // MoveLeftButton
            // 
            this.MoveLeftButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MoveLeftButton.Location = new System.Drawing.Point(513, 148);
            this.MoveLeftButton.Name = "MoveLeftButton";
            this.MoveLeftButton.Size = new System.Drawing.Size(125, 34);
            this.MoveLeftButton.TabIndex = 20;
            this.MoveLeftButton.Text = "Move Left";
            this.MoveLeftButton.UseVisualStyleBackColor = false;
            this.MoveLeftButton.Click += new System.EventHandler(this.MoveLeftButton_Click);
            // 
            // MoveRightButton
            // 
            this.MoveRightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MoveRightButton.Location = new System.Drawing.Point(634, 148);
            this.MoveRightButton.Name = "MoveRightButton";
            this.MoveRightButton.Size = new System.Drawing.Size(125, 34);
            this.MoveRightButton.TabIndex = 21;
            this.MoveRightButton.Text = "Move Right";
            this.MoveRightButton.UseVisualStyleBackColor = false;
            this.MoveRightButton.Click += new System.EventHandler(this.MoveRightButton_Click);
            // 
            // PrefabNameTextbox
            // 
            this.PrefabNameTextbox.Location = new System.Drawing.Point(513, 215);
            this.PrefabNameTextbox.Name = "PrefabNameTextbox";
            this.PrefabNameTextbox.Size = new System.Drawing.Size(146, 22);
            this.PrefabNameTextbox.TabIndex = 22;
            this.PrefabNameTextbox.Text = "Prefab Name";
            // 
            // SpamInstantiatePrefabToggle
            // 
            this.SpamInstantiatePrefabToggle.AutoSize = true;
            this.SpamInstantiatePrefabToggle.Location = new System.Drawing.Point(513, 188);
            this.SpamInstantiatePrefabToggle.Name = "SpamInstantiatePrefabToggle";
            this.SpamInstantiatePrefabToggle.Size = new System.Drawing.Size(135, 21);
            this.SpamInstantiatePrefabToggle.TabIndex = 23;
            this.SpamInstantiatePrefabToggle.Text = "Spam Instantiate";
            this.SpamInstantiatePrefabToggle.UseVisualStyleBackColor = true;
            this.SpamInstantiatePrefabToggle.CheckedChanged += new System.EventHandler(this.SpamInstantiatePrefabToggle_CheckedChanged);
            // 
            // UnmutedToggle
            // 
            this.UnmutedToggle.AutoSize = true;
            this.UnmutedToggle.Location = new System.Drawing.Point(12, 272);
            this.UnmutedToggle.Name = "UnmutedToggle";
            this.UnmutedToggle.Size = new System.Drawing.Size(87, 21);
            this.UnmutedToggle.TabIndex = 24;
            this.UnmutedToggle.Text = "Unmuted";
            this.UnmutedToggle.UseVisualStyleBackColor = true;
            this.UnmutedToggle.CheckedChanged += new System.EventHandler(this.UnmutedToggle_CheckedChanged);
            // 
            // EarrapeMicToggle
            // 
            this.EarrapeMicToggle.AutoSize = true;
            this.EarrapeMicToggle.Location = new System.Drawing.Point(12, 247);
            this.EarrapeMicToggle.Name = "EarrapeMicToggle";
            this.EarrapeMicToggle.Size = new System.Drawing.Size(81, 21);
            this.EarrapeMicToggle.TabIndex = 25;
            this.EarrapeMicToggle.Text = "Earrape";
            this.EarrapeMicToggle.UseVisualStyleBackColor = true;
            this.EarrapeMicToggle.CheckedChanged += new System.EventHandler(this.EarrapeMicToggle_CheckedChanged);
            // 
            // TargetFramerateTextbox
            // 
            this.TargetFramerateTextbox.Location = new System.Drawing.Point(215, 303);
            this.TargetFramerateTextbox.Name = "TargetFramerateTextbox";
            this.TargetFramerateTextbox.Size = new System.Drawing.Size(53, 22);
            this.TargetFramerateTextbox.TabIndex = 26;
            this.TargetFramerateTextbox.Text = "25";
            // 
            // SetTargetFramerateButton
            // 
            this.SetTargetFramerateButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SetTargetFramerateButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.SetTargetFramerateButton.Location = new System.Drawing.Point(12, 299);
            this.SetTargetFramerateButton.Name = "SetTargetFramerateButton";
            this.SetTargetFramerateButton.Size = new System.Drawing.Size(197, 31);
            this.SetTargetFramerateButton.TabIndex = 27;
            this.SetTargetFramerateButton.Text = "Set Target Framerate";
            this.SetTargetFramerateButton.UseVisualStyleBackColor = false;
            this.SetTargetFramerateButton.Click += new System.EventHandler(this.SetTargetFramerateButton_Click);
            // 
            // WestCoastLaggerToggle
            // 
            this.WestCoastLaggerToggle.AutoSize = true;
            this.WestCoastLaggerToggle.Location = new System.Drawing.Point(116, 130);
            this.WestCoastLaggerToggle.Name = "WestCoastLaggerToggle";
            this.WestCoastLaggerToggle.Size = new System.Drawing.Size(151, 21);
            this.WestCoastLaggerToggle.TabIndex = 28;
            this.WestCoastLaggerToggle.Text = "West Coast Lagger";
            this.WestCoastLaggerToggle.UseVisualStyleBackColor = true;
            this.WestCoastLaggerToggle.CheckedChanged += new System.EventHandler(this.WestCoastLaggerToggle_CheckedChanged);
            // 
            // AppBots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(771, 342);
            this.Controls.Add(this.WestCoastLaggerToggle);
            this.Controls.Add(this.SetTargetFramerateButton);
            this.Controls.Add(this.TargetFramerateTextbox);
            this.Controls.Add(this.EarrapeMicToggle);
            this.Controls.Add(this.UnmutedToggle);
            this.Controls.Add(this.SpamInstantiatePrefabToggle);
            this.Controls.Add(this.PrefabNameTextbox);
            this.Controls.Add(this.MoveRightButton);
            this.Controls.Add(this.MoveLeftButton);
            this.Controls.Add(this.MoveBackwardButton);
            this.Controls.Add(this.MoveForwardButton);
            this.Controls.Add(this.SetSpinbotSpeed);
            this.Controls.Add(this.SpinbotSpeedTextbox);
            this.Controls.Add(this.SpinbotToggle);
            this.Controls.Add(this.EventCachingDCToggle);
            this.Controls.Add(this.RotateRightButton);
            this.Controls.Add(this.RotateLeftButton);
            this.Controls.Add(this.AvatarIDTextbox);
            this.Controls.Add(this.ChangeAvatarButton);
            this.Controls.Add(this.ClickTPToggle);
            this.Controls.Add(this.BlockAllButton);
            this.Controls.Add(this.PlayerList);
            this.Controls.Add(this.OrbitSelectedButton);
            this.Controls.Add(this.RC2SelectedButton);
            this.Controls.Add(this.StartBotsButton);
            this.Controls.Add(this.JoinButton);
            this.Controls.Add(this.WorldLaggerToggle);
            this.Name = "AppBots";
            this.Text = "AppBots";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox WorldLaggerToggle;
        private System.Windows.Forms.Button JoinButton;
        private System.Windows.Forms.Button StartBotsButton;
        private System.Windows.Forms.Button RC2SelectedButton;
        private System.Windows.Forms.Button OrbitSelectedButton;
        private System.Windows.Forms.ComboBox PlayerList;
        private System.Windows.Forms.Button BlockAllButton;
        private System.Windows.Forms.CheckBox ClickTPToggle;
        private System.Windows.Forms.Button ChangeAvatarButton;
        private System.Windows.Forms.TextBox AvatarIDTextbox;
        private System.Windows.Forms.Button RotateLeftButton;
        private System.Windows.Forms.Button RotateRightButton;
        private System.Windows.Forms.CheckBox EventCachingDCToggle;
        private System.Windows.Forms.CheckBox SpinbotToggle;
        private System.Windows.Forms.TextBox SpinbotSpeedTextbox;
        private System.Windows.Forms.Button SetSpinbotSpeed;
        private System.Windows.Forms.Button MoveForwardButton;
        private System.Windows.Forms.Button MoveBackwardButton;
        private System.Windows.Forms.Button MoveLeftButton;
        private System.Windows.Forms.Button MoveRightButton;
        private System.Windows.Forms.TextBox PrefabNameTextbox;
        private System.Windows.Forms.CheckBox SpamInstantiatePrefabToggle;
        private System.Windows.Forms.CheckBox UnmutedToggle;
        private System.Windows.Forms.CheckBox EarrapeMicToggle;
        private System.Windows.Forms.TextBox TargetFramerateTextbox;
        private System.Windows.Forms.Button SetTargetFramerateButton;
        private System.Windows.Forms.CheckBox WestCoastLaggerToggle;
    }
}