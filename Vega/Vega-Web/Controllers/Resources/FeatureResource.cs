using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vega_Web.Controllers.Resources
{
    public class FeatureResource
    {
         public int Id { get; set; }

        public string Name { get; set; }
    }
}