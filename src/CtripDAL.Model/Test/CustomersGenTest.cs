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
    public class CustomersGenTest
    {
        public static void Test()
        {
            //���·�������ҪĿ���ǽ̻������ʹ��DAL
            //��ʵ��ʹ�õ�ʱ������Ҫ���ݲ�ͬ������
            //��ע����Ӧ�Ĵ��룬������Ϸ��Ĳ���
            //-------�������õķ�����VS��intellisense���������---------
            ICustomersGenDao customersGenDao = DALFactory.CustomersGenDao;


            //CustomersGen orm = customersGenDao.OrmByHand("select * from table");

            //int insertResult = customersGenDao.InsertCustomersGen(new CustomersGen());

            //int updateResult = customersGenDao.UpdateCustomersGen(new CustomersGen());

            //int deleteResult = customersGenDao.DeleteCustomersGen(new CustomersGen());

            //int deleteByFieldResult = customersGenDao.DeleteCustomersGen(null);


            //var resultsByPk = customersGenDao.FindByPk(null);
            //var entities = customersGenDao.GetAll();

            //long count = customersGenDao.Count();

            //var listByPage = customersGenDao.GetListByPage(null, 0, 0);

        }
    }
}
