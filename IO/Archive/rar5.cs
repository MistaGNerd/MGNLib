using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGNLib.IO.Archive.Options;

namespace MGNLib.IO.Archive
{
    public class rar5
    {
        public static string[] CompressionLevels = { "Store", "Fastest", "Fast", "Normal", "Good", "Best" };

        public static string[] DictionarySizesKB = { "1024", "2048", "4096", "8192", "16384", "32768", "65536", 
            "131072", "262144", "524288", "1048576"};

        public static List<DataSize> DictionarySizes = new List<DataSize>() {
            new DataSize(1024, DataSize.UnitSizes.KB),
            new DataSize(2048, DataSize.UnitSizes.KB),
            new DataSize(4096, DataSize.UnitSizes.KB),
            new DataSize(8192, DataSize.UnitSizes.KB),
            new DataSize(16384, DataSize.UnitSizes.KB),
            new DataSize(32768, DataSize.UnitSizes.KB),
            new DataSize(65536, DataSize.UnitSizes.KB),
            new DataSize(131072, DataSize.UnitSizes.KB),
            new DataSize(262144, DataSize.UnitSizes.KB),
            new DataSize(524288, DataSize.UnitSizes.KB),
            new DataSize(1048576, DataSize.UnitSizes.KB)
        };

        public static string[] SplitVolumeBySizeMB = { "5MB", "10MB", "100MB", "650MB CD", "700MB CD" };
        //{ "5MB", "10MB", "100MB", "650MB CD", "700MB CD", _4095MB_Fat32, _4481MB_DVD, _8128MB_DVDDL, _23040MB_BD }

    }
}
