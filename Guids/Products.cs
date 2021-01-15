using System;
using System.Collections.Generic;
using System.Text;

namespace Guids
{
    public class Products : IGuids
    {
        public Guid UUID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool NotValid { get; set; }
        public Guid Owner { get; set; }

        public Products(string name)
        {
            this.Name = name;
            Code = "00-0000000";
            Description = Name;
            NotValid = false;
            UUID = Guid.NewGuid();
            Owner = Guid.Empty;
        }

        public Products(string name, Guid owner)
        {
            this.Name = name;
            Code = "00-0000000";
            this.Owner = owner;
            Description = Name;
            NotValid = false;
            UUID = Guid.NewGuid();
        }

        public Products(string code, string name)
        {
            this.Name = name;
            this.Code = code;
            Description = Name;
            NotValid = false;
            UUID = Guid.NewGuid();
            Owner = Guid.Empty;
        }

        public Products(string code, string name, Guid owner)
        {
            this.Name = name;
            this.Code = code;
            this.Owner = owner;
            Description = Name;
            NotValid = false;
            UUID = Guid.NewGuid();
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

        public Guid FindByCode(string code, Guid owner)
        {
            throw new NotImplementedException();
        }

        public Guid FindByName(string name, Guid oner)
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
