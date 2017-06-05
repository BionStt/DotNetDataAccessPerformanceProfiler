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
    public partial class CategoriesGenDao : ICategoriesGenDao
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
        public CategoriesGen OrmByHand(string sql)
        {
            try
            {
                return baseDao.VisitDataReader<CategoriesGen>(sql, (reader) =>
                {
                    CategoriesGen entity = new CategoriesGen();
					if(reader.Read())
					{
                        entity.CategoryID = reader["CategoryID"];
                        entity.CategoryName = reader["CategoryName"];
                        entity.Description = reader["Description"];
                        entity.Picture = reader["Picture"];
                    }
                    return entity;
                });

                //CategoriesGen entity = new CategoriesGen();
                //using(var reader = baseDao.SelectDataReader(sql))
                //{
					//if(reader.Read())
					//{
                        //entity.CategoryID = reader["CategoryID"];
                        //entity.CategoryName = reader["CategoryName"];
                        //entity.Description = reader["Description"];
                        //entity.Picture = reader["Picture"];
	                //}
                //}
                //return entity;
            }
            catch (Exception ex)
            {
                throw new DalException("����CategoriesGenDaoʱ������OrmByHandʱ����", ex);
            }
        }
        */
        /// <summary>
        /// �޸�CategoriesGen
        /// </summary>
        /// <param name="categoriesGen">CategoriesGenʵ�����</param>
        /// <returns>״̬����</returns>
        public int UpdateCategoriesGen(CategoriesGen categoriesGen)
        {
            try
            {
                Object result = baseDao.Update<CategoriesGen>(categoriesGen);
                int iReturn = Convert.ToInt32(result);

                return iReturn;
            }
            catch (Exception ex)
            {
                throw new DalException("����CategoriesGenʱ������Updateʱ����", ex);
            }
        }
        /// <summary>
        /// ɾ��CategoriesGen
        /// </summary>
        /// <param name="categoriesGen">CategoriesGenʵ�����</param>
        /// <returns>״̬����</returns>
        public int DeleteCategoriesGen(CategoriesGen categoriesGen)
        {
            try
            {
                Object result = baseDao.Delete<CategoriesGen>(categoriesGen);
                int iReturn = Convert.ToInt32(result);

                return iReturn;
            }
            catch (Exception ex)
            {
                throw new DalException("����CategoriesGenʱ������Deleteʱ����", ex);
            }
        }
        /// <summary>
        /// ����������ȡCategoriesGen��Ϣ
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns>CategoriesGen��Ϣ</returns>
        public CategoriesGen FindByPk(int categoryID )
        {
            try
            {
                return baseDao.GetByKey<CategoriesGen>(categoryID);
            }
            catch (Exception ex)
            {
                throw new DalException("����CategoriesGenDaoʱ������FindByPkʱ����", ex);
            }
        }
        /// <summary>
        /// ��ȡ����CategoriesGen��Ϣ
        /// </summary>
        /// <returns>CategoriesGen�б�</returns>
        public IList<CategoriesGen> GetAll()
        {
            try
            {
                return baseDao.GetAll<CategoriesGen>();
            }
            catch (Exception ex)
            {
                throw new DalException("����CategoriesGenDaoʱ������GetAllʱ����", ex);
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
                String sql = "SELECT count(1) from Categories  with (nolock)  ";
                object obj = baseDao.ExecScalar(sql);
                long ret = Convert.ToInt64(obj);
                return ret;
            }
            catch (Exception ex)
            {
                throw new DalException("����CategoriesGenDaoʱ������Countʱ����", ex);
            }
        }
        /// <summary>
        ///  ����CategoriesGen������ҳ
        /// </summary>
        /// <param name="obj">CategoriesGenʵ������������</param>
        /// <param name="pagesize">ÿҳ��¼��</param>
        /// <param name="pageNo">ҳ��</param>
        /// <returns>�������</returns>
        public IList<CategoriesGen> GetListByPage(CategoriesGen obj, int pagesize, int pageNo)
        {
            try
            {
                StringBuilder sbSql = new StringBuilder(200);

                sbSql.Append(@"select CategoryID, CategoryName, Description, Picture from Categories (nolock) ");
                sbSql.Append(" order by CategoryID desc ");
                sbSql.Append(string.Format("OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY", (pageNo - 1) * pagesize, pagesize));
                IList<CategoriesGen> list = baseDao.SelectList<CategoriesGen>(sbSql.ToString());
                return list;
            }
            catch (Exception ex)
            {
                throw new DalException("����CategoriesGenDaoʱ������GetListByPageʱ����", ex);
            }
        }

       /// <summary>
       ///  ��������CategoriesGen
       /// </summary>
       /// <param name="categoriesGen">CategoriesGenʵ������б�</param>
       /// <returns>״̬����</returns>
        public bool BulkInsertCategoriesGen(IList<CategoriesGen> categoriesGenList)
       	{
            try
            {
                return baseDao.BulkInsert<CategoriesGen>(categoriesGenList);
            }
            catch (Exception ex)
            {
                throw new DalException("����CategoriesGenDaoʱ������BulkInsertʱ����", ex);
            }
        }

        
    }
}