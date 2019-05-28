using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class usersDTO
    {
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nameLogin { get; set; }
        public string password { get; set; }
        public string mail { get; set; }
        public string phone { get; set; }
        public static usersDTO ToDtousers(DAL.user t)
        {

            return new usersDTO()
            {
                userId = t.userId,
                firstName = t.firstName,
                lastName = t.lastName,
                nameLogin = t.nameLogin,
                password = t.password,
                mail = t.mail,
                phone=t.phone
            };
        }
        public static DAL.user ToDaluser(usersDTO t)
        {

            return new DAL.user()
            {
                userId = t.userId,
                firstName = t.firstName,
                lastName = t.lastName,
                nameLogin = t.nameLogin,
                password = t.password,
                mail = t.mail,
                phone = t.phone
            };


        }
    }
}
