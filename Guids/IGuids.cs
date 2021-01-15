using System;
using System.Collections.Generic;
using System.Text;

namespace Guids
{
    public interface IGuids
    {
        Guid UUID { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        bool NotValid { get; set; }

        void Write();
        void Fill();
        void Copy();
        void Delete();
        void SetNewCode();
        Guid FindByCode(string code, Guid owner);
        Guid FindByName(string name, Guid owner);

    }
}
