﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Microsoft.VisualStudio.Terminal
{
    [Guid("0A251003-6B81-4441-A00F-FB1FC45DB09B")]
    public interface IEmbeddedTerminalService
    {
        Task<IEmbeddedTerminal> CreateTerminalAsync(string name, string workingDirectory, IEnumerable<string> args, IEnumerable<string> environment);
    }
}
