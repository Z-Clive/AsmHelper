namespace AsmHelper
{
    partial class AsmHelperMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox = new AsmHelper.TextBoxSync.TextBoxSync();
            this.instructionComposer = new AsmHelper.Controls.InstructionComposer();
            this.asmRunner = new AsmHelper.Controls.AsmRunner();
            this.fileChooser = new AsmHelper.Controls.FileChooser();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(577, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Location = new System.Drawing.Point(13, 41);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(261, 249);
            this.textBox.TabIndex = 5;
            // 
            // instructionComposer
            // 
            this.instructionComposer.Location = new System.Drawing.Point(280, 41);
            this.instructionComposer.Name = "instructionComposer";
            this.instructionComposer.Size = new System.Drawing.Size(348, 249);
            this.instructionComposer.TabIndex = 4;
            // 
            // asmRunner
            // 
            this.asmRunner.Location = new System.Drawing.Point(12, 296);
            this.asmRunner.Name = "asmRunner";
            this.asmRunner.Size = new System.Drawing.Size(608, 150);
            this.asmRunner.TabIndex = 1;
            // 
            // fileChooser
            // 
            this.fileChooser.Location = new System.Drawing.Point(13, 13);
            this.fileChooser.Name = "fileChooser";
            this.fileChooser.Size = new System.Drawing.Size(558, 27);
            this.fileChooser.TabIndex = 0;
            // 
            // AsmHelperMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 449);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.instructionComposer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.asmRunner);
            this.Controls.Add(this.fileChooser);
            this.Name = "AsmHelperMain";
            this.Text = "汇编小助手";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.FileChooser fileChooser;
        private Controls.AsmRunner asmRunner;
        private System.Windows.Forms.Button btnSave;
        private Controls.InstructionComposer instructionComposer;
        private TextBoxSync.TextBoxSync textBox;
    }
}

