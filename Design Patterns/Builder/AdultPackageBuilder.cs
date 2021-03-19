using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class AdultPackageBuilder : PackageBuilder
    {
        Package package = new Package();
        public override void SetSweets()
        {
            package.Sweets = 2;
        }
        public override void SetSavouries()
        {
            package.Savouries = 2;

        }
        public override Package GetPackage()
        {
            return package;
        }
    }
}
