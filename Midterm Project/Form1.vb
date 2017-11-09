' #####################################################################
' Ryan Dennick
' Midterm Project
' 10/18/2017
' Employee discounts takes in five inputs (name, employment years,
' employee status, previous purchases and todays purchase total). 
' The application provides six outputs. Employee name, the employees
' discount percentage based on years of employment, YTD amout in 
' discounts throught the year, today's purchase total before discount
' is applied, the amount an item is getting discounted and a net 
' total price for today's purchase after discount calculation. 
' Employee discounts also keeps a running total of both total price
' of items purchased prior to discount and total price for those items
' after the employee discount is applied. 
' #####################################################################

Option Strict On

Public Class Form1

    ' Declare modular variables
    Private mdblDailyTotalPriorToDiscount As Double
    Private mdblDailyTotalWithDiscount As Double

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Declare local variables
        Const intMaxDiscount As Integer = 200
        Dim intNumberOfYearsEmployed As Integer
        Dim dblPreviousPurchases As Double
        Dim dblTodaysPurchases As Double
        Dim dblEmployeeDiscountPercentage As Double
        Dim dblYTDPreviousDiscount As Double
        Dim dblNumerator As Double
        Dim dblEmployeeDiscountThisPurchase As Double
        Dim dblTodaysTotalPurchase As Double
        Dim strManager As String = "Manager"
        Dim strHourly As String = "Hourly"

        ' Change back color back to white once errors in inputs are fixed
        txtName.BackColor = Color.White
        txtNumberOfYearsEmployed.BackColor = Color.White
        txtEmployeeStatus.BackColor = Color.White
        txtPreviousPurchases.BackColor = Color.White
        txtTodaysTotal.BackColor = Color.White


        Try

            ' Validate inputs

            ' Check to see if name field is empty
            If txtName.Text = String.Empty Then
                MessageBox.Show("Please enter an employee name")
                txtName.Focus()
                txtName.BackColor = Color.Yellow
                Exit Sub
            End If
            ' Check to see if name is a string
            If IsNumeric(txtName.Text) Then
                MessageBox.Show("Please enter only string characters")
                txtName.Focus()
                txtName.BackColor = Color.Yellow
                Exit Sub
            End If

            ' Check years employed input is not empty
            If txtNumberOfYearsEmployed.Text = String.Empty Then
                MessageBox.Show("Please enter number of years employed")
                txtNumberOfYearsEmployed.Focus()
                txtNumberOfYearsEmployed.BackColor = Color.Yellow
                Exit Sub
            End If

            ' Check that years employed input is numeric and greater than zero
            If IsNumeric(txtNumberOfYearsEmployed.Text) Then
                If CInt(txtNumberOfYearsEmployed.Text) > 0 Then
                    intNumberOfYearsEmployed = CInt(txtNumberOfYearsEmployed.Text)
                Else
                    MessageBox.Show("Please enter a number greater than zero")
                    txtNumberOfYearsEmployed.Focus()
                    txtNumberOfYearsEmployed.BackColor = Color.Yellow
                    Exit Sub
                End If
            Else
                MessageBox.Show("Please enter a numeric value for number of employed years")
                txtNumberOfYearsEmployed.Focus()
                txtNumberOfYearsEmployed.BackColor = Color.Yellow
                Exit Sub
            End If

            ' Check employee status is not empty
            If txtEmployeeStatus.Text = String.Empty Then
                MessageBox.Show("Please enter an employee status")
                txtEmployeeStatus.Focus()
                txtEmployeeStatus.BackColor = Color.Yellow
                Exit Sub
            End If

            ' Check employee status is a string
            If IsNumeric(txtEmployeeStatus.Text) Then
                MessageBox.Show("Please enter string characters for employee status")
                txtEmployeeStatus.Focus()
                txtEmployeeStatus.BackColor = Color.Yellow
                Exit Sub
            End If

            ' Removes whitespace from user input for comparison
            txtEmployeeStatus.Text = txtEmployeeStatus.Text.Replace(" ", "")

            ' Limit user input of employee status to two inputs
            If LCase(txtEmployeeStatus.Text) = LCase(strManager) Or LCase(txtEmployeeStatus.Text) = LCase(strHourly) Then
            Else
                MessageBox.Show("Please answer with Manager or Hourly only")
                txtEmployeeStatus.Focus()
                txtEmployeeStatus.BackColor = Color.Yellow
                Exit Sub
            End If

            ' Check previous purchase is not empty
            If txtPreviousPurchases.Text = String.Empty Then
                MessageBox.Show("Please enter a previous purchase amount")
                txtPreviousPurchases.Focus()
                txtPreviousPurchases.BackColor = Color.Yellow
                Exit Sub
            End If

            ' Check if previous purchase amount is numeric and greater than zero
            If IsNumeric(txtPreviousPurchases.Text) Then
                If CDbl(txtPreviousPurchases.Text) > 0 Then
                    dblPreviousPurchases = CDbl(txtPreviousPurchases.Text)
                Else
                    MessageBox.Show("Please enter a previous purchase amount greater than zero")
                    txtPreviousPurchases.Focus()
                    txtPreviousPurchases.BackColor = Color.Yellow
                    Exit Sub
                End If
            Else
                MessageBox.Show("Please enter only numeric values for previous purchases")
                txtPreviousPurchases.Focus()
                txtPreviousPurchases.BackColor = Color.Yellow
                Exit Sub
            End If

            ' Check total of today's purchase is not empty
            If txtTodaysTotal.Text = String.Empty Then
                MessageBox.Show("Please enter today's purchase total")
                txtTodaysTotal.Focus()
                txtTodaysTotal.BackColor = Color.Yellow
                Exit Sub
            End If

            ' Check if total of todays purchases is numeric and greater than zero
            If IsNumeric(txtTodaysTotal.Text) Then
                If CDbl(txtTodaysTotal.Text) > 0 Then
                    dblTodaysPurchases = CDbl(txtTodaysTotal.Text)
                Else
                    MessageBox.Show("Please enter today's purchase total greater than zero")
                    txtTodaysTotal.Focus()
                    txtTodaysTotal.BackColor = Color.Yellow
                    Exit Sub
                End If
            Else
                MessageBox.Show("Please enter only numeric values for today's purchase total")
                txtTodaysTotal.Focus()
                txtTodaysTotal.BackColor = Color.Yellow
                Exit Sub
            End If

            ' Populate name label with employee name
            lblName.Text = txtName.Text

            ' Find employees discount percentage based on number of years employed
            If intNumberOfYearsEmployed <= 3 Then
                If LCase(txtEmployeeStatus.Text) = "manager" Then
                    dblEmployeeDiscountPercentage = 0.2
                Else
                    dblEmployeeDiscountPercentage = 0.1
                End If
            ElseIf intNumberOfYearsEmployed > 3 And intNumberOfYearsEmployed <= 6 Then
                If LCase(txtEmployeeStatus.Text) = "manager" Then
                    dblEmployeeDiscountPercentage = 0.24
                Else
                    dblEmployeeDiscountPercentage = 0.14
                End If
            ElseIf intNumberOfYearsEmployed > 6 And intNumberOfYearsEmployed <= 10 Then
                If LCase(txtEmployeeStatus.Text) = "manager" Then
                    dblEmployeeDiscountPercentage = 0.3
                Else
                    dblEmployeeDiscountPercentage = 0.2
                End If
            ElseIf intNumberOfYearsEmployed > 10 And intNumberOfYearsEmployed <= 15 Then
                If LCase(txtEmployeeStatus.Text) = "manager" Then
                    dblEmployeeDiscountPercentage = 0.35
                Else
                    dblEmployeeDiscountPercentage = 0.25
                End If
            Else
                If LCase(txtEmployeeStatus.Text) = "manager" Then
                    dblEmployeeDiscountPercentage = 0.4
                Else
                    dblEmployeeDiscountPercentage = 0.3
                End If
            End If

            ' Set employee discount percentage in output label
            lblEmployeeDiscountPercentage.Text = dblEmployeeDiscountPercentage.ToString("P0")

            ' Calculate year to date previous discount total in dollars
            ' Calculated by multiplying previous purchases by employee discount percentage
            dblYTDPreviousDiscount = dblPreviousPurchases * dblEmployeeDiscountPercentage

            ' Check if discount total to date is greater than 200 dollars
            ' If it is, discount total  value is set to max discount value
            If dblYTDPreviousDiscount > 200 Then
                dblYTDPreviousDiscount = intMaxDiscount
            End If

            ' Checks to see if the current purchase will put employee over 200 dollar threshold
            ' If the purchase does, the if-statement will re-adjust employee discount rate
            If (dblTodaysPurchases * dblEmployeeDiscountPercentage) + dblYTDPreviousDiscount > intMaxDiscount Then
                dblNumerator = intMaxDiscount - dblYTDPreviousDiscount
                dblEmployeeDiscountPercentage = dblNumerator / dblTodaysPurchases
            End If

            ' Calculates employees discount on this purchase
            dblEmployeeDiscountThisPurchase = dblEmployeeDiscountPercentage * dblTodaysPurchases

            ' Calculates todays purchase total
            dblTodaysTotalPurchase = dblTodaysPurchases - dblEmployeeDiscountThisPurchase

            ' Populate the output labels with local variables
            lblYTDDiscountAmount.Text = dblYTDPreviousDiscount.ToString("c")
            lblTotalPurchaseTodayBeforeDiscount.Text = dblTodaysPurchases.ToString("c")
            lblEmployeeDiscountThisPurchase.Text = dblEmployeeDiscountThisPurchase.ToString("c")
            lblTotalWithDiscount.Text = dblTodaysTotalPurchase.ToString("c")

            ' Update modular variables

            ' Updates modular variable for purchases without discount applied
            mdblDailyTotalPriorToDiscount += dblTodaysPurchases
            ' Updates modular variable for purchases after discount applied 
            mdblDailyTotalWithDiscount += dblTodaysTotalPurchase

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnNextEmployee_Click(sender As Object, e As EventArgs) Handles btnNextEmployee.Click

        ' Clears the form for the next employee
        txtName.Clear()
        txtNumberOfYearsEmployed.Clear()
        txtEmployeeStatus.Clear()
        txtPreviousPurchases.Clear()
        txtTodaysTotal.Clear()
        txtName.Focus()

        ' CAN BE UNCOMMENTED TO CLEAR OUTPUTS
        'lblName.ResetText()
        'lblEmployeeDiscountPercentage.ResetText()
        'lblYTDDiscountAmount.ResetText()
        'lblTotalPurchaseTodayBeforeDiscount.ResetText()
        'lblEmployeeDiscountThisPurchase.ResetText()
        'lblTotalWithDiscount.ResetText()

    End Sub

    Private Sub btnDiscountSummary_Click(sender As Object, e As EventArgs) Handles btnDiscountSummary.Click

        ' Keeps a running total for employee discounts

        ' Displays running total of employee purchases prior to applying discount
        lblDailyTotalPriorToDiscount.Text = mdblDailyTotalPriorToDiscount.ToString("c")
        ' Displays running total of employee purchases after discounts are applied
        lblDailyTotalWithDiscount.Text = mdblDailyTotalWithDiscount.ToString("c")


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Exits the application
        Me.Close()

    End Sub
End Class
