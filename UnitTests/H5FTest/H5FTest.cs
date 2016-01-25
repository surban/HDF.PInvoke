﻿/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Copyright by The HDF Group.                                               *
 * Copyright by the Board of Trustees of the University of Illinois.         *
 * All rights reserved.                                                      *
 *                                                                           *
 * This file is part of HDF5.  The full HDF5 copyright notice, including     *
 * terms governing use, modification, and redistribution, is contained in    *
 * the files COPYING and Copyright.html.  COPYING can be found at the root   *
 * of the source code distribution tree; Copyright.html can be found at the  *
 * root level of an installed copy of the electronic HDF5 document set and   *
 * is linked from the top-level documents page.  It can also be found at     *
 * http://hdfgroup.org/HDF5/doc/Copyright.html.  If you do not have          *
 * access to either file, you may request a copy from help@hdfgroup.org.     *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HDF.PInvoke;

using hid_t = System.Int32;

namespace UnitTests
{
    [TestClass]
    public partial class H5FTest
    {
        [ClassInitialize()]
        public static void ClassInit(TestContext testContext)
        {
            // create a test file which persists across file tests
            m_class_file = Utilities.H5TempFile();
            Assert.IsTrue(m_class_file >= 0);
        }

        [TestInitialize()]
        public void Init()
        {
            // create a test-local file
            m_test_file = Utilities.H5TempFile(ref m_test_file_name);
            Assert.IsTrue(m_test_file >= 0);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            // close the test-local file
            Assert.IsTrue(H5F.close(m_test_file) >= 0);
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            // close the global test file
            Assert.IsTrue(H5F.close(m_class_file) >= 0);
        }

        private static hid_t m_class_file = -1;

        private hid_t m_test_file = -1;

        private string m_test_file_name;
    }
}