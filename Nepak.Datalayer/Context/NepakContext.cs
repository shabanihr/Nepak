using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Nepak.Datalayer.Context
{
    public class NepakContext:DbContext
    {
        public NepakContext(DbContextOptions<NepakContext> options) : base(options)
        {

            
        }
    }
}
