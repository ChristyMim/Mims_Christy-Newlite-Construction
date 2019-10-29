Public Class frmNewliteConstruction
    'Program Name: Newlite Construction Company
    'Programmer: Christy Mims
    'Date: 4/12/17
    'Description:  This program allows the user to select information and calculate the cost of shipping the items.  The program does this through
    'the use of tool strip, buttons, list boxes and combo boxes.  The program transfers data from list box to list box and when it makes it to the 
    'list box it calculates the data for the user.

    Const D65_Bulldozer As String = "D65 Bulldozer"
    Const D72_Bulldozer As String = "D72 Bulldozer"
    Const E1000_Excavator As String = "E1000 Excavator"
    Const E450_Compact_Excavator As String = "E450 Compact Excavator"
    Const SC_200_Scraper As String = "SC 200 Scraper"
    Const ST_500_Skid_Steer_Loader As String = "ST 500 Skid Steer Loader"
    Const Cost_D65 As Decimal = 400
    Const Cost_D72 As Decimal = 500
    Const Cost_E1000 As Decimal = 250
    Const Cost_E450 As Decimal = 350
    Const Cost_SC_200 As Decimal = 300
    Const Cost_ST_500 As Decimal = 600

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes the program.
        Me.Close()
    End Sub

    Private Sub NewShippingOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewShippingOrderToolStripMenuItem.Click
        'Displays message box about clearing information entered.
        Dim New_Order As DialogResult
        New_Order = MessageBox.Show("Are you sure you want to clear all fields and create a new shipping order?", "Clear",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If New_Order = DialogResult.Yes Then
            cmbShipFrom.Text = ""
            cmbShipTo.Text = ""
            lstResults.Items.Clear()
            lstFreightCompany.SelectedIndex = -1
            lstShip.Items.Clear()
            lstInventory.SelectedIndex = -1
        End If
    End Sub

    Private Sub AboutNewliteConstructionCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutNewliteConstructionCompanyToolStripMenuItem.Click
        'Displays a message box telling user what Newlite Construction is about.
        MessageBox.Show("Newlite Construction Company currently has construction contracts in the following seven cities: " &
                        "Jackson, MS; Tupelo, MS; Gulfport, MS; Mobile, AL; Birmingham, AL; Memphis, TN; and Knoxville, TN." &
                        "They must frequently ship their heavy construction equipment from one of these cities to another." &
                        "They have contracts with four shipping companies that charge them a flat shipping charge for each" &
                        "piece of equipment regardless of its destination. The equipment names and corresponding shipping" &
                        "charges are as follows:", "About")
    End Sub
    Private Sub btnAddAll_Click(sender As Object, e As EventArgs) Handles btnAddAll.Click
        'This button adds all the equipment inventory to the shipping list box.
        Dim add_all As Double = lstInventory.Items.Count - 1
        For inventory As Double = 0 To add_all
            lstShip.Items.Add(lstInventory.Items(inventory))
        Next
        lstInventory.Items.Clear()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'This button adds only the selected machine to the shipping list box and if nothing is selected it shows an error message.
        lstInventory.Sorted = True
        lstShip.Sorted = True

        If lstInventory.SelectedIndex = -1 Then
            MessageBox.Show("You must select an equipment item to add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lstShip.Items.Add(lstInventory.SelectedItem)
            lstInventory.Items.Remove(lstInventory.SelectedItem)
        End If

    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'This button removes only the selected item and shows a error message if nothing is selected.
        lstInventory.Sorted = True
        lstShip.Sorted = True

        If lstShip.SelectedIndex = -1 Then
            MessageBox.Show("You must select an equipment item to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lstInventory.Items.Add(lstShip.SelectedItem)
            lstShip.Items.Remove(lstShip.SelectedItem)
        End If
    End Sub
    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        'This button removes all equipment inventory from the shipping list box.
        Dim remove_all As Double = lstShip.Items.Count - 1
        For inventory As Double = 0 To remove_all
            lstInventory.Items.Add(lstShip.Items(inventory))
        Next
        lstShip.Items.Clear()
    End Sub


    Private Sub btnCalculateShippingCharge_Click(sender As Object, e As EventArgs) Handles btnCalculateShippingCharge.Click
        'Displays where the equipment is being shipped from and to and calculates the cost for the user.
        Dim machine As Double

        lstResults.Items.Add("Newlite Construction Company")
        lstResults.Items.Add(" ")
        lstResults.Items.Add("Freight Company:   " & lstFreightCompany.SelectedItem)
        lstResults.Items.Add("Ship from:         " & cmbShipFrom.Text)
        lstResults.Items.Add("Ship to:           " & cmbShipTo.Text)
        lstResults.Items.Add(" ")

        Dim format_string As String = "{0, -20}  {1, 20}"
        lstResults.Items.Add(String.Format(format_string, "Equipment", "Shipping Cost"))
        lstResults.Items.Add(String.Format(format_string, "-------------------", "--------------------"))





        lstResults.Items.Add(String.Format(format_string, "-------------------", "--------------------"))
    End Sub
End Class
