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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTodaysTotal = New System.Windows.Forms.TextBox()
        Me.txtPreviousPurchases = New System.Windows.Forms.TextBox()
        Me.txtEmployeeStatus = New System.Windows.Forms.TextBox()
        Me.txtNumberOfYearsEmployed = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalWithDiscount = New System.Windows.Forms.Label()
        Me.lblEmployeeDiscountThisPurchase = New System.Windows.Forms.Label()
        Me.lblTotalPurchaseTodayBeforeDiscount = New System.Windows.Forms.Label()
        Me.lblYTDDiscountAmount = New System.Windows.Forms.Label()
        Me.lblEmployeeDiscountPercentage = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblDailyTotalWithDiscount = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblDailyTotalPriorToDiscount = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnNextEmployee = New System.Windows.Forms.Button()
        Me.btnDiscountSummary = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.txtTodaysTotal)
        Me.GroupBox1.Controls.Add(Me.txtPreviousPurchases)
        Me.GroupBox1.Controls.Add(Me.txtEmployeeStatus)
        Me.GroupBox1.Controls.Add(Me.txtNumberOfYearsEmployed)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 150)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Information"
        '
        'txtTodaysTotal
        '
        Me.txtTodaysTotal.Location = New System.Drawing.Point(683, 23)
        Me.txtTodaysTotal.Name = "txtTodaysTotal"
        Me.txtTodaysTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTodaysTotal.TabIndex = 16
        Me.txtTodaysTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPreviousPurchases
        '
        Me.txtPreviousPurchases.Location = New System.Drawing.Point(426, 98)
        Me.txtPreviousPurchases.Name = "txtPreviousPurchases"
        Me.txtPreviousPurchases.Size = New System.Drawing.Size(100, 20)
        Me.txtPreviousPurchases.TabIndex = 15
        Me.txtPreviousPurchases.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmployeeStatus
        '
        Me.txtEmployeeStatus.Location = New System.Drawing.Point(426, 23)
        Me.txtEmployeeStatus.Name = "txtEmployeeStatus"
        Me.txtEmployeeStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeeStatus.TabIndex = 14
        Me.txtEmployeeStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumberOfYearsEmployed
        '
        Me.txtNumberOfYearsEmployed.Location = New System.Drawing.Point(123, 98)
        Me.txtNumberOfYearsEmployed.Name = "txtNumberOfYearsEmployed"
        Me.txtNumberOfYearsEmployed.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOfYearsEmployed.TabIndex = 13
        Me.txtNumberOfYearsEmployed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(123, 23)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 12
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(561, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 34)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Total of Today's Purchase:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(254, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 37)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total Amount of Previous Purchases Prior to Discount:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(344, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 34)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Employee Status:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 38)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Number of Years Employed: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.lblTotalWithDiscount)
        Me.GroupBox2.Controls.Add(Me.lblEmployeeDiscountThisPurchase)
        Me.GroupBox2.Controls.Add(Me.lblTotalPurchaseTodayBeforeDiscount)
        Me.GroupBox2.Controls.Add(Me.lblYTDDiscountAmount)
        Me.GroupBox2.Controls.Add(Me.lblEmployeeDiscountPercentage)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(41, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 150)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employee Summary"
        '
        'lblTotalWithDiscount
        '
        Me.lblTotalWithDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalWithDiscount.Location = New System.Drawing.Point(683, 111)
        Me.lblTotalWithDiscount.Name = "lblTotalWithDiscount"
        Me.lblTotalWithDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalWithDiscount.TabIndex = 11
        Me.lblTotalWithDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeDiscountThisPurchase
        '
        Me.lblEmployeeDiscountThisPurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeDiscountThisPurchase.Location = New System.Drawing.Point(683, 46)
        Me.lblEmployeeDiscountThisPurchase.Name = "lblEmployeeDiscountThisPurchase"
        Me.lblEmployeeDiscountThisPurchase.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployeeDiscountThisPurchase.TabIndex = 10
        Me.lblEmployeeDiscountThisPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalPurchaseTodayBeforeDiscount
        '
        Me.lblTotalPurchaseTodayBeforeDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPurchaseTodayBeforeDiscount.Location = New System.Drawing.Point(426, 112)
        Me.lblTotalPurchaseTodayBeforeDiscount.Name = "lblTotalPurchaseTodayBeforeDiscount"
        Me.lblTotalPurchaseTodayBeforeDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalPurchaseTodayBeforeDiscount.TabIndex = 9
        Me.lblTotalPurchaseTodayBeforeDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYTDDiscountAmount
        '
        Me.lblYTDDiscountAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYTDDiscountAmount.Location = New System.Drawing.Point(426, 46)
        Me.lblYTDDiscountAmount.Name = "lblYTDDiscountAmount"
        Me.lblYTDDiscountAmount.Size = New System.Drawing.Size(100, 23)
        Me.lblYTDDiscountAmount.TabIndex = 8
        Me.lblYTDDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeDiscountPercentage
        '
        Me.lblEmployeeDiscountPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeDiscountPercentage.Location = New System.Drawing.Point(123, 111)
        Me.lblEmployeeDiscountPercentage.Name = "lblEmployeeDiscountPercentage"
        Me.lblEmployeeDiscountPercentage.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployeeDiscountPercentage.TabIndex = 7
        Me.lblEmployeeDiscountPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Location = New System.Drawing.Point(123, 46)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 23)
        Me.lblName.TabIndex = 6
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(546, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 23)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Total with Discount:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(561, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 39)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Employee Discount this Purchase:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(283, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 35)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Total Purchase Today Before Discount:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(299, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 36)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "YTD Amount of Discount in Dollars:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 33)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Employee Discount Percentage:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Name:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox3.Controls.Add(Me.lblDailyTotalWithDiscount)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.lblDailyTotalPriorToDiscount)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(41, 373)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(800, 150)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totals for all Employees"
        '
        'lblDailyTotalWithDiscount
        '
        Me.lblDailyTotalWithDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDailyTotalWithDiscount.Location = New System.Drawing.Point(586, 64)
        Me.lblDailyTotalWithDiscount.Name = "lblDailyTotalWithDiscount"
        Me.lblDailyTotalWithDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblDailyTotalWithDiscount.TabIndex = 15
        Me.lblDailyTotalWithDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(423, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 13)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Daily Total with Discount:"
        '
        'lblDailyTotalPriorToDiscount
        '
        Me.lblDailyTotalPriorToDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDailyTotalPriorToDiscount.Location = New System.Drawing.Point(237, 64)
        Me.lblDailyTotalPriorToDiscount.Name = "lblDailyTotalPriorToDiscount"
        Me.lblDailyTotalPriorToDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblDailyTotalPriorToDiscount.TabIndex = 13
        Me.lblDailyTotalPriorToDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(68, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(144, 38)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Daily Total Prior to Discount:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(112, 542)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 50)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnNextEmployee
        '
        Me.btnNextEmployee.Location = New System.Drawing.Point(303, 542)
        Me.btnNextEmployee.Name = "btnNextEmployee"
        Me.btnNextEmployee.Size = New System.Drawing.Size(100, 50)
        Me.btnNextEmployee.TabIndex = 4
        Me.btnNextEmployee.Text = "Next Employee"
        Me.btnNextEmployee.UseVisualStyleBackColor = True
        '
        'btnDiscountSummary
        '
        Me.btnDiscountSummary.Location = New System.Drawing.Point(496, 542)
        Me.btnDiscountSummary.Name = "btnDiscountSummary"
        Me.btnDiscountSummary.Size = New System.Drawing.Size(100, 50)
        Me.btnDiscountSummary.TabIndex = 5
        Me.btnDiscountSummary.Text = "Discount Summary"
        Me.btnDiscountSummary.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(674, 542)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 50)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(884, 611)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDiscountSummary)
        Me.Controls.Add(Me.btnNextEmployee)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Employee Discounts"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTodaysTotal As TextBox
    Friend WithEvents txtPreviousPurchases As TextBox
    Friend WithEvents txtEmployeeStatus As TextBox
    Friend WithEvents txtNumberOfYearsEmployed As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTotalWithDiscount As Label
    Friend WithEvents lblEmployeeDiscountThisPurchase As Label
    Friend WithEvents lblTotalPurchaseTodayBeforeDiscount As Label
    Friend WithEvents lblYTDDiscountAmount As Label
    Friend WithEvents lblEmployeeDiscountPercentage As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblDailyTotalWithDiscount As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblDailyTotalPriorToDiscount As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnNextEmployee As Button
    Friend WithEvents btnDiscountSummary As Button
    Friend WithEvents btnExit As Button
End Class
