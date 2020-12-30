Public Class Validare

    'am incercat sa aduc toate mesajele intr-o singura clasa de unde le pot modifica o singura data
    Public Function validAdaugare()

        MessageBox.Show("Sigur doriti sa adaugati aceasta inregistrare? Verificati inca odata datele pe care le-ati introdus", "Informatii", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

    End Function

    Public Function validActualizare()

        MessageBox.Show("Te rog, selecteaza o inregistrare din tabela de mai jos dupa ce ai afisat informatiile despre elevi! Apoi puteti actualiza inregistrarea", "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Warning)

    End Function

    Public Function validStergere()

        MessageBox.Show("Te rog, selecteaza o inregistrare din tabela de mai jos dupa ce ai afisat informatiile despre elevi! Apoi puteti sterge inregistrarea", "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Warning)

    End Function

End Class
