Public Class Form1

    Private Sub VectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectorToolStripMenuItem.Click

        DataGridView1.Rows.Clear()
    End Sub

    Private Sub DatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosToolStripMenuItem.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        RadioButton1.Checked = 0
        RadioButton2.Checked = 0
        RadioButton3.Checked = 0
        RadioButton4.Checked = 0
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click


        DataGridView1.Rows.Add(TextBox1, GroupBox1, TextBox2, TextBox3)

    End Sub
End Class
