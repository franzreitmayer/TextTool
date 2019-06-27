namespace TextTool
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definitionFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromTextToTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromTableToTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTextFile = new System.Windows.Forms.TabPage();
            this.textBox = new System.Windows.Forms.TextBox();
            this.tabPageTableDefinition = new System.Windows.Forms.TabPage();
            this.tabPageTable = new System.Windows.Forms.TabPage();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonTextToTable = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTableToText = new System.Windows.Forms.ToolStripButton();
            this.saveDescriptionDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDescriptionDialog = new System.Windows.Forms.OpenFileDialog();
            this.openTextFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveTextFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.editor = new TextTool.TextTableDefinitionEditor();
            this.mainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageTextFile.SuspendLayout();
            this.tabPageTableDefinition.SuspendLayout();
            this.tabPageTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.processorToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(970, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTextFileToolStripMenuItem,
            this.definitionFileToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openTextFileToolStripMenuItem
            // 
            this.openTextFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.openTextFileToolStripMenuItem.Name = "openTextFileToolStripMenuItem";
            this.openTextFileToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.openTextFileToolStripMenuItem.Text = "&Textfile";
            this.openTextFileToolStripMenuItem.Click += new System.EventHandler(this.openTextFileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // definitionFileToolStripMenuItem
            // 
            this.definitionFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem1});
            this.definitionFileToolStripMenuItem.Name = "definitionFileToolStripMenuItem";
            this.definitionFileToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.definitionFileToolStripMenuItem.Text = "&Definition File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem1.Text = "&Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem1.Text = "&Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitApplicationToolStripMenuItem.Text = "&Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // processorToolStripMenuItem
            // 
            this.processorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromTextToTableToolStripMenuItem,
            this.fromTableToTextToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.processorToolStripMenuItem.Name = "processorToolStripMenuItem";
            this.processorToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.processorToolStripMenuItem.Text = "&Processor";
            // 
            // fromTextToTableToolStripMenuItem
            // 
            this.fromTextToTableToolStripMenuItem.Name = "fromTextToTableToolStripMenuItem";
            this.fromTextToTableToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.fromTextToTableToolStripMenuItem.Text = "&1 From Text to Table";
            this.fromTextToTableToolStripMenuItem.Click += new System.EventHandler(this.fromTextToTableToolStripMenuItem_Click);
            // 
            // fromTableToTextToolStripMenuItem
            // 
            this.fromTableToTextToolStripMenuItem.Name = "fromTableToTextToolStripMenuItem";
            this.fromTableToTextToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.fromTableToTextToolStripMenuItem.Text = "&2 From Table to Text";
            this.fromTableToTextToolStripMenuItem.Click += new System.EventHandler(this.fromTableToTextToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toDatabaseToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exportToolStripMenuItem.Text = "&Export";
            // 
            // toDatabaseToolStripMenuItem
            // 
            this.toDatabaseToolStripMenuItem.Name = "toDatabaseToolStripMenuItem";
            this.toDatabaseToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.toDatabaseToolStripMenuItem.Text = "&To Database";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.onlineHelpToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "&Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // onlineHelpToolStripMenuItem
            // 
            this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
            this.onlineHelpToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.onlineHelpToolStripMenuItem.Text = "&Online Help";
            this.onlineHelpToolStripMenuItem.Click += new System.EventHandler(this.onlineHelpToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 596);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(970, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(57, 6);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(970, 547);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(970, 572);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTextFile);
            this.tabControl.Controls.Add(this.tabPageTableDefinition);
            this.tabControl.Controls.Add(this.tabPageTable);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(970, 547);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageTextFile
            // 
            this.tabPageTextFile.Controls.Add(this.textBox);
            this.tabPageTextFile.Location = new System.Drawing.Point(4, 22);
            this.tabPageTextFile.Name = "tabPageTextFile";
            this.tabPageTextFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTextFile.Size = new System.Drawing.Size(962, 521);
            this.tabPageTextFile.TabIndex = 0;
            this.tabPageTextFile.Text = "Text File";
            this.tabPageTextFile.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.AcceptsTab = true;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(3, 3);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(956, 515);
            this.textBox.TabIndex = 0;
            this.textBox.WordWrap = false;
            // 
            // tabPageTableDefinition
            // 
            this.tabPageTableDefinition.Controls.Add(this.editor);
            this.tabPageTableDefinition.Location = new System.Drawing.Point(4, 22);
            this.tabPageTableDefinition.Name = "tabPageTableDefinition";
            this.tabPageTableDefinition.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTableDefinition.Size = new System.Drawing.Size(962, 521);
            this.tabPageTableDefinition.TabIndex = 1;
            this.tabPageTableDefinition.Text = "Table Definition";
            this.tabPageTableDefinition.UseVisualStyleBackColor = true;
            // 
            // tabPageTable
            // 
            this.tabPageTable.Controls.Add(this.dataGrid);
            this.tabPageTable.Location = new System.Drawing.Point(4, 22);
            this.tabPageTable.Name = "tabPageTable";
            this.tabPageTable.Size = new System.Drawing.Size(962, 521);
            this.tabPageTable.TabIndex = 2;
            this.tabPageTable.Text = "Table";
            this.tabPageTable.UseVisualStyleBackColor = true;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(962, 521);
            this.dataGrid.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonTextToTable,
            this.toolStripButtonTableToText});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(89, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButtonTextToTable
            // 
            this.toolStripButtonTextToTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTextToTable.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTextToTable.Image")));
            this.toolStripButtonTextToTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTextToTable.Name = "toolStripButtonTextToTable";
            this.toolStripButtonTextToTable.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonTextToTable.Text = "To Text...";
            this.toolStripButtonTextToTable.Click += new System.EventHandler(this.toolStripButtonTextToTable_Click);
            // 
            // toolStripButtonTableToText
            // 
            this.toolStripButtonTableToText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTableToText.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTableToText.Image")));
            this.toolStripButtonTableToText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTableToText.Name = "toolStripButtonTableToText";
            this.toolStripButtonTableToText.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonTableToText.Text = "To Table...";
            this.toolStripButtonTableToText.Click += new System.EventHandler(this.toolStripButtonTableToText_Click);
            // 
            // saveDescriptionDialog
            // 
            this.saveDescriptionDialog.DefaultExt = "*.fsd";
            this.saveDescriptionDialog.Filter = "File Structure Definition (*.fsd)|*.fsd|All Files (*.*)|*.*";
            this.saveDescriptionDialog.Title = "Save File Structure Definition";
            // 
            // openDescriptionDialog
            // 
            this.openDescriptionDialog.DefaultExt = "*.fsd";
            this.openDescriptionDialog.FileName = "openFileDialog1";
            this.openDescriptionDialog.Filter = "File Structure Definition (*.fsd)|*.fsd|All Files (*.*)|*.*";
            this.openDescriptionDialog.Title = "Open File Structure Definition";
            // 
            // openTextFileDialog
            // 
            this.openTextFileDialog.FileName = "openFileDialog1";
            this.openTextFileDialog.Filter = "Textfile (*.txt)|*.TXT|All Files (*.*)|*.*";
            this.openTextFileDialog.Title = "Open Textfile";
            // 
            // saveTextFileDialog
            // 
            this.saveTextFileDialog.Filter = "Textfile (*.txt)|*.TXT|All Files (*.*)|*.*";
            this.saveTextFileDialog.Title = "Save Textfile";
            // 
            // editor
            // 
            this.editor.AcceptsTab = true;
            this.editor.BackColor = System.Drawing.Color.FloralWhite;
            this.editor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor.IdentifierColor = System.Drawing.Color.MidnightBlue;
            this.editor.IdentifierFont = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor.IntegerColor = System.Drawing.Color.SeaGreen;
            this.editor.IntegerFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor.KeyWordColor = System.Drawing.Color.Blue;
            this.editor.KeyWordFont = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor.Location = new System.Drawing.Point(3, 3);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(956, 515);
            this.editor.TabIndex = 0;
            this.editor.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 618);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "frmMain";
            this.Text = "TextTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageTextFile.ResumeLayout(false);
            this.tabPageTextFile.PerformLayout();
            this.tabPageTableDefinition.ResumeLayout(false);
            this.tabPageTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definitionFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromTextToTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromTableToTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonTextToTable;
        private System.Windows.Forms.ToolStripButton toolStripButtonTableToText;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageTextFile;
        private System.Windows.Forms.TabPage tabPageTableDefinition;
        private System.Windows.Forms.TabPage tabPageTable;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.DataGridView dataGrid;
        private TextTableDefinitionEditor editor;
        private System.Windows.Forms.SaveFileDialog saveDescriptionDialog;
        private System.Windows.Forms.OpenFileDialog openDescriptionDialog;
        private System.Windows.Forms.OpenFileDialog openTextFileDialog;
        private System.Windows.Forms.SaveFileDialog saveTextFileDialog;
    }
}

