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
            //���·�������ҪĿ���ǽ̻������ʹ��DAL
            //��ʵ��ʹ�õ�ʱ������Ҫ���ݲ�ͬ������
            //��ע����Ӧ�Ĵ��룬������Ϸ��Ĳ���
            //-------�������õķ�����VS��intellisense���������---------
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
