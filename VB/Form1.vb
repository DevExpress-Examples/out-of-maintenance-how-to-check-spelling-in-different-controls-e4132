Imports System
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Globalization
Imports DevExpress.Utils.Win
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSpellChecker

Namespace SpellCheckerInheritedControls
	Partial Public Class Form1
		Inherits Form

'INSTANT VB NOTE: The field activeControl was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private activeControl_Conflict As Control = Nothing

		Public Sub New()
			InitializeComponent()

			LoadDictionaries()

			AddHandler textBox1.GotFocus, AddressOf editor_GotFocus
			AddHandler textEdit1.GotFocus, AddressOf editor_GotFocus
			AddHandler memoEdit1.GotFocus, AddressOf editor_GotFocus
			AddHandler richTextBox1.GotFocus, AddressOf editor_GotFocus
			AddHandler richEditControl1.GotFocus, AddressOf editor_GotFocus
			AddHandler buttonEdit1.GotFocus, AddressOf editor_GotFocus
			AddHandler comboBoxEdit1.GotFocus, AddressOf editor_GotFocus
			AddHandler memoExEdit1.GotFocus, AddressOf editor_GotFocus
		End Sub

		Private Sub LoadDictionaries()
			Dim currentDirectory As String = Directory.GetCurrentDirectory()

			Dim openOfficeDictionaryEnglish As New SpellCheckerOpenOfficeDictionary()
			openOfficeDictionaryEnglish.DictionaryPath = currentDirectory & "\..\..\Dictionaries\en_US\en_US.dic"
			openOfficeDictionaryEnglish.GrammarPath = currentDirectory & "\..\..\Dictionaries\en_US\en_US.aff"
			openOfficeDictionaryEnglish.Culture = New CultureInfo("en-US")
			spellChecker1.Dictionaries.Add(openOfficeDictionaryEnglish)

			spellChecker1.Culture = openOfficeDictionaryEnglish.Culture
			spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType
		End Sub

		Private Sub editor_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
			activeControl_Conflict = DirectCast(sender, Control)
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			If Not Me.button1.IsHandleCreated Then Return

			spellChecker1.Check(activeControl_Conflict)
		End Sub

		Private Sub memoExEdit1_Popup(ByVal sender As Object, ByVal e As EventArgs) Handles memoExEdit1.Popup
			Dim popup As IPopupControl = DirectCast(sender, IPopupControl)

			For i As Integer = 0 To popup.PopupWindow.Controls.Count - 1
				Dim popupItem As Control = popup.PopupWindow.Controls(i)

				If TypeOf popupItem Is MemoEdit Then
					spellChecker1.SetShowSpellCheckMenu(popupItem, True)
					spellChecker1.Check(popupItem)
					Exit For
				End If
			Next i
		End Sub

		Private Sub spellChecker1_SpellingFormShowing(ByVal sender As Object, ByVal e As SpellingFormShowingEventArgs) Handles spellChecker1.SpellingFormShowing
			e.Handled = (activeControl_Conflict Is memoExEdit1)
		End Sub
	End Class
End Namespace