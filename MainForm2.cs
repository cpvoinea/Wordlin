using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Wordlin
{
    public partial class MainForm2 : Form
    {
        const string FILE_NAME = "words5.txt";
        const int MAX_WORD_COUNT = 500;

        readonly List<string> _allWords = File.ReadAllLines(FILE_NAME).ToList();
        readonly Dictionary<string, LetterRule> _letterRule = new Dictionary<string, LetterRule>();
        bool _isUpdatingRule = false;

        LetterRule SelectedRule => lstLetters.SelectedItems.Count != 1 ? null : _letterRule[lstLetters.SelectedItems[0].Text];

        public MainForm2()
        {
            InitializeComponent();
        }

        bool MatchSecondLeter(string word, LetterRule rule)
        {
            if (!rule.IsSecondOccurence)
                return true;
            int firstIndex = word.IndexOf(rule.Letter);
            if (firstIndex < 0)
                return false;
            int secondIndex = word.IndexOf(rule.Letter, firstIndex + 1);
            if (secondIndex < 0)
                return false;
            if (!rule.IsSecondPosition.HasValue)
                return true;
            if (rule.IsSecondPosition.Value)
                return word[rule.SecondPosition] == rule.Letter;
            return word[rule.SecondPosition] != rule.Letter;
        }

        bool MatchWordToRule(string word, LetterRule rule)
        {
            if (rule.IsInclude == false)
                return !word.Contains(rule.Letter);
            if (!rule.IsPosition.HasValue)
                return word.Contains(rule.Letter) && MatchSecondLeter(word, rule);
            if (rule.IsPosition == true)
                return word[rule.Position] == rule.Letter && MatchSecondLeter(word, rule);
            return word.Contains(rule.Letter) && word[rule.Position] != rule.Letter && MatchSecondLeter(word, rule);
        }

        void ShowWords()
        {
            lstWords.Items.Clear();
            var activeRules = _letterRule.Values.Where(r => r.IsInclude.HasValue);
            if (!activeRules.Any())
                lstWords.Items.Add("NO ACTIVE LETTER RULES FOUND");
            var candidates = new List<string>();
            foreach (string w in _allWords)
                if (activeRules.All(r => MatchWordToRule(w, r)))
                    candidates.Add(w);
            if (candidates.Count > 500)
                lstWords.Items.Add("TOO MANY TO SHOW");
            else if (candidates.Count == 0)
                lstWords.Items.Add("NO WORDS FOUND");
            else
                lstWords.Items.AddRange(candidates.Select(w => new ListViewItem(w.ToUpper())).ToArray());
        }

        void ShowColors()
        {
            foreach (ListViewItem i in lstLetters.Items)
            {
                var rule = _letterRule[i.Text];
                if (!rule.IsInclude.HasValue)
                    i.BackColor = Color.White;
                else if (rule.IsInclude.Value)
                {
                    if (!rule.IsPosition.HasValue)
                        i.BackColor = Color.Yellow;
                    else if (rule.IsPosition.Value)
                        i.BackColor = Color.Green;
                    else
                        i.BackColor = Color.Orange;
                }
                else
                    i.BackColor = Color.Gray;
            }
        }

        void UpdateSelectedRule(LetterRule rule)
        {
            if (rule == null)
                return;
            _isUpdatingRule = true;

            lblLetter.Text = rule.Letter.ToString().ToUpper();
            cmbInclude.Enabled = true;
            cmbInclude.SelectedIndex = rule.IsInclude.HasValue ? (rule.IsInclude.Value ? 1 : 2) : 0;
            cmbIsPosition.Enabled = rule.IsInclude == true;
            cmbIsPosition.SelectedIndex = rule.IsPosition.HasValue ? (rule.IsPosition.Value ? 1 : 2) : 0;
            cmbPosition.Enabled = rule.IsPosition.HasValue;
            cmbPosition.SelectedIndex = rule.Position;
            chkIsSecondOccurence.Enabled = rule.IsInclude == true;
            chkIsSecondOccurence.Checked = rule.IsSecondOccurence;
            cmbIsSecondPosition.Enabled = rule.IsSecondOccurence;
            cmbIsSecondPosition.SelectedIndex = rule.IsSecondPosition.HasValue ? (rule.IsSecondPosition.Value ? 1 : 2) : 0;
            cmbSecondPosition.Enabled = rule.IsSecondPosition.HasValue;
            cmbSecondPosition.SelectedIndex = rule.SecondPosition;

            _isUpdatingRule = false;
        }

        void InitializeRules()
        {
            _letterRule.Clear();
            foreach (ListViewItem i in lstLetters.Items)
            {
                string letter = i.Text;
                _letterRule.Add(letter, new LetterRule(letter));
            }
        }

        void InitializeDictionary(string fileName)
        {
            _allWords.Clear();
            _allWords.AddRange(File.ReadAllLines(fileName));
        }

        void LoadDictionary()
        {
            if (ofdDictionary.ShowDialog(this) == DialogResult.OK)
            {
                _allWords.Clear();
                _allWords.AddRange(File.ReadAllLines(ofdDictionary.FileName));
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeRules();
            if (File.Exists(FILE_NAME))
                InitializeDictionary(FILE_NAME);
            else
                LoadDictionary();
        }

        private void lstLetters_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowColors();
            var rule = SelectedRule;
            UpdateSelectedRule(rule);
        }

        private void cmbInclude_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingRule)
                return;
            var rule = SelectedRule;
            if (rule == null)
                return;

            rule.IsInclude = cmbInclude.SelectedIndex == 0 ? (bool?)null : (cmbInclude.SelectedIndex == 1);
            rule.IsPosition = null;
            rule.Position = 0;
            rule.IsSecondOccurence = false;
            rule.IsSecondPosition = null;
            rule.SecondPosition = 0;

            UpdateSelectedRule(rule);
            ShowWords();
        }

        private void cmbIsPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingRule)
                return;
            var rule = SelectedRule;
            if (rule == null)
                return;

            rule.IsPosition = cmbIsPosition.SelectedIndex == 0 ? (bool?)null : (cmbIsPosition.SelectedIndex == 1);

            UpdateSelectedRule(rule);
            ShowWords();
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingRule)
                return;
            var rule = SelectedRule;
            if (rule == null)
                return;

            rule.Position = cmbPosition.SelectedIndex;

            UpdateSelectedRule(rule);
            ShowWords();
        }

        private void chkIsSecondOccurence_CheckedChanged(object sender, EventArgs e)
        {
            if (_isUpdatingRule)
                return;
            var rule = SelectedRule;
            if (rule == null)
                return;

            rule.IsSecondOccurence = chkIsSecondOccurence.Checked;

            UpdateSelectedRule(rule);
            ShowWords();
        }

        private void cmbIsSecondPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingRule)
                return;
            var rule = SelectedRule;
            if (rule == null)
                return;

            rule.IsSecondPosition = cmbIsSecondPosition.SelectedIndex == 0 ? (bool?)null : (cmbIsSecondPosition.SelectedIndex == 1);

            UpdateSelectedRule(rule);
            ShowWords();
        }

        private void cmbSecondPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingRule)
                return;
            var rule = SelectedRule;
            if (rule == null)
                return;

            rule.SecondPosition = cmbSecondPosition.SelectedIndex;

            UpdateSelectedRule(rule);
            ShowWords();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            InitializeRules();
            ShowColors();
            ShowWords();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                LoadDictionary();
        }
    }
}
