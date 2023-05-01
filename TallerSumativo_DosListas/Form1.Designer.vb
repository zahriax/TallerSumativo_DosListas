<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDerecha = New System.Windows.Forms.Button()
        Me.btnTodo1 = New System.Windows.Forms.Button()
        Me.btnIzquierda = New System.Windows.Forms.Button()
        Me.btnTodo2 = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(94, 54)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.ReadOnly = True
        Me.tbNombre.Size = New System.Drawing.Size(158, 20)
        Me.tbNombre.TabIndex = 0
        Me.tbNombre.Text = "nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(382, 44)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(87, 28)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(58, 141)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(180, 251)
        Me.ListBox1.TabIndex = 3
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(359, 141)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(175, 251)
        Me.ListBox2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Lista 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(359, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Lista 2"
        '
        'btnDerecha
        '
        Me.btnDerecha.Location = New System.Drawing.Point(278, 171)
        Me.btnDerecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDerecha.Name = "btnDerecha"
        Me.btnDerecha.Size = New System.Drawing.Size(56, 19)
        Me.btnDerecha.TabIndex = 7
        Me.btnDerecha.Text = ">"
        Me.btnDerecha.UseVisualStyleBackColor = True
        '
        'btnTodo1
        '
        Me.btnTodo1.Location = New System.Drawing.Point(278, 224)
        Me.btnTodo1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTodo1.Name = "btnTodo1"
        Me.btnTodo1.Size = New System.Drawing.Size(56, 19)
        Me.btnTodo1.TabIndex = 8
        Me.btnTodo1.Text = ">>"
        Me.btnTodo1.UseVisualStyleBackColor = True
        '
        'btnIzquierda
        '
        Me.btnIzquierda.Location = New System.Drawing.Point(278, 272)
        Me.btnIzquierda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnIzquierda.Name = "btnIzquierda"
        Me.btnIzquierda.Size = New System.Drawing.Size(56, 19)
        Me.btnIzquierda.TabIndex = 9
        Me.btnIzquierda.Text = "<"
        Me.btnIzquierda.UseVisualStyleBackColor = True
        '
        'btnTodo2
        '
        Me.btnTodo2.Location = New System.Drawing.Point(278, 331)
        Me.btnTodo2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTodo2.Name = "btnTodo2"
        Me.btnTodo2.Size = New System.Drawing.Size(56, 19)
        Me.btnTodo2.TabIndex = 10
        Me.btnTodo2.Text = "<<"
        Me.btnTodo2.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(589, 372)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(56, 19)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 434)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnTodo2)
        Me.Controls.Add(Me.btnIzquierda)
        Me.Controls.Add(Me.btnTodo1)
        Me.Controls.Add(Me.btnDerecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbNombre)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDerecha As Button
    Friend WithEvents btnTodo1 As Button
    Friend WithEvents btnIzquierda As Button
    Friend WithEvents btnTodo2 As Button
    Friend WithEvents btnSalir As Button
End Class
