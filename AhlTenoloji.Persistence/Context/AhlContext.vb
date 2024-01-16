Imports Microsoft.EntityFrameworkCore

Public Class AhlContext
    Inherits DbContext
    Public Sub New(options As DbContextOptions(Of AhlContext))
        MyBase.New(options)
    End Sub

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        optionsBuilder.UseSqlServer("Server=.\SQLEXPRESS;Database=Ah;Trusted_Connection=True;TrustServerCertificate=True")
        'optionsBuilder.UseSqlServer("Data Source=DESKTOP-R04PVQ3\SQLEXPRESS; Initial Catalog=ERPDB; Integrated Security=true; TrustServerCertificate=True")
    End Sub

    'Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
    '    MyBase.OnModelCreating(modelBuilder)


    'End Sub
End Class
