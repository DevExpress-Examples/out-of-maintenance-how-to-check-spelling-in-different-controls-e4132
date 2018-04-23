using System;
using System.Text;
using System.Collections.Generic;
using DevExpress.XtraSpellChecker.Native;
using DevExpress.XtraRichEdit.SpellChecker;
using DevExpress.XtraEditors;

namespace SpellCheckerInheritedControls {
    public static class SpellCheckerRegistrationHelper {
        public static void RegisterCustomControlsForSpellChecking() {
            // CustomTextBox
            SpellCheckTextControllersManager.Default.RegisterClass(typeof(CustomTextBox), typeof(SimpleTextBoxTextController));
            SpellCheckTextBoxBaseFinderManager.Default.RegisterClass(typeof(CustomTextBox), typeof(TextBoxFinder));

            // CustomTextEdit
            SpellCheckTextControllersManager.Default.RegisterClass(typeof(CustomTextEdit), typeof(SimpleTextEditTextController));
            SpellCheckTextBoxBaseFinderManager.Default.RegisterClass(typeof(CustomTextEdit), typeof(TextEditTextBoxFinder));

            // CustomMemoEdit
            SpellCheckTextControllersManager.Default.RegisterClass(typeof(CustomMemoEdit), typeof(SimpleTextEditTextController));
            SpellCheckTextBoxBaseFinderManager.Default.RegisterClass(typeof(CustomMemoEdit), typeof(MemoEditTextBoxFinder));

            // CustomRichTextBox
            SpellCheckTextControllersManager.Default.RegisterClass(typeof(CustomRichTextBox), typeof(RichTextBoxTextController));
            SpellCheckTextBoxBaseFinderManager.Default.RegisterClass(typeof(CustomRichTextBox), typeof(RTFTextBoxFinder));

            // CustomRichEditControl
            SpellCheckTextControllersManager.Default.RegisterClass(typeof(CustomRichEditControl), typeof(RichEditSpellCheckController));
            
            // ButtonEdit
            SpellCheckTextControllersManager.Default.RegisterClass(typeof(ButtonEdit), typeof(SimpleTextEditTextController));
            SpellCheckTextBoxBaseFinderManager.Default.RegisterClass(typeof(ButtonEdit), typeof(TextEditTextBoxFinder));

            // ComboBoxEdit
            SpellCheckTextControllersManager.Default.RegisterClass(typeof(ComboBoxEdit), typeof(SimpleTextEditTextController));
            SpellCheckTextBoxBaseFinderManager.Default.RegisterClass(typeof(ComboBoxEdit), typeof(TextEditTextBoxFinder));
        }
    }
}
