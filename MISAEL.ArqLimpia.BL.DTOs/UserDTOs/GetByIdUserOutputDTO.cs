using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISAEL.ArqLimpia.BL.DTOs.UserDTOs
{
    public class GetByIdUserOutputDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
