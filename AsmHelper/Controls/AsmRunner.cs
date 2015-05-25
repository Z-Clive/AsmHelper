using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace AsmHelper.Controls
{
    public partial class AsmRunner : UserControl
    {
        private delegate TResult Func<in T, out TResult>(T arg);

        public string FullFileName
        {
            private get { return _fullFileName; }
            set 
            {
                _fullFileName = string.IsNullOrEmpty(value) ? value : value.Substring(0, value.LastIndexOf('.')) ;
            }
        }

        private string _fullFileName;

        private RichTextBox _textBox;

        public RichTextBox TextBox
        {
            private get { return _textBox; }
            set
            {
                if (value!=null)
                {
                    _textBox = value;
                    _textBox.TextChanged += _textBox_TextChanged;
                }
            }
        }

        void _textBox_TextChanged(object sender, EventArgs e)
        {
            _hasCompiled = false;
            _hasLinked = false;
        }

        private bool _hasCompiled;
        private bool _hasLinked;

        public AsmRunner()
        {
            InitializeComponent();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (File.Exists(FullFileName + ".obj"))
            {
                File.Delete(FullFileName + ".obj");
            }

            if (File.Exists(FullFileName + ".exe"))
            {
                File.Delete(FullFileName + ".exe");
            }

            _hasCompiled = false;
            _hasLinked = false;
        }

        private Process _runProcess(string fileName, string argument, bool createNoWindow)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo(fileName, argument)
                {
                    CreateNoWindow = createNoWindow,
                    UseShellExecute = !createNoWindow,
                    RedirectStandardInput = createNoWindow,
                    RedirectStandardOutput = createNoWindow,
                }
            };

            if (createNoWindow)
                return process;
            else
            {
                process.Start();
                process.WaitForExit();

                txtResult.Text = string.Format("程序在{0}结束，返回值{1}\r\n", process.ExitTime, process.ExitCode);

                process.Close();
                process.Dispose();
            }

            return null;
        }

        private bool _verifyProcess(Process process, Func<string, bool> validateFunc)
        {
            try
            {
                process.Start();

                Thread.Sleep(100);

                txtResult.Text = process.StandardOutput.ReadToEnd();

                process.Close();
                process.Dispose();

                if (validateFunc(txtResult.Text))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (_hasCompiled)
            {
                if (_hasLinked)
                {
                    _runProcess("cmd.exe", "/c " + FullFileName + ".exe & pause", false);
                }
                else
                {
                    btnLink_Click(null, null);
                    if (_hasLinked)
                    {
                        _runProcess("cmd.exe", "/c " + FullFileName + ".exe & pause", false);
                    }
                }
            }
            else
            {
                btnMasm_Click(null, null);
                if (_hasCompiled)
                {
                    btnLink_Click(null, null);
                    if (_hasLinked)
                    {
                        _runProcess("cmd.exe", "/c " + FullFileName + ".exe & pause", false);
                    }
                }
            }
        }

        private void btnMasm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullFileName))
            {
                MessageBox.Show("请先打开文件！");
                return;
            }

            TextBox.SaveFile(FullFileName + ".asm", RichTextBoxStreamType.PlainText);

            var masmProcess = _runProcess("ml.exe", "/Fo " + FullFileName + ".obj /c "
                                                    + FullFileName + ".asm", true);
            if (_verifyProcess(masmProcess, text => text.EndsWith(" Assembling: " + FullFileName + ".asm\r\n")))
            {
                _hasCompiled = true;
            }
            else
            {
                MessageBox.Show("翻译出错。");
            }
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            if (_hasCompiled)
            {
                var linkProcess = _runProcess("link.exe", FullFileName + ".obj,"
                    + FullFileName + ".exe,nul,nul,nul", true);
                if (_verifyProcess(linkProcess, text => text.EndsWith("LINK : warning L4021: no stack segment\r\n")
                    || text.EndsWith("All rights reserved.\r\n\r\n")))
                {
                    _hasLinked = true;
                }
                else
                {
                    MessageBox.Show("连接出错。");
                }
            }
            else
            {
                MessageBox.Show("请先完成 ‘翻译’ 程序。");
            }
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            if (_hasCompiled)
            {
                if (_hasLinked)
                {
                    _runProcess("cmd.exe", "/c debug.exe " + FullFileName + ".exe & pause", false);
                }
                else
                {
                    btnLink_Click(null, null);
                    if (_hasLinked)
                    {
                        _runProcess("cmd.exe", "/c debug.exe " + FullFileName + ".exe & pause", false);
                    }
                }
            }
            else
            {
                btnMasm_Click(null, null);
                if (_hasCompiled)
                {
                    btnLink_Click(null, null);
                    if (_hasLinked)
                    {
                        _runProcess("cmd.exe", "/c debug.exe " + FullFileName + ".exe & pause", false);
                    }
                }
            }
        }
    }
}
