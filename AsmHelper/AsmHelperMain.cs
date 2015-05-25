using System;
using System.Windows.Forms;

namespace AsmHelper
{
    public partial class AsmHelperMain : Form
    {
        public AsmHelperMain()
        {
            InitializeComponent();
            Load += AsmHelperMain_Load;
        }

        void AsmHelperMain_Load(object sender, EventArgs e)
        {
            textBox.Enabled = false;

            asmRunner.TextBox = textBox.TextBox;
            instructionComposer.InsertInstruction += instructionComposer_InsertInstruction;

            fileChooser.FileChanged += fileChooser_FileChanged;
            fileChooser.SaveFile += fileChooser_SaveFile;
        }

        void instructionComposer_InsertInstruction(string instruction)
        {
            if (textBox.Enabled)
            {
                var selectionStart = textBox.TextBox.SelectionStart;

                textBox.TextBox.Text = textBox.TextBox.Text.Insert(selectionStart, instruction);
                textBox.TextBox.SelectionStart = selectionStart + instruction.Length - 1;
            }
        }

        void fileChooser_FileChanged(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                asmRunner.FullFileName = null;
                textBox.Enabled = false;
                textBox.TextBox.Clear();
            }
            else
            {
                asmRunner.FullFileName = fileName;

                textBox.Enabled = true;
                textBox.TextBox.LoadFile(fileName, RichTextBoxStreamType.PlainText);
            }
        }

        void fileChooser_SaveFile(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
                textBox.TextBox.SaveFile(fileName, RichTextBoxStreamType.PlainText);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fileChooser_SaveFile(fileChooser.FileName);
        }
    }
}
