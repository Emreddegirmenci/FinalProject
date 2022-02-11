using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; } // Get(tek kullanılırsa) => Sadece okunabilir
        string Message { get; }

    }
}
