Imports Microsoft.VisualBasic
Imports System
Namespace SpellCheckerInheritedControls
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker()
			Me.label1 = New System.Windows.Forms.Label()
			Me.button1 = New System.Windows.Forms.Button()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.memoExEdit1 = New DevExpress.XtraEditors.MemoExEdit()
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			Me.label6 = New System.Windows.Forms.Label()
			Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label7 = New System.Windows.Forms.Label()
			Me.richEditControl1 = New SpellCheckerInheritedControls.CustomRichEditControl()
			Me.richTextBox1 = New SpellCheckerInheritedControls.CustomRichTextBox()
			Me.memoEdit1 = New SpellCheckerInheritedControls.CustomMemoEdit()
			Me.textEdit1 = New SpellCheckerInheritedControls.CustomTextEdit()
			Me.textBox1 = New SpellCheckerInheritedControls.CustomTextBox()
			Me.label8 = New System.Windows.Forms.Label()
			CType(Me.memoExEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' spellChecker1
			' 
			Me.spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = True
			Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en-US")
			Me.spellChecker1.ParentContainer = Me
'			Me.spellChecker1.SpellingFormShowing += New DevExpress.XtraSpellChecker.SpellingFormShowingEventHandler(Me.spellChecker1_SpellingFormShowing);
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(12, 18)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(58, 17)
			Me.label1.TabIndex = 2
			Me.label1.Text = "TextBox"
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(15, 244)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(326, 45)
			Me.button1.TabIndex = 3
			Me.button1.Text = "Check spelling in active control"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(12, 48)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(59, 17)
			Me.label2.TabIndex = 5
			Me.label2.Text = "TextEdit"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(12, 75)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(70, 17)
			Me.label3.TabIndex = 7
			Me.label3.Text = "MemoEdit"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(12, 104)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(86, 17)
			Me.label4.TabIndex = 8
			Me.label4.Text = "RichTextBox"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(12, 133)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(105, 17)
			Me.label5.TabIndex = 11
			Me.label5.Text = "RichEditControl"
			' 
			' memoExEdit1
			' 
			Me.memoExEdit1.EditValue = "teest"
			Me.memoExEdit1.Location = New System.Drawing.Point(144, 216)
			Me.memoExEdit1.Name = "memoExEdit1"
			Me.memoExEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.memoExEdit1.Size = New System.Drawing.Size(197, 22)
			Me.memoExEdit1.TabIndex = 12
'			Me.memoExEdit1.Popup += New System.EventHandler(Me.memoExEdit1_Popup);
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.EditValue = "teest"
			Me.buttonEdit1.Location = New System.Drawing.Point(144, 160)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit1.Size = New System.Drawing.Size(197, 22)
			Me.buttonEdit1.TabIndex = 13
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(12, 161)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(73, 17)
			Me.label6.TabIndex = 14
			Me.label6.Text = "ButtonEdit"
			' 
			' comboBoxEdit1
			' 
			Me.comboBoxEdit1.EditValue = "teest"
			Me.comboBoxEdit1.Location = New System.Drawing.Point(144, 188)
			Me.comboBoxEdit1.Name = "comboBoxEdit1"
			Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit1.Size = New System.Drawing.Size(197, 22)
			Me.comboBoxEdit1.TabIndex = 15
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(12, 189)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(99, 17)
			Me.label7.TabIndex = 16
			Me.label7.Text = "ComboBoxEdit"
			' 
			' richEditControl1
			' 
			Me.richEditControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
			Me.richEditControl1.Location = New System.Drawing.Point(144, 129)
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(197, 25)
			Me.richEditControl1.SpellChecker = Me.spellChecker1
			Me.richEditControl1.TabIndex = 10
			Me.richEditControl1.Text = "teest"
			Me.richEditControl1.Views.SimpleView.Padding = New System.Windows.Forms.Padding(0)
			' 
			' richTextBox1
			' 
			Me.richTextBox1.Location = New System.Drawing.Point(144, 101)
			Me.richTextBox1.Name = "richTextBox1"
			Me.richTextBox1.Size = New System.Drawing.Size(197, 22)
			Me.richTextBox1.TabIndex = 9
			Me.richTextBox1.Text = "teest"
			' 
			' memoEdit1
			' 
			Me.memoEdit1.EditValue = "teest"
			Me.memoEdit1.Location = New System.Drawing.Point(144, 73)
			Me.memoEdit1.Name = "memoEdit1"
			Me.memoEdit1.Size = New System.Drawing.Size(197, 22)
			Me.memoEdit1.TabIndex = 6
			' 
			' textEdit1
			' 
			Me.textEdit1.EditValue = "teest"
			Me.textEdit1.Location = New System.Drawing.Point(144, 45)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(197, 22)
			Me.textEdit1.TabIndex = 4
			' 
			' textBox1
			' 
			Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.textBox1.Location = New System.Drawing.Point(144, 12)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(197, 27)
			Me.textBox1.TabIndex = 1
			Me.textBox1.Text = "teest"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(12, 217)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(85, 17)
			Me.label8.TabIndex = 17
			Me.label8.Text = "MemoExEdit"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(357, 303)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.comboBoxEdit1)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.buttonEdit1)
			Me.Controls.Add(Me.memoExEdit1)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.richEditControl1)
			Me.Controls.Add(Me.richTextBox1)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.memoEdit1)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.textEdit1)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.textBox1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.memoExEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker
		Private textBox1 As CustomTextBox
		Private label1 As System.Windows.Forms.Label
		Private WithEvents button1 As System.Windows.Forms.Button
		Private label2 As System.Windows.Forms.Label
		Private textEdit1 As CustomTextEdit
		Private label3 As System.Windows.Forms.Label
		Private memoEdit1 As CustomMemoEdit
		Private richTextBox1 As CustomRichTextBox
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private richEditControl1 As CustomRichEditControl
		Private buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
		Private WithEvents memoExEdit1 As DevExpress.XtraEditors.MemoExEdit
		Private label6 As System.Windows.Forms.Label
		Private comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
		Private label7 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
	End Class
End Namespace

