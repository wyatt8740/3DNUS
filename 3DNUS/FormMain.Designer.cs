﻿namespace _3DNUS_Material_Edition
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));


            this.materialContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();

            this.extensionManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_download = new System.Windows.Forms.Button();
            this.prog_main = new System.Windows.Forms.ProgressBar();
            this.prog_sub = new System.Windows.Forms.ProgressBar();
            this.t_titleid = new System.Windows.Forms.TextBox();
            this.t_log = new System.Windows.Forms.TextBox();
            this.old_3ds = new System.Windows.Forms.RadioButton();
            this.check_noerr = new System.Windows.Forms.CheckBox();
            this.new_3ds = new System.Windows.Forms.RadioButton();
            this.c_cia = new System.Windows.Forms.CheckBox();
            this.panel_ctl = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dev_look_forum = new System.Windows.Forms.Timer(this.components);
            this.lbl_ver = new System.Windows.Forms.Label();
            this.dev_repeat_msc = new System.Windows.Forms.Timer(this.components);
            this.materialContextMenuStrip1.SuspendLayout();
            this.panel_ctl.SuspendLayout();

            this.SuspendLayout();

            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extensionManagerToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
	
            // 
            // extensionManagerToolStripMenuItem
            // 
            this.extensionManagerToolStripMenuItem.Name = "extensionManagerToolStripMenuItem";
            this.extensionManagerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.extensionManagerToolStripMenuItem.Text = "Extension Manager";
            this.extensionManagerToolStripMenuItem.Click += new System.EventHandler(this.extensionManagerToolStripMenuItem_Click);

            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.settingsToolStripMenuItem.Text = "Settings";

            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);

            // 
            // b_download
            // 
            this.b_download.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_download.AutoSize = true;
            this.b_download.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_download.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_download.Location = new System.Drawing.Point(193, 353);
            this.b_download.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.b_download.Name = "b_download";
            this.b_download.Size = new System.Drawing.Size(130, 36);
            this.b_download.TabIndex = 0;
            this.b_download.Text = "Begin Download";
            this.b_download.Click += new System.EventHandler(this.materialFlatButton1_Click);

            // 
            // prog_main
            // 
            this.prog_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prog_main.Location = new System.Drawing.Point(12, 392);
            this.prog_main.Name = "prog_main";
            this.prog_main.Size = new System.Drawing.Size(511, 5);
            this.prog_main.TabIndex = 2;

            // 
            // prog_sub
            // 
            this.prog_sub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prog_sub.Location = new System.Drawing.Point(12, 403);
            this.prog_sub.Name = "prog_sub";
            this.prog_sub.Size = new System.Drawing.Size(511, 5);
            this.prog_sub.TabIndex = 2;

            // 
            // t_titleid
            // 
            this.t_titleid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_titleid.Location = new System.Drawing.Point(12, 12);
            this.t_titleid.MaxLength = 32767;
            this.t_titleid.BackColor = System.Drawing.SystemColors.Window;
            this.t_titleid.Name = "t_titleid";
            this.t_titleid.PasswordChar = '\0';
            this.t_titleid.SelectedText = "";
            this.t_titleid.SelectionLength = 0;
            this.t_titleid.SelectionStart = 0;
            this.t_titleid.Size = new System.Drawing.Size(511, 23);
            this.t_titleid.TabIndex = 3;
            this.t_titleid.TabStop = false;
            this.t_titleid.UseSystemPasswordChar = false;

            // 
            // t_log
            // 
            this.t_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_log.BackColor = System.Drawing.Color.Gainsboro;
            this.t_log.Location = new System.Drawing.Point(12, 79);
            this.t_log.Multiline = true;
            this.t_log.Name = "t_log";
            this.t_log.ReadOnly = true;
            this.t_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.t_log.Size = new System.Drawing.Size(511, 247);
            this.t_log.TabIndex = 4;
            this.t_log.Text = "Console: ";

            // 
            // old_3ds
            // 
            this.old_3ds.AutoSize = true;
            this.old_3ds.Checked = true;
            this.old_3ds.Font = new System.Drawing.Font("Roboto", 10F);
            this.old_3ds.Location = new System.Drawing.Point(278, -1);
            this.old_3ds.Margin = new System.Windows.Forms.Padding(0);
            this.old_3ds.Name = "old_3ds";
            this.old_3ds.Size = new System.Drawing.Size(78, 30);
            this.old_3ds.TabIndex = 7;
            this.old_3ds.TabStop = true;
            this.old_3ds.Text = "Old 3DS";
            this.old_3ds.UseVisualStyleBackColor = true;
            this.old_3ds.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);

            // 
            // check_noerr
            // 
            this.check_noerr.AutoSize = true;
            this.check_noerr.Font = new System.Drawing.Font("Roboto", 10F);
            this.check_noerr.Location = new System.Drawing.Point(0, 0);
            this.check_noerr.Margin = new System.Windows.Forms.Padding(0);
            this.check_noerr.Name = "check_noerr";
            this.check_noerr.Size = new System.Drawing.Size(65, 30);
            this.check_noerr.TabIndex = 10;
            this.check_noerr.Text = "Silent";
            this.check_noerr.UseVisualStyleBackColor = true;

            // 
            // new_3ds
            // 
            this.new_3ds.AutoSize = true;
            this.new_3ds.Font = new System.Drawing.Font("Roboto", 10F);
            this.new_3ds.Location = new System.Drawing.Point(185, -1);
            this.new_3ds.Margin = new System.Windows.Forms.Padding(0);
            this.new_3ds.Name = "new_3ds";
            this.new_3ds.Size = new System.Drawing.Size(85, 30);
            this.new_3ds.TabIndex = 6;
            this.new_3ds.Text = "New 3DS";
            this.new_3ds.UseVisualStyleBackColor = true;
            this.new_3ds.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);

            // 
            // c_cia
            // 
            this.c_cia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_cia.AutoSize = true;
            this.c_cia.BackColor = System.Drawing.Color.Transparent;
            this.c_cia.Checked = true;
            this.c_cia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.c_cia.Font = new System.Drawing.Font("Roboto", 10F);
            this.c_cia.Location = new System.Drawing.Point(73, 0);
            this.c_cia.Margin = new System.Windows.Forms.Padding(0);
            this.c_cia.Name = "c_cia";
            this.c_cia.Size = new System.Drawing.Size(104, 30);
            this.c_cia.TabIndex = 1;
            this.c_cia.Text = "Pack as CIA";
            this.c_cia.UseVisualStyleBackColor = false;

            // 
            // panel_ctl
            // 
            this.panel_ctl.Controls.Add(this.c_cia);
            this.panel_ctl.Controls.Add(this.new_3ds);
            this.panel_ctl.Controls.Add(this.check_noerr);
            this.panel_ctl.Controls.Add(this.old_3ds);
            this.panel_ctl.Location = new System.Drawing.Point(53, 41);
            this.panel_ctl.Name = "panel_ctl";
            this.panel_ctl.Size = new System.Drawing.Size(363, 24);
            this.panel_ctl.TabIndex = 11;

            // 
            // materialFlatButton1
            // 
/*            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Location = new System.Drawing.Point(515, 68);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Size = new System.Drawing.Size(19, 36);
            this.materialFlatButton1.TabIndex = 12;
            this.materialFlatButton1.Text = "?";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
*/

            /* KEEP THIS LINE NO MATTER WHAT */
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click_1);

            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dump Log";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);

            // 
            // dev_look_forum
            // 
/*            this.dev_look_forum.Enabled = true;
            this.dev_look_forum.Tick += new System.EventHandler(this.dev_look_forum_Tick);*/

            // 
            // lbl_ver
            // 
            this.lbl_ver.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_ver.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_ver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ver.Location = new System.Drawing.Point(0, 450);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(535, 15);
            this.lbl_ver.TabIndex = 15;
            this.lbl_ver.Text = "%VER%";
            this.lbl_ver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(535, 420);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.lbl_ver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_ctl);
            this.Controls.Add(this.t_log);
            this.Controls.Add(this.t_titleid);
            this.Controls.Add(this.prog_sub);
            this.Controls.Add(this.prog_main);
            this.Controls.Add(this.b_download);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3DNUS: Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.FormMain_ResizeEnd);
            this.Resize += new System.EventHandler(this.FormMain_ResizeEnd);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.panel_ctl.ResumeLayout(false);
            this.panel_ctl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip materialContextMenuStrip1;

        private System.Windows.Forms.ToolStripMenuItem extensionManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        private System.Windows.Forms.Button b_download;

        private System.Windows.Forms.ProgressBar prog_main;

        private System.Windows.Forms.ProgressBar prog_sub;

        private System.Windows.Forms.TextBox t_titleid;

        private System.Windows.Forms.TextBox t_log;


        private System.Windows.Forms.RadioButton old_3ds;

        private System.Windows.Forms.CheckBox check_noerr;

        private System.Windows.Forms.RadioButton new_3ds;


        private System.Windows.Forms.CheckBox c_cia;


        private System.Windows.Forms.Panel panel_ctl;

        private System.Windows.Forms.Button materialFlatButton1;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;

        private System.Windows.Forms.Timer dev_look_forum;
        private System.Windows.Forms.Label lbl_ver;
        private System.Windows.Forms.Timer dev_repeat_msc;
    }
}

