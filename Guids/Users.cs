using System;
using System.Collections.Generic;
using System.Text;

namespace Guids
{
    public class Users
    {
        public Guid UUID { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Users(string login, string pass, string email)
        {
            this.Login = login;
            this.Pass = pass;
            this.Email = email;
            UUID = Guid.NewGuid();
        }

        public Users(string login, string pass, string email, string phone)
        {
            this.Login = login;
            this.Pass = pass;
            this.Email = email;
            this.Phone = phone;
            UUID = Guid.NewGuid();
        }

        public Users(string login, string pass, string email, Guid uuid)
        {
            this.Login = login;
            this.Pass = pass;
            this.Email = email;
            this.UUID = uuid;
        }

        public void Copy()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Fill()
        {
            throw new NotImplementedException();
        }

        public Users FindBylogin(string login)
        {
            throw new NotImplementedException();
        }

        public Users Find(string login, string email)
        {
            throw new NotImplementedException();
        }

        public void SetNewCode()
        {
            throw new NotImplementedException();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }
}
