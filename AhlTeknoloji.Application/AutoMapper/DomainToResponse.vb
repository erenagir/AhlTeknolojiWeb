Imports AhlTeknoloji.Domain
Imports AutoMapper

Public Class DomainToResponse
    Inherits Profile
    Public Sub New()
        CreateMap(Of Popup, PopupResponse)()
        CreateMap(Of PopupRequest, Popup)()


    End Sub
End Class
