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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ORDERTXT = New System.Windows.Forms.TextBox()
        Me.FNAMETXT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LNAMETXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CNUMBER = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ADDTXT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EMADDTXT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ITEMTXT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.QTXT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order Number :"
        '
        'ORDERTXT
        '
        Me.ORDERTXT.Enabled = False
        Me.ORDERTXT.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ORDERTXT.Location = New System.Drawing.Point(153, 27)
        Me.ORDERTXT.Name = "ORDERTXT"
        Me.ORDERTXT.Size = New System.Drawing.Size(136, 25)
        Me.ORDERTXT.TabIndex = 1
        '
        'FNAMETXT
        '
        Me.FNAMETXT.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNAMETXT.Location = New System.Drawing.Point(127, 68)
        Me.FNAMETXT.Name = "FNAMETXT"
        Me.FNAMETXT.Size = New System.Drawing.Size(162, 25)
        Me.FNAMETXT.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name :"
        '
        'LNAMETXT
        '
        Me.LNAMETXT.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNAMETXT.Location = New System.Drawing.Point(127, 110)
        Me.LNAMETXT.Name = "LNAMETXT"
        Me.LNAMETXT.Size = New System.Drawing.Size(162, 25)
        Me.LNAMETXT.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name :"
        '
        'CNUMBER
        '
        Me.CNUMBER.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNUMBER.Location = New System.Drawing.Point(164, 146)
        Me.CNUMBER.Name = "CNUMBER"
        Me.CNUMBER.Size = New System.Drawing.Size(125, 25)
        Me.CNUMBER.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contact Number :"
        '
        'ADDTXT
        '
        Me.ADDTXT.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDTXT.Location = New System.Drawing.Point(104, 185)
        Me.ADDTXT.Name = "ADDTXT"
        Me.ADDTXT.Size = New System.Drawing.Size(185, 25)
        Me.ADDTXT.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Address :"
        '
        'EMADDTXT
        '
        Me.EMADDTXT.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMADDTXT.Location = New System.Drawing.Point(153, 226)
        Me.EMADDTXT.Name = "EMADDTXT"
        Me.EMADDTXT.Size = New System.Drawing.Size(136, 25)
        Me.EMADDTXT.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Email Address :"
        '
        'ITEMTXT
        '
        Me.ITEMTXT.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITEMTXT.Location = New System.Drawing.Point(142, 267)
        Me.ITEMTXT.Name = "ITEMTXT"
        Me.ITEMTXT.Size = New System.Drawing.Size(147, 25)
        Me.ITEMTXT.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 22)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Item Number:"
        '
        'QTXT
        '
        Me.QTXT.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QTXT.Location = New System.Drawing.Point(104, 308)
        Me.QTXT.Name = "QTXT"
        Me.QTXT.Size = New System.Drawing.Size(185, 25)
        Me.QTXT.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 22)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Quantity :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(164, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 45)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(347, 366)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 45)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(515, 366)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 45)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(306, 27)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(538, 304)
        Me.ListView1.TabIndex = 20
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Order #"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "First Name"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Last Name"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Contact No."
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Address"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Email Address"
        Me.ColumnHeader6.Width = 72
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Item #"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Quantity"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 435)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.QTXT)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ITEMTXT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.EMADDTXT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ADDTXT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CNUMBER)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LNAMETXT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FNAMETXT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ORDERTXT)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Simple Order Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ORDERTXT As System.Windows.Forms.TextBox
    Friend WithEvents FNAMETXT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LNAMETXT As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CNUMBER As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ADDTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents EMADDTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ITEMTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents QTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader

End Class
