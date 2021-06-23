using System;
using System.Diagnostics;
using System.IO;

namespace MGNLib.IO.Archive
{
    public class Archive
    {
        #region Public Fields

        public static readonly string[] ArchiveExtensions = new string[] { ".7z", ".tar", ".tar.bz2", ".tar.gz", ".wim", ".rar", ".rar", ".zip", ".zipx", ".cbr", ".cbz" };
        public static readonly int[] WordSizes = new int[] { 8, 12, 16, 24, 32, 48, 64, 96, 128, 192, 256, 273 };
        public static readonly string[] ArchiveTypesString = new string[] { "7z", "tar", "bzip2", "gzip", "wim", "rar", "rar4", "zip", "zipx", "cbr", "cbz" };

        public ArchiveOptions ArchiveOptions { get; set; }
        #endregion Public Fields

        #region Public Enums
        public enum ArchiveTypes { _7z, tar, bzip2, gzip, wim, rar, rar4, zip, zipx, cbr, cbz }
        public enum ArchiveStatus { Pending, Completed, Failed }

        public enum CompressionMethods { LZMA2, LZMA, PPMd, BZ, Deflate, Deflate64, BZip2 }

        

        public enum EncryptionMethods { AES256 }

        public enum PathModes { RelativePaths, FullPaths, AbsolutePaths }

        

        public enum UpdateModes { AddNReplace, AddNUpdate, FreshExistingOnly, AskBeforeOverwrite, SkipExisting, SynchronizeArchiveContents }

        #endregion Public Enums

        #region Public Properties

        public bool AddRecoveryRecord { get; set; }
        public ArchiveTypes ArchiveType { get; set; }
        public string[] Args { get; set; }
        public bool CompressSharedFiles { get; set; }
        public int CPUThreads { get; set; }
        public bool CreateSFXArchive { get; set; }
        public bool CreateSolidArchive { get; set; }
        public bool DeleteFilesAfterArchiving { get; set; }
        public bool EncryptFileNames { get; set; }
        public EncryptionMethods EncryptionMethod { get; set; }
        public bool IsArchiveBuilt { get; set; }
        public string Location { get; set; }
        public int Name { get; set; }
        public string OutputPath { get; set; }
        public string Password { get; set; }
        public PathModes PathMode { get; set; }
        public bool ShowPassword { get; set; }
        public string SourcePath { get; set; }
        public ArchiveStatus Status { get; set; }
        public bool TestArchivedFiles { get; set; }
        public int TotalSizeCompressed { get; set; }
        public int TotalSizeUncompressed { get; set; }
        public UpdateModes UpdateMode { get; set; }
        public int WordSize { get; set; }

        #endregion Public Properties

        #region Public Methods

        public bool Compress(DirectoryInfo di, string archiveProgramLocation, string[] args)
        {
            /*
             
            //archiveProgramLocation = "C:\Program Files\WinRAR\Rar.exe"
            ProcessStartInfo startInfo = new ProcessStartInfo(@archiveProgramLocation);
            this.BeginInvoke((Action)delegate ()
            {
                startInfo.WindowStyle = ProcessWindowStyle.Minimized; //SET MAX COUNTER...THIS IS A RUNAWAY!!
                startInfo.Arguments = string.Format("{0}\"{1}\" \"{2}\"",
                                      switches, di.FullName + Archive.ArchiveExtensions[comboBoxArchiveFormatSelect.SelectedIndex], di.FullName);
                Console.WriteLine(startInfo.Arguments);
            });

            //startInfo.CreateNoWindow = false;

            Process exeProcess = Process.Start(startInfo);
            exeProcess.WaitForExit();
            

            */
            return true;
        }

        #endregion Public Methods
    }
}