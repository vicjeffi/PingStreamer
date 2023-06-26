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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Интернет", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Этот компьютер", 2, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Глобальная сеть", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Хорошее подлючение", 3, 3);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Плохое подключение", 4, 4);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ошибка подлючения", 5, 5);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Результаты сканирования", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            this.soursesTreeNodes_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSourse_toolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllSourses_toolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeStatistic_panel = new System.Windows.Forms.Panel();
            this.treeIcons_imageList = new System.Windows.Forms.ImageList(this.components);
            this.soursesTreeNode_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toggleState_toolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSourse_toolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSourse_toolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settings_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.file_toolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.results_panel = new System.Windows.Forms.Panel();
            this.results_dataGridView = new System.Windows.Forms.DataGridView();
            this.sourses_groupBox = new System.Windows.Forms.GroupBox();
            this.sourses_treeView = new System.Windows.Forms.TreeView();
            this.SelectedResult_panel = new System.Windows.Forms.Panel();
            this.soursesTreeNodes_contextMenuStrip.SuspendLayout();
            this.soursesTreeNode_contextMenuStrip.SuspendLayout();
            this.settings_MenuStrip.SuspendLayout();
            this.results_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results_dataGridView)).BeginInit();
            this.sourses_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // soursesTreeNodes_contextMenuStrip
            // 
            this.soursesTreeNodes_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSourse_toolItem,
            this.clearAllSourses_toolItem});
            this.soursesTreeNodes_contextMenuStrip.Name = "soursesTreeAddNode_contextMenuStrip";
            this.soursesTreeNodes_contextMenuStrip.Size = new System.Drawing.Size(181, 70);
            // 
            // addSourse_toolItem
            // 
            this.addSourse_toolItem.Name = "addSourse_toolItem";
            this.addSourse_toolItem.Size = new System.Drawing.Size(180, 22);
            this.addSourse_toolItem.Text = "Добавить элимент";
            this.addSourse_toolItem.Click += new System.EventHandler(this.addSourse_toolItem_Click);
            // 
            // clearAllSourses_toolItem
            // 
            this.clearAllSourses_toolItem.Name = "clearAllSourses_toolItem";
            this.clearAllSourses_toolItem.Size = new System.Drawing.Size(180, 22);
            this.clearAllSourses_toolItem.Text = "Очистить папку";
            // 
            // timeStatistic_panel
            // 
            this.timeStatistic_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timeStatistic_panel.Location = new System.Drawing.Point(0, 622);
            this.timeStatistic_panel.Name = "timeStatistic_panel";
            this.timeStatistic_panel.Size = new System.Drawing.Size(893, 38);
            this.timeStatistic_panel.TabIndex = 1;
            // 
            // treeIcons_imageList
            // 
            this.treeIcons_imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeIcons_imageList.ImageStream")));
            this.treeIcons_imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.treeIcons_imageList.Images.SetKeyName(0, "folder-sign-icon.png");
            this.treeIcons_imageList.Images.SetKeyName(1, "ethernet-sign-icon.png");
            this.treeIcons_imageList.Images.SetKeyName(2, "this-computer-sign-icon.png");
            this.treeIcons_imageList.Images.SetKeyName(3, "good-sign-icon.png");
            this.treeIcons_imageList.Images.SetKeyName(4, "warning-sign-icon.png");
            this.treeIcons_imageList.Images.SetKeyName(5, "error-icon-sign.png");
            // 
            // soursesTreeNode_contextMenuStrip
            // 
            this.soursesTreeNode_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleState_toolItem,
            this.deleteSourse_toolItem,
            this.editSourse_toolItem});
            this.soursesTreeNode_contextMenuStrip.Name = "soursesTreeAddNode_contextMenuStrip";
            this.soursesTreeNode_contextMenuStrip.Size = new System.Drawing.Size(199, 70);
            // 
            // toggleState_toolItem
            // 
            this.toggleState_toolItem.Name = "toggleState_toolItem";
            this.toggleState_toolItem.Size = new System.Drawing.Size(198, 22);
            this.toggleState_toolItem.Text = "Остановить/Запустить";
            // 
            // deleteSourse_toolItem
            // 
            this.deleteSourse_toolItem.Name = "deleteSourse_toolItem";
            this.deleteSourse_toolItem.Size = new System.Drawing.Size(198, 22);
            this.deleteSourse_toolItem.Text = "Удалить";
            // 
            // editSourse_toolItem
            // 
            this.editSourse_toolItem.Name = "editSourse_toolItem";
            this.editSourse_toolItem.Size = new System.Drawing.Size(198, 22);
            this.editSourse_toolItem.Text = "Редактировать";
            // 
            // settings_MenuStrip
            // 
            this.settings_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_toolItem});
            this.settings_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.settings_MenuStrip.Name = "settings_MenuStrip";
            this.settings_MenuStrip.Size = new System.Drawing.Size(893, 24);
            this.settings_MenuStrip.TabIndex = 3;
            this.settings_MenuStrip.Text = "menuStrip";
            // 
            // file_toolItem
            // 
            this.file_toolItem.Name = "file_toolItem";
            this.file_toolItem.Size = new System.Drawing.Size(48, 20);
            this.file_toolItem.Text = "Файл";
            // 
            // results_panel
            // 
            this.results_panel.Controls.Add(this.results_dataGridView);
            this.results_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.results_panel.Location = new System.Drawing.Point(209, 24);
            this.results_panel.Name = "results_panel";
            this.results_panel.Padding = new System.Windows.Forms.Padding(3, 6, 3, 1);
            this.results_panel.Size = new System.Drawing.Size(684, 441);
            this.results_panel.TabIndex = 16;
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
            this.results_dataGridView.Size = new System.Drawing.Size(678, 434);
            this.results_dataGridView.TabIndex = 0;
            this.results_dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.results_dataGridView_CellFormatting);
            // 
            // sourses_groupBox
            // 
            this.sourses_groupBox.Controls.Add(this.sourses_treeView);
            this.sourses_groupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.sourses_groupBox.Location = new System.Drawing.Point(0, 24);
            this.sourses_groupBox.Name = "sourses_groupBox";
            this.sourses_groupBox.Padding = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.sourses_groupBox.Size = new System.Drawing.Size(209, 441);
            this.sourses_groupBox.TabIndex = 15;
            this.sourses_groupBox.TabStop = false;
            // 
            // sourses_treeView
            // 
            this.sourses_treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourses_treeView.BackColor = System.Drawing.SystemColors.Control;
            this.sourses_treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sourses_treeView.ImageIndex = 0;
            this.sourses_treeView.ImageList = this.treeIcons_imageList;
            this.sourses_treeView.ItemHeight = 20;
            this.sourses_treeView.Location = new System.Drawing.Point(10, 16);
            this.sourses_treeView.Name = "sourses_treeView";
            treeNode1.ContextMenuStrip = this.soursesTreeNodes_contextMenuStrip;
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Ethernet";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Интернет";
            treeNode2.ContextMenuStrip = this.soursesTreeNode_contextMenuStrip;
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "ThisСomputer";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "Этот компьютер";
            treeNode3.Name = "Global";
            treeNode3.Text = "Глобальная сеть";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "GoodResultScans";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Text = "Хорошее подлючение";
            treeNode5.ImageIndex = 4;
            treeNode5.Name = "BadResultScans";
            treeNode5.SelectedImageIndex = 4;
            treeNode5.Text = "Плохое подключение";
            treeNode6.ImageIndex = 5;
            treeNode6.Name = "FatalErrorScans";
            treeNode6.SelectedImageIndex = 5;
            treeNode6.Text = "Ошибка подлючения";
            treeNode7.Name = "ScanResults";
            treeNode7.Text = "Результаты сканирования";
            this.sourses_treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7});
            this.sourses_treeView.SelectedImageIndex = 0;
            this.sourses_treeView.Size = new System.Drawing.Size(196, 255);
            this.sourses_treeView.TabIndex = 1;
            // 
            // SelectedResult_panel
            // 
            this.SelectedResult_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectedResult_panel.Location = new System.Drawing.Point(0, 465);
            this.SelectedResult_panel.Name = "SelectedResult_panel";
            this.SelectedResult_panel.Size = new System.Drawing.Size(893, 157);
            this.SelectedResult_panel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 660);
            this.Controls.Add(this.results_panel);
            this.Controls.Add(this.sourses_groupBox);
            this.Controls.Add(this.SelectedResult_panel);
            this.Controls.Add(this.settings_MenuStrip);
            this.Controls.Add(this.timeStatistic_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.soursesTreeNodes_contextMenuStrip.ResumeLayout(false);
            this.soursesTreeNode_contextMenuStrip.ResumeLayout(false);
            this.settings_MenuStrip.ResumeLayout(false);
            this.settings_MenuStrip.PerformLayout();
            this.results_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.results_dataGridView)).EndInit();
            this.sourses_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel timeStatistic_panel;
        private System.Windows.Forms.ImageList treeIcons_imageList;
        private System.Windows.Forms.ContextMenuStrip soursesTreeNodes_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addSourse_toolItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllSourses_toolItem;
        private System.Windows.Forms.ContextMenuStrip soursesTreeNode_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toggleState_toolItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSourse_toolItem;
        private System.Windows.Forms.ToolStripMenuItem editSourse_toolItem;
        private System.Windows.Forms.MenuStrip settings_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem file_toolItem;
        private System.Windows.Forms.Panel results_panel;
        private System.Windows.Forms.DataGridView results_dataGridView;
        private System.Windows.Forms.GroupBox sourses_groupBox;
        private System.Windows.Forms.TreeView sourses_treeView;
        private System.Windows.Forms.Panel SelectedResult_panel;
    }
}

