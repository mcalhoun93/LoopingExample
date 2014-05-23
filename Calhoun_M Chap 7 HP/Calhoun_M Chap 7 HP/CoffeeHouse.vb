Public Class CoffeeHouse

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub AddCoffeeFlavorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCoffeeFlavorToolStripMenuItem.Click
        Dim itemfoundboolean As Boolean
        Dim iteminteger As Integer

        With ComboBox1
            If .Text <> "" Then
                Do Until itemfoundboolean Or iteminteger = .Items.Count
                    If .Text = .Items(iteminteger).ToString() Then
                        itemfoundboolean = True
                        Exit Do
                    Else
                        iteminteger += 1
                    End If
                Loop
                If itemfoundboolean Then
                    MessageBox.Show("duplicate item", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    .Items.Add(.Text)
                    .Text = ""
                End If
            Else
                MessageBox.Show("enter a coffee flavor to add", "missing data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            .Focus()
        End With
    End Sub

    Private Sub ClearCoffeeListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearCoffeeListToolStripMenuItem.Click
        Dim responsedialog As DialogResult
        responsedialog = MessageBox.Show("clear the coffee list?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If responsedialog = Windows.Forms.DialogResult.Yes Then
            ComboBox1.Items.Clear()
        End If
    End Sub

    Private Sub RemoveCoffeeFlavorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveCoffeeFlavorToolStripMenuItem.Click
        With ComboBox1
            If .SelectedIndex <> -1 Then
                .Items.RemoveAt(.SelectedIndex)
            Else
                MessageBox.Show("no selection made", "data entry error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End With
    End Sub

    Private Sub DisplayCoffeeCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayCoffeeCountToolStripMenuItem.Click
        Dim messagestring As String
        messagestring = "The number of coffe types is " & ComboBox1.Items.Count & "."
        MessageBox.Show(messagestring, "count", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
