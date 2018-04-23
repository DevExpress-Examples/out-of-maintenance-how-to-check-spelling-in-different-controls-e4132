Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Collections.Generic
Imports DevExpress.XtraSpellChecker.Native
Imports DevExpress.XtraRichEdit.SpellChecker
Imports DevExpress.XtraEditors

Namespace SpellCheckerInheritedControls
	Public NotInheritable Class SpellCheckerRegistrationHelper
		Private Sub New()
		End Sub
		Public Shared Sub RegisterCustomControlsForSpellChecking()
			' CustomTextBox
			SpellCheckTextControllersManager.Default.RegisterClass(GetType(CustomTextBox), GetType(SimpleTextBoxTextController))
			SpellCheckTextBoxBaseFinderManager.Default.RegisterClass(GetType(CustomTextBox), GetType(TextBoxFinder))

			' CustomTextEdit
			SpellCheckTextControllersManager.Default.RegisterClass(GetType(CustomTextEdit), GetType(SimpleTextEditTextController))
			SpellCheckTextBoxBaseFinderManager.Default.RegisterClass(GetType(CustomTextEdit), GetType(TextEditTextBoxFinder))

			' CustomMemoEdit
			SpellCheckTextControllersManager.Default.RegisterClass(GetType(CustomMemoEdit), GetType(SimpleTextEditTextController))
			SpellCheckTextBoxBaseFinderManager.Default.RegisterClass(GetType(CustomMemoEdit), GetType(MemoEditTextBoxFinder))

			' CustomRichTextBox
			SpellCheckTextControllersManager.Default.RegisterClass(GetType(CustomRichTextBox), GetType(RichTextBoxTextController))
			SpellCheckTextBoxBaseFinderManager.Default.RegisterClass(GetType(CustomRichTextBox), GetType(RTFTextBoxFinder))

			' CustomRichEditControl
			SpellCheckTextControllersManager.Default.RegisterClass(GetType(CustomRichEditControl), GetType(RichEditSpellCheckController))

			' ButtonEdit
			SpellCheckTextControllersManager.Default.RegisterClass(GetType(ButtonEdit), GetType(SimpleTextEditTextController))
			SpellCheckTextBoxBaseFinderManager.Default.RegisterClass(GetType(ButtonEdit), GetType(TextEditTextBoxFinder))

			' ComboBoxEdit
			SpellCheckTextControllersManager.Default.RegisterClass(GetType(ComboBoxEdit), GetType(SimpleTextEditTextController))
			SpellCheckTextBoxBaseFinderManager.Default.RegisterClass(GetType(ComboBoxEdit), GetType(TextEditTextBoxFinder))
		End Sub
	End Class
End Namespace
