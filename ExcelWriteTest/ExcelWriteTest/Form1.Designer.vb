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
        Me.btnExport = New System.Windows.Forms.Button()
        Me.dgvIssuing = New System.Windows.Forms.DataGridView()
        CType(Me.dgvIssuing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(1078, 608)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 0
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'dgvIssuing
        '
        Me.dgvIssuing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIssuing.Location = New System.Drawing.Point(12, 12)
        Me.dgvIssuing.Name = "dgvIssuing"
        Me.dgvIssuing.RowHeadersWidth = 51
        Me.dgvIssuing.RowTemplate.Height = 24
        Me.dgvIssuing.Size = New System.Drawing.Size(1166, 590)
        Me.dgvIssuing.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 643)
        Me.Controls.Add(Me.dgvIssuing)
        Me.Controls.Add(Me.btnExport)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvIssuing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExport As Button
    Friend WithEvents dgvIssuing As DataGridView
End Class
