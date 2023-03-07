using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MISAEL.ArqLimpia.BL.DTOs.UserDTOs;

namespace MISAEL.ArqLimpia.BL.Interfaces
{
    public interface IUserBL
    {
        Task<CreateUserOutputDTO> Create(CreateUserInputDTO pUser);

        Task<int> Update(UpdateUserDTO pUser);

        Task<int> Delete(DeleteUserDTO pUser);

        Task<GetByIdUserOutputDTO> GetById(GetByIdUserInputDTO pUser);

        Task<List<SearchUserOutputDTO>> Search(SearchUserInputDTO pUser);
    }
}
