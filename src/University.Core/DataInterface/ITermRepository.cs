﻿using System;
using System.Collections.Generic;
using System.Text;
using University.Core.Domain;

namespace University.Core.DataInterface
{
    public interface ITermRepository
    {


        List<Term> LoadTerms();


    }
}
