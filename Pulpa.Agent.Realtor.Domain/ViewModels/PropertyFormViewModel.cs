namespace Pulpa.Agent.Realtor.Domain.ViewModels
{
    public class PropertyFormViewModel
    {
        public PropertyType PropertyType { get; set; }
        public ListingType ListingType { get; set; }
        public string? Neighborhood { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public int Bedrooms { get; set; }
        public int? Bathrooms { get; set; } // Optional for MVP
        public double? Area { get; set; }   // Optional for MVP (square meters)

        // Added properties
        public int Stories { get; set; }
        public int? Age { get; set; } // Age in years, optional

        public Amenity Amenities { get; set; } = Amenity.None;

        public PropertyCondition Condition { get; set; }

        public RentalModality RentalModality { get; set; }

        public bool Furnished { get; set; }

        // GPS coordinates
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
