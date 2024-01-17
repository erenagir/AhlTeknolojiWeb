Imports AhlTeknoloji.Application
Imports Microsoft.AspNetCore.Mvc

<ApiController>
<Route("[controller]/[action]")>
Public Class PopupController
    Inherits Controller

    Private ReadOnly _service As PopupManager

    Public Sub New(service As IPopupService)
        _service = service
    End Sub


    <HttpGet>
    Public Async Function GetAll() As Task(Of IActionResult)
        Dim values = Await _service.GetAllAsync()
        Return Ok(values)
    End Function

    <HttpGet>
    Public Async Function GetOne(id As Int64) As Task(Of IActionResult)
        Dim values = Await _service.GetAsync(id)
        Return Ok(values)
    End Function
    <HttpPost>
    Public Async Function Add(data As PopupRequest) As Task(Of IActionResult)
        Dim values = Await _service.AddAsync(data)
        Return Ok(values)
    End Function
    <HttpPut>
    Public Async Function Update(data As PopupRequest) As Task(Of IActionResult)
        Dim values = Await _service.UpdateAsync(data)
        Return Ok(values)
    End Function
    <HttpDelete>
    Public Async Function Delete(item As PopupRequest) As Task(Of IActionResult)
        Dim values = Await _service.DeleteAsync(item)
        Return Ok(values)
    End Function
End Class
