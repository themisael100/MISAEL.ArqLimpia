using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MISAEL.ArqLimpia.BL.Interfaces;
using MISAEL.ArqLimpia.EN;
using MISAEL.ArqLimpia.EN.Interfaces;
using MISAEL.ArqLimpia.BL.DTOs.UserDTOs;


namespace MISAEL.ArqLimpia.BL
{
    public class UserBL : IUserBL
    {

        readonly IUser userDAL;
        readonly IUnitOfWork unitWork;

        public UserBL(IUser pUserDAL, IUnitOfWork pUnitWork)
        {
            userDAL = pUserDAL;
            unitWork = pUnitWork;
        }


        //METODO CREAR
        public async Task<CreateUserOutputDTO> Create(CreateUserInputDTO pUser)
        {
            User user = new User
            {
                Email = pUser.Email,
                Password = pUser.Password,
                Name = pUser.Name

            };
            userDAL.Create(user);
            await unitWork.SaveChangesAsync();
            CreateUserOutputDTO userOutput = new CreateUserOutputDTO
            {
                Id = user.Id,
                Email = user.Email,
                Name = user.Name,
            };
            return userOutput;
        }


        //METODO ELIMINAR

        public async Task<int> Delete(DeleteUserDTO pUser)
        {
            userDAL.Delete(new User { Id = pUser.Id });
            return await unitWork.SaveChangesAsync();

        }


        //METODO GETBYID

        public async Task<GetByIdUserOutputDTO> GetById(GetByIdUserInputDTO pUser)
        {
            User user = await userDAL.GetById(new User { Id = pUser.Id });
            return new GetByIdUserOutputDTO
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email
            };
        }


        //METODO BUSCAR
        public async Task<List<SearchUserOutputDTO>> Search(SearchUserInputDTO pUser)
        {
            List<User> users = await userDAL.Search(new User { Email = pUser.Email, Name = pUser.Name });
            List<SearchUserOutputDTO> list = new List<SearchUserOutputDTO>();
            users.ForEach(s => list.Add(new SearchUserOutputDTO
            {
                Id = s.Id,
                Email = s.Email,
                Name = s.Name
            }));
            return list;
        }


        //METODO ACTUALIZAR

        public async Task<int> Update(UpdateUserDTO pUser)
        {
            User user = await userDAL.GetById(new User { Id = pUser.Id });
            if (user.Id == pUser.Id)
            {
                user.Name = pUser.Name;
                userDAL.Update(user);
                return await unitWork.SaveChangesAsync();
            }
            else
                return 0;
        }
    }
}

