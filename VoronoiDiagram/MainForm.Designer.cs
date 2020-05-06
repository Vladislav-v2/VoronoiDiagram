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
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.BuildingPlanImage = new System.Windows.Forms.Panel();
            this.openPlanFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenPlanFile = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            this.BuildingPlanImage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictBox
            // 
            this.pictBox.BackColor = System.Drawing.Color.Transparent;
            this.pictBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBox.Location = new System.Drawing.Point(0, 0);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(512, 512);
            this.pictBox.TabIndex = 0;
            this.pictBox.TabStop = false;
            this.pictBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbHousePlan_MouseClick);            // 
            // BuildingPlanImage
            // 
            this.BuildingPlanImage.Controls.Add(this.pictBox);
            this.BuildingPlanImage.Location = new System.Drawing.Point(12, 12);
            this.BuildingPlanImage.Name = "BuildingPlanImage";
            this.BuildingPlanImage.Size = new System.Drawing.Size(513, 513);
            this.BuildingPlanImage.TabIndex = 5;
            // 
            // openPlanFile
            // 
            this.openPlanFile.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            this.openPlanFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openPlanFile_FileOk);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOpenPlanFile);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(535, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 538);
            this.panel1.TabIndex = 6;
            // 
            // btnOpenPlanFile
            // 
            this.btnOpenPlanFile.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnOpenPlanFile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOpenPlanFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOpenPlanFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPlanFile.Location = new System.Drawing.Point(109, 12);
            this.btnOpenPlanFile.Name = "btnOpenPlanFile";
            this.btnOpenPlanFile.Size = new System.Drawing.Size(95, 38);
            this.btnOpenPlanFile.TabIndex = 4;
            this.btnOpenPlanFile.Text = "Load building plan";
            this.btnOpenPlanFile.UseVisualStyleBackColor = true;
            this.btnOpenPlanFile.Click += new System.EventHandler(this.btnOpenPlanFile_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(8, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // VoronoiDiagramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(747, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BuildingPlanImage);
            this.Name = "VoronoiDiagramForm";
            this.Text = "VoronoiDiagram";
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            this.BuildingPlanImage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBox;
        private System.Windows.Forms.Panel BuildingPlanImage;
        private System.Windows.Forms.OpenFileDialog openPlanFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpenPlanFile;
        private System.Windows.Forms.Button btnClear;
    }
}

