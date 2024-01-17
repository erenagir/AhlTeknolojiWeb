Imports System.Linq.Expressions
Imports AhlTeknoloji.Domain
Imports AutoMapper

Public Class PopupManager
    Implements IPopupService

    Private ReadOnly _uow As IUnitOfWork
    Private ReadOnly _mapper As IMapper

    Public Sub New(uow As IUnitOfWork, mapper As IMapper)
        _uow = uow
        _mapper = mapper
    End Sub

    Public Async Function GetAsync(Id As Int64, ParamArray IncludeList() As String) As Task(Of Result(Of PopupResponse)) Implements IGenericService(Of PopupRequest, PopupResponse).GetAsync
        Dim result = New Result(Of PopupResponse)



        Dim data = Await _uow.GetRepository(Of Popup).GetAsync(Function(x) x.Id = Id)
        Dim mapData = _mapper.Map(Of PopupResponse)(data)
        result.Data = mapData
        Return result
    End Function

    Public Async Function GetAllAsync(Optional Filter As Expression(Of Func(Of PopupRequest, Boolean)) = Nothing, Optional IncludeList() As String = Nothing) As Task(Of Result(Of IEnumerable(Of PopupResponse))) Implements IGenericService(Of PopupRequest, PopupResponse).GetAllAsync

        Dim result = New Result(Of IEnumerable(Of PopupResponse))

        Dim data = Await _uow.GetRepository(Of Popup).GetAllAsync()
        Dim mapData = _mapper.Map(Of List(Of PopupResponse))(data)
        result.Data = mapData
        Return result




    End Function

    Public Async Function AddAsync(p As PopupRequest) As Task(Of Result(Of Nullable)) Implements IGenericService(Of PopupRequest, PopupResponse).AddAsync
        Dim result = New Result(Of Nullable)
        Dim entity = _mapper.Map(Of Popup)(p)
        _uow.GetRepository(Of Popup).Add(entity)
        Await _uow.CommitAsync()
        Return result
    End Function

    Public Async Function UpdateAsync(p As PopupRequest) As Task(Of Result(Of Nullable)) Implements IGenericService(Of PopupRequest, PopupResponse).UpdateAsync
        Dim result = New Result(Of Nullable)
        Dim entity = _mapper.Map(Of Popup)(p)
        _uow.GetRepository(Of Popup).Update(entity)
        Await _uow.CommitAsync()
        Return Result
    End Function


    Public Async Function DeleteAsync(p As PopupRequest) As Task(Of Result(Of Nullable)) Implements IGenericService(Of PopupRequest, PopupResponse).DeleteAsync
        Dim result = New Result(Of Nullable)
        Dim exists = Await _uow.GetRepository(Of Popup).AnyAsync(Function(x) x.Id = p.Id)
        If Not exists Then
            Throw New Exception("popup bulunamadı")
        End If
        Dim e = _mapper.Map(Of Popup)(p)
        'Dim e = New Popup With {.Id = p.Id}
        'Dim entity = Await _uow.GetRepository(Of Popup).GetAsync(Function(x) x.Id = p)
        _uow.GetRepository(Of Popup).Delete(e)
        Await _uow.CommitAsync()
        Return result
    End Function
End Class
