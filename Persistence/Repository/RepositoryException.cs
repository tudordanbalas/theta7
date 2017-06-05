﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    /*Class for throwing exceptions*/
    [Serializable]
    public class RepositoryException:Exception
    {
        public RepositoryException() { }

        public RepositoryException(string message)
            : base(message) { }
        
        public RepositoryException(string message,Exception inner)
            :base(message,inner)
        { }
    }
}
