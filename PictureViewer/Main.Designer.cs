﻿namespace PictureViewer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.prinyItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.setPhotoshopLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSelectArea = new System.Windows.Forms.Button();
            this.buttonCropManual = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonCropNormal = new System.Windows.Forms.Button();
            this.buttonCropFace = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonOpenPhotoshop = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menu.SuspendLayout();
            this.tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1084, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menu";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openItemMenu,
            this.prinyItemMenu,
            this.setPhotoshopLocationToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitItemMenu});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.openToolStripMenuItem.Text = "Tùy chọn";
            // 
            // openItemMenu
            // 
            this.openItemMenu.Name = "openItemMenu";
            this.openItemMenu.Size = new System.Drawing.Size(200, 22);
            this.openItemMenu.Text = "Mở";
            this.openItemMenu.Click += new System.EventHandler(this.OpenItemMenu_Click);
            // 
            // prinyItemMenu
            // 
            this.prinyItemMenu.Name = "prinyItemMenu";
            this.prinyItemMenu.Size = new System.Drawing.Size(200, 22);
            this.prinyItemMenu.Text = "In";
            this.prinyItemMenu.Click += new System.EventHandler(this.PrinyItemMenu_Click);
            // 
            // setPhotoshopLocationToolStripMenuItem
            // 
            this.setPhotoshopLocationToolStripMenuItem.Name = "setPhotoshopLocationToolStripMenuItem";
            this.setPhotoshopLocationToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.setPhotoshopLocationToolStripMenuItem.Text = "Set Photoshop Location";
            this.setPhotoshopLocationToolStripMenuItem.Click += new System.EventHandler(this.SetPhotoshopLocationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // exitItemMenu
            // 
            this.exitItemMenu.Name = "exitItemMenu";
            this.exitItemMenu.Size = new System.Drawing.Size(200, 22);
            this.exitItemMenu.Text = "Exit";
            this.exitItemMenu.Click += new System.EventHandler(this.ExitItemMenu_Click);
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 4;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.Controls.Add(this.buttonSelectArea, 0, 2);
            this.tableLayout.Controls.Add(this.buttonCropManual, 0, 2);
            this.tableLayout.Controls.Add(this.pictureBox, 0, 1);
            this.tableLayout.Controls.Add(this.buttonPrint, 0, 0);
            this.tableLayout.Controls.Add(this.buttonCropNormal, 1, 0);
            this.tableLayout.Controls.Add(this.buttonCropFace, 2, 0);
            this.tableLayout.Controls.Add(this.buttonUndo, 3, 0);
            this.tableLayout.Controls.Add(this.buttonOpenPhotoshop, 2, 2);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 24);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 3;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout.Size = new System.Drawing.Size(1084, 713);
            this.tableLayout.TabIndex = 0;
            // 
            // buttonSelectArea
            // 
            this.buttonSelectArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelectArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSelectArea.Image = global::PictureViewer.Properties.Resources.select_icon;
            this.buttonSelectArea.Location = new System.Drawing.Point(274, 666);
            this.buttonSelectArea.Name = "buttonSelectArea";
            this.buttonSelectArea.Size = new System.Drawing.Size(265, 44);
            this.buttonSelectArea.TabIndex = 6;
            this.buttonSelectArea.Text = "Chọn vùng";
            this.buttonSelectArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelectArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSelectArea.UseVisualStyleBackColor = true;
            this.buttonSelectArea.Click += new System.EventHandler(this.ButtonSelectArea_Click);
            // 
            // buttonCropManual
            // 
            this.buttonCropManual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCropManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonCropManual.Image = global::PictureViewer.Properties.Resources.crop_icon;
            this.buttonCropManual.Location = new System.Drawing.Point(3, 666);
            this.buttonCropManual.Name = "buttonCropManual";
            this.buttonCropManual.Size = new System.Drawing.Size(265, 44);
            this.buttonCropManual.TabIndex = 5;
            this.buttonCropManual.Text = "Cắt thủ công";
            this.buttonCropManual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCropManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCropManual.UseVisualStyleBackColor = true;
            this.buttonCropManual.Click += new System.EventHandler(this.ButtonCropManual_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayout.SetColumnSpan(this.pictureBox, 4);
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::PictureViewer.Properties.Resources.no_image;
            this.pictureBox.Location = new System.Drawing.Point(3, 53);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1078, 607);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.WaitOnLoad = true;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonPrint.Image = global::PictureViewer.Properties.Resources.print_icon;
            this.buttonPrint.Location = new System.Drawing.Point(3, 3);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(265, 44);
            this.buttonPrint.TabIndex = 1;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // buttonCropNormal
            // 
            this.buttonCropNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCropNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonCropNormal.Image = global::PictureViewer.Properties.Resources.crop_icon;
            this.buttonCropNormal.Location = new System.Drawing.Point(274, 3);
            this.buttonCropNormal.Name = "buttonCropNormal";
            this.buttonCropNormal.Size = new System.Drawing.Size(265, 44);
            this.buttonCropNormal.TabIndex = 2;
            this.buttonCropNormal.Text = "Cắt ảnh thường";
            this.buttonCropNormal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCropNormal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCropNormal.UseVisualStyleBackColor = true;
            this.buttonCropNormal.Click += new System.EventHandler(this.ButtonCropNormal_Click);
            // 
            // buttonCropFace
            // 
            this.buttonCropFace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCropFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonCropFace.Image = global::PictureViewer.Properties.Resources.crop_icon;
            this.buttonCropFace.Location = new System.Drawing.Point(545, 3);
            this.buttonCropFace.Name = "buttonCropFace";
            this.buttonCropFace.Size = new System.Drawing.Size(265, 44);
            this.buttonCropFace.TabIndex = 3;
            this.buttonCropFace.Text = "Cắt ảnh mặt";
            this.buttonCropFace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCropFace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCropFace.UseVisualStyleBackColor = true;
            this.buttonCropFace.Click += new System.EventHandler(this.ButtonCropFace_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonUndo.Image = global::PictureViewer.Properties.Resources.undo_icon;
            this.buttonUndo.Location = new System.Drawing.Point(816, 3);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(265, 44);
            this.buttonUndo.TabIndex = 4;
            this.buttonUndo.Text = "Quay lại";
            this.buttonUndo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.ButtonUndo_Click);
            // 
            // buttonOpenPhotoshop
            // 
            this.tableLayout.SetColumnSpan(this.buttonOpenPhotoshop, 2);
            this.buttonOpenPhotoshop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpenPhotoshop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenPhotoshop.Image = global::PictureViewer.Properties.Resources.photoshop_icon;
            this.buttonOpenPhotoshop.Location = new System.Drawing.Point(545, 666);
            this.buttonOpenPhotoshop.Name = "buttonOpenPhotoshop";
            this.buttonOpenPhotoshop.Size = new System.Drawing.Size(536, 44);
            this.buttonOpenPhotoshop.TabIndex = 7;
            this.buttonOpenPhotoshop.Text = "Mở trong Photoshop";
            this.buttonOpenPhotoshop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOpenPhotoshop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOpenPhotoshop.UseVisualStyleBackColor = true;
            this.buttonOpenPhotoshop.Click += new System.EventHandler(this.ButtonOpenPhotoshop_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 737);
            this.Controls.Add(this.tableLayout);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trình xem ảnh - Phòng khám 158";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openItemMenu;
        private System.Windows.Forms.ToolStripMenuItem prinyItemMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitItemMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonCropNormal;
        private System.Windows.Forms.Button buttonCropFace;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSelectArea;
        private System.Windows.Forms.Button buttonCropManual;
        private System.Windows.Forms.Button buttonOpenPhotoshop;
        private System.Windows.Forms.ToolStripMenuItem setPhotoshopLocationToolStripMenuItem;
    }
}

