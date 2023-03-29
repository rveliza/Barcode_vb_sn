Public Class Form1
    Private Sub Prdocut_ListBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Prdocut_ListBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Prdocut_ListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Barcode_ds)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Barcode_ds.Prdocut_List' table. You can move, or remove it, as needed.
        Me.Prdocut_ListTableAdapter.Fill(Me.Barcode_ds.Prdocut_List)

    End Sub
End Class
