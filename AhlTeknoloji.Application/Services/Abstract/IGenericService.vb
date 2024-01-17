﻿Imports System.Linq.Expressions

Public Interface IGenericService(Of TRequest, TResponse)
    Function GetAsync(ByVal Id As Int64,
                          ParamArray IncludeList As String()) As Task(Of Result(Of TResponse))
    'Function GetAllAsync(Optional IncludeList As String() = Nothing) As Task(Of Result(Of IEnumerable(Of TResponse)))
    Function GetAllAsync(ByVal Optional Filter As Expression(Of Func(Of TRequest, Boolean)) = Nothing, Optional IncludeList As String() = Nothing) As Task(Of Result(Of IEnumerable(Of TResponse)))
    Function AddAsync(ByVal p As TRequest) As Task(Of Result(Of Nullable))
    Function UpdateAsync(ByVal p As TRequest) As Task(Of Result(Of Nullable))
    Function DeleteAsync(ByVal p As TRequest) As Task(Of Result(Of Nullable))
End Interface