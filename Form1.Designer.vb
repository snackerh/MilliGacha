<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataSet1 = New System.Data.DataSet()
        Me.SSR = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PickupSelect = New System.Windows.Forms.CheckedListBox()
        Me.onetime = New System.Windows.Forms.Button()
        Me.tentimes = New System.Windows.Forms.Button()
        Me.customtry = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Result = New System.Windows.Forms.ListBox()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.SSR})
        '
        'SSR
        '
        Me.SSR.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
        Me.SSR.MinimumCapacity = 500
        Me.SSR.TableName = "SSR"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "No"
        Me.DataColumn1.DataType = GetType(Integer)
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.ColumnName = "name"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "pickup"
        Me.DataColumn3.DataType = GetType(Boolean)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PickupSelect)
        Me.GroupBox1.Location = New System.Drawing.Point(323, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 130)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "가챠 선택"
        '
        'PickupSelect
        '
        Me.PickupSelect.FormattingEnabled = True
        Me.PickupSelect.Location = New System.Drawing.Point(6, 20)
        Me.PickupSelect.Name = "PickupSelect"
        Me.PickupSelect.Size = New System.Drawing.Size(177, 100)
        Me.PickupSelect.TabIndex = 2
        '
        'onetime
        '
        Me.onetime.Location = New System.Drawing.Point(329, 148)
        Me.onetime.Name = "onetime"
        Me.onetime.Size = New System.Drawing.Size(81, 26)
        Me.onetime.TabIndex = 2
        Me.onetime.Text = "단챠 시뮬"
        Me.onetime.UseVisualStyleBackColor = True
        '
        'tentimes
        '
        Me.tentimes.BackColor = System.Drawing.Color.Yellow
        Me.tentimes.Location = New System.Drawing.Point(416, 148)
        Me.tentimes.Name = "tentimes"
        Me.tentimes.Size = New System.Drawing.Size(90, 26)
        Me.tentimes.TabIndex = 3
        Me.tentimes.Text = "10연챠 시뮬"
        Me.tentimes.UseVisualStyleBackColor = False
        '
        'customtry
        '
        Me.customtry.Location = New System.Drawing.Point(329, 180)
        Me.customtry.Name = "customtry"
        Me.customtry.Size = New System.Drawing.Size(177, 27)
        Me.customtry.TabIndex = 4
        Me.customtry.Text = "횟수 지정"
        Me.customtry.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(324, 353)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(189, 94)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "현재 가챠 정보"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 74)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "유리코 통상," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "타마키 통상" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(~20.06.18)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(323, 213)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(189, 134)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "저격 전용"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(177, 44)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "체크항목 저격 시뮬 시작"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(6, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 25)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "컴플할때까지(천장고려)"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(6, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "컴플할때까지(천장미고려)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Result
        '
        Me.Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Result.FormattingEnabled = True
        Me.Result.ItemHeight = 12
        Me.Result.Location = New System.Drawing.Point(12, 12)
        Me.Result.Name = "Result"
        Me.Result.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Result.Size = New System.Drawing.Size(305, 434)
        Me.Result.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 459)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.customtry)
        Me.Controls.Add(Me.tentimes)
        Me.Controls.Add(Me.onetime)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "밀리가챠시뮬"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents SSR As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PickupSelect As CheckedListBox
    Friend WithEvents onetime As Button
    Friend WithEvents tentimes As Button
    Friend WithEvents customtry As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Result As ListBox
End Class
