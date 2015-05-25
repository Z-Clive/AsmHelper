using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using AsmHelper.DataProvider;

namespace AsmHelper.Controls
{
    public partial class InstructionComposer : UserControl
    {
        public event Action<string> InsertInstruction;

        private readonly Dictionary<UsefulInstructionType, Dictionary<string, string>> _usefulInstructionDictionary =
            GetInstructions.UsefulInstructionDictionary;

        private readonly Dictionary<AdvancedInstructionType, Dictionary<string, string>> _advancedInstructionDictionary =
            GetInstructions.AdvancedInstructionDictionary;

        private Dictionary<string, string> _currentUsefulDictionary;
        private Dictionary<string, string> _currentAdvancedDictionary;

        public InstructionComposer()
        {
            InitializeComponent();
        }

        private void cbIndexUseful_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentUsefulDictionary = _usefulInstructionDictionary[(UsefulInstructionType)cbIndexUseful.SelectedIndex];
            var bindingSource = new BindingSource { DataSource = _currentUsefulDictionary.Keys };
            cbChooserUseful.DataSource = bindingSource;
        }

        private void cbChooserUseful_SelectedIndexChanged(object sender, EventArgs e)
        {
            var instruction = (string)cbChooserUseful.Items[cbChooserUseful.SelectedIndex];
            var instructionDescription = _currentUsefulDictionary[instruction];

            lblInstructionUseful.Text = instruction;
            lblUsageUseful.Text = instructionDescription;

            cbFirstUseful.Text = string.Empty;
            cbLastUseful.Text = string.Empty;
        }

        private void btnInsUseful_Click(object sender, EventArgs e)
        {
            var handler = InsertInstruction;
            if (handler != null)
            {
                var stringBuilder = new StringBuilder();

                if (!string.IsNullOrEmpty(cbChooserUseful.Text))
                {
                    stringBuilder.Append(cbChooserUseful.Text);
                }

                if (!string.IsNullOrEmpty(cbFirstUseful.Text))
                {
                    stringBuilder.Append(' ');
                    stringBuilder.Append(cbFirstUseful.Text);
                }

                if (!string.IsNullOrEmpty(cbLastUseful.Text))
                {
                    stringBuilder.Append(", ");
                    stringBuilder.Append(cbLastUseful.Text);
                }

                stringBuilder.Append("\r\n");

                handler(stringBuilder.ToString());
            }
        }

        private void cbIndexAdvanced_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentAdvancedDictionary = _advancedInstructionDictionary[(AdvancedInstructionType)cbIndexAdvanced.SelectedIndex];
            var bindingSource = new BindingSource { DataSource = _currentAdvancedDictionary.Keys };
            cbChooserAdvanced.DataSource = bindingSource;
        }

        private void cbChooserAdvanced_SelectedIndexChanged(object sender, EventArgs e)
        {
            var instruction = (string)cbChooserAdvanced.Items[cbChooserAdvanced.SelectedIndex];
            var instructionDescription = _currentAdvancedDictionary[instruction];

            lblInstructionAdvanced.Text = instruction;
            lblUsageAdvanced.Text = instructionDescription;

            cbFirstAdvanced.Text = string.Empty;
            cbLastAdvanced.Text = string.Empty;
        }

        private void btnInsAdvanced_Click(object sender, EventArgs e)
        {
            var handler = InsertInstruction;
            if (handler != null)
            {
                var stringBuilder = new StringBuilder();

                if (!string.IsNullOrEmpty(cbChooserAdvanced.Text))
                {
                    stringBuilder.Append(cbChooserAdvanced.Text);
                }

                if (!string.IsNullOrEmpty(cbFirstAdvanced.Text))
                {
                    stringBuilder.Append(' ');
                    stringBuilder.Append(cbFirstAdvanced.Text);
                }

                if (!string.IsNullOrEmpty(cbLastAdvanced.Text))
                {
                    stringBuilder.Append(", ");
                    stringBuilder.Append(cbLastAdvanced.Text);
                }

                stringBuilder.Append("\r\n");

                handler(stringBuilder.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text;

            foreach (var indexer in _usefulInstructionDictionary)
            {
                var i = 0;

                foreach (var instruction in indexer.Value)
                {
                    if (string.Equals(searchText, instruction.Key, StringComparison.OrdinalIgnoreCase))
                    {
                        tabControl.SelectedIndex = 0;
                        cbIndexUseful.SelectedIndex = (int)indexer.Key;
                        cbChooserUseful.SelectedIndex = i;
                        return;
                    }
                    i++;
                }
            }

            foreach (var indexer in _advancedInstructionDictionary)
            {
                var i = 0;

                foreach (var instruction in indexer.Value)
                {
                    if (string.Equals(searchText, instruction.Key, StringComparison.OrdinalIgnoreCase))
                    {
                        tabControl.SelectedIndex = 1;
                        cbIndexAdvanced.SelectedIndex = (int)indexer.Key;
                        cbChooserAdvanced.SelectedIndex = i;
                        return;
                    }
                    i++;
                }
            }

            MessageBox.Show("未找到结果！");
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }
    }
}
