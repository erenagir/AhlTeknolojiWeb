Imports System.Linq.Expressions
Imports AhlTenoloji.Domain

Public Class ImagesManager
    Implements IImagesService

    Private ReadOnly _uow As IUnitOfWork

    Public Sub New(uow As IUnitOfWork)
        _uow = uow
    End Sub

    Public Function GetAsync(Filter As Expression(Of Func(Of Images, Boolean)), ParamArray IncludeList() As String) As Task(Of Images) Implements IGenericService(Of Images).GetAsync
        Throw New NotImplementedException()
    End Function

    Public Function AddAsync(p As Images) As Task(Of Images) Implements IGenericService(Of Images).AddAsync
        Throw New NotImplementedException()
    End Function

    Public Function UpdateAsync(p As Images) As Task Implements IGenericService(Of Images).UpdateAsync
        Throw New NotImplementedException()
    End Function

    Public Function DeleteAsync(p As Images) As Task Implements IGenericService(Of Images).DeleteAsync
        Throw New NotImplementedException()
    End Function

    'Public Async Function GetAsync(Filter As Expression(Of Func(Of Images, Boolean)), ParamArray IncludeList() As String) As Task(Of Images) Implements IGenericService(Of Images).GetAsync
    '    Return Await _uow.GetRepository(Of Images).Get
    'End Function

    'Public Async Function GetAllAsync(Optional Filter As Expression(Of Func(Of Images, Boolean)) = Nothing, Optional IncludeList() As String = Nothing) As Task(Of IEnumerable(Of Images)) Implements IGenericService(Of Images).GetAllAsync
    '    Return Await _uow.ImagesRepository.GetAllAsync(Filter, IncludeList)
    'End Function

    'Public Async Function AddAsync(p As Images) As Task(Of Images) Implements IGenericService(Of Images).AddAsync
    '    Await _uow.ImagesRepository.AddAsync(p)
    '    Await _uow.SaveChangeAsync()
    '    Return p
    'End Function

    'Public Async Function UpdateAsync(p As Images) As Task Implements IGenericService(Of Images).UpdateAsync
    '    Await _uow.ImagesRepository.UpdateAsync(p)
    '    Await _uow.SaveChangeAsync()
    'End Function

    'Public Async Function DeleteAsync(p As Images) As Task Implements IGenericService(Of Images).DeleteAsync
    '    Await _uow.ImagesRepository.DeleteAsync(p)
    '    Await _uow.SaveChangeAsync()
    'End Function

    Private Async Function IGenericService_GetAllAsync(Optional Filter As Expression(Of Func(Of Images, Boolean)) = Nothing, Optional IncludeList() As String = Nothing) As Task(Of IEnumerable(Of Task)) Implements IGenericService(Of Images).GetAllAsync
        Return Await _uow.GetRepository(Of Images).GetAllAsync()
    End Function
End Class
