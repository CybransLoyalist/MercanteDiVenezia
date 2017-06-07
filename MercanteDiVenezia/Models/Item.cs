using System.ComponentModel.DataAnnotations;

namespace MercanteDiVenezia.Models
{
    public class Item : Model
    {
        private string _name;
        private decimal _value;
        private int _quantity;


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

        [Required]
        public decimal Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        [Required]
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }
    }
}