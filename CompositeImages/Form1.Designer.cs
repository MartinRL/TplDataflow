namespace CompositeImages;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        toolStrip1 = new ToolStrip();
        toolStripButton1 = new ToolStripButton();
        toolStripButton2 = new ToolStripButton();
        pictureBox1 = new PictureBox();
        toolStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // toolStrip1
        // 
        toolStrip1.ImageScalingSize = new Size(24, 24);
        toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
        toolStrip1.Location = new Point(0, 0);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new Size(800, 34);
        toolStrip1.TabIndex = 0;
        toolStrip1.Text = "toolStrip1";
        // 
        // toolStripButton1
        // 
        toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
        toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
        toolStripButton1.ImageTransparentColor = Color.Magenta;
        toolStripButton1.Name = "toolStripButton1";
        toolStripButton1.Size = new Size(131, 29);
        toolStripButton1.Text = "Choose Folder";
        // 
        // toolStripButton2
        // 
        toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
        toolStripButton2.Enabled = false;
        toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
        toolStripButton2.ImageTransparentColor = Color.Magenta;
        toolStripButton2.Name = "toolStripButton2";
        toolStripButton2.Size = new Size(67, 29);
        toolStripButton2.Text = "Cancel";
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = DockStyle.Fill;
        pictureBox1.Location = new Point(0, 34);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(800, 416);
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(pictureBox1);
        Controls.Add(toolStrip1);
        Name = "Form1";
        Text = "Form1";
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ToolStrip toolStrip1;
    private ToolStripButton toolStripButton1;
    private ToolStripButton toolStripButton2;
    private PictureBox pictureBox1;
}
