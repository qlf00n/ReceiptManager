using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReceiptManager;
using System;

namespace ReceiptManagerTests
{
    [TestClass]
    public class DataFileManagerTests
    {
        #region consts

        const string DATA_ITEMS_FILENAME = @"C:\TestPath\TestFileName.bin";

        #endregion

        #region fields

        DataFileManager dataFileManager;

        /// <summary>
        /// Allows access to private static members.
        /// </summary>
        private static PrivateType prvTypDataFileManager;

        /// <summary>
        /// Allows access to private instance members.
        /// </summary>
        PrivateObject prvObjDataFileManager;

        #endregion

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            prvTypDataFileManager = new PrivateType(typeof(DataFileManager));
        }

        [TestInitialize]
        public void TestInitialize()
        {
            dataFileManager = new DataFileManager();
            prvObjDataFileManager = new PrivateObject(dataFileManager, prvTypDataFileManager);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReadDataFile_ShouldThrowNotImplementedException_OnDataFileDetailesBeingNull()
        {
            // act
            DataFileManager.ReadDataFile(null);
        }

        [TestMethod]
        public void ReadDataFile_ShouldReturnFalse_OnEmptyDataFileName()
        {
            // arrange
            IDataFileDetails dataFileDetails = new DataFileDetails(string.Empty);

            // act
            bool actualResult = DataFileManager.ReadDataFile(dataFileDetails);

            // assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void ReadDataFile_ShouldKeepFileName_OnNotEmptyDataFileName()
        {
            // arrange
            IDataFileDetails dataFileDetails = new DataFileDetails(DATA_ITEMS_FILENAME);

            // act
            bool actualResult = DataFileManager.ReadDataFile(dataFileDetails);

            // assert
            Assert.IsNotNull((string)prvTypDataFileManager.GetStaticField("dataItemsFileName"));
            Assert.AreEqual(DATA_ITEMS_FILENAME, 
                (string)prvTypDataFileManager.GetStaticField("dataItemsFileName"));
        }
    }
}
