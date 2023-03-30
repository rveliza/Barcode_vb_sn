Public Class Form1
    Private Sub Prdocut_ListBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Prdocut_ListBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Prdocut_ListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Barcode_ds)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Barcode_ds.Prdocut_List' table. You can move, or remove it, as needed.
        'Me.Prdocut_ListTableAdapter.Fill(Me.Barcode_ds.Prdocut_List)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Prdocut_ListTableAdapter.Fill(Me.Barcode_ds.Prdocut_List)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Prdocut_ListTableAdapter.FillBy_barcode_data(Me.Barcode_ds.Prdocut_List)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Prdocut_ListTableAdapter.FillBy_barcode_search(Me.Barcode_ds.Prdocut_List, Me.search_TextBox1.Text)
    End Sub

    Private Sub search_TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles search_TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.search_TextBox1.SelectAll()
            Button3_Click(sender, e)
        End If
    End Sub
End Class
