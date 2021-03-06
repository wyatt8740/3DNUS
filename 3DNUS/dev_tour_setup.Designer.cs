﻿namespace _3DNUS_Material_Edition
{
    partial class dev_tour_setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_tour_setup));
            this.lbl_body = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.b_fin = new MaterialSkin.Controls.MaterialFlatButton();
            this.chck_music = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtbx_flags = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_sys_type = new MaterialSkin.Controls.MaterialLabel();
            this.old_3ds = new MaterialSkin.Controls.MaterialRadioButton();
            this.new_3ds = new MaterialSkin.Controls.MaterialRadioButton();
            this.chck_auto_upd = new MaterialSkin.Controls.MaterialCheckBox();
            this.chck_dump_info = new MaterialSkin.Controls.MaterialCheckBox();
            this.lbl_flags = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lbl_body
            // 
            this.lbl_body.BackColor = System.Drawing.Color.Transparent;
            this.lbl_body.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_body.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_body.Location = new System.Drawing.Point(0, 108);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(579, 58);
            this.lbl_body.TabIndex = 6;
            this.lbl_body.Text = "Go ahead and select what Features and Options you want enabled.";
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(579, 108);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Let\'s get things Setup:";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // b_fin
            // 
            this.b_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_fin.AutoSize = true;
            this.b_fin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_fin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.b_fin.Depth = 0;
            this.b_fin.Location = new System.Drawing.Point(524, 416);
            this.b_fin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.b_fin.MouseState = MaterialSkin.MouseState.HOVER;
            this.b_fin.Name = "b_fin";
            this.b_fin.Primary = false;
            this.b_fin.Size = new System.Drawing.Size(55, 36);
            this.b_fin.TabIndex = 4;
            this.b_fin.Text = "finish";
            this.b_fin.UseVisualStyleBackColor = false;
            this.b_fin.Click += new System.EventHandler(this.b_fin_Click);
            // 
            // chck_music
            // 
            this.chck_music.AutoSize = true;
            this.chck_music.BackColor = System.Drawing.Color.Transparent;
            this.chck_music.Depth = 0;
            this.chck_music.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_music.Location = new System.Drawing.Point(5, 219);
            this.chck_music.Margin = new System.Windows.Forms.Padding(0);
            this.chck_music.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_music.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_music.Name = "chck_music";
            this.chck_music.Ripple = true;
            this.chck_music.Size = new System.Drawing.Size(119, 30);
            this.chck_music.TabIndex = 23;
            this.chck_music.Text = "Enable Music? ";
            this.chck_music.UseVisualStyleBackColor = false;
            // 
            // txtbx_flags
            // 
            this.txtbx_flags.Depth = 0;
            this.txtbx_flags.Hint = "Enter any Application Flags here";
            this.txtbx_flags.Location = new System.Drawing.Point(5, 387);
            this.txtbx_flags.MaxLength = 32767;
            this.txtbx_flags.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbx_flags.Name = "txtbx_flags";
            this.txtbx_flags.PasswordChar = '\0';
            this.txtbx_flags.SelectedText = "";
            this.txtbx_flags.SelectionLength = 0;
            this.txtbx_flags.SelectionStart = 0;
            this.txtbx_flags.Size = new System.Drawing.Size(349, 23);
            this.txtbx_flags.TabIndex = 22;
            this.txtbx_flags.TabStop = false;
            this.txtbx_flags.Text = "-v dev_mode=1 ext_mng=1";
            this.txtbx_flags.UseSystemPasswordChar = false;
            // 
            // lbl_sys_type
            // 
            this.lbl_sys_type.AutoSize = true;
            this.lbl_sys_type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sys_type.Depth = 0;
            this.lbl_sys_type.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_sys_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_sys_type.Location = new System.Drawing.Point(4, 263);
            this.lbl_sys_type.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_sys_type.Name = "lbl_sys_type";
            this.lbl_sys_type.Size = new System.Drawing.Size(120, 19);
            this.lbl_sys_type.TabIndex = 21;
            this.lbl_sys_type.Text = "Default Titlelist: ";
            // 
            // old_3ds
            // 
            this.old_3ds.AutoSize = true;
            this.old_3ds.Checked = true;
            this.old_3ds.Depth = 0;
            this.old_3ds.Font = new System.Drawing.Font("Roboto", 10F);
            this.old_3ds.Location = new System.Drawing.Point(5, 322);
            this.old_3ds.Margin = new System.Windows.Forms.Padding(0);
            this.old_3ds.MouseLocation = new System.Drawing.Point(-1, -1);
            this.old_3ds.MouseState = MaterialSkin.MouseState.HOVER;
            this.old_3ds.Name = "old_3ds";
            this.old_3ds.Ripple = true;
            this.old_3ds.Size = new System.Drawing.Size(78, 30);
            this.old_3ds.TabIndex = 20;
            this.old_3ds.TabStop = true;
            this.old_3ds.Text = "Old 3DS";
            this.old_3ds.UseVisualStyleBackColor = true;
            // 
            // new_3ds
            // 
            this.new_3ds.AutoSize = true;
            this.new_3ds.Depth = 0;
            this.new_3ds.Font = new System.Drawing.Font("Roboto", 10F);
            this.new_3ds.Location = new System.Drawing.Point(5, 292);
            this.new_3ds.Margin = new System.Windows.Forms.Padding(0);
            this.new_3ds.MouseLocation = new System.Drawing.Point(-1, -1);
            this.new_3ds.MouseState = MaterialSkin.MouseState.HOVER;
            this.new_3ds.Name = "new_3ds";
            this.new_3ds.Ripple = true;
            this.new_3ds.Size = new System.Drawing.Size(85, 30);
            this.new_3ds.TabIndex = 19;
            this.new_3ds.Text = "New 3DS";
            this.new_3ds.UseVisualStyleBackColor = true;
            // 
            // chck_auto_upd
            // 
            this.chck_auto_upd.AutoSize = true;
            this.chck_auto_upd.BackColor = System.Drawing.Color.Transparent;
            this.chck_auto_upd.Checked = true;
            this.chck_auto_upd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chck_auto_upd.Depth = 0;
            this.chck_auto_upd.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_auto_upd.Location = new System.Drawing.Point(5, 189);
            this.chck_auto_upd.Margin = new System.Windows.Forms.Padding(0);
            this.chck_auto_upd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_auto_upd.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_auto_upd.Name = "chck_auto_upd";
            this.chck_auto_upd.Ripple = true;
            this.chck_auto_upd.Size = new System.Drawing.Size(166, 30);
            this.chck_auto_upd.TabIndex = 18;
            this.chck_auto_upd.Text = "Enable Auto-Updates? ";
            this.chck_auto_upd.UseVisualStyleBackColor = false;
            // 
            // chck_dump_info
            // 
            this.chck_dump_info.AutoSize = true;
            this.chck_dump_info.BackColor = System.Drawing.Color.Transparent;
            this.chck_dump_info.Depth = 0;
            this.chck_dump_info.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_dump_info.Location = new System.Drawing.Point(5, 159);
            this.chck_dump_info.Margin = new System.Windows.Forms.Padding(0);
            this.chck_dump_info.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_dump_info.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_dump_info.Name = "chck_dump_info";
            this.chck_dump_info.Ripple = true;
            this.chck_dump_info.Size = new System.Drawing.Size(271, 30);
            this.chck_dump_info.TabIndex = 17;
            this.chck_dump_info.Text = "When dumping log, Dump System Info? ";
            this.chck_dump_info.UseVisualStyleBackColor = false;
            // 
            // lbl_flags
            // 
            this.lbl_flags.AutoSize = true;
            this.lbl_flags.BackColor = System.Drawing.Color.Transparent;
            this.lbl_flags.Depth = 0;
            this.lbl_flags.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_flags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_flags.Location = new System.Drawing.Point(1, 365);
            this.lbl_flags.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_flags.Name = "lbl_flags";
            this.lbl_flags.Size = new System.Drawing.Size(129, 19);
            this.lbl_flags.TabIndex = 24;
            this.lbl_flags.Text = "Application Flags:";
            // 
            // dev_tour_setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 451);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_flags);
            this.Controls.Add(this.chck_music);
            this.Controls.Add(this.txtbx_flags);
            this.Controls.Add(this.lbl_sys_type);
            this.Controls.Add(this.old_3ds);
            this.Controls.Add(this.new_3ds);
            this.Controls.Add(this.chck_auto_upd);
            this.Controls.Add(this.chck_dump_info);
            this.Controls.Add(this.lbl_body);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.b_fin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dev_tour_setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3DNUS: Tour";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.dev_tour_setup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_body;
        private System.Windows.Forms.Label lbl_title;
        private MaterialSkin.Controls.MaterialFlatButton b_fin;
        private MaterialSkin.Controls.MaterialCheckBox chck_music;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtbx_flags;
        private MaterialSkin.Controls.MaterialLabel lbl_sys_type;
        private MaterialSkin.Controls.MaterialRadioButton old_3ds;
        private MaterialSkin.Controls.MaterialRadioButton new_3ds;
        private MaterialSkin.Controls.MaterialCheckBox chck_auto_upd;
        private MaterialSkin.Controls.MaterialCheckBox chck_dump_info;
        private MaterialSkin.Controls.MaterialLabel lbl_flags;
    }
}