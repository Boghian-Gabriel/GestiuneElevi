Public Class Elevi

    'Automatic. Auto-implemented properties use a shorter syntax form. 
    'With them, we Do Not specify the Get Or Set methods. 
    'We just the Property keyword And the declaration statement.

    'for example get and set without auto-implement
    Private _ex As Integer
    Public Property idElevi As Integer
    Public Property Nume As String
    Public Property Prenume As String
    Public Property Email As String
    Public Property Adresa As String

    'olso
    'https://www.dotnetperls.com/property-vbnet

    'exemplu de o proprietate get si set fara a utiliza variatna de mai sus cu auto-implementare
    ' ce e mai jos , e doar un exemplu cum scrii get si set manual, mai sus e varianta simplificata
    Public Property EX As Integer
        Set(value As Integer)
            _ex = value
        End Set
        Get
            Return _ex
        End Get
    End Property


End Class
