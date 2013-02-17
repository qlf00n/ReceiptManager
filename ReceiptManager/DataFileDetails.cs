using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReceiptManager
{
    public class DataFileDetails : IDataFileDetails
    {
        #region fields

        private string fileName;

        #endregion

        #region properties

        public string FileName
        {
            get
            {
                return fileName;
            }
        }

        #endregion

        #region constructors

        public DataFileDetails(string fileName)
        {
            this.fileName = fileName;
        }

        #endregion
    }
}
