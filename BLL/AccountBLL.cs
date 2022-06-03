using CuaHangDoChoiAPI.DAL;
using CuaHangDoChoiAPI.Models;

namespace CuaHangDoChoiAPI.BLL
{
    public class AccountBLL
    {
        private AccountDAL dal = new AccountDAL();

        public int Register(string username, string password)
        {
            return dal.Register(username, password);
        }

        public Account Login(string username, string password)
        {
            return dal.Login(username, password);
        }
    }
}