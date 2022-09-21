using System.ComponentModel.DataAnnotations;

/// <summary>
/// Issues:
/// 1. Authentication
/// 2. C#, ENum, for example Item200
/// </summary>
namespace PromoStandards.REST.Core.Inventory
{
    public class GetFilterValuesRequest
    {
        public wsVersion wsVersion { get; set; }

        /// <summary>
        ///  The customer Id or any other agreed upon Id.
        /// </summary>        
        [MaxLength(64), MinLength(1)]
        public string id { get; set; }

        [Required]
        [MaxLength(64), MinLength(1)]
        public string password { get; set; }


        [MaxLength(64), MinLength(1)]
        public string productId { get; set; }
    }
}
