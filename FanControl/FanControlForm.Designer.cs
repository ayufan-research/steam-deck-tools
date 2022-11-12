﻿namespace FanControl
{
    partial class FanControlForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FanControlForm));
            this.fanLoopTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fanModeSelectNotifyMenu = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fanModeSelectMenu = new System.Windows.Forms.ToolStripComboBox();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStartupOnBoot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyGridUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.helpLabel = new System.Windows.Forms.Label();
            this.sensorWarningLabel = new System.Windows.Forms.Label();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.contextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fanLoopTimer
            // 
            this.fanLoopTimer.Enabled = true;
            this.fanLoopTimer.Interval = 250;
            this.fanLoopTimer.Tick += new System.EventHandler(this.fanLoopTimer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Test";
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Steam Deck Fan Control";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.formShow_Event);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fanModeSelectNotifyMenu,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.contextMenu.Name = "fanModeSelectMenu";
            this.contextMenu.Size = new System.Drawing.Size(311, 96);
            // 
            // fanModeSelectNotifyMenu
            // 
            this.fanModeSelectNotifyMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fanModeSelectNotifyMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fanModeSelectNotifyMenu.Name = "fanModeSelectNotifyMenu";
            this.fanModeSelectNotifyMenu.Size = new System.Drawing.Size(250, 40);
            this.fanModeSelectNotifyMenu.SelectedIndexChanged += new System.EventHandler(this.fanModeSelect_SelectedValueChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(307, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(310, 38);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.formClose_Event);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fanModeSelectMenu,
            this.controlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 44);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fanModeSelectMenu
            // 
            this.fanModeSelectMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fanModeSelectMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fanModeSelectMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fanModeSelectMenu.Name = "fanModeSelectMenu";
            this.fanModeSelectMenu.Size = new System.Drawing.Size(250, 40);
            this.fanModeSelectMenu.SelectedIndexChanged += new System.EventHandler(this.fanModeSelect_SelectedValueChanged);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStartupOnBoot,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(113, 40);
            this.controlToolStripMenuItem.Text = "&Control";
            // 
            // toolStripMenuItemStartupOnBoot
            // 
            this.toolStripMenuItemStartupOnBoot.Name = "toolStripMenuItemStartupOnBoot";
            this.toolStripMenuItemStartupOnBoot.Size = new System.Drawing.Size(315, 44);
            this.toolStripMenuItemStartupOnBoot.Text = "&Startup on Boot";
            this.toolStripMenuItemStartupOnBoot.Click += new System.EventHandler(this.toolStripMenuItemStartupOnBoot_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(312, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(315, 44);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.formClose_Event);
            // 
            // propertyGridUpdateTimer
            // 
            this.propertyGridUpdateTimer.Enabled = true;
            this.propertyGridUpdateTimer.Interval = 1000;
            this.propertyGridUpdateTimer.Tick += new System.EventHandler(this.propertyGridUpdateTimer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.helpLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.sensorWarningLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.propertyGrid1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(712, 989);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 893);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 64);
            this.label1.TabIndex = 9;
            this.label1.Text = "This application is highly experimental.\r\nUse at your own risk!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpLabel.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.helpLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.helpLabel.Location = new System.Drawing.Point(3, 957);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(706, 32);
            this.helpLabel.TabIndex = 8;
            this.helpLabel.Text = "https://github.com/ayufan-research/SteamDeckTools";
            this.helpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sensorWarningLabel
            // 
            this.sensorWarningLabel.AutoSize = true;
            this.sensorWarningLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sensorWarningLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sensorWarningLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sensorWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.sensorWarningLabel.Location = new System.Drawing.Point(3, 797);
            this.sensorWarningLabel.Name = "sensorWarningLabel";
            this.sensorWarningLabel.Size = new System.Drawing.Size(706, 96);
            this.sensorWarningLabel.TabIndex = 6;
            this.sensorWarningLabel.Text = "Some sensors are missing.\r\nThe fan behavior might be incorrect.\r\nWhich might resu" +
    "lt in device overheating.\r\n";
            this.sensorWarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sensorWarningLabel.Visible = false;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.DisabledItemForeColor = System.Drawing.SystemColors.ControlText;
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(706, 791);
            this.propertyGrid1.TabIndex = 1;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // FanControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 1033);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FanControlForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Deck Fan Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FanControlForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FanControlForm_FormClosed);
            this.contextMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer fanLoopTimer;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenu;
        private MenuStrip menuStrip1;
        private ToolStripComboBox fanModeSelectNotifyMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripComboBox fanModeSelectMenu;
        private ToolStripMenuItem controlToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer propertyGridUpdateTimer;
        private TableLayoutPanel tableLayoutPanel1;
        private Label sensorWarningLabel;
        private PropertyGrid propertyGrid1;
        private ToolStripMenuItem toolStripMenuItemStartupOnBoot;
        private ToolStripSeparator toolStripSeparator2;
        private Label label1;
        private Label helpLabel;
    }
}