using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Lms_ID3_BE.Infrastructure.Entities.Course
{
  public class CourseEntity
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Id { get; set; }

    [NotNull]
    public string CourseName { get; set; }

    [NotNull]
    public string ClassId { get; set; }
  }
}
