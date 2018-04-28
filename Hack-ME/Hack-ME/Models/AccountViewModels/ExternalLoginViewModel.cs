using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hack_ME.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int TeacherorStudent { get; set; }

        public string Email { get; internal set; }
    }
}
