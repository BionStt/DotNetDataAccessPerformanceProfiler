using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arch.Data;
using Arch.Data.DbEngine;
using CtripDAL.Model.Entity.DataModel;
using CtripDAL.Model.Interface.IDao;
using CtripDAL.Model.Dao;

namespace CtripDAL.Model.Test
{
    public class ProductsGenTest
    {
        public static void Test()
        {
            //以下方法的主要目的是教会您如何使用DAL
            //在实际使用的时候，您需要根据不同的情形
            //反注释相应的代码，并传入合法的参数
            //-------其他可用的方法，VS的intellisense会告诉您的---------
            IProductsGenDao productsGenDao = DALFactory.ProductsGenDao;


            //ProductsGen orm = productsGenDao.OrmByHand("select * from table");

            //int insertResult = productsGenDao.InsertProductsGen(new ProductsGen());

            //int updateResult = productsGenDao.UpdateProductsGen(new ProductsGen());

            //int deleteResult = productsGenDao.DeleteProductsGen(new ProductsGen());

            //int deleteByFieldResult = productsGenDao.DeleteProductsGen(0);


            //var resultsByPk = productsGenDao.FindByPk(0);
            //var entities = productsGenDao.GetAll();

            //long count = productsGenDao.Count();

            //var listByPage = productsGenDao.GetListByPage(null, 0, 0);

        }
    }
}
