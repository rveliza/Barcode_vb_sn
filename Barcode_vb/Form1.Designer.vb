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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Barcode_ds = New Barcode_vb.barcode_ds()
        Me.Prdocut_ListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Prdocut_ListTableAdapter = New Barcode_vb.barcode_dsTableAdapters.Prdocut_ListTableAdapter()
        Me.TableAdapterManager = New Barcode_vb.barcode_dsTableAdapters.TableAdapterManager()
        Me.Prdocut_ListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Prdocut_ListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Prdocut_ListDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Barcode_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Prdocut_ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Prdocut_ListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Prdocut_ListBindingNavigator.SuspendLayout()
        CType(Me.Prdocut_ListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(188, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(164, 21)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Barcode:"
        '
        'Barcode_ds
        '
        Me.Barcode_ds.DataSetName = "barcode_ds"
        Me.Barcode_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Prdocut_ListBindingSource
        '
        Me.Prdocut_ListBindingSource.DataMember = "Prdocut_List"
        Me.Prdocut_ListBindingSource.DataSource = Me.Barcode_ds
        '
        'Prdocut_ListTableAdapter
        '
        Me.Prdocut_ListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Prdocut_ListTableAdapter = Me.Prdocut_ListTableAdapter
        Me.TableAdapterManager.UpdateOrder = Barcode_vb.barcode_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Prdocut_ListBindingNavigator
        '
        Me.Prdocut_ListBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Prdocut_ListBindingNavigator.AutoSize = False
        Me.Prdocut_ListBindingNavigator.BindingSource = Me.Prdocut_ListBindingSource
        Me.Prdocut_ListBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Prdocut_ListBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Prdocut_ListBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Prdocut_ListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Prdocut_ListBindingNavigatorSaveItem})
        Me.Prdocut_ListBindingNavigator.Location = New System.Drawing.Point(0, 522)
        Me.Prdocut_ListBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Prdocut_ListBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Prdocut_ListBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Prdocut_ListBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Prdocut_ListBindingNavigator.Name = "Prdocut_ListBindingNavigator"
        Me.Prdocut_ListBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Prdocut_ListBindingNavigator.Size = New System.Drawing.Size(732, 42)
        Me.Prdocut_ListBindingNavigator.TabIndex = 2
        Me.Prdocut_ListBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 39)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 39)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Prdocut_ListBindingNavigatorSaveItem
        '
        Me.Prdocut_ListBindingNavigatorSaveItem.Image = CType(resources.GetObject("Prdocut_ListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Prdocut_ListBindingNavigatorSaveItem.Name = "Prdocut_ListBindingNavigatorSaveItem"
        Me.Prdocut_ListBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 39)
        Me.Prdocut_ListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Prdocut_ListDataGridView
        '
        Me.Prdocut_ListDataGridView.AutoGenerateColumns = False
        Me.Prdocut_ListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Prdocut_ListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Prdocut_ListDataGridView.DataSource = Me.Prdocut_ListBindingSource
        Me.Prdocut_ListDataGridView.Location = New System.Drawing.Point(69, 139)
        Me.Prdocut_ListDataGridView.Name = "Prdocut_ListDataGridView"
        Me.Prdocut_ListDataGridView.Size = New System.Drawing.Size(586, 348)
        Me.Prdocut_ListDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Product_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Product_Barcode"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Product_Barcode"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Product_Price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Product_Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(732, 564)
        Me.Controls.Add(Me.Prdocut_ListDataGridView)
        Me.Controls.Add(Me.Prdocut_ListBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barcode Reader"
        CType(Me.Barcode_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Prdocut_ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Prdocut_ListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Prdocut_ListBindingNavigator.ResumeLayout(False)
        Me.Prdocut_ListBindingNavigator.PerformLayout()
        CType(Me.Prdocut_ListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Barcode_ds As barcode_ds
    Friend WithEvents Prdocut_ListBindingSource As BindingSource
    Friend WithEvents Prdocut_ListTableAdapter As barcode_dsTableAdapters.Prdocut_ListTableAdapter
    Friend WithEvents TableAdapterManager As barcode_dsTableAdapters.TableAdapterManager
    Friend WithEvents Prdocut_ListBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Prdocut_ListBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Prdocut_ListDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
