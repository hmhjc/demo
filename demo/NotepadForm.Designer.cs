﻿namespace demo
{
    partial class NotepadForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_new = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_open = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_pageset = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_print = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_revocation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_find = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_findnext = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_replace = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_toline = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_allselect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_time = new System.Windows.Forms.ToolStripMenuItem();
            this.格式OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_autochangeline = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_font = new System.Windows.Forms.ToolStripMenuItem();
            this.查看VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.状态栏SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_about = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.编辑EToolStripMenuItem,
            this.格式OToolStripMenuItem,
            this.查看VToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1269, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_new,
            this.tsmi_open,
            this.tsmi_save,
            this.tsmi_saveas,
            this.toolStripSeparator1,
            this.tsmi_pageset,
            this.tsmi_print,
            this.toolStripSeparator2,
            this.tsmi_exit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(58, 21);
            this.toolStripMenuItem1.Text = "文件(F)";
            // 
            // tsmi_new
            // 
            this.tsmi_new.Name = "tsmi_new";
            this.tsmi_new.Size = new System.Drawing.Size(189, 22);
            this.tsmi_new.Text = "新建(N)        Ctrl+N";
            this.tsmi_new.Click += new System.EventHandler(this.tsmi_new_Click);
            // 
            // tsmi_open
            // 
            this.tsmi_open.Name = "tsmi_open";
            this.tsmi_open.Size = new System.Drawing.Size(189, 22);
            this.tsmi_open.Text = "打开(O)        Ctrl+O";
            this.tsmi_open.Click += new System.EventHandler(this.tsmi_open_Click);
            // 
            // tsmi_save
            // 
            this.tsmi_save.Name = "tsmi_save";
            this.tsmi_save.Size = new System.Drawing.Size(189, 22);
            this.tsmi_save.Text = "保存(S)        Ctrl+S";
            this.tsmi_save.Click += new System.EventHandler(this.tsmi_save_Click);
            // 
            // tsmi_saveas
            // 
            this.tsmi_saveas.Name = "tsmi_saveas";
            this.tsmi_saveas.Size = new System.Drawing.Size(189, 22);
            this.tsmi_saveas.Text = "另存为(A)";
            this.tsmi_saveas.Click += new System.EventHandler(this.tsmi_saveas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // tsmi_pageset
            // 
            this.tsmi_pageset.Name = "tsmi_pageset";
            this.tsmi_pageset.Size = new System.Drawing.Size(189, 22);
            this.tsmi_pageset.Text = "页面设置(U)";
            this.tsmi_pageset.Click += new System.EventHandler(this.tsmi_pageset_Click);
            // 
            // tsmi_print
            // 
            this.tsmi_print.Name = "tsmi_print";
            this.tsmi_print.Size = new System.Drawing.Size(189, 22);
            this.tsmi_print.Text = "打印(P)        Ctrl+p";
            this.tsmi_print.Click += new System.EventHandler(this.tsmi_print_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // tsmi_exit
            // 
            this.tsmi_exit.Name = "tsmi_exit";
            this.tsmi_exit.Size = new System.Drawing.Size(189, 22);
            this.tsmi_exit.Text = "退出(X)";
            this.tsmi_exit.Click += new System.EventHandler(this.tsmi_exit_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_revocation,
            this.toolStripSeparator3,
            this.tsmi_cut,
            this.tsmi_copy,
            this.tsmi_paste,
            this.tsmi_delete,
            this.toolStripSeparator4,
            this.tsmi_find,
            this.tsmi_findnext,
            this.tsmi_replace,
            this.tsmi_toline,
            this.toolStripSeparator5,
            this.tsmi_allselect,
            this.tsmi_time});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.编辑EToolStripMenuItem.Text = "编辑(E)";
            // 
            // tsmi_revocation
            // 
            this.tsmi_revocation.Name = "tsmi_revocation";
            this.tsmi_revocation.Size = new System.Drawing.Size(187, 22);
            this.tsmi_revocation.Text = "撤销(U)        Ctrl+Z";
            this.tsmi_revocation.Click += new System.EventHandler(this.tsmi_revocation_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // tsmi_cut
            // 
            this.tsmi_cut.Name = "tsmi_cut";
            this.tsmi_cut.Size = new System.Drawing.Size(187, 22);
            this.tsmi_cut.Text = "剪切(T)        Ctrl+X";
            this.tsmi_cut.Click += new System.EventHandler(this.tsmi_cut_Click);
            // 
            // tsmi_copy
            // 
            this.tsmi_copy.Name = "tsmi_copy";
            this.tsmi_copy.Size = new System.Drawing.Size(187, 22);
            this.tsmi_copy.Text = "复制(C)        Ctrl+C";
            this.tsmi_copy.Click += new System.EventHandler(this.tsmi_copy_Click);
            // 
            // tsmi_paste
            // 
            this.tsmi_paste.Name = "tsmi_paste";
            this.tsmi_paste.Size = new System.Drawing.Size(187, 22);
            this.tsmi_paste.Text = "粘贴(P)        Ctrl+V";
            this.tsmi_paste.Click += new System.EventHandler(this.tsmi_paste_Click);
            // 
            // tsmi_delete
            // 
            this.tsmi_delete.Name = "tsmi_delete";
            this.tsmi_delete.Size = new System.Drawing.Size(187, 22);
            this.tsmi_delete.Text = "删除(L)             Del";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(184, 6);
            // 
            // tsmi_find
            // 
            this.tsmi_find.Name = "tsmi_find";
            this.tsmi_find.Size = new System.Drawing.Size(187, 22);
            this.tsmi_find.Text = "查找(F)        Ctrl+F";
            this.tsmi_find.Click += new System.EventHandler(this.tsmi_find_Click);
            // 
            // tsmi_findnext
            // 
            this.tsmi_findnext.Name = "tsmi_findnext";
            this.tsmi_findnext.Size = new System.Drawing.Size(187, 22);
            this.tsmi_findnext.Text = "查找下一个(N)    F3";
            this.tsmi_findnext.Click += new System.EventHandler(this.tsmi_findnext_Click);
            // 
            // tsmi_replace
            // 
            this.tsmi_replace.Name = "tsmi_replace";
            this.tsmi_replace.Size = new System.Drawing.Size(187, 22);
            this.tsmi_replace.Text = "替换(R)        Ctrl+H";
            this.tsmi_replace.Click += new System.EventHandler(this.tsmi_replace_Click);
            // 
            // tsmi_toline
            // 
            this.tsmi_toline.Name = "tsmi_toline";
            this.tsmi_toline.Size = new System.Drawing.Size(187, 22);
            this.tsmi_toline.Text = "转到(G)        Ctrl+G";
            this.tsmi_toline.Click += new System.EventHandler(this.tsmi_toline_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(184, 6);
            // 
            // tsmi_allselect
            // 
            this.tsmi_allselect.Name = "tsmi_allselect";
            this.tsmi_allselect.Size = new System.Drawing.Size(187, 22);
            this.tsmi_allselect.Text = "全选(A)        Ctrl+A";
            this.tsmi_allselect.Click += new System.EventHandler(this.tsmi_allselect_Click);
            // 
            // tsmi_time
            // 
            this.tsmi_time.Name = "tsmi_time";
            this.tsmi_time.Size = new System.Drawing.Size(187, 22);
            this.tsmi_time.Text = "日期/时间(D)       F5";
            this.tsmi_time.Click += new System.EventHandler(this.tsmi_time_Click);
            // 
            // 格式OToolStripMenuItem
            // 
            this.格式OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_autochangeline,
            this.tsmi_font});
            this.格式OToolStripMenuItem.Name = "格式OToolStripMenuItem";
            this.格式OToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.格式OToolStripMenuItem.Text = "格式(O)";
            // 
            // tsmi_autochangeline
            // 
            this.tsmi_autochangeline.Name = "tsmi_autochangeline";
            this.tsmi_autochangeline.Size = new System.Drawing.Size(152, 22);
            this.tsmi_autochangeline.Text = "自动换行(W)";
            this.tsmi_autochangeline.Click += new System.EventHandler(this.tsmi_autochangeline_Click);
            // 
            // tsmi_font
            // 
            this.tsmi_font.Name = "tsmi_font";
            this.tsmi_font.Size = new System.Drawing.Size(152, 22);
            this.tsmi_font.Text = "字体(F)";
            this.tsmi_font.Click += new System.EventHandler(this.tsmi_font_Click);
            // 
            // 查看VToolStripMenuItem
            // 
            this.查看VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.状态栏SToolStripMenuItem});
            this.查看VToolStripMenuItem.Name = "查看VToolStripMenuItem";
            this.查看VToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.查看VToolStripMenuItem.Text = "查看(V)";
            // 
            // 状态栏SToolStripMenuItem
            // 
            this.状态栏SToolStripMenuItem.Name = "状态栏SToolStripMenuItem";
            this.状态栏SToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.状态栏SToolStripMenuItem.Text = "状态栏(S)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助ToolStripMenuItem,
            this.toolStripSeparator6,
            this.tsmi_about});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(H)";
            // 
            // 查看帮助ToolStripMenuItem
            // 
            this.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
            this.查看帮助ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查看帮助ToolStripMenuItem.Text = "查看帮助(H)";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmi_about
            // 
            this.tsmi_about.Name = "tsmi_about";
            this.tsmi_about.Size = new System.Drawing.Size(152, 22);
            this.tsmi_about.Text = "关于记事本(A)";
            this.tsmi_about.Click += new System.EventHandler(this.tsmi_about_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 623);
            this.panel1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1269, 623);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // NotepadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NotepadForm";
            this.Text = "notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_new;
        private System.Windows.Forms.ToolStripMenuItem tsmi_open;
        private System.Windows.Forms.ToolStripMenuItem tsmi_save;
        private System.Windows.Forms.ToolStripMenuItem tsmi_saveas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_pageset;
        private System.Windows.Forms.ToolStripMenuItem tsmi_print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exit;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_revocation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmi_cut;
        private System.Windows.Forms.ToolStripMenuItem tsmi_copy;
        private System.Windows.Forms.ToolStripMenuItem tsmi_paste;
        private System.Windows.Forms.ToolStripMenuItem tsmi_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmi_find;
        private System.Windows.Forms.ToolStripMenuItem tsmi_findnext;
        private System.Windows.Forms.ToolStripMenuItem tsmi_replace;
        private System.Windows.Forms.ToolStripMenuItem tsmi_toline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmi_allselect;
        private System.Windows.Forms.ToolStripMenuItem tsmi_time;
        private System.Windows.Forms.ToolStripMenuItem 格式OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_autochangeline;
        private System.Windows.Forms.ToolStripMenuItem tsmi_font;
        private System.Windows.Forms.ToolStripMenuItem 查看VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 状态栏SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmi_about;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}