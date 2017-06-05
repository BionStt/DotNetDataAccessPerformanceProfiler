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
    public class CategoriesGenUnitTest
    {

		ICategoriesGenDao categoriesGenDao = DALFactory.CategoriesGenDao;

        [TestMethod]
        public void TestCount()
        {
            long ret = categoriesGenDao.Count();
            Assert.IsTrue(ret > 0);
        }
		
	    [TestMethod]
        public void TestDeleteCategoriesGen1()
        {
            //CategoriesGen categoriesGen;
			//int ret = categoriesGenDao.DeleteCategoriesGen(categoriesGen);
        }
		
	    [TestMethod]
        public void TestFindByPk()
        {
            //int categoryID;
			//CategoriesGen obj = categoriesGenDao.FindByPk(categoryID);
        }
		
	    [TestMethod]
        public void TestGetAll()
        {
            IList<CategoriesGen> obj = categoriesGenDao.GetAll();
        }
		
        [TestMethod]
        public void TestGetListByPage()
        {
            //CategoriesGen obj;
			//int pagesize;
			//int pageNo;
			//IList<CategoriesGen> ret = categoriesGenDao.GetListByPage(obj, pagesize, pageNo);
        }
		
	    //sp insert
	    [TestMethod]
        public void TestInsertCategoriesGen()
        {
			//CategoriesGen categoriesGen;
            //int ret = categoriesGenDao.InsertCategoriesGen(categoriesGen);
        }
		
        [TestMethod]
        public void TestUpdateCategoriesGen()
        {
			//CategoriesGen categoriesGen;
            //int ret = categoriesGenDao.UpdateCategoriesGen(categoriesGen);
        }
		
    }
	
}
