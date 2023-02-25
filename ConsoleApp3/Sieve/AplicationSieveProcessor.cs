using ConsoleApp3.Models;
using Microsoft.Extensions.Options;
using Sieve.Models;
using Sieve.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Sieve
{
    internal class AplicationSieveProcessor : SieveProcessor
    {
        public AplicationSieveProcessor(IOptions<SieveOptions> options) : base(options)
        {
        }
        protected override SievePropertyMapper MapProperties(SievePropertyMapper mapper)
        {
            mapper.Property<Authors>(e => e.AuthorsID)
                .CanSort()
                .CanFilter();
            mapper.Property<Authors>(e => e.AuthorName)
              .CanSort()
              .CanFilter();
            return mapper;

        }
    }
}
