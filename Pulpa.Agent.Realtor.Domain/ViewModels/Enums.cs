using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulpa.Agent.Realtor.Domain.ViewModels
{

    public enum PropertyType
    {
        House,
        Apartment,
        Office,
        Commercial,
        Land
    }

    public enum ListingType
    {
        Rent,
        Sale
    }

    [Flags]
    public enum Amenity
    {
        None = 0,
        Garden = 1,
        Pool = 2,
        RoofGarden = 4,
        Security = 8,
        Parking = 16
        // Add more as needed
    }

    public enum PropertyCondition
    {
        New,
        Used,
        Remodeled
    }

    public enum RentalModality
    {
        ShortTerm,
        LongTerm,
        Temporary
    }
}
