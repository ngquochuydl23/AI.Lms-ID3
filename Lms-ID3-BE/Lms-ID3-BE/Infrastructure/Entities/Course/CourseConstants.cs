using System.Diagnostics.CodeAnalysis;

namespace Lms_ID3_BE.Infrastructure.Entities.Course
{
  public class CourseConstants: Entity
  {
    [NotNull]
    public string CourseName {  get; set; }

    public long StudentCount { get; set; } = 0;
  }
}
