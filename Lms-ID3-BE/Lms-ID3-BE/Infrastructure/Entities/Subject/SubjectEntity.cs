using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Lms_ID3_BE.Infrastructure.Entities.Subject
{
  public class SubjectEntity : Entity
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Id { get; set; }

    [NotNull]
    [MaxLength(SubjectConstants.SubjectNameMaxLength)]
    public string SubjectName { get; set; }

    [NotNull]
    [Range(SubjectConstants.MinCreditCount, SubjectConstants.MaxCreditCount)]
    public int TotalCreditCount { get; set; }

    [NotNull]
    [Range(SubjectConstants.MinCreditCount, SubjectConstants.MaxCreditCount)]
    public int TheoricalCreditCount { get; set; }

    [NotNull]
    [Range(SubjectConstants.MinCreditCount, SubjectConstants.MaxCreditCount)]
    public int PracticalCreditCount { get; set; }

    public bool Compulsory { get; set; } = true;

    public virtual IEnumerable<SubjectEntity> PreModules { get; set; } = new List<SubjectEntity>();

    public string FacultyName { get; set; }
  }
}
