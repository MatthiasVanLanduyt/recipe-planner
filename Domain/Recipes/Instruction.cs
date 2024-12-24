using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Recipes
{
    public class Instruction
    {
        public required string InstructionText { get; set; }
        public int Order { get; set; }
    }
}
