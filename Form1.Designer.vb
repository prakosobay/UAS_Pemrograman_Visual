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
        DataGridView1 = New DataGridView()
        btnBrowse = New Button()
        Label1 = New Label()
        txtFileName = New TextBox()
        cmbSheet = New ComboBox()
        Label2 = New Label()
        btnSave = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1072, 450)
        DataGridView1.TabIndex = 0
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(990, 479)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 479)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 20)
        Label1.TabIndex = 2
        Label1.Text = "File Name :"
        ' 
        ' txtFileName
        ' 
        txtFileName.Location = New Point(105, 477)
        txtFileName.Name = "txtFileName"
        txtFileName.ReadOnly = True
        txtFileName.Size = New Size(864, 27)
        txtFileName.TabIndex = 3
        ' 
        ' cmbSheet
        ' 
        cmbSheet.FormattingEnabled = True
        cmbSheet.Location = New Point(105, 522)
        cmbSheet.Name = "cmbSheet"
        cmbSheet.Size = New Size(151, 28)
        cmbSheet.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 525)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 5
        Label2.Text = "Sheet :"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(990, 525)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 6
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1102, 583)
        Controls.Add(btnSave)
        Controls.Add(Label2)
        Controls.Add(cmbSheet)
        Controls.Add(txtFileName)
        Controls.Add(Label1)
        Controls.Add(btnBrowse)
        Controls.Add(DataGridView1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Input Nilai Kuis Mahasiswa"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbSheet As ComboBox
    Friend WithEvents btnSave As Button
End Class
