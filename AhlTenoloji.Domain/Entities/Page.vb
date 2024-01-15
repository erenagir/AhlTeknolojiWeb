Public Class Page
    Inherits BaseEntity
    Public Property UpperPageId As Long

    Public Property Url As String
    Public Property Name As String
    Public Property LowerPage As ICollection(Of Page)
    Public Property PageRoles As ICollection(Of PageRole)
    Public Property UpperPage As Page = Nothing
End Class
