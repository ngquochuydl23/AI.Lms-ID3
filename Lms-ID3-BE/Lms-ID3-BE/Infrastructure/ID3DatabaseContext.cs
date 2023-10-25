using Lms_ID3_BE.Infrastructure.Entities.Course;
using Lms_ID3_BE.Infrastructure.Entities.Student;
using Lms_ID3_BE.Infrastructure.Entities.Subject;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Lms_ID3_BE.Infrastructure
{
  public class ID3DatabaseContext : DbContext
  {
    public ID3DatabaseContext(DbContextOptions<ID3DatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<CourseEntity>(entity =>
      {
        entity.ToTable("Course");
        entity.HasKey(x => x.Id);
      });

      modelBuilder.Entity<StudentEntity>(entity =>
      {
        entity.ToTable("Student");
        entity.HasKey(x => x.Id);
      });

      modelBuilder.Entity<SubjectEntity>(entity =>
      {
        entity.ToTable("Subject");
        entity.HasKey(x => x.Id);

        entity
          .HasOne(x => x)
          .WithMany(playlist => playlist.PreModules)
          .HasForeignKey(x => x.Id);
      });

      //modelBuilder.Entity<PlaylistSongEntity>(entity =>
      //{
      //  entity.ToTable("PlaylistSong");
      //  entity.HasKey(x => x.Id);
      //  entity
      //    .HasOne(x => x.Playlist)
      //    .WithMany(playlist => playlist.PlaylistSongs)
      //    .HasForeignKey(x => x.PlaylistId);
      //});

      //modelBuilder.Entity<CollaboratorEntity>(entity =>
      //{
      //  entity.ToTable("Collaborator");
      //  entity.HasKey(x => x.Id);
      //  entity
      //    .HasOne(x => x.Playlist)
      //    .WithMany(playlist => playlist.Collaborators)
      //    .HasForeignKey(x => x.PlaylistId);
      //});
    }
  }
}
