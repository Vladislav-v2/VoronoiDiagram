namespace VoronoiDiagram
{
    partial class VoronoiDiagramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoronoiDiagramForm));
            this.contextPanel = new System.Windows.Forms.Panel();
            this.showBuildPlan = new System.Windows.Forms.CheckBox();
            this.showDiagram = new System.Windows.Forms.CheckBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DaigramPanel = new System.Windows.Forms.Panel();
            this.pictBoxDaigram = new System.Windows.Forms.PictureBox();
            this.contextPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.DaigramPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxDaigram)).BeginInit();
            this.SuspendLayout();
            // 
            // contextPanel
            // 
            this.contextPanel.Controls.Add(this.showBuildPlan);
            this.contextPanel.Controls.Add(this.showDiagram);
            this.contextPanel.Controls.Add(this.btnLoadFile);
            this.contextPanel.Controls.Add(this.btnClear);
            this.contextPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.contextPanel.Location = new System.Drawing.Point(536, 0);
            this.contextPanel.Name = "contextPanel";
            this.contextPanel.Size = new System.Drawing.Size(218, 536);
            this.contextPanel.TabIndex = 6;
            // 
            // showBuildPlan
            // 
            this.showBuildPlan.AutoSize = true;
            this.showBuildPlan.Checked = true;
            this.showBuildPlan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showBuildPlan.Location = new System.Drawing.Point(17, 88);
            this.showBuildPlan.Name = "showBuildPlan";
            this.showBuildPlan.Size = new System.Drawing.Size(86, 17);
            this.showBuildPlan.TabIndex = 6;
            this.showBuildPlan.Text = "Building plan";
            this.showBuildPlan.UseVisualStyleBackColor = true;
            this.showBuildPlan.CheckedChanged += new System.EventHandler(this.showBuildPlan_CheckedChanged);
            // 
            // showDiagram
            // 
            this.showDiagram.AutoSize = true;
            this.showDiagram.Checked = true;
            this.showDiagram.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showDiagram.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.showDiagram.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.showDiagram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.showDiagram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.showDiagram.Location = new System.Drawing.Point(17, 65);
            this.showDiagram.Name = "showDiagram";
            this.showDiagram.Size = new System.Drawing.Size(65, 17);
            this.showDiagram.TabIndex = 5;
            this.showDiagram.Text = "Diagram";
            this.showDiagram.UseVisualStyleBackColor = true;
            this.showDiagram.CheckedChanged += new System.EventHandler(this.showDiagram_CheckedChanged);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnLoadFile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLoadFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFile.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadFile.Location = new System.Drawing.Point(109, 12);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(95, 38);
            this.btnLoadFile.TabIndex = 4;
            this.btnLoadFile.Text = "Load file";
            this.btnLoadFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = global::VoronoiDiagram.Properties.Resources.icon_clean;
            this.btnClear.Location = new System.Drawing.Point(8, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif" +
    "; *.png\"";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.DaigramPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(536, 536);
            this.MainPanel.TabIndex = 7;
            // 
            // DaigramPanel
            // 
            this.DaigramPanel.BackColor = System.Drawing.Color.White;
            this.DaigramPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DaigramPanel.Controls.Add(this.pictBoxDaigram);
            this.DaigramPanel.Location = new System.Drawing.Point(12, 12);
            this.DaigramPanel.Name = "DaigramPanel";
            this.DaigramPanel.Size = new System.Drawing.Size(512, 512);
            this.DaigramPanel.TabIndex = 6;
            // 
            // pictBoxDaigram
            // 
            this.pictBoxDaigram.BackColor = System.Drawing.Color.Transparent;
            this.pictBoxDaigram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBoxDaigram.Location = new System.Drawing.Point(-1, -1);
            this.pictBoxDaigram.Name = "pictBoxDaigram";
            this.pictBoxDaigram.Size = new System.Drawing.Size(512, 512);
            this.pictBoxDaigram.TabIndex = 0;
            this.pictBoxDaigram.TabStop = false;
            this.pictBoxDaigram.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbHousePlan_MouseClick);
            // 
            // VoronoiDiagramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(754, 536);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.contextPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VoronoiDiagramForm";
            this.Text = "VoronoiDiagram";
            this.contextPanel.ResumeLayout(false);
            this.contextPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.DaigramPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxDaigram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel contextPanel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox showBuildPlan;
        private System.Windows.Forms.CheckBox showDiagram;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel DaigramPanel;
        private System.Windows.Forms.PictureBox pictBoxDaigram;
    }
}

