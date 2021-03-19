using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   public abstract class PackageBuilder
    {
        public abstract void SetSweets();
        public abstract void SetSavouries();
        public abstract Package GetPackage();
    }
}
