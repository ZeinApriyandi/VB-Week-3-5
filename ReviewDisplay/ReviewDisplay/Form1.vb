Public Class Form1

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "'H'ari dddd"
        TextBox3.Text = "Nim  : " & txt_nim.Text
        TextBox4.Text = "Nama : " & txt_nama.Text
        TextBox5.Text = "Hari : " & DateTimePicker1.Text

    End Sub
End Class
