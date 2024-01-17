Public Class Role
    Inherits BaseEntity
    Public Property Name As String
    Public Property UserRoles As ICollection(Of UserRole)
    Public Property PageRoles As ICollection(Of PageRole)


End Class
