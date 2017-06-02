﻿// ***********************************************************************
// Assembly         : Linq2dbPerformanceTest.Model
// Author           : PeterLiu
// Created          : 06-02-2017
//
// Last Modified By : PeterLiu
// Last Modified On : 06-02-2017
// ***********************************************************************
// <copyright file="PetaPocoPerformanceTest.cs" company="Megadotnet">
//     Copyright (c) Megadotnet. All rights reserved.
// </copyright>
// <summary></summary>
namespace PetaPoco.Model
{
    using DBPerformanceTest.Core;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TestPerformaceDBConnection;


    /// <summary>
    /// PetaPocoPerformanceTest
    /// </summary>
    public class PetaPocoPerformanceTest : IPerformanceTest
    {
        /// <summary>
        /// FetchAllTest
        /// </summary>
        /// <param name="repeatTime"></param>
        /// <seealso cref="https://github.com/CollaboratingPlatypus/PetaPoco/wiki/Quick-Start"/>
        /// <returns></returns>
        public long FetchAllTest(int repeatTime)
        {
            return Utility.PerformanceWatch(
              () =>
          {
              var db = new TestPerformaceDBConnectionDB();

              for (int i = 0; i < repeatTime; i++)
              {
                  var customers = db.Query<Customer>("select * from Customers").ToList();
                  var product = db.Query<Product>("select * from Products").ToList();
                  var categories = db.Query<Category>("select * from Categories").ToList();
              }
          });
        }

        /// <summary>
        /// FetchSingleTest
        /// </summary>
        /// <param name="repeatTime"></param>
        /// <returns></returns>
        public long FetchSingleTest(int repeatTime)
        {
            return Utility.PerformanceWatch(
    () =>
    {

        var db = new TestPerformaceDBConnectionDB();

        for (int i = 0; i < repeatTime; i++)
        {
            var customers = db.Query<Customer>("select * from Customers where CustomerID = '10'").FirstOrDefault();
            var product = db.Query<Product>("select * from Products where ProductID = 10").FirstOrDefault();
            var categories = db.Query<Category>("select * from Categories where CategoryID = 10").FirstOrDefault();
        }

    });
        }

        /// <summary>
        /// WriteTest
        /// </summary>
        /// <param name="repeatTime"></param>
        /// <returns></returns>
        public long WriteTest(int repeatTime)
        {
            return Utility.PerformanceWatch(
() =>
{

});
        }
    }
}
