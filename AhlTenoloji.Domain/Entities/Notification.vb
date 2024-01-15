Public Class Notification
    Inherits BaseEntity
    Public Property Title As String
    Public Property ShortText As String
    Public Property Text As String
    Public Property ReleaseDate As DateOnly
    Public Property IsActive As Boolean
    Public Property IsImportant As Boolean

    Public Property Images As ICollection(Of Image)


End Class
