namespace CombatForms
{
    partial class Form1
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
            this.Hand1 = new System.Windows.Forms.Button();
            this.Hand2 = new System.Windows.Forms.Button();
            this.Hand3 = new System.Windows.Forms.Button();
            this.Hand4 = new System.Windows.Forms.Button();
            this.Field1 = new System.Windows.Forms.Button();
            this.Field2 = new System.Windows.Forms.Button();
            this.Field3 = new System.Windows.Forms.Button();
            this.Field4 = new System.Windows.Forms.Button();
            this.PlayerHealth = new System.Windows.Forms.Label();
            this.EnemyHealth = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.PhaseCounter = new System.Windows.Forms.Label();
            this.CurrentState = new System.Windows.Forms.Label();
            this.EnemySpeed = new System.Windows.Forms.Label();
            this.PlayerSpeed = new System.Windows.Forms.Label();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Hand1
            // 
            this.Hand1.Location = new System.Drawing.Point(23, 361);
            this.Hand1.Name = "Hand1";
            this.Hand1.Size = new System.Drawing.Size(89, 120);
            this.Hand1.TabIndex = 0;
            this.Hand1.Text = "Hand1";
            this.Hand1.UseVisualStyleBackColor = true;
            this.Hand1.Click += new System.EventHandler(this.Hand1_Click);
            // 
            // Hand2
            // 
            this.Hand2.Location = new System.Drawing.Point(118, 361);
            this.Hand2.Name = "Hand2";
            this.Hand2.Size = new System.Drawing.Size(89, 120);
            this.Hand2.TabIndex = 1;
            this.Hand2.Text = "Hand2";
            this.Hand2.UseVisualStyleBackColor = true;
            this.Hand2.Click += new System.EventHandler(this.Hand2_Click);
            // 
            // Hand3
            // 
            this.Hand3.Location = new System.Drawing.Point(213, 361);
            this.Hand3.Name = "Hand3";
            this.Hand3.Size = new System.Drawing.Size(89, 120);
            this.Hand3.TabIndex = 2;
            this.Hand3.Text = "Hand3";
            this.Hand3.UseVisualStyleBackColor = true;
            this.Hand3.Click += new System.EventHandler(this.Hand3_Click);
            // 
            // Hand4
            // 
            this.Hand4.Location = new System.Drawing.Point(308, 361);
            this.Hand4.Name = "Hand4";
            this.Hand4.Size = new System.Drawing.Size(89, 120);
            this.Hand4.TabIndex = 3;
            this.Hand4.Text = "Hand4";
            this.Hand4.UseVisualStyleBackColor = true;
            this.Hand4.Click += new System.EventHandler(this.Hand4_Click);
            // 
            // Field1
            // 
            this.Field1.Location = new System.Drawing.Point(118, 218);
            this.Field1.Name = "Field1";
            this.Field1.Size = new System.Drawing.Size(89, 120);
            this.Field1.TabIndex = 4;
            this.Field1.Text = "Field1";
            this.Field1.UseVisualStyleBackColor = true;
            // 
            // Field2
            // 
            this.Field2.Location = new System.Drawing.Point(213, 218);
            this.Field2.Name = "Field2";
            this.Field2.Size = new System.Drawing.Size(89, 120);
            this.Field2.TabIndex = 5;
            this.Field2.Text = "Field2";
            this.Field2.UseVisualStyleBackColor = true;
            // 
            // Field3
            // 
            this.Field3.Location = new System.Drawing.Point(118, 33);
            this.Field3.Name = "Field3";
            this.Field3.Size = new System.Drawing.Size(89, 120);
            this.Field3.TabIndex = 6;
            this.Field3.Text = "Field3";
            this.Field3.UseVisualStyleBackColor = true;
            // 
            // Field4
            // 
            this.Field4.Location = new System.Drawing.Point(213, 33);
            this.Field4.Name = "Field4";
            this.Field4.Size = new System.Drawing.Size(89, 120);
            this.Field4.TabIndex = 7;
            this.Field4.Text = "Field4";
            this.Field4.UseVisualStyleBackColor = true;
            // 
            // PlayerHealth
            // 
            this.PlayerHealth.AutoSize = true;
            this.PlayerHealth.Location = new System.Drawing.Point(132, 193);
            this.PlayerHealth.Name = "PlayerHealth";
            this.PlayerHealth.Size = new System.Drawing.Size(62, 13);
            this.PlayerHealth.TabIndex = 8;
            this.PlayerHealth.Text = "Health: 100";
            this.PlayerHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnemyHealth
            // 
            this.EnemyHealth.AutoSize = true;
            this.EnemyHealth.Location = new System.Drawing.Point(132, 9);
            this.EnemyHealth.Name = "EnemyHealth";
            this.EnemyHealth.Size = new System.Drawing.Size(62, 13);
            this.EnemyHealth.TabIndex = 9;
            this.EnemyHealth.Text = "Health: 100";
            this.EnemyHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(425, 402);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 38);
            this.NextButton.TabIndex = 10;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PhaseCounter
            // 
            this.PhaseCounter.AutoSize = true;
            this.PhaseCounter.Location = new System.Drawing.Point(20, 22);
            this.PhaseCounter.Name = "PhaseCounter";
            this.PhaseCounter.Size = new System.Drawing.Size(49, 13);
            this.PhaseCounter.TabIndex = 11;
            this.PhaseCounter.Text = "Phase: 1";
            // 
            // CurrentState
            // 
            this.CurrentState.AutoSize = true;
            this.CurrentState.Location = new System.Drawing.Point(20, 87);
            this.CurrentState.Name = "CurrentState";
            this.CurrentState.Size = new System.Drawing.Size(72, 13);
            this.CurrentState.TabIndex = 12;
            this.CurrentState.Text = "Current State:";
            // 
            // EnemySpeed
            // 
            this.EnemySpeed.AutoSize = true;
            this.EnemySpeed.Location = new System.Drawing.Point(224, 9);
            this.EnemySpeed.Name = "EnemySpeed";
            this.EnemySpeed.Size = new System.Drawing.Size(56, 13);
            this.EnemySpeed.TabIndex = 13;
            this.EnemySpeed.Text = "Speed: 50";
            this.EnemySpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerSpeed
            // 
            this.PlayerSpeed.AutoSize = true;
            this.PlayerSpeed.Location = new System.Drawing.Point(224, 193);
            this.PlayerSpeed.Name = "PlayerSpeed";
            this.PlayerSpeed.Size = new System.Drawing.Size(56, 13);
            this.PlayerSpeed.TabIndex = 14;
            this.PlayerSpeed.Text = "Speed: 50";
            this.PlayerSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(358, 56);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(129, 263);
            this.LogBox.TabIndex = 15;
            this.LogBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 503);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.PlayerSpeed);
            this.Controls.Add(this.EnemySpeed);
            this.Controls.Add(this.CurrentState);
            this.Controls.Add(this.PhaseCounter);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.EnemyHealth);
            this.Controls.Add(this.PlayerHealth);
            this.Controls.Add(this.Field4);
            this.Controls.Add(this.Field3);
            this.Controls.Add(this.Field2);
            this.Controls.Add(this.Field1);
            this.Controls.Add(this.Hand4);
            this.Controls.Add(this.Hand3);
            this.Controls.Add(this.Hand2);
            this.Controls.Add(this.Hand1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hand1;
        private System.Windows.Forms.Button Hand2;
        private System.Windows.Forms.Button Hand3;
        private System.Windows.Forms.Button Hand4;
        private System.Windows.Forms.Button Field1;
        private System.Windows.Forms.Button Field2;
        private System.Windows.Forms.Button Field3;
        private System.Windows.Forms.Button Field4;
        private System.Windows.Forms.Label PlayerHealth;
        private System.Windows.Forms.Label EnemyHealth;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label PhaseCounter;
        private System.Windows.Forms.Label CurrentState;
        private System.Windows.Forms.Label EnemySpeed;
        private System.Windows.Forms.Label PlayerSpeed;
        private System.Windows.Forms.RichTextBox LogBox;
    }
}

