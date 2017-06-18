using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [FlagsAttribute]
    public enum Transformations : int
    {
        None = 0,
        addNumber = 1,
        addSamePassword = 2,
        firstUpperCase = 4,
        makeUpper = 8,
        replaceLetter = 16,
        addSome = 32,
        bracket = 64,
        addNumberA = 128,
        addNumberB = 256,
        addNumberAB = 512,
        replaceAtIndex = 1024,
        replaceAllTheSameLetter = 2048,
        addSign = 4096
    };
}
