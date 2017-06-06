using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arch.Data;
using Arch.Data.DbEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CtripDAL.Model.Entity.DataModel;
using CtripDAL.Model.Interface.IDao;
using CtripDAL.Model.Dao;


namespace CtripDAL.Model.Test
{
	//��ʵ��ʹ�õ�ʱ������Ҫ���ݲ�ͬ�����γ�ʼ������ֵ����ע�ͺ���������test case
	[TestClass]
    public class CustomersGenUnitTest
    {

		ICustomersGenDao customersGenDao = DALFactory.CustomersGenDao;

        [TestMethod]
        public void TestCount()
        {
            long ret = customersGenDao.Count();
        }
		
	    [TestMethod]
        public void TestDeleteCustomersGen1()
        {
            //CustomersGen customersGen;
			//int ret = customersGenDao.DeleteCustomersGen(customersGen);
        }
		
	    [TestMethod]
        public void TestFindByPk()
        {
            //string customerID;
			//CustomersGen obj = customersGenDao.FindByPk(customerID);
        }
		
	    [TestMethod]
        public void TestGetAll()
        {
            IList<CustomersGen> obj = customersGenDao.GetAll();
        }
		
        [TestMethod]
        public void TestGetListByPage()
        {
            //CustomersGen obj;
			//int pagesize;
			//int pageNo;
			//IList<CustomersGen> ret = customersGenDao.GetListByPage(obj, pagesize, pageNo);
        }
		
	    //sp insert
	    [TestMethod]
        public void TestInsertCustomersGen()
        {
            var customersGen = new CustomersGen
            {
                CompanyName = "Newcvompanyname",
                ContactName = "ccc",
                Address = "asdcadsdws",
                ContactTitle = "adsdf",
                City = "ku2na",
                Country = "chi2na",
                Phone = "231",
                PostalCode = "234",
                Region = "ASIA",
                CustomerID = "9012"
            };

            int ret = customersGenDao.InsertCustomersGen(customersGen);
            Assert.IsTrue(ret > 0);
        }
		
        [TestMethod]
        public void TestUpdateCustomersGen()
        {
			//CustomersGen customersGen;
            //int ret = customersGenDao.UpdateCustomersGen(customersGen);
        }
		
    }
	
}
