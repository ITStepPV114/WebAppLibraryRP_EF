using System.ComponentModel.DataAnnotations;

namespace WebAppLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Style { get; set; }
        public string? Publisher { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublisheDate { get; set; }

    }
}

//назва книги;
// П.І.Б.автора;
// стиль;
// видавництво;
// рік видання.