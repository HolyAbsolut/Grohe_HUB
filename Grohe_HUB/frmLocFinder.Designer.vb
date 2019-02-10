<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocFinder
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtUnloc = New System.Windows.Forms.TextBox()
        Me.txtLocName = New System.Windows.Forms.TextBox()
        Me.lblLoc = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUnloc
        '
        Me.txtUnloc.Location = New System.Drawing.Point(12, 25)
        Me.txtUnloc.Name = "txtUnloc"
        Me.txtUnloc.Size = New System.Drawing.Size(58, 20)
        Me.txtUnloc.TabIndex = 0
        '
        'txtLocName
        '
        Me.txtLocName.Location = New System.Drawing.Point(76, 25)
        Me.txtLocName.Name = "txtLocName"
        Me.txtLocName.Size = New System.Drawing.Size(163, 20)
        Me.txtLocName.TabIndex = 1
        '
        'lblLoc
        '
        Me.lblLoc.AutoSize = True
        Me.lblLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoc.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblLoc.Location = New System.Drawing.Point(116, 9)
        Me.lblLoc.Name = "lblLoc"
        Me.lblLoc.Size = New System.Drawing.Size(45, 13)
        Me.lblLoc.TabIndex = 2
        Me.lblLoc.Text = "Label1"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(245, 23)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(70, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.TabStop = False
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Location searched:"
        '
        'frmLocFinder
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 58)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblLoc)
        Me.Controls.Add(Me.txtLocName)
        Me.Controls.Add(Me.txtUnloc)
        Me.Name = "frmLocFinder"
        Me.Text = "frmLocFinder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUnloc As TextBox
    Friend WithEvents txtLocName As TextBox
    Friend WithEvents lblLoc As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents Label1 As Label
End Class
