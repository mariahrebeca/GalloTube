using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GalloTube.Models;

[Table("Video")]
public class Video
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Título")]
    [Required(ErrorMessage = "O Título é obrigatório")]
    [StringLength(100, ErrorMessage = "O Título deve possuir no máximo 100 caracteres")]
    public string Name { get; set; }

    [Display(Description = "Descrição")]
    [StringLength(8000)]
    public string Description { get; set; }

    [Display(Name = "Data de Lançamento")]
    public DateTime UploadData { get; set; }

    [Display(Name = "Duração")]
    public Int16 Duration { get; set; }


    [Display(Name = "Capa")]
    [StringLength(200)]
    public string Thumbnail { get; set; }
    
    [Display(Name = "Arquivo")]
    [StringLength(200)]
    public string VideoFile { get; set; }

    public ICollection<VideoTag> Tags { get; set; }
    

}