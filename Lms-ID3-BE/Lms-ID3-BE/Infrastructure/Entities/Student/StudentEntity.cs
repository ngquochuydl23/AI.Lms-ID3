using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Lms_ID3_BE.Infrastructure.Entities.Student
{
  public class StudentEntity : Entity
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Id { get; set; }

    [NotNull]
    [MaxLength(StudentConstants.StudentNameMaxLength)]
    public string StudentName { get; set; }

    public DateTime StartStudyingAt {  get; set; }

    public DateTime EndStudyingAt { get; set; }

    [NotNull]
    public string ClassId { get; set; }
  }
}
