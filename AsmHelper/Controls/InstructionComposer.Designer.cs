namespace AsmHelper.Controls
{
    partial class InstructionComposer
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpUseful = new System.Windows.Forms.TabPage();
            this.btnInsUseful = new System.Windows.Forms.Button();
            this.cbLastUseful = new System.Windows.Forms.ComboBox();
            this.cbFirstUseful = new System.Windows.Forms.ComboBox();
            this.cbChooserUseful = new System.Windows.Forms.ComboBox();
            this.cbIndexUseful = new System.Windows.Forms.ComboBox();
            this.gbUseful = new System.Windows.Forms.GroupBox();
            this.lblUsageUseful = new System.Windows.Forms.Label();
            this.lblInstructionUseful = new System.Windows.Forms.Label();
            this.tpAdvanced = new System.Windows.Forms.TabPage();
            this.cbFirstAdvanced = new System.Windows.Forms.ComboBox();
            this.cbChooserAdvanced = new System.Windows.Forms.ComboBox();
            this.cbLastAdvanced = new System.Windows.Forms.ComboBox();
            this.cbIndexAdvanced = new System.Windows.Forms.ComboBox();
            this.btnInsAdvanced = new System.Windows.Forms.Button();
            this.gbAdvanced = new System.Windows.Forms.GroupBox();
            this.lblUsageAdvanced = new System.Windows.Forms.Label();
            this.lblInstructionAdvanced = new System.Windows.Forms.Label();
            this.tpUtility = new System.Windows.Forms.TabPage();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tpUseful.SuspendLayout();
            this.gbUseful.SuspendLayout();
            this.tpAdvanced.SuspendLayout();
            this.gbAdvanced.SuspendLayout();
            this.tpUtility.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpUseful);
            this.tabControl.Controls.Add(this.tpAdvanced);
            this.tabControl.Controls.Add(this.tpUtility);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(348, 249);
            this.tabControl.TabIndex = 0;
            // 
            // tpUseful
            // 
            this.tpUseful.Controls.Add(this.btnInsUseful);
            this.tpUseful.Controls.Add(this.cbLastUseful);
            this.tpUseful.Controls.Add(this.cbFirstUseful);
            this.tpUseful.Controls.Add(this.cbChooserUseful);
            this.tpUseful.Controls.Add(this.cbIndexUseful);
            this.tpUseful.Controls.Add(this.gbUseful);
            this.tpUseful.Location = new System.Drawing.Point(4, 22);
            this.tpUseful.Name = "tpUseful";
            this.tpUseful.Padding = new System.Windows.Forms.Padding(3);
            this.tpUseful.Size = new System.Drawing.Size(340, 223);
            this.tpUseful.TabIndex = 0;
            this.tpUseful.Text = "常用指令";
            this.tpUseful.UseVisualStyleBackColor = true;
            // 
            // btnInsUseful
            // 
            this.btnInsUseful.Location = new System.Drawing.Point(6, 74);
            this.btnInsUseful.Name = "btnInsUseful";
            this.btnInsUseful.Size = new System.Drawing.Size(75, 23);
            this.btnInsUseful.TabIndex = 3;
            this.btnInsUseful.Text = "<--插入";
            this.btnInsUseful.UseVisualStyleBackColor = true;
            this.btnInsUseful.Click += new System.EventHandler(this.btnInsUseful_Click);
            // 
            // cbLastUseful
            // 
            this.cbLastUseful.FormattingEnabled = true;
            this.cbLastUseful.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX",
            "SP",
            "BP",
            "SI",
            "DI",
            "IP",
            "FLAG",
            "CS",
            "DS",
            "SS",
            "ES"});
            this.cbLastUseful.Location = new System.Drawing.Point(229, 32);
            this.cbLastUseful.Name = "cbLastUseful";
            this.cbLastUseful.Size = new System.Drawing.Size(90, 20);
            this.cbLastUseful.TabIndex = 2;
            // 
            // cbFirstUseful
            // 
            this.cbFirstUseful.FormattingEnabled = true;
            this.cbFirstUseful.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX",
            "SP",
            "BP",
            "SI",
            "DI",
            "IP",
            "FLAG",
            "CS",
            "DS",
            "SS",
            "ES"});
            this.cbFirstUseful.Location = new System.Drawing.Point(133, 32);
            this.cbFirstUseful.Name = "cbFirstUseful";
            this.cbFirstUseful.Size = new System.Drawing.Size(90, 20);
            this.cbFirstUseful.TabIndex = 2;
            // 
            // cbChooserUseful
            // 
            this.cbChooserUseful.FormattingEnabled = true;
            this.cbChooserUseful.Location = new System.Drawing.Point(37, 32);
            this.cbChooserUseful.Name = "cbChooserUseful";
            this.cbChooserUseful.Size = new System.Drawing.Size(90, 20);
            this.cbChooserUseful.TabIndex = 2;
            this.cbChooserUseful.SelectedIndexChanged += new System.EventHandler(this.cbChooserUseful_SelectedIndexChanged);
            // 
            // cbIndexUseful
            // 
            this.cbIndexUseful.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIndexUseful.FormattingEnabled = true;
            this.cbIndexUseful.Items.AddRange(new object[] {
            "数据移动",
            "数据运算",
            "数据移位",
            "比较跳转",
            "循环与调用"});
            this.cbIndexUseful.Location = new System.Drawing.Point(6, 6);
            this.cbIndexUseful.Name = "cbIndexUseful";
            this.cbIndexUseful.Size = new System.Drawing.Size(121, 20);
            this.cbIndexUseful.TabIndex = 1;
            this.cbIndexUseful.SelectedIndexChanged += new System.EventHandler(this.cbIndexUseful_SelectedIndexChanged);
            // 
            // gbUseful
            // 
            this.gbUseful.Controls.Add(this.lblUsageUseful);
            this.gbUseful.Controls.Add(this.lblInstructionUseful);
            this.gbUseful.Location = new System.Drawing.Point(6, 103);
            this.gbUseful.Name = "gbUseful";
            this.gbUseful.Size = new System.Drawing.Size(328, 117);
            this.gbUseful.TabIndex = 0;
            this.gbUseful.TabStop = false;
            this.gbUseful.Text = "使用方法：";
            // 
            // lblUsageUseful
            // 
            this.lblUsageUseful.AutoSize = true;
            this.lblUsageUseful.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUsageUseful.Location = new System.Drawing.Point(80, 17);
            this.lblUsageUseful.MaximumSize = new System.Drawing.Size(242, 139);
            this.lblUsageUseful.Name = "lblUsageUseful";
            this.lblUsageUseful.Size = new System.Drawing.Size(40, 16);
            this.lblUsageUseful.TabIndex = 1;
            this.lblUsageUseful.Text = "用法";
            // 
            // lblInstructionUseful
            // 
            this.lblInstructionUseful.AutoSize = true;
            this.lblInstructionUseful.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInstructionUseful.Location = new System.Drawing.Point(6, 17);
            this.lblInstructionUseful.Name = "lblInstructionUseful";
            this.lblInstructionUseful.Size = new System.Drawing.Size(42, 16);
            this.lblInstructionUseful.TabIndex = 0;
            this.lblInstructionUseful.Text = "指令";
            // 
            // tpAdvanced
            // 
            this.tpAdvanced.Controls.Add(this.cbFirstAdvanced);
            this.tpAdvanced.Controls.Add(this.cbChooserAdvanced);
            this.tpAdvanced.Controls.Add(this.cbLastAdvanced);
            this.tpAdvanced.Controls.Add(this.cbIndexAdvanced);
            this.tpAdvanced.Controls.Add(this.btnInsAdvanced);
            this.tpAdvanced.Controls.Add(this.gbAdvanced);
            this.tpAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tpAdvanced.Name = "tpAdvanced";
            this.tpAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdvanced.Size = new System.Drawing.Size(340, 223);
            this.tpAdvanced.TabIndex = 1;
            this.tpAdvanced.Text = "高级指令";
            this.tpAdvanced.UseVisualStyleBackColor = true;
            // 
            // cbFirstAdvanced
            // 
            this.cbFirstAdvanced.FormattingEnabled = true;
            this.cbFirstAdvanced.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX",
            "SP",
            "BP",
            "SI",
            "DI",
            "IP",
            "FLAG",
            "CS",
            "DS",
            "SS",
            "ES"});
            this.cbFirstAdvanced.Location = new System.Drawing.Point(133, 32);
            this.cbFirstAdvanced.Name = "cbFirstAdvanced";
            this.cbFirstAdvanced.Size = new System.Drawing.Size(90, 20);
            this.cbFirstAdvanced.TabIndex = 2;
            // 
            // cbChooserAdvanced
            // 
            this.cbChooserAdvanced.FormattingEnabled = true;
            this.cbChooserAdvanced.Location = new System.Drawing.Point(37, 32);
            this.cbChooserAdvanced.Name = "cbChooserAdvanced";
            this.cbChooserAdvanced.Size = new System.Drawing.Size(90, 20);
            this.cbChooserAdvanced.TabIndex = 2;
            this.cbChooserAdvanced.SelectedIndexChanged += new System.EventHandler(this.cbChooserAdvanced_SelectedIndexChanged);
            // 
            // cbLastAdvanced
            // 
            this.cbLastAdvanced.FormattingEnabled = true;
            this.cbLastAdvanced.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX",
            "SP",
            "BP",
            "SI",
            "DI",
            "IP",
            "FLAG",
            "CS",
            "DS",
            "SS",
            "ES"});
            this.cbLastAdvanced.Location = new System.Drawing.Point(229, 32);
            this.cbLastAdvanced.Name = "cbLastAdvanced";
            this.cbLastAdvanced.Size = new System.Drawing.Size(90, 20);
            this.cbLastAdvanced.TabIndex = 2;
            // 
            // cbIndexAdvanced
            // 
            this.cbIndexAdvanced.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIndexAdvanced.FormattingEnabled = true;
            this.cbIndexAdvanced.Items.AddRange(new object[] {
            "数据移动",
            "外设相关",
            "数据运算",
            "扩展与调整",
            "数据移位",
            "数据串传送",
            "比较循环",
            "比较跳转",
            "处理器控制"});
            this.cbIndexAdvanced.Location = new System.Drawing.Point(6, 6);
            this.cbIndexAdvanced.Name = "cbIndexAdvanced";
            this.cbIndexAdvanced.Size = new System.Drawing.Size(121, 20);
            this.cbIndexAdvanced.TabIndex = 1;
            this.cbIndexAdvanced.SelectedIndexChanged += new System.EventHandler(this.cbIndexAdvanced_SelectedIndexChanged);
            // 
            // btnInsAdvanced
            // 
            this.btnInsAdvanced.Location = new System.Drawing.Point(6, 74);
            this.btnInsAdvanced.Name = "btnInsAdvanced";
            this.btnInsAdvanced.Size = new System.Drawing.Size(75, 23);
            this.btnInsAdvanced.TabIndex = 3;
            this.btnInsAdvanced.Text = "<--插入";
            this.btnInsAdvanced.UseVisualStyleBackColor = true;
            this.btnInsAdvanced.Click += new System.EventHandler(this.btnInsAdvanced_Click);
            // 
            // gbAdvanced
            // 
            this.gbAdvanced.Controls.Add(this.lblUsageAdvanced);
            this.gbAdvanced.Controls.Add(this.lblInstructionAdvanced);
            this.gbAdvanced.Location = new System.Drawing.Point(6, 103);
            this.gbAdvanced.Name = "gbAdvanced";
            this.gbAdvanced.Size = new System.Drawing.Size(328, 121);
            this.gbAdvanced.TabIndex = 0;
            this.gbAdvanced.TabStop = false;
            this.gbAdvanced.Text = "使用方法：";
            // 
            // lblUsageAdvanced
            // 
            this.lblUsageAdvanced.AutoSize = true;
            this.lblUsageAdvanced.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUsageAdvanced.Location = new System.Drawing.Point(80, 17);
            this.lblUsageAdvanced.MaximumSize = new System.Drawing.Size(242, 139);
            this.lblUsageAdvanced.Name = "lblUsageAdvanced";
            this.lblUsageAdvanced.Size = new System.Drawing.Size(40, 16);
            this.lblUsageAdvanced.TabIndex = 5;
            this.lblUsageAdvanced.Text = "用法";
            // 
            // lblInstructionAdvanced
            // 
            this.lblInstructionAdvanced.AutoSize = true;
            this.lblInstructionAdvanced.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInstructionAdvanced.Location = new System.Drawing.Point(6, 17);
            this.lblInstructionAdvanced.Name = "lblInstructionAdvanced";
            this.lblInstructionAdvanced.Size = new System.Drawing.Size(42, 16);
            this.lblInstructionAdvanced.TabIndex = 2;
            this.lblInstructionAdvanced.Text = "指令";
            // 
            // tpUtility
            // 
            this.tpUtility.Controls.Add(this.gbSearch);
            this.tpUtility.Location = new System.Drawing.Point(4, 22);
            this.tpUtility.Name = "tpUtility";
            this.tpUtility.Size = new System.Drawing.Size(340, 274);
            this.tpUtility.TabIndex = 2;
            this.tpUtility.Text = "实用工具";
            this.tpUtility.UseVisualStyleBackColor = true;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Location = new System.Drawing.Point(3, 8);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(334, 48);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "搜索";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(291, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "MOV",
            "PUSH",
            "POP",
            "LEA",
            "LDS",
            "LES",
            "ADD",
            "ADC",
            "INC",
            "SUB",
            "SBB",
            "DEC",
            "MUL",
            "IMUL",
            "DIV",
            "IDIV",
            "AND",
            "OR",
            "NOT",
            "XOR",
            "SHL",
            "SHR",
            "SAL",
            "SAR",
            "CMP",
            "JMP",
            "JE",
            "JNE",
            "JB",
            "JNB",
            "JA",
            "JNA",
            "JL",
            "JNL",
            "JG",
            "JNG",
            "CALL",
            "RET",
            "INT",
            "NOP",
            "LOOP",
            "LOOPE",
            "LOOPNE",
            "PUSHF",
            "POPF",
            "XCHG",
            "XLAT",
            "IN",
            "OUT",
            "NEG",
            "CBW",
            "CWD",
            "DAA",
            "DAS",
            "AAA",
            "AAS",
            "AAM",
            "AAD",
            "ROL",
            "ROR",
            "RCL",
            "RCR",
            "MOVSB",
            "MOVSW",
            "MOVS",
            "LODSB",
            "LODSW",
            "LODS",
            "STOSB",
            "STOSW",
            "STOS",
            "CMPS",
            "SCAS",
            "REP",
            "REPE",
            "REPNE",
            "TEST",
            "JS",
            "JNS",
            "JO",
            "JNO",
            "JP",
            "JNP",
            "JC",
            "JNC",
            "CLC",
            "STC",
            "CMC",
            "CLD",
            "STD",
            "CLI",
            "STI",
            "HLT",
            "WAIT",
            "LOCK",
            "ESC"});
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(6, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 21);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // InstructionComposer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "InstructionComposer";
            this.Size = new System.Drawing.Size(348, 249);
            this.tabControl.ResumeLayout(false);
            this.tpUseful.ResumeLayout(false);
            this.gbUseful.ResumeLayout(false);
            this.gbUseful.PerformLayout();
            this.tpAdvanced.ResumeLayout(false);
            this.gbAdvanced.ResumeLayout(false);
            this.gbAdvanced.PerformLayout();
            this.tpUtility.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpUseful;
        private System.Windows.Forms.Button btnInsUseful;
        private System.Windows.Forms.ComboBox cbLastUseful;
        private System.Windows.Forms.ComboBox cbFirstUseful;
        private System.Windows.Forms.ComboBox cbChooserUseful;
        private System.Windows.Forms.ComboBox cbIndexUseful;
        private System.Windows.Forms.GroupBox gbUseful;
        private System.Windows.Forms.TabPage tpAdvanced;
        private System.Windows.Forms.ComboBox cbFirstAdvanced;
        private System.Windows.Forms.ComboBox cbChooserAdvanced;
        private System.Windows.Forms.ComboBox cbLastAdvanced;
        private System.Windows.Forms.ComboBox cbIndexAdvanced;
        private System.Windows.Forms.Button btnInsAdvanced;
        private System.Windows.Forms.GroupBox gbAdvanced;
        private System.Windows.Forms.TabPage tpUtility;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblUsageUseful;
        private System.Windows.Forms.Label lblInstructionUseful;
        private System.Windows.Forms.Label lblUsageAdvanced;
        private System.Windows.Forms.Label lblInstructionAdvanced;

    }
}
