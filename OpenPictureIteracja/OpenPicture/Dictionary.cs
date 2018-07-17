using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPicture
{
    public partial class DictionarySave : PlotForm
    {
        internal static string LocationDic { get; set; }

        public DictionarySave(string location)
        {
            LocationDic = location;
        }
    }
}
