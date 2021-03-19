using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class SweetShop
    {
        private PackageBuilder _packageBuilder;
        public SweetShop(PackageBuilder packageBuilder)
        {
            _packageBuilder = packageBuilder;
        }
        public void CreatePackage()
        {
            _packageBuilder.SetSweets();
            _packageBuilder.SetSavouries();
        }
        public Package GetPackage()
        {
            return _packageBuilder.GetPackage();
        }
    }
}
