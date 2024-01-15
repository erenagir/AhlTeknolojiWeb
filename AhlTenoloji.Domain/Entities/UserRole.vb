Public Class UserRole
    Inherits BaseEntity
    Public Property UserId As Long
    Public Property RoleId As Long
    Public Overridable Property User As User
    Public Overridable Property Role As Role

End Class
