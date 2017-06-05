using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Arch.Data;
using Arch.Data.DbEngine;
using CtripDAL.Model.Entity.DataModel;
using CtripDAL.Model.Interface.IDao;

namespace CtripDAL.Model.Dao
{
    /// <summary>
    ///ProductsGenDao
    /// </summary>
    public partial class ProductsGenDao : IProductsGenDao
    {
        readonly BaseDao baseDao = BaseDaoFactory.CreateBaseDao("TestPrerdb");
        
        //�ر�ע�⣬����ǿɿ����ͣ����������·�ʽʹ�ã�
        // var data = reader["field"];
        // entity.stringData = data == null ? data : data.ToString();
        //����Ҫ�ֹ�ӳ�䣬�뷴ע�����´��룬��ע��ת������
        /*
        /// <summary>
        /// �ֹ�ӳ�䣬����ʹ��1.2.0.5�汾���ϵ�VisitDataReader
        /// </summary>
        /// <returns>���</returns>
        public ProductsGen OrmByHand(string sql)
        {
            try
            {
                return baseDao.VisitDataReader<ProductsGen>(sql, (reader) =>
                {
                    ProductsGen entity = new ProductsGen();
					if(reader.Read())
					{
                        entity.CategoryID = reader["CategoryID"];
                        entity.Discontinued = reader["Discontinued"];
                        entity.ProductID = reader["ProductID"];
                        entity.ProductName = reader["ProductName"];
                        entity.QuantityPerUnit = reader["QuantityPerUnit"];
                        entity.ReorderLevel = reader["ReorderLevel"];
                        entity.SupplierID = reader["SupplierID"];
                        entity.UnitPrice = reader["UnitPrice"];
                        entity.UnitsInStock = reader["UnitsInStock"];
                        entity.UnitsOnOrder = reader["UnitsOnOrder"];
                    }
                    return entity;
                });

                //ProductsGen entity = new ProductsGen();
                //using(var reader = baseDao.SelectDataReader(sql))
                //{
					//if(reader.Read())
					//{
                        //entity.CategoryID = reader["CategoryID"];
                        //entity.Discontinued = reader["Discontinued"];
                        //entity.ProductID = reader["ProductID"];
                        //entity.ProductName = reader["ProductName"];
                        //entity.QuantityPerUnit = reader["QuantityPerUnit"];
                        //entity.ReorderLevel = reader["ReorderLevel"];
                        //entity.SupplierID = reader["SupplierID"];
                        //entity.UnitPrice = reader["UnitPrice"];
                        //entity.UnitsInStock = reader["UnitsInStock"];
                        //entity.UnitsOnOrder = reader["UnitsOnOrder"];
	                //}
                //}
                //return entity;
            }
            catch (Exception ex)
            {
                throw new DalException("����ProductsGenDaoʱ������OrmByHandʱ����", ex);
            }
        }
        */
        /// <summary>
        /// �޸�ProductsGen
        /// </summary>
        /// <param name="productsGen">ProductsGenʵ�����</param>
        /// <returns>״̬����</returns>
        public int UpdateProductsGen(ProductsGen productsGen)
        {
            try
            {
                Object result = baseDao.Update<ProductsGen>(productsGen);
                int iReturn = Convert.ToInt32(result);

                return iReturn;
            }
            catch (Exception ex)
            {
                throw new DalException("����ProductsGenʱ������Updateʱ����", ex);
            }
        }
        /// <summary>
        /// ɾ��ProductsGen
        /// </summary>
        /// <param name="productsGen">ProductsGenʵ�����</param>
        /// <returns>״̬����</returns>
        public int DeleteProductsGen(ProductsGen productsGen)
        {
            try
            {
                Object result = baseDao.Delete<ProductsGen>(productsGen);
                int iReturn = Convert.ToInt32(result);

                return iReturn;
            }
            catch (Exception ex)
            {
                throw new DalException("����ProductsGenʱ������Deleteʱ����", ex);
            }
        }
        /// <summary>
        /// ����������ȡProductsGen��Ϣ
        /// </summary>
        /// <param name="productID"></param>
        /// <returns>ProductsGen��Ϣ</returns>
        public ProductsGen FindByPk(int productID )
        {
            try
            {
                return baseDao.GetByKey<ProductsGen>(productID);
            }
            catch (Exception ex)
            {
                throw new DalException("����ProductsGenDaoʱ������FindByPkʱ����", ex);
            }
        }
        /// <summary>
        /// ��ȡ����ProductsGen��Ϣ
        /// </summary>
        /// <returns>ProductsGen�б�</returns>
        public IList<ProductsGen> GetAll()
        {
            try
            {
                return baseDao.GetAll<ProductsGen>();
            }
            catch (Exception ex)
            {
                throw new DalException("����ProductsGenDaoʱ������GetAllʱ����", ex);
            }
        }
        /// <summary>
        /// ȡ���ܼ�¼��
        /// </summary>
        /// <returns>��¼��</returns>
        public long Count()
        {
            try
            {
                String sql = "SELECT count(1) from Products  with (nolock)  ";
                object obj = baseDao.ExecScalar(sql);
                long ret = Convert.ToInt64(obj);
                return ret;
            }
            catch (Exception ex)
            {
                throw new DalException("����ProductsGenDaoʱ������Countʱ����", ex);
            }
        }
        /// <summary>
        ///  ����ProductsGen������ҳ
        /// </summary>
        /// <param name="obj">ProductsGenʵ������������</param>
        /// <param name="pagesize">ÿҳ��¼��</param>
        /// <param name="pageNo">ҳ��</param>
        /// <returns>�������</returns>
        public IList<ProductsGen> GetListByPage(ProductsGen obj, int pagesize, int pageNo)
        {
            try
            {
                StringBuilder sbSql = new StringBuilder(200);

                sbSql.Append(@"select CategoryID, Discontinued, ProductID, ProductName, QuantityPerUnit, ReorderLevel, SupplierID, UnitPrice, UnitsInStock, UnitsOnOrder from Products (nolock) ");
                sbSql.Append(" order by ProductID desc ");
                sbSql.Append(string.Format("OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY", (pageNo - 1) * pagesize, pagesize));
                IList<ProductsGen> list = baseDao.SelectList<ProductsGen>(sbSql.ToString());
                return list;
            }
            catch (Exception ex)
            {
                throw new DalException("����ProductsGenDaoʱ������GetListByPageʱ����", ex);
            }
        }

       /// <summary>
       ///  ��������ProductsGen
       /// </summary>
       /// <param name="productsGen">ProductsGenʵ������б�</param>
       /// <returns>״̬����</returns>
        public bool BulkInsertProductsGen(IList<ProductsGen> productsGenList)
       	{
            try
            {
                return baseDao.BulkInsert<ProductsGen>(productsGenList);
            }
            catch (Exception ex)
            {
                throw new DalException("����ProductsGenDaoʱ������BulkInsertʱ����", ex);
            }
        }

        public int InsertProductsGen(ProductsGen productsGen)
        {
            throw new NotImplementedException();
        }
    }
}