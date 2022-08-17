<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lstStart = New System.Windows.Forms.ListBox()
        Me.lstDest = New System.Windows.Forms.ListBox()
        Me.cmbChange = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstStart
        '
        Me.lstStart.FormattingEnabled = True
        Me.lstStart.Location = New System.Drawing.Point(127, 222)
        Me.lstStart.Name = "lstStart"
        Me.lstStart.Size = New System.Drawing.Size(209, 186)
        Me.lstStart.TabIndex = 2
        '
        'lstDest
        '
        Me.lstDest.FormattingEnabled = True
        Me.lstDest.Location = New System.Drawing.Point(447, 221)
        Me.lstDest.Name = "lstDest"
        Me.lstDest.Size = New System.Drawing.Size(209, 186)
        Me.lstDest.TabIndex = 3
        '
        'cmbChange
        '
        Me.cmbChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChange.FormattingEnabled = True
        Me.cmbChange.Items.AddRange(New Object() {"Gregorian to Ethiopic", "Ethiopic to Gregorian"})
        Me.cmbChange.Location = New System.Drawing.Point(127, 184)
        Me.cmbChange.Name = "cmbChange"
        Me.cmbChange.Size = New System.Drawing.Size(209, 21)
        Me.cmbChange.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(127, 419)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(529, 34)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save to File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(124, 44)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(462, 20)
        Me.txtFilePath.TabIndex = 7
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(593, 43)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(60, 23)
        Me.btnBrowse.TabIndex = 8
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Select File (MM/dd/yyyy)"
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(124, 93)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(462, 20)
        Me.txtText.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Type Date (MM/dd/yyyy)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(124, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Converion Type"
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(354, 289)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 51)
        Me.btnChange.TabIndex = 13
        Me.btnChange.Text = "Convert >"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(508, 119)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 24)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add Date"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 464)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbChange)
        Me.Controls.Add(Me.lstDest)
        Me.Controls.Add(Me.lstStart)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "GC EC Convertor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstStart As ListBox
    Friend WithEvents lstDest As ListBox
    Friend WithEvents cmbChange As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnChange As Button
    Friend WithEvents btnAdd As Button
End Class
