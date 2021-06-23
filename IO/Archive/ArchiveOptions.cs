using MGNLib.IO.Archive.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGNLib.IO.Archive
{
    public class ArchiveOptions
    {
        public string[] CompressionLevels;
        public string[] DictionarySizesKB;
        public string[] SplitVolumeBySizeMB;
        public List<DataSize> DictionarySizes;
        public enum SplitVolumeSizes { _5MB, _10MB, _100MB, _650_CD, _700MB_CD, _4095MB_Fat32, _4481MB_DVD, _8128MB_DVDDL, _23040MB_BD }
        public enum DictSize
        {
            _32KB = 32, _64KB = 64, _128KB = 128, _256KB = 256, _512KB = 512, _1MB = 1024, _2MB = 2048,
            _3MB = 3072, _4MB = 4096, _6MB = 6144, _8MB = 8192, _12MB = 12288, _16MB = 16384, _24MB = 24576, _32MB, _64MB, _128MB, _256MB, _512MB, _1024MB
        }

        public void LoadRar5()
        {
            this.CompressionLevels = rar5.CompressionLevels;
            this.DictionarySizesKB = rar5.DictionarySizesKB;
            this.SplitVolumeBySizeMB = rar5.SplitVolumeBySizeMB;
            this.DictionarySizes = rar5.DictionarySizes;
        }
    }
}
