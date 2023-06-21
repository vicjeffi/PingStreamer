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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.settings_panel = new System.Windows.Forms.Panel();
            this.timeStatistic_panel = new System.Windows.Forms.Panel();
            this.SelectedResult_panel = new System.Windows.Forms.Panel();
            this.sourses_groupBox = new System.Windows.Forms.GroupBox();
            this.sourses_treeView = new System.Windows.Forms.TreeView();
            this.results_panel = new System.Windows.Forms.Panel();
            this.results_dataGridView = new System.Windows.Forms.DataGridView();
            this.sourses_groupBox.SuspendLayout();
            this.results_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results_dataGridView)).BeginInit();
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
            // results_panel
            // 
            this.results_panel.Controls.Add(this.results_dataGridView);
            this.results_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.results_panel.Location = new System.Drawing.Point(209, 35);
            this.results_panel.Name = "results_panel";
            this.results_panel.Padding = new System.Windows.Forms.Padding(3, 6, 3, 1);
            this.results_panel.Size = new System.Drawing.Size(684, 430);
            this.results_panel.TabIndex = 4;
            // 
            // results_dataGridView
            // 
            this.results_dataGridView.AllowUserToAddRows = false;
            this.results_dataGridView.AllowUserToDeleteRows = false;
            this.results_dataGridView.AllowUserToOrderColumns = true;
            this.results_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.results_dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.results_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.results_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results_dataGridView.ColumnHeadersVisible = false;
            this.results_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.results_dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.results_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.results_dataGridView.Location = new System.Drawing.Point(3, 6);
            this.results_dataGridView.Name = "results_dataGridView";
            this.results_dataGridView.ReadOnly = true;
            this.results_dataGridView.RowHeadersVisible = false;
            this.results_dataGridView.Size = new System.Drawing.Size(678, 423);
            this.results_dataGridView.TabIndex = 0;
            this.results_dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.results_dataGridView_CellFormatting);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 660);
            this.Controls.Add(this.results_panel);
            this.Controls.Add(this.sourses_groupBox);
            this.Controls.Add(this.SelectedResult_panel);
            this.Controls.Add(this.timeStatistic_panel);
            this.Controls.Add(this.settings_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sourses_groupBox.ResumeLayout(false);
            this.results_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.results_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settings_panel;
        private System.Windows.Forms.Panel timeStatistic_panel;
        private System.Windows.Forms.Panel SelectedResult_panel;
        private System.Windows.Forms.GroupBox sourses_groupBox;
        private System.Windows.Forms.TreeView sourses_treeView;
        private System.Windows.Forms.Panel results_panel;
        private System.Windows.Forms.DataGridView results_dataGridView;
    }
}

