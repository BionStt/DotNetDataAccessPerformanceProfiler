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
    ///
    /// </summary>
    public partial class CustomersGenDao : ICustomersGenDao
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
        public CustomersGen OrmByHand(string sql)
        {
            try
            {
                return baseDao.VisitDataReader<CustomersGen>(sql, (reader) =>
                {
                    CustomersGen entity = new CustomersGen();
					if(reader.Read())
					{
                        entity.Address = reader["Address"];
                        entity.City = reader["City"];
                        entity.CompanyName = reader["CompanyName"];
                        entity.ContactName = reader["ContactName"];
                        entity.ContactTitle = reader["ContactTitle"];
                        entity.Country = reader["Country"];
                        entity.CustomerID = reader["CustomerID"];
                        entity.Fax = reader["Fax"];
                        entity.Phone = reader["Phone"];
                        entity.PostalCode = reader["PostalCode"];
                        entity.Region = reader["Region"];
                    }
                    return entity;
                });

                //CustomersGen entity = new CustomersGen();
                //using(var reader = baseDao.SelectDataReader(sql))
                //{
					//if(reader.Read())
					//{
                        //entity.Address = reader["Address"];
                        //entity.City = reader["City"];
                        //entity.CompanyName = reader["CompanyName"];
                        //entity.ContactName = reader["ContactName"];
                        //entity.ContactTitle = reader["ContactTitle"];
                        //entity.Country = reader["Country"];
                        //entity.CustomerID = reader["CustomerID"];
                        //entity.Fax = reader["Fax"];
                        //entity.Phone = reader["Phone"];
                        //entity.PostalCode = reader["PostalCode"];
                        //entity.Region = reader["Region"];
	                //}
                //}
                //return entity;
            }
            catch (Exception ex)
            {
                throw new DalException("����CustomersGenDaoʱ������OrmByHandʱ����", ex);
            }
        }
        */
        /// <summary>
        /// �޸�CustomersGen
        /// </summary>
        /// <param name="customersGen">CustomersGenʵ�����</param>
        /// <returns>״̬����</returns>
        public int UpdateCustomersGen(CustomersGen customersGen)
        {
            try
            {
                Object result = baseDao.Update<CustomersGen>(customersGen);
                int iReturn = Convert.ToInt32(result);

                return iReturn;
            }
            catch (Exception ex)
            {
                throw new DalException("����CustomersGenʱ������Updateʱ����", ex);
            }
        }
        /// <summary>
        /// ɾ��CustomersGen
        /// </summary>
        /// <param name="customersGen">CustomersGenʵ�����</param>
        /// <returns>״̬����</returns>
        public int DeleteCustomersGen(CustomersGen customersGen)
        {
            try
            {
                Object result = baseDao.Delete<CustomersGen>(customersGen);
                int iReturn = Convert.ToInt32(result);

                return iReturn;
            }
            catch (Exception ex)
            {
                throw new DalException("����CustomersGenʱ������Deleteʱ����", ex);
            }
        }
        /// <summary>
        /// ����������ȡCustomersGen��Ϣ
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns>CustomersGen��Ϣ</returns>
        public CustomersGen FindByPk(string customerID )
        {
            try
            {
                return baseDao.GetByKey<CustomersGen>(customerID);
            }
            catch (Exception ex)
            {
                throw new DalException("����CustomersGenDaoʱ������FindByPkʱ����", ex);
            }
        }
        /// <summary>
        /// ��ȡ����CustomersGen��Ϣ
        /// </summary>
        /// <returns>CustomersGen�б�</returns>
        public IList<CustomersGen> GetAll()
        {
            try
            {
                return baseDao.GetAll<CustomersGen>();
            }
            catch (Exception ex)
            {
                throw new DalException("����CustomersGenDaoʱ������GetAllʱ����", ex);
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
                String sql = "SELECT count(1) from Customers  with (nolock)  ";
                object obj = baseDao.ExecScalar(sql);
                long ret = Convert.ToInt64(obj);
                return ret;
            }
            catch (Exception ex)
            {
                throw new DalException("����CustomersGenDaoʱ������Countʱ����", ex);
            }
        }
        /// <summary>
        ///  ����CustomersGen������ҳ
        /// </summary>
        /// <param name="obj">CustomersGenʵ������������</param>
        /// <param name="pagesize">ÿҳ��¼��</param>
        /// <param name="pageNo">ҳ��</param>
        /// <returns>�������</returns>
        public IList<CustomersGen> GetListByPage(CustomersGen obj, int pagesize, int pageNo)
        {
            try
            {
                StringBuilder sbSql = new StringBuilder(200);

                sbSql.Append(@"select Address, City, CompanyName, ContactName, ContactTitle, Country, CustomerID, Fax, Phone, PostalCode, Region from Customers (nolock) ");
                sbSql.Append(" order by CustomerID desc ");
                sbSql.Append(string.Format("OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY", (pageNo - 1) * pagesize, pagesize));
                IList<CustomersGen> list = baseDao.SelectList<CustomersGen>(sbSql.ToString());
                return list;
            }
            catch (Exception ex)
            {
                throw new DalException("����CustomersGenDaoʱ������GetListByPageʱ����", ex);
            }
        }

       /// <summary>
       ///  ��������CustomersGen
       /// </summary>
       /// <param name="customersGen">CustomersGenʵ������б�</param>
       /// <returns>״̬����</returns>
        public bool BulkInsertCustomersGen(IList<CustomersGen> customersGenList)
       	{
            try
            {
                return baseDao.BulkInsert<CustomersGen>(customersGenList);
            }
            catch (Exception ex)
            {
                throw new DalException("����CustomersGenDaoʱ������BulkInsertʱ����", ex);
            }
        }

        public int InsertCustomersGen(CustomersGen customersGen)
        {
            throw new NotImplementedException();
        }
    }
}