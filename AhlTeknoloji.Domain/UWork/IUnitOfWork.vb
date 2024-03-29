﻿Public Interface IUnitOfWork
    Function GetRepository(Of T As BaseEntity)() As IRepository(Of T)
    Function CommitAsync() As Task(Of Boolean)
End Interface
