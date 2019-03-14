using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispetcherZadach
{
    class MyPlugin : IAddition
    {
        public List<string> OutputParams { get; set; }
        public string GeneralInfo { get; set; }
        public string AuthorInfo { get; set; } = "Made by Nikd";
        public int TimeToUpdateData { get; set; }

        public void Do()
        {

        }
    }
}
