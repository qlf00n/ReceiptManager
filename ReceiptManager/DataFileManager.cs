using System;
using System.Collections.Generic;

namespace ReceiptManager
{
    public class DataFileManager
    {
        #region fields

        private static Dictionary<string, IDataFileItem> dataFileItems = new Dictionary<string, IDataFileItem>();

        private static string dataItemsFileName;

        #endregion

        public static bool ReadDataFile(IDataFileDetails dataFileDetails)
        {
            if (dataFileDetails == null)
            {
                throw new ArgumentNullException();
            }

            if (dataFileDetails.FileName == string.Empty)
            {
                return false;
            }

            dataItemsFileName = dataFileDetails.FileName;

            return true;
        }
    }
}
