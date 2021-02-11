using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script_Creator
{
    public partial class FRM_MAIN : Form
    {
        private string _template = "";
        private string _full_template = "";
        private string[] _agenda;
        private string[] _naam;

        public FRM_MAIN()
        {
            InitializeComponent();
            LoadTemplate();
            DisplayTemplate();
        }

        private void BTN_TOEVOEGEN_Click(object sender, EventArgs e)
        {
            if (TXT_AGENDA.Text.Length == 0)
            {
                MessageBox.Show("Vul het tekstvak 'Agenda' in.");
                return;
            }
            if (TXT_NAAM.Text.Length ==  0)
            {
                MessageBox.Show("Vul het tekstvak 'Naam' in.");
                return;
            }
            _agenda = TXT_AGENDA.Text.Split(',');
            _naam = TXT_NAAM.Text.Split(',');
            _full_template = "";
            for (int _i = 0; _i < _agenda.Count(); _i++)
                for (int _j = 0; _j < _naam.Count(); _j++)
                {
                    LoadTemplate();
                    DisplayTemplate();
                    AlterTemplate(_i, _j);
                }
        }

        private void LoadTemplate()
        {
            try
            {
                StreamReader _sr = new StreamReader("Script exchange template.txt", Encoding.UTF8);
                _template = _sr.ReadToEnd();
                _sr.Close();
            }
            catch (Exception _e)
            {
                MessageBox.Show("Er was een probleem bij het laden van het 'template', " + _e.InnerException.ToString());
            }
        }

        public void HighlightText(string _word, Color _color)
        {
            if (_word == string.Empty)
                return;

            int s_start = RTB_TEMPLATE.SelectionStart, _start = 0, _index;

            while ((_index = RTB_TEMPLATE.Text.IndexOf(_word, _start)) != -1)
            {
                HighLight(_index, _word.Length, _color);
                _start = _index + _word.Length;
            }
        }

        private void DisplayTemplate()
        {
            RTB_TEMPLATE.Text = _template;
            HighlightText("{AGENDA}", Color.FromArgb(192, 192, 255));
            HighlightText("{NAAM}", Color.FromArgb(192, 255, 192));
            HighlightText("{RECHTEN}", Color.FromArgb(255, 255, 192));
        }

        private void HighLight(int _start, int _length, Color _color)
        {
            RTB_TEMPLATE.Select(_start, _length);
            RTB_TEMPLATE.SelectionColor = _color;
        }

        private void AlterTemplate(int _agenda_index, int _naam_index)
        {
            RTB_TEMPLATE.Text = RTB_TEMPLATE.Text.Replace("{AGENDA}", "{0}");
            RTB_TEMPLATE.Text = RTB_TEMPLATE.Text.Replace("{NAAM}", "{1}");
            RTB_TEMPLATE.Text = RTB_TEMPLATE.Text.Replace("{RECHTEN}", "{2}");
            RTB_TEMPLATE.Text = String.Format(RTB_TEMPLATE.Text, _agenda[_agenda_index], _naam[_naam_index], COMBO_RIGHTS.Text);
            _full_template += RTB_TEMPLATE.Text + Environment.NewLine + Environment.NewLine;
            HighlightText(TXT_AGENDA.Text, Color.FromArgb(192, 192, 255));
            HighlightText(TXT_NAAM.Text, Color.FromArgb(192, 255, 192));
            HighlightText(COMBO_RIGHTS.Text, Color.FromArgb(255, 255, 192));
        }

        private void BTN_NEW_SCRIPT_Click(object sender, EventArgs e)
        {
            RTB_SCRIPT.Text = "";
        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            LoadTemplate();
            DisplayTemplate();
        }

        private void BTN_GENERATE_Click(object sender, EventArgs e)
        {
            RTB_SCRIPT.Text += _full_template + Environment.NewLine;
        }

        private void BTN_SAVE_SCRIPT_Click(object sender, EventArgs e)
        {
            SaveFileDialog _sfd = new SaveFileDialog();
            _sfd.ShowDialog();
            if (_sfd.FileName != "")
            {
                try
                {
                    StreamWriter _sr = new StreamWriter(_sfd.FileName);
                    string[] _parts = RTB_SCRIPT.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                    foreach (String _s in _parts)
                        _sr.WriteLine(_s);
                    _sr.Close();
                    MessageBox.Show("Script: [" + _sfd.FileName + "] opgeslagen!");
                }
                catch (Exception _e)
                {
                    MessageBox.Show("Er was een probleem met het opslagen van het script! " + _e.InnerException.ToString());
                }
            }
        }

        private void BTN_CLIPBOARD_Click(object sender, EventArgs e)
        {
            string _copy = RTB_SCRIPT.Text.Replace("\n", "\n\r");
            Clipboard.SetText(_copy);
            if (CHECK_NOTICE_CLIPBOARD.Checked)
                MessageBox.Show("Script is gekopiëerd naar het klembord.");
        }

        private void BTN_IMPORT_Click(object sender, EventArgs e)
        {
            OpenFileDialog _ofd = new OpenFileDialog();
            _ofd.ShowDialog();
            if (_ofd.FileName != "")
            {
                StreamReader _sr = new StreamReader(_ofd.FileName);
                string _names = _sr.ReadToEnd();
                string[] _name = _names.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                _sr.Close();
                TXT_NAAM.Text = "";
                for (int _i = 0; _i < _name.Count(); _i++)
                {
                    TXT_NAAM.Text += _name[_i];
                    if (_i < _name.Count() - 1)
                        TXT_NAAM.Text += ",";
                }
            }
        }

        private void BTN_IMPORT_AGENDA_Click(object sender, EventArgs e)
        {
            OpenFileDialog _ofd = new OpenFileDialog();
            _ofd.ShowDialog();
            if (_ofd.FileName != "")
            {
                StreamReader _sr = new StreamReader(_ofd.FileName);
                string _names = _sr.ReadToEnd();
                string[] _name = _names.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                _sr.Close();
                TXT_AGENDA.Text = "";
                for (int _i = 0; _i < _name.Count(); _i++)
                {
                    TXT_AGENDA.Text += _name[_i];
                    if (_i < _name.Count() - 1)
                        TXT_AGENDA.Text += ",";
                }
            }
        }
    }
}

