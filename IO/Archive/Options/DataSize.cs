namespace MGNLib.IO.Archive.Options
{
    public class DataSize
    {
        #region Public Fields
        public string SizeAsString;

        public DataSize(decimal size, UnitSizes unitSize)
        {
            this.Size = size;
            this.UnitSize = unitSize;
        }
        #endregion Public Fields

        #region Public Constructors
        #endregion Public Constructors

        #region Public Enums

        public enum UnitSizes { KB, MB, GB };

        #endregion Public Enums

        #region Public Properties

        public decimal Size { get; set; }
        public UnitSizes UnitSize { get; set; }

        #endregion Public Properties

        #region Internal Methods

        internal string setSizeAsString()
        {
            string s = this.Size.ToString() + " " + this.UnitSize.ToString();
            return s;
        }
        #endregion Internal Methods
        public DataSize ToKB()
        {
            decimal sz = this.Size;
            UnitSizes us = this.UnitSize;

            DataSize ds = new DataSize(Size, UnitSize);
            if (us != UnitSizes.KB)
            {
                if (us == UnitSizes.MB)
                {
                    ds.Size = (int)(sz * 1000);
                }
                if (us == UnitSizes.GB)
                {
                    ds.Size = (int)(sz * 1000000);
                }
                ds.UnitSize = UnitSizes.KB;
            }
            return ds;
        }
        public DataSize ToMB()
        {
            decimal sz = this.Size;
            UnitSizes us = this.UnitSize;

            DataSize ds = new DataSize(Size, UnitSize);
            if (us != UnitSizes.MB)
            {
                if (us == UnitSizes.KB)
                {
                    ds.Size = sz / 1000;
                }
                if (us == UnitSizes.GB)
                {
                    ds.Size = (int)(sz * 1000);
                }
                ds.UnitSize = UnitSizes.MB;
            }
            return ds;
        }
        public DataSize ToGB()
        {
            decimal sz = this.Size;
            UnitSizes us = this.UnitSize;

            DataSize ds = new DataSize(Size, UnitSize);
            if (us != UnitSizes.GB)
            {
                if (us == UnitSizes.KB)
                {
                    ds.Size = (sz / 1000);
                }
                if (us == UnitSizes.MB)
                {
                    ds.Size = (int)(sz * 1000000);
                }
                ds.UnitSize = UnitSizes.GB;
            }
            return ds;
        }
    }
}