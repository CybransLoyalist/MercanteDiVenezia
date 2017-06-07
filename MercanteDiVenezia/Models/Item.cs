using System.ComponentModel.DataAnnotations;

namespace MercanteDiVenezia.Models
{
    public class Item : Model
    {
        private string _name;

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }
}