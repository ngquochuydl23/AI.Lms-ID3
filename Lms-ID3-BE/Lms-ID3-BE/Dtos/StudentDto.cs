using Lms_ID3_BE.Infrastructure.Entities.Student;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Lms_ID3_BE.Dtos
{
  public class StudentDto
  {
    public string Id { get; set; }

    public string StudentName { get; set; }

    public DateTime StartStudyingAt { get; set; }

    public DateTime EndStudyingAt { get; set; }

    public string ClassId { get; set; }
  }
}
