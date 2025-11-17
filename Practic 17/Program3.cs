using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_17._3
{
    [Flags]
    public enum FileAccess { None = 1, Read, Write, Execute }

    public struct File
    {
        public FileAccess Permissions { get; private set; }
        public File(FileAccess permissions)
        {
            Permissions = permissions;
        }

        public bool CanRead()
        {
            return (Permissions & FileAccess.Read) == FileAccess.Read;
        }

        public bool CanWrite()
        {
            return (Permissions & FileAccess.Write) == FileAccess.Write;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                var f = new File { Permissions = FileAccess.Read | FileAccess.Write};
                Console.WriteLine(f.CanRead());
                Console.WriteLine(f.CanWrite());
            }
        }
    }
}
