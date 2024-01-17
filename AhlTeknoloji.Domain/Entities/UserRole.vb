Public Class UserRole
    Inherits BaseEntity
    Public Property UserId As Int64
    Public Property RoleId As Int64
    Public Overridable Property User As User
    Public Overridable Property Role As Role

End Class
