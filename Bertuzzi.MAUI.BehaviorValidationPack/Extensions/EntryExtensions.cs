using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class EntryExtensions
{
    public static string ValidatedText(this Entry entry)
    {
        return entry?.Text ?? string.Empty;
    }
}
