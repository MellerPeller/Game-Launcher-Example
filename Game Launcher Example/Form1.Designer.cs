namespace Game_Launcher_Example
{
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
            totalProgressBar = new ProgressBar();
            button1 = new Button();
            barProgressFile = new ProgressBar();
            labelProgressFile = new Label();
            labelFilename = new Label();
            labelProgressTotal = new Label();
            SuspendLayout();
            // 
            // totalProgressBar
            // 
            totalProgressBar.BackColor = SystemColors.Control;
            totalProgressBar.Location = new Point(17, 643);
            totalProgressBar.Margin = new Padding(4, 5, 4, 5);
            totalProgressBar.Name = "totalProgressBar";
            totalProgressBar.Size = new Size(776, 38);
            totalProgressBar.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.cat_play____;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Enabled = false;
            button1.Location = new Point(899, 600);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(231, 136);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // barProgressFile
            // 
            barProgressFile.Location = new Point(17, 692);
            barProgressFile.Margin = new Padding(4, 5, 4, 5);
            barProgressFile.Name = "barProgressFile";
            barProgressFile.Size = new Size(776, 38);
            barProgressFile.TabIndex = 2;
            // 
            // labelProgressFile
            // 
            labelProgressFile.BackColor = Color.Transparent;
            labelProgressFile.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelProgressFile.ForeColor = Color.Black;
            labelProgressFile.Location = new Point(801, 692);
            labelProgressFile.Margin = new Padding(4, 0, 4, 0);
            labelProgressFile.Name = "labelProgressFile";
            labelProgressFile.Size = new Size(95, 38);
            labelProgressFile.TabIndex = 3;
            labelProgressFile.Text = "0%";
            labelProgressFile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelFilename
            // 
            labelFilename.BackColor = Color.Transparent;
            labelFilename.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelFilename.ForeColor = Color.Black;
            labelFilename.Location = new Point(17, 600);
            labelFilename.Margin = new Padding(4, 0, 4, 0);
            labelFilename.Name = "labelFilename";
            labelFilename.Size = new Size(776, 38);
            labelFilename.TabIndex = 4;
            labelFilename.Text = "n/a";
            labelFilename.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelProgressTotal
            // 
            labelProgressTotal.BackColor = Color.Transparent;
            labelProgressTotal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelProgressTotal.ForeColor = Color.Black;
            labelProgressTotal.Location = new Point(801, 643);
            labelProgressTotal.Margin = new Padding(4, 0, 4, 0);
            labelProgressTotal.Name = "labelProgressTotal";
            labelProgressTotal.Size = new Size(90, 38);
            labelProgressTotal.TabIndex = 5;
            labelProgressTotal.Text = "n/a";
            labelProgressTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources.cat__________;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 750);
            Controls.Add(labelProgressTotal);
            Controls.Add(labelFilename);
            Controls.Add(labelProgressFile);
            Controls.Add(barProgressFile);
            Controls.Add(button1);
            Controls.Add(totalProgressBar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Game Launcher";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar totalProgressBar;
        private Button button1;
        private ProgressBar barProgressFile;
        private Label labelProgressFile;
        private Label labelFilename;
        private Label labelProgressTotal;
    }
}
