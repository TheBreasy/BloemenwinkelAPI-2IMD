using System.Collections.Generic;

namespace BloemenwinkelAPI.API.Models.Domain
{
    public class Boeket : BaseDatabaseClass
    {
        [Required]
        public int Id{ get; set;}
    }
}