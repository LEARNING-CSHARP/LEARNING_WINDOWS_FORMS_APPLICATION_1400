namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.myMainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.option1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.option2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.item1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.item2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.item21ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.item22ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.item3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.item4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.item41ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.item42ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.item43ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.myMainMenuStrip.SuspendLayout();
			this.mainContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// myMainMenuStrip
			// 
			this.myMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
			this.myMainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.myMainMenuStrip.Name = "myMainMenuStrip";
			this.myMainMenuStrip.Size = new System.Drawing.Size(570, 24);
			this.myMainMenuStrip.TabIndex = 0;
			this.myMainMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.openToolStripMenuItem.Text = "&Open";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.saveAsToolStripMenuItem.Text = "Save &As";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.ToolTipText = "Click me for exit!";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option1ToolStripMenuItem,
            this.option2ToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.optionsToolStripMenuItem.Text = "&Options";
			// 
			// option1ToolStripMenuItem
			// 
			this.option1ToolStripMenuItem.Name = "option1ToolStripMenuItem";
			this.option1ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.option1ToolStripMenuItem.Text = "Option &1";
			// 
			// option2ToolStripMenuItem
			// 
			this.option2ToolStripMenuItem.Name = "option2ToolStripMenuItem";
			this.option2ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.option2ToolStripMenuItem.Text = "Option &2";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 27);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// mainContextMenuStrip
			// 
			this.mainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.item2ToolStripMenuItem,
            this.item3ToolStripMenuItem,
            this.item4ToolStripMenuItem});
			this.mainContextMenuStrip.Name = "mainContextMenuStrip";
			this.mainContextMenuStrip.Size = new System.Drawing.Size(108, 92);
			// 
			// item1ToolStripMenuItem
			// 
			this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
			this.item1ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.item1ToolStripMenuItem.Text = "Item 1";
			// 
			// item2ToolStripMenuItem
			// 
			this.item2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item21ToolStripMenuItem,
            this.item22ToolStripMenuItem});
			this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
			this.item2ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.item2ToolStripMenuItem.Text = "Item 2";
			// 
			// item21ToolStripMenuItem
			// 
			this.item21ToolStripMenuItem.Name = "item21ToolStripMenuItem";
			this.item21ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.item21ToolStripMenuItem.Text = "Item 2 1";
			// 
			// item22ToolStripMenuItem
			// 
			this.item22ToolStripMenuItem.Name = "item22ToolStripMenuItem";
			this.item22ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.item22ToolStripMenuItem.Text = "Item 2 2";
			// 
			// item3ToolStripMenuItem
			// 
			this.item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
			this.item3ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.item3ToolStripMenuItem.Text = "Item 3";
			// 
			// item4ToolStripMenuItem
			// 
			this.item4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item41ToolStripMenuItem,
            this.item42ToolStripMenuItem,
            this.item43ToolStripMenuItem});
			this.item4ToolStripMenuItem.Name = "item4ToolStripMenuItem";
			this.item4ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.item4ToolStripMenuItem.Text = "Item 4";
			// 
			// item41ToolStripMenuItem
			// 
			this.item41ToolStripMenuItem.Name = "item41ToolStripMenuItem";
			this.item41ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.item41ToolStripMenuItem.Text = "Item 4 1";
			// 
			// item42ToolStripMenuItem
			// 
			this.item42ToolStripMenuItem.Name = "item42ToolStripMenuItem";
			this.item42ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.item42ToolStripMenuItem.Text = "Item 4 2";
			// 
			// item43ToolStripMenuItem
			// 
			this.item43ToolStripMenuItem.Name = "item43ToolStripMenuItem";
			this.item43ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.item43ToolStripMenuItem.Text = "Item 4 3";
			// 
			// button2
			// 
			this.button2.ContextMenuStrip = this.mainContextMenuStrip;
			this.button2.Location = new System.Drawing.Point(12, 56);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 85);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.ContextMenuStrip = this.mainContextMenuStrip;
			this.button4.Location = new System.Drawing.Point(12, 114);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(12, 143);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 5;
			this.button5.Text = "button5";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(570, 426);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.myMainMenuStrip);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.myMainMenuStrip;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.myMainMenuStrip.ResumeLayout(false);
			this.myMainMenuStrip.PerformLayout();
			this.mainContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip myMainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem option1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem option2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ContextMenuStrip mainContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem item2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem item21ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem item22ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem item3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem item4ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem item41ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem item42ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem item43ToolStripMenuItem;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
	}
}
