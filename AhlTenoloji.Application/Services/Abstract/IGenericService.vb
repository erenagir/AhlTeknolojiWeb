Imports System.Linq.Expressions

Public Interface IGenericService(Of T)
    Function GetAsync(ByVal Filter As Expression(Of Func(Of T, Boolean)),
                          ParamArray IncludeList As String()) As Task(Of T)
    Function GetAllAsync(ByVal Optional Filter As Expression(Of Func(Of T, Boolean)) = Nothing, Optional IncludeList As String() = Nothing) As Task(Of IEnumerable(Of Task))
    Function AddAsync(ByVal p As T) As Task(Of T)
    Function UpdateAsync(ByVal p As T) As Task
    Function DeleteAsync(ByVal p As T) As Task
End Interface