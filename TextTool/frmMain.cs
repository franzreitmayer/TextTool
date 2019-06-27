using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TextTool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void openTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonTableToText_Click(object sender, EventArgs e)
        {
            fromTextToTable();
        }

        private void fromTextToTable()
        {
            String scriptText = editor.Text;
            String text = textBox.Text;
            TextTableProcessor processor = new TextTableProcessor(scriptText, text);
            IRelation relation = processor.process();
            dataGrid.Rows.Clear();
            dataGrid.RowCount = 0;
            dataGrid.Columns.Clear();
            foreach (String column in relation.getColumns())
            {
                dataGrid.Columns.Add(column, column);
            }
            for (int i = 0; i < relation.getData().Length; i++)
            {
                String[] row = relation.getData()[i];
                dataGrid.Rows.Add(row);
            }
            tabControl.SelectedIndex = 2;
        }

        private void fromTextToTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fromTextToTable();
        }

        private void toolStripButtonTextToTable_Click(object sender, EventArgs e)
        {
            fromTableToText();
        }

        private void fromTableToText()
        {
            TextTableProcessor processor = new TextTableProcessor(editor.Text, textBox.Text);
            IRelation relation = new DefaultRelation();
            String[] columns = new String[dataGrid.Columns.Count];
            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                columns[i] = dataGrid.Columns[i].HeaderText;
            }
            String[][] data = new String[dataGrid.Rows.Count][];
            
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                String[] row = new String[columns.Length];
                for (int j = 0; j < columns.Length; j++)
                {
                    object cell_value = dataGrid.Rows[i].Cells[j].Value;
                    row[j] = cell_value != null ? cell_value.ToString() : "";
                }
                data[i] = row;
            }
            relation.setData(data);
            relation.setColumns(columns);

            textBox.Text = processor.process(relation);
            tabControl.SelectedIndex = 0;

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveDescriptionFile();
        }

        private void saveDescriptionFile()
        {

            if (saveDescriptionDialog.ShowDialog() == DialogResult.OK)
            {
                editor.SaveFile(saveDescriptionDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openDescriptionFile();
        }

        private void openDescriptionFile()
        {
            if (openDescriptionDialog.ShowDialog() == DialogResult.OK)
            {
                editor.LoadFile(openDescriptionDialog.FileName, RichTextBoxStreamType.PlainText);
                tabControl.SelectedIndex = 1;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTextFile();
        }

        private void openTextFile()
        {
            if (openTextFileDialog.ShowDialog() == DialogResult.OK)
            {

                StreamReader reader = new StreamReader(openTextFileDialog.FileName,Encoding.Default);
                textBox.Text = reader.ReadToEnd();
                reader.Close();
                tabControl.SelectedIndex = 0;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveTextFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveTextFileDialog.FileName, false, Encoding.Default);
                writer.Write(textBox.Text);
                writer.Flush();
                writer.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog aboutDialog = new AboutDialog();
            aboutDialog.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to close TextTool?\nAll unsaved data will be lost.", 
                "Close TextTool", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) ==
                DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.reitmayer.eu/texttool");
        }

        private void fromTableToTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fromTableToText();
        }


    }
}
