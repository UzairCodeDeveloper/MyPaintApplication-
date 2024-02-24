namespace MyPaint
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSelect = new System.Windows.Forms.ToolStripButton();
            this.tsbLine = new System.Windows.Forms.ToolStripButton();
            this.tsbRect = new System.Windows.Forms.ToolStripButton();
            this.tsbCircle = new System.Windows.Forms.ToolStripButton();
            this.tsbColorDialog = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pgShape = new System.Windows.Forms.PropertyGrid();
            this.tvShapes = new System.Windows.Forms.TreeView();
            this.myDrawing = new MyPaint.DrawingBoard();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 34);
            this.toolStripMenuItem1.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.circleToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(69, 30);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSelect,
            this.tsbLine,
            this.tsbRect,
            this.tsbCircle,
            this.tsbColorDialog});
            this.toolStrip1.Location = new System.Drawing.Point(0, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(905, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSelect
            // 
            this.tsbSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSelect.Image = global::MyPaint.Properties.Resources.Select;
            this.tsbSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelect.Name = "tsbSelect";
            this.tsbSelect.Size = new System.Drawing.Size(34, 33);
            this.tsbSelect.Text = "Select Tool";
            this.tsbSelect.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // tsbLine
            // 
            this.tsbLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLine.Image = global::MyPaint.Properties.Resources.Bitmap1;
            this.tsbLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLine.Name = "tsbLine";
            this.tsbLine.Size = new System.Drawing.Size(34, 33);
            this.tsbLine.Text = "Line Tool";
            this.tsbLine.ToolTipText = "Line Drawing Tool";
            this.tsbLine.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // tsbRect
            // 
            this.tsbRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRect.Image = global::MyPaint.Properties.Resources.Rectangle;
            this.tsbRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRect.Name = "tsbRect";
            this.tsbRect.Size = new System.Drawing.Size(34, 33);
            this.tsbRect.Text = "Rectangle Tool";
            this.tsbRect.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // tsbCircle
            // 
            this.tsbCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCircle.Image = global::MyPaint.Properties.Resources.Circle;
            this.tsbCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCircle.Name = "tsbCircle";
            this.tsbCircle.Size = new System.Drawing.Size(34, 33);
            this.tsbCircle.Text = "toolStripButton1";
            this.tsbCircle.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // tsbColorDialog
            // 
            this.tsbColorDialog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbColorDialog.Image = ((System.Drawing.Image)(resources.GetObject("tsbColorDialog.Image")));
            this.tsbColorDialog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbColorDialog.Name = "tsbColorDialog";
            this.tsbColorDialog.Size = new System.Drawing.Size(34, 33);
            this.tsbColorDialog.Text = "tsbColorDialog";
            this.tsbColorDialog.Click += new System.EventHandler(this.tsbColorDialog_Click);
            // 
            // pgShape
            // 
            this.pgShape.Dock = System.Windows.Forms.DockStyle.Right;
            this.pgShape.Location = new System.Drawing.Point(678, 74);
            this.pgShape.Name = "pgShape";
            this.pgShape.Size = new System.Drawing.Size(227, 455);
            this.pgShape.TabIndex = 3;
            this.pgShape.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgShape_PropertyValueChanged);
            this.pgShape.Click += new System.EventHandler(this.pgShape_Click);
            // 
            // tvShapes
            // 
            this.tvShapes.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvShapes.Location = new System.Drawing.Point(0, 74);
            this.tvShapes.Name = "tvShapes";
            this.tvShapes.Size = new System.Drawing.Size(198, 455);
            this.tvShapes.TabIndex = 4;
            this.tvShapes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvShapes_AfterSelect);
            // 
            // myDrawing
            // 
            this.myDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDrawing.Location = new System.Drawing.Point(198, 74);
            this.myDrawing.Name = "myDrawing";
            this.myDrawing.OutLineColor = System.Drawing.Color.Empty;
            this.myDrawing.SelectedTool = MyPaint.SHAPETOOLS.SELECT;
            this.myDrawing.Size = new System.Drawing.Size(480, 455);
            this.myDrawing.TabIndex = 2;
            this.myDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myDrawing_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 529);
            this.Controls.Add(this.myDrawing);
            this.Controls.Add(this.tvShapes);
            this.Controls.Add(this.pgShape);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSelect;
        private System.Windows.Forms.ToolStripButton tsbLine;
        private System.Windows.Forms.ToolStripButton tsbRect;
        private System.Windows.Forms.ToolStripButton tsbCircle;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DrawingBoard myDrawing;
        private System.Windows.Forms.ToolStripButton tsbColorDialog;
        private System.Windows.Forms.PropertyGrid pgShape;
        private System.Windows.Forms.TreeView tvShapes;
    }
}

