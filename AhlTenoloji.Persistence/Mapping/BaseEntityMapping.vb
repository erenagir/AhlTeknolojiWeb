Imports AhlTenoloji.Domain
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata.Builders
Public MustInherit Class BaseEntityMapping(Of T As BaseEntity)
    Implements IEntityTypeConfiguration(Of T)
    Public MustOverride Sub ConfigureDerivedEntity(builder As EntityTypeBuilder(Of T))



    Public Sub Configure(builder As EntityTypeBuilder(Of T)) Implements IEntityTypeConfiguration(Of T).Configure

        builder.HasKey(Function(e) e.Id)
        builder.Property(Function(e) e.Id).
            HasColumnName("ID")

        builder.Property(Function(x) x.CreatedBy).
            HasColumnName("CREATE_BY").
            HasColumnOrder(36)

        builder.Property(Function(x) x.CreatedDate).
            HasColumnName("CREATE_DATE").
            HasColumnOrder(37)
        builder.Property(Function(x) x.UpdateddDate).
            HasColumnName("UPDATED_DATE").
            HasColumnOrder(38)
        builder.Property(Function(x) x.UpdatedBy).
            HasColumnName("UPDATED_BY").
            HasColumnOrder(39)


        builder.Property(Function(x) x.IsDeleted).
        HasColumnName("IS_DELETED").
        HasColumnOrder(40).
        HasDefaultValueSql("0")

        ConfigureDerivedEntity(builder)
    End Sub
End Class
