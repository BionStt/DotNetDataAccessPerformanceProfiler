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
    public class CategoriesGenTest
    {
        public static void Test()
        {
            //���·�������ҪĿ���ǽ̻������ʹ��DAL
            //��ʵ��ʹ�õ�ʱ������Ҫ���ݲ�ͬ������
            //��ע����Ӧ�Ĵ��룬������Ϸ��Ĳ���
            //-------�������õķ�����VS��intellisense���������---------
            ICategoriesGenDao categoriesGenDao = DALFactory.CategoriesGenDao;


            //CategoriesGen orm = categoriesGenDao.OrmByHand("select * from table");

            //int insertResult = categoriesGenDao.InsertCategoriesGen(new CategoriesGen());

            //int updateResult = categoriesGenDao.UpdateCategoriesGen(new CategoriesGen());

            //int deleteResult = categoriesGenDao.DeleteCategoriesGen(new CategoriesGen());

            //int deleteByFieldResult = categoriesGenDao.DeleteCategoriesGen(0);


            //var resultsByPk = categoriesGenDao.FindByPk(0);
            //var entities = categoriesGenDao.GetAll();

            //long count = categoriesGenDao.Count();

            //var listByPage = categoriesGenDao.GetListByPage(null, 0, 0);

        }
    }
}
