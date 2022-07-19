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
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtRateperHour = New System.Windows.Forms.TextBox()
        Me.txtHourPerDay = New System.Windows.Forms.TextBox()
        Me.txtNumberOfdays = New System.Windows.Forms.TextBox()
        Me.txtGrossSalary = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtPhilHealth = New System.Windows.Forms.TextBox()
        Me.txtSss = New System.Windows.Forms.TextBox()
        Me.txtTotaRedu = New System.Windows.Forms.TextBox()
        Me.txtGrosSalary = New System.Windows.Forms.TextBox()
        Me.txtDeduction = New System.Windows.Forms.TextBox()
        Me.txtNetSalary = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblNetsalary = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(654, 182)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(113, 133)
        Me.btnCompute.TabIndex = 0
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'txtRateperHour
        '
        Me.txtRateperHour.Location = New System.Drawing.Point(185, 29)
        Me.txtRateperHour.Name = "txtRateperHour"
        Me.txtRateperHour.Size = New System.Drawing.Size(100, 22)
        Me.txtRateperHour.TabIndex = 1
        '
        'txtHourPerDay
        '
        Me.txtHourPerDay.Location = New System.Drawing.Point(185, 55)
        Me.txtHourPerDay.Name = "txtHourPerDay"
        Me.txtHourPerDay.Size = New System.Drawing.Size(100, 22)
        Me.txtHourPerDay.TabIndex = 2
        '
        'txtNumberOfdays
        '
        Me.txtNumberOfdays.Location = New System.Drawing.Point(185, 81)
        Me.txtNumberOfdays.Name = "txtNumberOfdays"
        Me.txtNumberOfdays.Size = New System.Drawing.Size(100, 22)
        Me.txtNumberOfdays.TabIndex = 3
        '
        'txtGrossSalary
        '
        Me.txtGrossSalary.Location = New System.Drawing.Point(185, 107)
        Me.txtGrossSalary.Name = "txtGrossSalary"
        Me.txtGrossSalary.Size = New System.Drawing.Size(100, 22)
        Me.txtGrossSalary.TabIndex = 4
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(185, 175)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(100, 22)
        Me.txtTax.TabIndex = 5
        '
        'txtPhilHealth
        '
        Me.txtPhilHealth.Location = New System.Drawing.Point(185, 201)
        Me.txtPhilHealth.Name = "txtPhilHealth"
        Me.txtPhilHealth.Size = New System.Drawing.Size(100, 22)
        Me.txtPhilHealth.TabIndex = 6
        '
        'txtSss
        '
        Me.txtSss.Location = New System.Drawing.Point(185, 227)
        Me.txtSss.Name = "txtSss"
        Me.txtSss.Size = New System.Drawing.Size(100, 22)
        Me.txtSss.TabIndex = 7
        '
        'txtTotaRedu
        '
        Me.txtTotaRedu.Location = New System.Drawing.Point(185, 253)
        Me.txtTotaRedu.Name = "txtTotaRedu"
        Me.txtTotaRedu.Size = New System.Drawing.Size(100, 22)
        Me.txtTotaRedu.TabIndex = 8
        '
        'txtGrosSalary
        '
        Me.txtGrosSalary.Location = New System.Drawing.Point(185, 330)
        Me.txtGrosSalary.Name = "txtGrosSalary"
        Me.txtGrosSalary.Size = New System.Drawing.Size(100, 22)
        Me.txtGrosSalary.TabIndex = 9
        '
        'txtDeduction
        '
        Me.txtDeduction.Location = New System.Drawing.Point(185, 356)
        Me.txtDeduction.Name = "txtDeduction"
        Me.txtDeduction.Size = New System.Drawing.Size(100, 22)
        Me.txtDeduction.TabIndex = 10
        '
        'txtNetSalary
        '
        Me.txtNetSalary.Location = New System.Drawing.Point(185, 382)
        Me.txtNetSalary.Name = "txtNetSalary"
        Me.txtNetSalary.Size = New System.Drawing.Size(100, 22)
        Me.txtNetSalary.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Rate Per Hour:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Hour per day:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Number of days:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Gross salary:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "DEDUCTION OF SALARY:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tax 15% of monthly wage:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Philhealth 5%:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(89, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "SSS 2%:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(31, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Total reduction:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(70, 337)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Gross salary:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(75, 363)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Deduction:"
        '
        'lblNetsalary
        '
        Me.lblNetsalary.AutoSize = True
        Me.lblNetsalary.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetsalary.Location = New System.Drawing.Point(59, 385)
        Me.lblNetsalary.Name = "lblNetsalary"
        Me.lblNetsalary.Size = New System.Drawing.Size(75, 17)
        Me.lblNetsalary.TabIndex = 23
        Me.lblNetsalary.Text = "Net salary:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(633, 399)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(155, 39)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(633, 339)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(155, 39)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblNetsalary)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNetSalary)
        Me.Controls.Add(Me.txtDeduction)
        Me.Controls.Add(Me.txtGrosSalary)
        Me.Controls.Add(Me.txtTotaRedu)
        Me.Controls.Add(Me.txtSss)
        Me.Controls.Add(Me.txtPhilHealth)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtGrossSalary)
        Me.Controls.Add(Me.txtNumberOfdays)
        Me.Controls.Add(Me.txtHourPerDay)
        Me.Controls.Add(Me.txtRateperHour)
        Me.Controls.Add(Me.btnCompute)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "PAYROLL SYSTEM BY Ian Cheruiyot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCompute As Button
    Friend WithEvents txtRateperHour As TextBox
    Friend WithEvents txtHourPerDay As TextBox
    Friend WithEvents txtNumberOfdays As TextBox
    Friend WithEvents txtGrossSalary As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtPhilHealth As TextBox
    Friend WithEvents txtSss As TextBox
    Friend WithEvents txtTotaRedu As TextBox
    Friend WithEvents txtGrosSalary As TextBox
    Friend WithEvents txtDeduction As TextBox
    Friend WithEvents txtNetSalary As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblNetsalary As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
End Class
