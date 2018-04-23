using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;
using DevExpress.Utils.Win;
using DevExpress.XtraEditors;
using DevExpress.XtraSpellChecker;

namespace SpellCheckerInheritedControls {
    public partial class Form1 : Form {
        private Control activeControl = null;
        
        public Form1() {
            InitializeComponent();

            LoadDictionaries();

            textBox1.GotFocus += editor_GotFocus;
            textEdit1.GotFocus += editor_GotFocus;
            memoEdit1.GotFocus += editor_GotFocus;
            richTextBox1.GotFocus += editor_GotFocus;
            richEditControl1.GotFocus += editor_GotFocus;
            buttonEdit1.GotFocus += editor_GotFocus;
            comboBoxEdit1.GotFocus += editor_GotFocus;
            memoExEdit1.GotFocus += editor_GotFocus;
        }

        private void LoadDictionaries() {
            string currentDirectory = Directory.GetCurrentDirectory();
            
            SpellCheckerOpenOfficeDictionary openOfficeDictionaryEnglish = new SpellCheckerOpenOfficeDictionary();
            openOfficeDictionaryEnglish.DictionaryPath = currentDirectory + @"\..\..\Dictionaries\en_US\en_US.dic";
            openOfficeDictionaryEnglish.GrammarPath = currentDirectory + @"\..\..\Dictionaries\en_US\en_US.aff";
            openOfficeDictionaryEnglish.Culture = new CultureInfo("en-US");
            spellChecker1.Dictionaries.Add(openOfficeDictionaryEnglish);

            spellChecker1.Culture = openOfficeDictionaryEnglish.Culture;
            spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType;
        }

        private void editor_GotFocus(object sender, EventArgs e) {
            activeControl = (Control)sender;
        }

        private void button1_Click(object sender, EventArgs e) {
            spellChecker1.Check(activeControl);
        }

        private void memoExEdit1_Popup(object sender, EventArgs e) {
            IPopupControl popup = (IPopupControl)sender;

            for (int i = 0; i < popup.PopupWindow.Controls.Count; i++) {
                Control popupItem = popup.PopupWindow.Controls[i];

                if (popupItem is MemoEdit) {
                    spellChecker1.SetShowSpellCheckMenu(popupItem, true);
                    spellChecker1.Check(popupItem);
                    break;
                }
            }
        }

        private void spellChecker1_SpellingFormShowing(object sender, SpellingFormShowingEventArgs e) {
            e.Handled = (activeControl == memoExEdit1);
        }
    }
}