using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.BLL
{
    public class BLL_ValidateData
    {
        private static BLL_ValidateData _Instance;
        public static BLL_ValidateData Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_ValidateData();
                return _Instance;
            }
            private set { }
        }
        private BLL_ValidateData()
        {

        }
    }
}
