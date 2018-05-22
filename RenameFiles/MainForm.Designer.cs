namespace RenameFiles
{
    partial class MainForm
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
            this.buttonSetInputDir = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.textBoxInputDir = new System.Windows.Forms.TextBox();
            this.textBoxOutputPrefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSetOutputDir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOutputDir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.buttonOpenInputDir = new System.Windows.Forms.Button();
            this.buttonOpenOutputDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSetInputDir
            // 
            this.buttonSetInputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetInputDir.BackColor = System.Drawing.Color.LightGray;
            this.buttonSetInputDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetInputDir.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.buttonSetInputDir.Location = new System.Drawing.Point(672, 11);
            this.buttonSetInputDir.Name = "buttonSetInputDir";
            this.buttonSetInputDir.Size = new System.Drawing.Size(64, 25);
            this.buttonSetInputDir.TabIndex = 0;
            this.buttonSetInputDir.Text = "Set";
            this.buttonSetInputDir.UseVisualStyleBackColor = false;
            this.buttonSetInputDir.Click += new System.EventHandler(this.buttonSetInputDir_Click);
            // 
            // buttonRename
            // 
            this.buttonRename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRename.BackColor = System.Drawing.Color.LightGray;
            this.buttonRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRename.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.buttonRename.Location = new System.Drawing.Point(812, 11);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(74, 90);
            this.buttonRename.TabIndex = 1;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = false;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // textBoxInputDir
            // 
            this.textBoxInputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputDir.BackColor = System.Drawing.Color.LightGray;
            this.textBoxInputDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputDir.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.textBoxInputDir.Location = new System.Drawing.Point(122, 12);
            this.textBoxInputDir.Name = "textBoxInputDir";
            this.textBoxInputDir.ReadOnly = true;
            this.textBoxInputDir.Size = new System.Drawing.Size(544, 22);
            this.textBoxInputDir.TabIndex = 2;
            // 
            // textBoxOutputPrefix
            // 
            this.textBoxOutputPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputPrefix.BackColor = System.Drawing.Color.LightGray;
            this.textBoxOutputPrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOutputPrefix.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.textBoxOutputPrefix.Location = new System.Drawing.Point(121, 79);
            this.textBoxOutputPrefix.Name = "textBoxOutputPrefix";
            this.textBoxOutputPrefix.Size = new System.Drawing.Size(289, 22);
            this.textBoxOutputPrefix.TabIndex = 3;
            this.textBoxOutputPrefix.Text = "image";
            this.textBoxOutputPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Output Prefix:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input Files Dir:";
            // 
            // buttonSetOutputDir
            // 
            this.buttonSetOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetOutputDir.BackColor = System.Drawing.Color.LightGray;
            this.buttonSetOutputDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetOutputDir.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.buttonSetOutputDir.Location = new System.Drawing.Point(672, 43);
            this.buttonSetOutputDir.Name = "buttonSetOutputDir";
            this.buttonSetOutputDir.Size = new System.Drawing.Size(64, 25);
            this.buttonSetOutputDir.TabIndex = 6;
            this.buttonSetOutputDir.Text = "Set";
            this.buttonSetOutputDir.UseVisualStyleBackColor = false;
            this.buttonSetOutputDir.Click += new System.EventHandler(this.buttonSetOutputDir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output Files Dir:";
            // 
            // textBoxOutputDir
            // 
            this.textBoxOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputDir.BackColor = System.Drawing.Color.LightGray;
            this.textBoxOutputDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOutputDir.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.textBoxOutputDir.Location = new System.Drawing.Point(121, 43);
            this.textBoxOutputDir.Name = "textBoxOutputDir";
            this.textBoxOutputDir.ReadOnly = true;
            this.textBoxOutputDir.Size = new System.Drawing.Size(545, 22);
            this.textBoxOutputDir.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.label4.Location = new System.Drawing.Point(447, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Progress:";
            // 
            // labelPercentage
            // 
            this.labelPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.labelPercentage.Location = new System.Drawing.Point(533, 81);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(27, 16);
            this.labelPercentage.TabIndex = 10;
            this.labelPercentage.Text = "0%";
            // 
            // buttonOpenInputDir
            // 
            this.buttonOpenInputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenInputDir.BackColor = System.Drawing.Color.LightGray;
            this.buttonOpenInputDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenInputDir.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.buttonOpenInputDir.Location = new System.Drawing.Point(742, 11);
            this.buttonOpenInputDir.Name = "buttonOpenInputDir";
            this.buttonOpenInputDir.Size = new System.Drawing.Size(64, 25);
            this.buttonOpenInputDir.TabIndex = 11;
            this.buttonOpenInputDir.Text = "Open";
            this.buttonOpenInputDir.UseVisualStyleBackColor = false;
            this.buttonOpenInputDir.Click += new System.EventHandler(this.buttonOpenInputDir_Click);
            // 
            // buttonOpenOutputDir
            // 
            this.buttonOpenOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenOutputDir.BackColor = System.Drawing.Color.LightGray;
            this.buttonOpenOutputDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenOutputDir.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.buttonOpenOutputDir.Location = new System.Drawing.Point(742, 43);
            this.buttonOpenOutputDir.Name = "buttonOpenOutputDir";
            this.buttonOpenOutputDir.Size = new System.Drawing.Size(64, 25);
            this.buttonOpenOutputDir.TabIndex = 12;
            this.buttonOpenOutputDir.Text = "Open";
            this.buttonOpenOutputDir.UseVisualStyleBackColor = false;
            this.buttonOpenOutputDir.Click += new System.EventHandler(this.buttonOpenOutputDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(898, 111);
            this.Controls.Add(this.buttonOpenOutputDir);
            this.Controls.Add(this.buttonOpenInputDir);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOutputDir);
            this.Controls.Add(this.buttonSetOutputDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOutputPrefix);
            this.Controls.Add(this.textBoxInputDir);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.buttonSetInputDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(513, 114);
            this.Name = "Form1";
            this.Text = "Rename files with index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetInputDir;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.TextBox textBoxInputDir;
        private System.Windows.Forms.TextBox textBoxOutputPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSetOutputDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOutputDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.Button buttonOpenInputDir;
        private System.Windows.Forms.Button buttonOpenOutputDir;
    }
}

