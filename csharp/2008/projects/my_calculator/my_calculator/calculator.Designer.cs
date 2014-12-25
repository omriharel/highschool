namespace my_calculator
{
    partial class myCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myCalculator));
            this.lblCopyright1 = new System.Windows.Forms.Label();
            this.lowerIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lnkCopyright2 = new System.Windows.Forms.LinkLabel();
            this.lblCopyright3 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.substractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.trcOpacity = new System.Windows.Forms.TrackBar();
            this.lblOpacity1 = new System.Windows.Forms.Label();
            this.lblOpacity2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCopyright1
            // 
            this.lblCopyright1.AutoSize = true;
            this.lblCopyright1.Location = new System.Drawing.Point(3, 114);
            this.lblCopyright1.Name = "lblCopyright1";
            this.lblCopyright1.Size = new System.Drawing.Size(68, 13);
            this.lblCopyright1.TabIndex = 0;
            this.lblCopyright1.Text = "Calculator by";
            // 
            // lowerIcon
            // 
            this.lowerIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.lowerIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("lowerIcon.Icon")));
            this.lowerIcon.Text = "Calculator by Omri Harel,  ©2008";
            this.lowerIcon.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // quitToolStripMenuItem2
            // 
            this.quitToolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.quitToolStripMenuItem2.Name = "quitToolStripMenuItem2";
            this.quitToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem2.Text = "Quit";
            this.quitToolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quitToolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.quitToolStripMenuItem2.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // lnkCopyright2
            // 
            this.lnkCopyright2.AutoSize = true;
            this.lnkCopyright2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lnkCopyright2.Location = new System.Drawing.Point(68, 114);
            this.lnkCopyright2.Name = "lnkCopyright2";
            this.lnkCopyright2.Size = new System.Drawing.Size(56, 13);
            this.lnkCopyright2.TabIndex = 1;
            this.lnkCopyright2.TabStop = true;
            this.lnkCopyright2.Text = "Omri Harel";
            this.lnkCopyright2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lnkCopyright2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCopyright2_LinkClicked);
            // 
            // lblCopyright3
            // 
            this.lblCopyright3.AutoSize = true;
            this.lblCopyright3.Location = new System.Drawing.Point(121, 114);
            this.lblCopyright3.Name = "lblCopyright3";
            this.lblCopyright3.Size = new System.Drawing.Size(43, 13);
            this.lblCopyright3.TabIndex = 2;
            this.lblCopyright3.Text = "© 2008";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(78, 36);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(113, 20);
            this.txtNumber1.TabIndex = 3;
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(12, 39);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(60, 13);
            this.lblNumber1.TabIndex = 4;
            this.lblNumber1.Text = "Operand 1:";
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(78, 62);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(113, 20);
            this.txtNumber2.TabIndex = 3;
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(12, 65);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(60, 13);
            this.lblNumber2.TabIndex = 4;
            this.lblNumber2.Text = "Operand 2:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(409, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.substractToolStripMenuItem,
            this.multiplyToolStripMenuItem,
            this.divideToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // substractToolStripMenuItem
            // 
            this.substractToolStripMenuItem.Name = "substractToolStripMenuItem";
            this.substractToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.substractToolStripMenuItem.Text = "Substract";
            this.substractToolStripMenuItem.Click += new System.EventHandler(this.substractToolStripMenuItem_Click);
            // 
            // multiplyToolStripMenuItem
            // 
            this.multiplyToolStripMenuItem.Name = "multiplyToolStripMenuItem";
            this.multiplyToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.multiplyToolStripMenuItem.Text = "Multiply";
            this.multiplyToolStripMenuItem.Click += new System.EventHandler(this.multiplyToolStripMenuItem_Click);
            // 
            // divideToolStripMenuItem
            // 
            this.divideToolStripMenuItem.Name = "divideToolStripMenuItem";
            this.divideToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.divideToolStripMenuItem.Text = "Divide";
            this.divideToolStripMenuItem.Click += new System.EventHandler(this.divideToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd.Location = new System.Drawing.Point(197, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 46);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSubstract.Location = new System.Drawing.Point(250, 36);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(47, 46);
            this.btnSubstract.TabIndex = 6;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMultiply.Location = new System.Drawing.Point(303, 36);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(47, 46);
            this.btnMultiply.TabIndex = 6;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDivide.Location = new System.Drawing.Point(356, 36);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(47, 46);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(11, 91);
            this.lblResult.MaximumSize = new System.Drawing.Size(340, 12);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 12);
            this.lblResult.TabIndex = 7;
            // 
            // trcOpacity
            // 
            this.trcOpacity.Location = new System.Drawing.Point(364, 78);
            this.trcOpacity.Maximum = 100;
            this.trcOpacity.Minimum = 25;
            this.trcOpacity.Name = "trcOpacity";
            this.trcOpacity.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcOpacity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trcOpacity.RightToLeftLayout = true;
            this.trcOpacity.Size = new System.Drawing.Size(45, 59);
            this.trcOpacity.TabIndex = 9;
            this.trcOpacity.TabStop = false;
            this.trcOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcOpacity.Value = 100;
            this.trcOpacity.ValueChanged += new System.EventHandler(this.trcOpacity_ValueChanged);
            // 
            // lblOpacity1
            // 
            this.lblOpacity1.AutoSize = true;
            this.lblOpacity1.Location = new System.Drawing.Point(275, 114);
            this.lblOpacity1.Name = "lblOpacity1";
            this.lblOpacity1.Size = new System.Drawing.Size(111, 13);
            this.lblOpacity1.TabIndex = 10;
            this.lblOpacity1.Text = "Window Opacity: 30%";
            // 
            // lblOpacity2
            // 
            this.lblOpacity2.AutoSize = true;
            this.lblOpacity2.Location = new System.Drawing.Point(353, 85);
            this.lblOpacity2.Name = "lblOpacity2";
            this.lblOpacity2.Size = new System.Drawing.Size(33, 13);
            this.lblOpacity2.TabIndex = 10;
            this.lblOpacity2.Text = "100%";
            // 
            // myCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 131);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.lblOpacity1);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.lblOpacity2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.trcOpacity);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.lblCopyright3);
            this.Controls.Add(this.lnkCopyright2);
            this.Controls.Add(this.lblCopyright1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(417, 165);
            this.MinimumSize = new System.Drawing.Size(417, 165);
            this.Name = "myCalculator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "C# Calculator";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCopyright1;
        private System.Windows.Forms.NotifyIcon lowerIcon;
        private System.Windows.Forms.LinkLabel lnkCopyright2;
        private System.Windows.Forms.Label lblCopyright3;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem substractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divideToolStripMenuItem;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem2;
        private System.Windows.Forms.TrackBar trcOpacity;
        private System.Windows.Forms.Label lblOpacity1;
        private System.Windows.Forms.Label lblOpacity2;
    }
}

