using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AsmHelper.Controls
{
    public partial class FileChooser : UserControl
    {
        public FileChooser()
        {
            InitializeComponent();
        }

        private bool _hasFileOpened;

        public event Action<string> FileChanged;
        public event Action<string> SaveFile;

        private void _handleFileNameChangedEvent()
        {
            var handler = FileChanged;
            if (handler != null)
            {
                handler(FileName);
            }
        }

        public string FileName { get; private set; }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (_checkFileOpened())
                return;

            var openFileDialog = new OpenFileDialog { Filter = "ASM 源文件|*.asm", };
            openFileDialog.ShowDialog();

            if (!openFileDialog.FileName.EndsWith(".asm"))
            {
                return;
            }

            FileName = openFileDialog.FileName;
            _hasFileOpened = true;
            txtFileName.Text = openFileDialog.FileName;

            _handleFileNameChangedEvent();
        }

        private bool _checkFileOpened()
        {
            if (_hasFileOpened)
            {
                var result = MessageBox.Show("是否保存现有文件？", "提示", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    var handler = SaveFile;
                    if (handler != null)
                    {
                        handler(FileName);
                    }
                }
                else if (result == DialogResult.No)
                {
                    _hasFileOpened = false;
                    FileName = null;
                    txtFileName.Clear();

                    _handleFileNameChangedEvent();
                }
                else
                    return true;
            }
            return false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFileName.Text))
            {
                return;
            }

            if (txtFileName.Text.Contains("\\"))
            {
                MessageBox.Show("文件名无效！");
                return;
            }

            var fileN = Environment.CurrentDirectory + "\\" + txtFileName.Text + ".asm";
            
            if (_checkFileOpened())
                return;

            FileName = fileN;

            using (var fileStream = File.Create(FileName))
            using (var streamWriter = new StreamWriter(fileStream, Encoding.ASCII))
            {
                streamWriter.Write(
                    "DATA SEGMENT\r\nDATA ENDS\r\n\r\nSTACK SEGMENT STACK\r\nSTACK ENDS\r\n\r\nCODE SEGMENT\r\n	ASSUME CS:CODE,DS:DATA\r\nSTART:\r\n	;EXIT\r\n	MOV AH,4CH\r\n	INT 21H\r\nCODE ENDS\r\nEND START");
            }
            txtFileName.Text = FileName;
            _hasFileOpened = true;

            _handleFileNameChangedEvent();
        }
    }
}
