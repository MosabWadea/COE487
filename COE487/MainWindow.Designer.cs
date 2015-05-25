namespace COE487
{
    partial class HelloOpenCV
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
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.redL = new System.Windows.Forms.TrackBar();
            this.redLb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.blueLT = new System.Windows.Forms.TextBox();
            this.greenLT = new System.Windows.Forms.TextBox();
            this.redLT = new System.Windows.Forms.TextBox();
            this.blueL = new System.Windows.Forms.TrackBar();
            this.blueLb = new System.Windows.Forms.Label();
            this.greenL = new System.Windows.Forms.TrackBar();
            this.greenLb = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.blueHT = new System.Windows.Forms.TextBox();
            this.greenHT = new System.Windows.Forms.TextBox();
            this.redHT = new System.Windows.Forms.TextBox();
            this.blueH = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.greenH = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.redH = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.consol = new System.Windows.Forms.TextBox();
            this.control = new System.Windows.Forms.ToolStripMenuItem();
            this.thisProjectWasDoneByMosabWadeaInCOE487ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redL)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenL)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redH)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(13, 38);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(640, 480);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(670, 38);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(640, 480);
            this.imageBox2.TabIndex = 3;
            this.imageBox2.TabStop = false;
            // 
            // redL
            // 
            this.redL.LargeChange = 25;
            this.redL.Location = new System.Drawing.Point(123, 31);
            this.redL.Maximum = 255;
            this.redL.Name = "redL";
            this.redL.Size = new System.Drawing.Size(306, 45);
            this.redL.SmallChange = 10;
            this.redL.TabIndex = 4;
            this.redL.Scroll += new System.EventHandler(this.redL_Scroll);
            // 
            // redLb
            // 
            this.redLb.AutoSize = true;
            this.redLb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLb.Location = new System.Drawing.Point(33, 31);
            this.redLb.Name = "redLb";
            this.redLb.Size = new System.Drawing.Size(66, 16);
            this.redLb.TabIndex = 5;
            this.redLb.Text = "Red Value";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blueLT);
            this.groupBox1.Controls.Add(this.greenLT);
            this.groupBox1.Controls.Add(this.redLT);
            this.groupBox1.Controls.Add(this.blueL);
            this.groupBox1.Controls.Add(this.blueLb);
            this.groupBox1.Controls.Add(this.greenL);
            this.groupBox1.Controls.Add(this.greenLb);
            this.groupBox1.Controls.Add(this.redL);
            this.groupBox1.Controls.Add(this.redLb);
            this.groupBox1.Location = new System.Drawing.Point(110, 524);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 176);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lower Color Values";
            // 
            // blueLT
            // 
            this.blueLT.Location = new System.Drawing.Point(435, 127);
            this.blueLT.Name = "blueLT";
            this.blueLT.Size = new System.Drawing.Size(63, 20);
            this.blueLT.TabIndex = 12;
            this.blueLT.TextChanged += new System.EventHandler(this.blueLT_TextChanged);
            // 
            // greenLT
            // 
            this.greenLT.Location = new System.Drawing.Point(435, 77);
            this.greenLT.Name = "greenLT";
            this.greenLT.Size = new System.Drawing.Size(63, 20);
            this.greenLT.TabIndex = 11;
            this.greenLT.TextChanged += new System.EventHandler(this.greenLT_TextChanged);
            // 
            // redLT
            // 
            this.redLT.Location = new System.Drawing.Point(435, 31);
            this.redLT.Name = "redLT";
            this.redLT.Size = new System.Drawing.Size(63, 20);
            this.redLT.TabIndex = 10;
            this.redLT.TextChanged += new System.EventHandler(this.redLT_TextChanged);
            // 
            // blueL
            // 
            this.blueL.LargeChange = 25;
            this.blueL.Location = new System.Drawing.Point(123, 127);
            this.blueL.Maximum = 255;
            this.blueL.Name = "blueL";
            this.blueL.Size = new System.Drawing.Size(306, 45);
            this.blueL.SmallChange = 10;
            this.blueL.TabIndex = 8;
            this.blueL.Scroll += new System.EventHandler(this.blueL_Scroll);
            // 
            // blueLb
            // 
            this.blueLb.AutoSize = true;
            this.blueLb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLb.Location = new System.Drawing.Point(33, 127);
            this.blueLb.Name = "blueLb";
            this.blueLb.Size = new System.Drawing.Size(68, 16);
            this.blueLb.TabIndex = 9;
            this.blueLb.Text = "Blue Value";
            // 
            // greenL
            // 
            this.greenL.LargeChange = 25;
            this.greenL.Location = new System.Drawing.Point(123, 77);
            this.greenL.Maximum = 255;
            this.greenL.Name = "greenL";
            this.greenL.Size = new System.Drawing.Size(306, 45);
            this.greenL.SmallChange = 10;
            this.greenL.TabIndex = 6;
            this.greenL.Scroll += new System.EventHandler(this.greenL_Scroll);
            // 
            // greenLb
            // 
            this.greenLb.AutoSize = true;
            this.greenLb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenLb.Location = new System.Drawing.Point(33, 77);
            this.greenLb.Name = "greenLb";
            this.greenLb.Size = new System.Drawing.Size(78, 16);
            this.greenLb.TabIndex = 7;
            this.greenLb.Text = "Green Value";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1326, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveOutputToolStripMenuItem,
            this.control});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.aboutToolStripMenuItem.Text = "File";
            // 
            // saveOutputToolStripMenuItem
            // 
            this.saveOutputToolStripMenuItem.Name = "saveOutputToolStripMenuItem";
            this.saveOutputToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.saveOutputToolStripMenuItem.Text = "Copy Output to clip board";
            this.saveOutputToolStripMenuItem.Click += new System.EventHandler(this.saveOutputToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thisProjectWasDoneByMosabWadeaInCOE487ToolStripMenuItem});
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.blueHT);
            this.groupBox2.Controls.Add(this.greenHT);
            this.groupBox2.Controls.Add(this.redHT);
            this.groupBox2.Controls.Add(this.blueH);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.greenH);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.redH);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(664, 524);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 176);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Higher Color Values";
            // 
            // blueHT
            // 
            this.blueHT.Location = new System.Drawing.Point(435, 127);
            this.blueHT.Name = "blueHT";
            this.blueHT.Size = new System.Drawing.Size(63, 20);
            this.blueHT.TabIndex = 12;
            this.blueHT.TextChanged += new System.EventHandler(this.blueHT_TextChanged);
            // 
            // greenHT
            // 
            this.greenHT.Location = new System.Drawing.Point(435, 77);
            this.greenHT.Name = "greenHT";
            this.greenHT.Size = new System.Drawing.Size(63, 20);
            this.greenHT.TabIndex = 11;
            this.greenHT.TextChanged += new System.EventHandler(this.greenHT_TextChanged);
            // 
            // redHT
            // 
            this.redHT.Location = new System.Drawing.Point(435, 31);
            this.redHT.Name = "redHT";
            this.redHT.Size = new System.Drawing.Size(63, 20);
            this.redHT.TabIndex = 10;
            this.redHT.TextChanged += new System.EventHandler(this.redHT_TextChanged);
            // 
            // blueH
            // 
            this.blueH.LargeChange = 25;
            this.blueH.Location = new System.Drawing.Point(123, 127);
            this.blueH.Maximum = 255;
            this.blueH.Name = "blueH";
            this.blueH.Size = new System.Drawing.Size(306, 45);
            this.blueH.SmallChange = 10;
            this.blueH.TabIndex = 8;
            this.blueH.Scroll += new System.EventHandler(this.blueH_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Blue Value";
            // 
            // greenH
            // 
            this.greenH.LargeChange = 25;
            this.greenH.Location = new System.Drawing.Point(123, 77);
            this.greenH.Maximum = 255;
            this.greenH.Name = "greenH";
            this.greenH.Size = new System.Drawing.Size(306, 45);
            this.greenH.SmallChange = 10;
            this.greenH.TabIndex = 6;
            this.greenH.Scroll += new System.EventHandler(this.greenH_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Green Value";
            // 
            // redH
            // 
            this.redH.LargeChange = 25;
            this.redH.Location = new System.Drawing.Point(123, 31);
            this.redH.Maximum = 255;
            this.redH.Name = "redH";
            this.redH.Size = new System.Drawing.Size(306, 45);
            this.redH.SmallChange = 10;
            this.redH.TabIndex = 4;
            this.redH.Scroll += new System.EventHandler(this.redH_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Red Value";
            // 
            // consol
            // 
            this.consol.Location = new System.Drawing.Point(110, 713);
            this.consol.Multiline = true;
            this.consol.Name = "consol";
            this.consol.ReadOnly = true;
            this.consol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consol.Size = new System.Drawing.Size(1102, 203);
            this.consol.TabIndex = 14;
            // 
            // control
            // 
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(213, 22);
            this.control.Text = "Stop capturing";
            this.control.Click += new System.EventHandler(this.control_Click);
            // 
            // thisProjectWasDoneByMosabWadeaInCOE487ToolStripMenuItem
            // 
            this.thisProjectWasDoneByMosabWadeaInCOE487ToolStripMenuItem.Name = "thisProjectWasDoneByMosabWadeaInCOE487ToolStripMenuItem";
            this.thisProjectWasDoneByMosabWadeaInCOE487ToolStripMenuItem.Size = new System.Drawing.Size(343, 22);
            this.thisProjectWasDoneByMosabWadeaInCOE487ToolStripMenuItem.Text = "This project was done by Mosab Wadea in COE 487";
            // 
            // HelloOpenCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 974);
            this.Controls.Add(this.consol);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HelloOpenCV";
            this.Text = "Hello Open CV";
            this.Load += new System.EventHandler(this.HelloOpenCV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenL)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.TrackBar redL;
        private System.Windows.Forms.Label redLb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar blueL;
        private System.Windows.Forms.Label blueLb;
        private System.Windows.Forms.TrackBar greenL;
        private System.Windows.Forms.Label greenLb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveOutputToolStripMenuItem;
        private System.Windows.Forms.TextBox blueLT;
        private System.Windows.Forms.TextBox greenLT;
        private System.Windows.Forms.TextBox redLT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox blueHT;
        private System.Windows.Forms.TextBox greenHT;
        private System.Windows.Forms.TextBox redHT;
        private System.Windows.Forms.TrackBar blueH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar greenH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar redH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox consol;
        private System.Windows.Forms.ToolStripMenuItem control;
        private System.Windows.Forms.ToolStripMenuItem thisProjectWasDoneByMosabWadeaInCOE487ToolStripMenuItem;
    }
}

