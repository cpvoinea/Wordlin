using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Wordlin
{
    public partial class MainForm : Form
    {
        const int MAX_WORD_COUNT = 500;

        readonly List<string> _allWords = new List<string>();
        readonly PositionRule[] _positionRule = new PositionRule[5];
        readonly Dictionary<string, LetterRule> _letterRule = new Dictionary<string, LetterRule>();
        string fileName = "words5.txt";

        public MainForm()
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
            lstSuggestions.Items.Clear();
            var activeRules = _letterRule.Values.Where(r => r.IsInclude.HasValue);
            if (!activeRules.Any())
                lstSuggestions.Items.Add("NO ACTIVE LETTER RULES FOUND");
            var candidates = new List<string>();
            foreach (string w in _allWords)
                if (activeRules.All(r => MatchWordToRule(w, r)))
                    candidates.Add(w);
            if (candidates.Count > MAX_WORD_COUNT)
                lstSuggestions.Items.Add("TOO MANY TO SHOW");
            else if (candidates.Count == 0)
                lstSuggestions.Items.Add("NO WORDS FOUND");
            else
                lstSuggestions.Items.AddRange(candidates.Select(w => new ListViewItem(w.ToUpper())).ToArray());
        }

        void InitializeRules()
        {
            for (int i = 0; i < 5; i++)
                _positionRule[i] = new PositionRule(i);
        }

        void ChangeLetterRule(Button c)
        {
            var pr = _positionRule[c.TabIndex - 1];
            pr.Letter = c.Text;
            pr.Rule = (Rule)(((int)pr.Rule + 1) % 3);
            switch (pr.Rule)
            {
                case Rule.Exclude: c.BackColor = Color.White; break;
                case Rule.Include: c.BackColor = Color.Yellow; break;
                case Rule.Fixed: c.BackColor = Color.Green; break;
            }
        }

        void ResetRules()
        {
            foreach (var pr in _positionRule)
                pr.Rule = Rule.Exclude;
            btnLetter1.BackColor = btnLetter2.BackColor = btnLetter3.BackColor = btnLetter4.BackColor = btnLetter5.BackColor = Color.White;
        }

        void BindRules()
        {
            lstRules.Items.Clear();
            foreach (var lr in _letterRule.Values)
            {
                var d = lr.IsInclude == true ? $"-{lr.Position + 1}" : string.Empty;
                ListViewItem i = new ListViewItem($"{lr.Letter.ToString().ToUpper()}{d}");
                i.BackColor = lr.IsInclude == true ? (lr.IsPosition == true ? Color.Green : Color.Yellow) : Color.Gray;

                lstRules.Items.Add(i);
            }
        }

        void InitializeDictionary()
        {
            _allWords.Clear();
            _allWords.AddRange(File.ReadAllLines(fileName));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeRules();
            InitializeDictionary();
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {
            var w = txtGuess.Text.ToUpper();
            if (w.Length > 0)
                _positionRule[0].Letter = btnLetter1.Text = w[0].ToString();
            if (w.Length > 1)
                _positionRule[1].Letter = btnLetter2.Text = w[1].ToString();
            if (w.Length > 2)
                _positionRule[2].Letter = btnLetter3.Text = w[2].ToString();
            if (w.Length > 3)
                _positionRule[3].Letter = btnLetter4.Text = w[3].ToString();
            if (w.Length > 4)
                _positionRule[4].Letter = btnLetter5.Text = w[4].ToString();
        }

        private void btnLetter_Click(object sender, EventArgs e)
        {
            var c = sender as Button;
            ChangeLetterRule(c);
        }

        private void btnSetRules_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                var pr = _positionRule[i];
                var exists = _letterRule.ContainsKey(pr.Letter);
                if (!exists)
                    _letterRule.Add(pr.Letter, new LetterRule(pr.Letter));
                var lr = _letterRule[pr.Letter];
                switch (pr.Rule)
                {
                    case Rule.Exclude:
                        if (!exists)
                        {
                            lr.IsInclude = false;
                        }
                        break;
                    case Rule.Include:
                        if (!exists || lr.IsInclude == false)
                        {
                            lr.IsInclude = true;
                            lr.IsPosition = false;
                            lr.Position = pr.Position;
                        }
                        break;
                    case Rule.Fixed:
                        if (!exists || lr.IsInclude == false || lr.IsPosition == false)
                        {
                            lr.IsInclude = true;
                            lr.IsPosition = true;
                            lr.Position = pr.Position;
                        }
                        else if (lr.IsInclude == true && lr.IsPosition == true && lr.Position != pr.Position)
                        {
                            lr.IsSecondOccurence = true;
                            lr.IsSecondPosition = true;
                            lr.SecondPosition = pr.Position;
                        }
                        break;
                }
            }

            BindRules();
            ShowWords();
            txtGuess.SelectAll();
        }

        private void btnClearRules_Click(object sender, EventArgs e)
        {
            _letterRule.Clear();
            ResetRules();
            BindRules();
        }

        private void lstSuggestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSuggestions.SelectedItems.Count > 0)
                txtGuess.Text = lstSuggestions.SelectedItems[0].Text;
        }

        private void btnRemoveWord_Click(object sender, EventArgs e)
        {
            if (lstSuggestions.SelectedItems.Count > 0)
            {
                var w = lstSuggestions.SelectedItems[0].Text.ToLower();
                _allWords.Remove(w);
                File.WriteAllLines(fileName, _allWords.ToArray());
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ofdLoad.ShowDialog(this) == DialogResult.OK)
            {
                fileName = ofdLoad.FileName;
                InitializeDictionary();
            }
        }

        private void txtGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0)
            {
                ResetRules();
            }
            else
            {
                Button c = null;
                switch (e.KeyCode)
                {
                    case Keys.D1: c = btnLetter1; break;
                    case Keys.D2: c = btnLetter2; break;
                    case Keys.D3: c = btnLetter3; break;
                    case Keys.D4: c = btnLetter4; break;
                    case Keys.D5: c = btnLetter5; break;
                }
                if (c != null)
                    ChangeLetterRule(c);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetRules();
        }
    }
}
