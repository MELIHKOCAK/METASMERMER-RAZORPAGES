using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetasMermer.Services.Footers.Update
{
    public record UpdateFooterDto:FooterDto
    {
        public int Id { get; set; }
    }
}
