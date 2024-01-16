Imports System
Imports System.Collections.Generic
Imports AhlTenoloji.Domain
Imports Microsoft.EntityFrameworkCore

Namespace Models
    Partial Public Class AhlContext
        Inherits DbContext

        Public Sub New()
        End Sub

        Public Sub New(options As DbContextOptions(Of AhlContext))
            MyBase.New(options)
        End Sub

        Public Overridable Property Images As DbSet(Of Images)

        Public Overridable Property Notifications As DbSet(Of Notification)

        Public Overridable Property Pages As DbSet(Of Page)

        Public Overridable Property PageRoles As DbSet(Of PageRole)

        Public Overridable Property Popups As DbSet(Of Popup)

        Public Overridable Property Roles As DbSet(Of Role)

        Public Overridable Property Sliders As DbSet(Of Slider)

        Public Overridable Property Socials As DbSet(Of Social)

        Public Overridable Property Users As DbSet(Of User)

        Public Overridable Property UserRoles As DbSet(Of UserRole)

        Public Overridable Property WebSiteInfos As DbSet(Of WebSiteInfo)

        Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
            'TODO /!\ To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-R04PVQ3\SQLEXPRESS; Initial Catalog= AhlTeknolojiDB; Integrated Security=True; TrustServerCertificate = true; ")
        End Sub

        Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)
            modelBuilder.Entity(Of Images)(
                Sub(entity)
                    entity.Property(Function(e) e.CreatedDate).HasColumnType("date")
                    entity.Property(Function(e) e.UpdatedDate).HasColumnType("date")
                    entity.Property(Function(e) e.Url).IsRequired()

                    entity.HasOne(Function(d) d.Notification).WithMany(Function(p) p.Images).
                        HasForeignKey(Function(d) d.NotificationId).
                        OnDelete(DeleteBehavior.ClientSetNull).
                        HasConstraintName("FK_Images_Notification")
                End Sub)

            modelBuilder.Entity(Of Notification)(
                Sub(entity)
                    entity.ToTable("Notification")

                    entity.Property(Function(e) e.CreatedDate).HasColumnType("date")
                    entity.Property(Function(e) e.IsActive).
                        IsRequired().
                        HasDefaultValueSql("((1))")
                    entity.Property(Function(e) e.ReleaseDate).HasColumnType("date")
                    entity.Property(Function(e) e.ShortText).
                        IsRequired().
                        HasMaxLength(150)
                    entity.Property(Function(e) e.Text).IsRequired()
                    entity.Property(Function(e) e.Title).
                        IsRequired().
                        HasMaxLength(50)
                    entity.Property(Function(e) e.UpdatedDate).HasColumnType("date")
                End Sub)

            modelBuilder.Entity(Of Page)(
                Sub(entity)
                    entity.ToTable("Page")

                    entity.Property(Function(e) e.CreatedDate).HasColumnType("date")
                    entity.Property(Function(e) e.Name).
                        IsRequired().
                        HasMaxLength(50)
                    entity.Property(Function(e) e.UpdatedDate).HasColumnType("date")
                    entity.Property(Function(e) e.Url).IsRequired()

                    entity.HasOne(Function(d) d.UpperPage).WithMany(Function(p) p.LowerPage).
                        HasForeignKey(Function(d) d.UpperPageId).
                        OnDelete(DeleteBehavior.ClientSetNull).
                        HasConstraintName("FK_Page_Page")
                End Sub)

            modelBuilder.Entity(Of PageRole)(
                Sub(entity)
                    entity.ToTable("PageRole")

                    entity.Property(Function(e) e.CreatedDate).HasColumnType("date")
                    entity.Property(Function(e) e.UpdatedDate).HasColumnType("date")

                    entity.HasOne(Function(d) d.Page).WithMany(Function(p) p.PageRoles).
                        HasForeignKey(Function(d) d.PageId).
                        OnDelete(DeleteBehavior.ClientSetNull).
                        HasConstraintName("FK_PageRole_Page")

                    entity.HasOne(Function(d) d.Role).WithMany(Function(p) p.PageRoles).
                        HasForeignKey(Function(d) d.RoleId).
                        OnDelete(DeleteBehavior.ClientSetNull).
                        HasConstraintName("FK_PageRole_Role")
                End Sub)

            modelBuilder.Entity(Of Popup)(
                Sub(entity)
                    entity.ToTable("Popup")

                    entity.Property(Function(e) e.CreatedDate).HasColumnType("date")
                    entity.Property(Function(e) e.Image).IsRequired()
                    entity.Property(Function(e) e.IsActive).
                        IsRequired().
                        HasDefaultValueSql("((1))")
                    entity.Property(Function(e) e.Text).
                        IsRequired().
                        HasMaxLength(100)
                    entity.Property(Function(e) e.UpdatedDate).HasColumnType("date")
                    entity.Property(Function(e) e.Url).IsRequired()
                End Sub)

            modelBuilder.Entity(Of Role)(
                Sub(entity)
                    entity.ToTable("Role")

                    entity.Property(Function(e) e.CreatedDate).HasColumnType("date")
                    entity.Property(Function(e) e.Name).
                        IsRequired().
                        HasMaxLength(50)
                    entity.Property(Function(e) e.UpdatedDate).HasColumnType("date")
                End Sub)

            modelBuilder.Entity(Of Slider)(
                Sub(entity)
                    entity.ToTable("Slider")

                    entity.Property(Function(e) e.CreatedDate).HasColumnType("date")
                    entity.Property(Function(e) e.Image).IsRequired()
                    entity.Property(Function(e) e.IsActive).
                        IsRequired().
                        HasDefaultValueSql("((1))")
                    entity.Property(Function(e) e.Text).
                        IsRequired().
                        HasMaxLength(100)
                    entity.Property(Function(e) e.UpdatedDate).HasColumnType("date")
                End Sub)

            modelBuilder.Entity(Of Social)(
                Sub(entity)
                    entity.ToTable("Social")

                    entity.Property(Function(e) e.CreatedDate).HasColumnType("date")
                    entity.Property(Function(e) e.Image).IsRequired()
                    entity.Property(Function(e) e.Name).
                        IsRequired().
                        HasMaxLength(50)
                    entity.Property(Function(e) e.UpdatedDate).HasColumnType("date")
                    entity.Property(Function(e) e.Url).IsRequired()
                End Sub)

            modelBuilder.Entity(Of User)(
                Sub(entity)
                    entity.ToTable("User")

                    entity.Property(Function(e) e.CreatedDate).HasColumnType("date")
                    entity.Property(Function(e) e.Mail).
                        IsRequired().
                        HasMaxLength(100)
                    entity.Property(Function(e) e.Name).
                        IsRequired().
                        HasMaxLength(50)
                    entity.Property(Function(e) e.Password).IsRequired()
                    entity.Property(Function(e) e.Surname).
                        IsRequired().
                        HasMaxLength(50)
                    entity.Property(Function(e) e.UpdatedDate).HasColumnType("date")
                End Sub)

            modelBuilder.Entity(Of UserRole)(
                Sub(entity)
                    entity.ToTable("UserRole")

                    entity.Property(Function(e) e.CreatedDate).HasColumnType("date")
                    entity.Property(Function(e) e.UpdatedDate).HasColumnType("date")

                    entity.HasOne(Function(d) d.Role).WithMany(Function(p) p.UserRoles).
                        HasForeignKey(Function(d) d.RoleId).
                        OnDelete(DeleteBehavior.ClientSetNull).
                        HasConstraintName("FK_UserRole_Role")

                    entity.HasOne(Function(d) d.User).WithMany(Function(p) p.UserRoles).
                        HasForeignKey(Function(d) d.UserId).
                        OnDelete(DeleteBehavior.ClientSetNull).
                        HasConstraintName("FK_UserRole_User")
                End Sub)

            modelBuilder.Entity(Of WebSiteInfo)(
                Sub(entity)
                    entity.ToTable("WebSiteInfo")

                    entity.Property(Function(e) e.Address).
                        IsRequired().
                        HasMaxLength(150)
                    entity.Property(Function(e) e.CreatedDate).HasColumnType("date")
                    entity.Property(Function(e) e.Description).IsRequired()
                    entity.Property(Function(e) e.Keyword).IsRequired()
                    entity.Property(Function(e) e.Mail).
                        IsRequired().
                        HasMaxLength(100)
                    entity.Property(Function(e) e.PhoneNumber).
                        IsRequired().
                        HasMaxLength(10)
                    entity.Property(Function(e) e.UpdatedDate).HasColumnType("date")
                End Sub)

            OnModelCreatingPartial(modelBuilder)
        End Sub

        Partial Private Sub OnModelCreatingPartial(modelBuilder As ModelBuilder)
        End Sub
    End Class
End Namespace