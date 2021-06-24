using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGNLib.DiskUtils
{
    public class Disk
    {
        public DriveGeometry Geometry { get; internal set; }
        public PhysInfo PhysicalInformation { get; internal set; }
        public MBR MasterBootRecord { get; set; }
        public DriveSector Sector { get; set; }
        public TableType PartitionTableType { get; set; }
        public string Path { get; set; }

        //Drive.PhysicalInformation.InterfaceType interfaceType = new Drive.PhysicalInformation.InterfaceType(); // ENUM

        public Disk()
        {
        }
        public enum TableType
        {

        }
        public class DriveGeometry
        {
            public uint Cylinders { get; internal set; }
            public byte TracksPerCylinder { get; internal set; }
            public byte SectorsPerTrack { get; internal set; }
            public ushort BytesPerSector { get; internal set; }
            public uint SectorCount { get; internal set; }
        }

        public class PhysInfo
        {
            public string DriveModel { get; internal set; }
            public string DriveSerialNumber { get; internal set; }
            public bool IsRemovableDrive { get; internal set; }
        }

        public class DriveSector
        {
            public List<byte> Data { get; set; }
        }

        public class MBR : DriveSector
        {

        }
        //enum DiskType; Physical Disk

        /*
        HDSector sector = new HDSector();
        sector.Size = 4000; //in bytes
        ushort s = sector.Size.inKB();

        AddressScheme.Type addressScheme = new AddressScheme.Type();

        //PHysical CHS Addressing Cylinder/Head/Sector
        //Logical CHS Addressing Cylinder/Head/Sector
        //Logical Block Addressing - Logical Block Number
        */
    }
}
