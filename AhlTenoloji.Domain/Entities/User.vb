Public Class User
    Inherits BaseEntity


    Public Property Name As String
    Public Property Surname As String
    Public Property Mail As String
    Public Property Password As String

    Public Property UserRoles As ICollection(Of UserRole)

End Class
