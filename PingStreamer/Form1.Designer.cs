namespace PingStreamer
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
            this.settings_panel = new System.Windows.Forms.Panel();
            this.timeStatistic_panel = new System.Windows.Forms.Panel();
            this.SelectedResult_panel = new System.Windows.Forms.Panel();
            this.sourses_groupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sourses_treeView = new System.Windows.Forms.TreeView();
            this.sourses_groupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // settings_panel
            // 
            this.settings_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settings_panel.Location = new System.Drawing.Point(0, 0);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(893, 35);
            this.settings_panel.TabIndex = 0;
            // 
            // timeStatistic_panel
            // 
            this.timeStatistic_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timeStatistic_panel.Location = new System.Drawing.Point(0, 622);
            this.timeStatistic_panel.Name = "timeStatistic_panel";
            this.timeStatistic_panel.Size = new System.Drawing.Size(893, 38);
            this.timeStatistic_panel.TabIndex = 1;
            // 
            // SelectedResult_panel
            // 
            this.SelectedResult_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectedResult_panel.Location = new System.Drawing.Point(0, 465);
            this.SelectedResult_panel.Name = "SelectedResult_panel";
            this.SelectedResult_panel.Size = new System.Drawing.Size(893, 157);
            this.SelectedResult_panel.TabIndex = 2;
            // 
            // sourses_groupBox
            // 
            this.sourses_groupBox.Controls.Add(this.sourses_treeView);
            this.sourses_groupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.sourses_groupBox.Location = new System.Drawing.Point(0, 35);
            this.sourses_groupBox.Name = "sourses_groupBox";
            this.sourses_groupBox.Padding = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.sourses_groupBox.Size = new System.Drawing.Size(209, 430);
            this.sourses_groupBox.TabIndex = 3;
            this.sourses_groupBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(209, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 430);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(684, 430);
            this.dataGridView1.TabIndex = 0;
            // 
            // sourses_treeView
            // 
            this.sourses_treeView.BackColor = System.Drawing.SystemColors.Control;
            this.sourses_treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sourses_treeView.Dock = System.Windows.Forms.DockStyle.Top;
            this.sourses_treeView.Location = new System.Drawing.Point(10, 16);
            this.sourses_treeView.Name = "sourses_treeView";
            this.sourses_treeView.Size = new System.Drawing.Size(196, 97);
            this.sourses_treeView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sourses_groupBox);
            this.Controls.Add(this.SelectedResult_panel);
            this.Controls.Add(this.timeStatistic_panel);
            this.Controls.Add(this.settings_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sourses_groupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settings_panel;
        private System.Windows.Forms.Panel timeStatistic_panel;
        private System.Windows.Forms.Panel SelectedResult_panel;
        private System.Windows.Forms.GroupBox sourses_groupBox;
        private System.Windows.Forms.TreeView sourses_treeView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

