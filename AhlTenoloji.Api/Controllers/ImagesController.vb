Imports System.Data.Entity.ModelConfiguration
Imports AhlTenoloji.Application
Imports AutoMapper
Imports Microsoft.AspNetCore.Mvc
Imports Microsoft.AspNetCore.Routing
Imports WPF.Business
Imports WPF.Entity

<ApiController>
<Route("[controller]/[action]")>
Public Class ImagesController
    Inherits Controller

    Private ReadOnly _service As IImagesService

    Public Sub New(service As IImagesService)
        _service = service
    End Sub


    <HttpGet>
    Public Async Function GetAll() As Task(Of IActionResult)
        Dim deneme = Await _service.GetAllAsync()
        Return deneme
    End Function


End Class
