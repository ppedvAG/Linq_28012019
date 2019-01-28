<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonAll = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonSort = New System.Windows.Forms.Button()
        Me.ButtonSortLamb = New System.Windows.Forms.Button()
        Me.ButtonWhere = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonMosteRev = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 82)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(926, 408)
        Me.DataGridView1.TabIndex = 0
        '
        'ButtonAll
        '
        Me.ButtonAll.AutoSize = True
        Me.ButtonAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonAll.Location = New System.Drawing.Point(3, 3)
        Me.ButtonAll.Name = "ButtonAll"
        Me.ButtonAll.Size = New System.Drawing.Size(140, 35)
        Me.ButtonAll.TabIndex = 1
        Me.ButtonAll.Text = "Alle anzeigen"
        Me.ButtonAll.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonAll)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonSort)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonSortLamb)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonWhere)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonMosteRev)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(926, 82)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'ButtonSort
        '
        Me.ButtonSort.AutoSize = True
        Me.ButtonSort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonSort.Location = New System.Drawing.Point(149, 3)
        Me.ButtonSort.Name = "ButtonSort"
        Me.ButtonSort.Size = New System.Drawing.Size(131, 35)
        Me.ButtonSort.TabIndex = 2
        Me.ButtonSort.Text = "Sort (Query)"
        Me.ButtonSort.UseVisualStyleBackColor = True
        '
        'ButtonSortLamb
        '
        Me.ButtonSortLamb.AutoSize = True
        Me.ButtonSortLamb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonSortLamb.Location = New System.Drawing.Point(286, 3)
        Me.ButtonSortLamb.Name = "ButtonSortLamb"
        Me.ButtonSortLamb.Size = New System.Drawing.Size(148, 35)
        Me.ButtonSortLamb.TabIndex = 3
        Me.ButtonSortLamb.Text = "Sort (Lambda)"
        Me.ButtonSortLamb.UseVisualStyleBackColor = True
        '
        'ButtonWhere
        '
        Me.ButtonWhere.AutoSize = True
        Me.ButtonWhere.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonWhere.Location = New System.Drawing.Point(440, 3)
        Me.ButtonWhere.Name = "ButtonWhere"
        Me.ButtonWhere.Size = New System.Drawing.Size(81, 35)
        Me.ButtonWhere.TabIndex = 4
        Me.ButtonWhere.Text = "Where"
        Me.ButtonWhere.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Location = New System.Drawing.Point(527, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "OfType"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button2.Location = New System.Drawing.Point(3, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(580, 35)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Alle Filme von Regiseuren die 2 oder mehr Filme gemacht haben"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtonMosteRev
        '
        Me.ButtonMosteRev.AutoSize = True
        Me.ButtonMosteRev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonMosteRev.Location = New System.Drawing.Point(621, 3)
        Me.ButtonMosteRev.Name = "ButtonMosteRev"
        Me.ButtonMosteRev.Size = New System.Drawing.Size(148, 35)
        Me.ButtonMosteRev.TabIndex = 5
        Me.ButtonMosteRev.Text = "Most Revenue"
        Me.ButtonMosteRev.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(926, 490)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonAll As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ButtonSort As Button
    Friend WithEvents ButtonSortLamb As Button
    Friend WithEvents ButtonWhere As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ButtonMosteRev As Button
End Class
