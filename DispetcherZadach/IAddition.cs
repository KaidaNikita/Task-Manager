﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispetcherZadach
{
    public interface IAddition
    {
        void Do();
        List<string> OutputParams { get; set; }
        string GeneralInfo { get; set; }
        string AuthorInfo { get; set; }
        int TimeToUpdateData { get; set; }//ms
    }

}
