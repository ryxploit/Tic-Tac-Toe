Public Class Form1

    Dim turno As Integer

    Private Sub ganar()
        Dim i As Integer

        Try
            'X
            If i = 1 Then

            ElseIf Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
                MsgBox("El jugador X ha ganado")
                Label3.Text += 1
                Call desabilitarbtn()

            ElseIf Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
                MsgBox("El jugador X ha ganado")
                Label3.Text += 1
                Call desabilitarbtn()


            ElseIf Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
                MsgBox("El jugador X ha ganado")
                Label3.Text += 1
                Call desabilitarbtn()

            ElseIf Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
                MsgBox("El jugador X ha ganado")
                Label3.Text += 1
                Call desabilitarbtn()

            ElseIf Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
                MsgBox("El jugador X ha ganado")
                Label3.Text += 1
                Call desabilitarbtn()

            ElseIf Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
                MsgBox("El jugador X ha ganado")
                Label3.Text += 1
                Call desabilitarbtn()

            ElseIf Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
                MsgBox("El jugador X ha ganado")
                Label3.Text += 1
                Call desabilitarbtn()

            ElseIf Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
                MsgBox("El jugador X ha ganado")
                Label3.Text += 1
                Call desabilitarbtn()

                'O

            ElseIf Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
                MsgBox("El jugador O ha ganado")
                Label4.Text += 1
                Call desabilitarbtn()

            ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
                MsgBox("El jugador O ha ganado")
                Label4.Text += 1
                Call desabilitarbtn()

            ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
                MsgBox("El jugador O ha ganado")
                Label4.Text += 1
                Call desabilitarbtn()

            ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
                MsgBox("El jugador O ha ganado")
                Label4.Text += 1
                Call desabilitarbtn()

            ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
                MsgBox("El jugador O ha ganado")
                Label4.Text += 1
                Call desabilitarbtn()

            ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
                MsgBox("El jugador O ha ganado")
                Label4.Text += 1
                Call desabilitarbtn()

            ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
                MsgBox("El jugador O ha ganado")
                Label4.Text += 1
                Call desabilitarbtn()

            ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
                MsgBox("El jugador O ha ganado")
                Label4.Text += 1
                Call desabilitarbtn()



            End If

        Catch ex As Exception
            MsgBox("fallo metodo ganar")
        End Try


    End Sub

    Private Sub desabilitarbtn()
        Button1.Enabled = (False)
        Button2.Enabled = (False)
        Button3.Enabled = (False)
        Button4.Enabled = (False)
        Button5.Enabled = (False)
        Button6.Enabled = (False)
        Button7.Enabled = (False)
        Button8.Enabled = (False)
        Button9.Enabled = (False)

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If turno = 1 Then
            Button1.Text = "O"
            Label7.Text = "X"
        Else
            Button1.Text = "X"
            Label7.Text = "O"
        End If

        turno += 1
        If turno > 2 Then
            turno = 1
        End If
        Call ganar()
        Button1.Enabled = (False)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If turno = 1 Then
            Button2.Text = "O"
            Label7.Text = "X"
        Else
            Button2.Text = "X"
            Label7.Text = "O"
        End If

        turno += 1
        If turno > 2 Then
            turno = 1
        End If
        Call ganar()
        Button2.Enabled = (False)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If turno = 1 Then
            Button3.Text = "O"
            Label7.Text = "X"
        Else
            Button3.Text = "X"
            Label7.Text = "O"
        End If

        turno += 1
        If turno > 2 Then
            turno = 1
        End If
        Call ganar()
        Button3.Enabled = (False)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If turno = 1 Then
            Button4.Text = "O"
            Label7.Text = "X"
        Else
            Button4.Text = "X"
            Label7.Text = "O"
        End If

        turno += 1
        If turno > 2 Then
            turno = 1
        End If
        Call ganar()
        Button4.Enabled = (False)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If turno = 1 Then
            Button5.Text = "O"
            Label7.Text = "X"
        Else
            Button5.Text = "X"
            Label7.Text = "O"
        End If

        turno += 1
        If turno > 2 Then
            turno = 1
        End If
        Call ganar()
        Button5.Enabled = (False)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If turno = 1 Then
            Button6.Text = "O"
            Label7.Text = "X"
        Else
            Button6.Text = "X"
            Label7.Text = "O"
        End If

        turno += 1
        If turno > 2 Then
            turno = 1
        End If
        Call ganar()
        Button6.Enabled = (False)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If turno = 1 Then
            Button7.Text = "O"
            Label7.Text = "X"
        Else
            Button7.Text = "X"
            Label7.Text = "O"
        End If

        turno += 1
        If turno > 2 Then
            turno = 1
        End If
        Call ganar()
        Button7.Enabled = (False)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If turno = 1 Then
            Button8.Text = "O"
            Label7.Text = "X"
        Else
            Button8.Text = "X"
            Label7.Text = "O"
        End If

        turno += 1
        If turno > 2 Then
            turno = 1
        End If
        Call ganar()
        Button8.Enabled = (False)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If turno = 1 Then
            Button9.Text = "O"
            Label7.Text = "X"
        Else
            Button9.Text = "X"
            Label7.Text = "O"
        End If

        turno += 1
        If turno > 2 Then
            turno = 1
        End If
        Call ganar()
        Button9.Enabled = (False)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button1.Text = ""
        Button1.Enabled = (True)

        Button2.Text = ""
        Button2.Enabled = (True)

        Button3.Text = ""
        Button3.Enabled = (True)

        Button4.Text = ""
        Button4.Enabled = (True)

        Button5.Text = ""
        Button5.Enabled = (True)

        Button6.Text = ""
        Button6.Enabled = (True)

        Button7.Text = ""
        Button7.Enabled = (True)

        Button8.Text = ""
        Button8.Enabled = (True)

        Button9.Text = ""
        Button9.Enabled = (True)

        Label7.Text = ""
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MsgBox("Hecho por juan carlos leon salcido")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
