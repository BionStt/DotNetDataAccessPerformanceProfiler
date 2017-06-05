using System;
using System.Collections.Generic;
using CtripDAL.Model.Entity.DataModel;

namespace CtripDAL.Model.Interface.IDao
{
        public partial interface ICategoriesGenDao
        {

        /// <summary>
        ///  ����CategoriesGen
        /// </summary>
        /// <param name="categoriesGen">CategoriesGenʵ�����</param>
        /// <returns>״̬����</returns>
		int InsertCategoriesGen(CategoriesGen categoriesGen);
        /// <summary>
        /// �޸�CategoriesGen
        /// </summary>
        /// <param name="categoriesGen">CategoriesGenʵ�����</param>
        /// <returns>״̬����</returns>
        int UpdateCategoriesGen(CategoriesGen categoriesGen);
        /// <summary>
        /// ɾ��CategoriesGen
        /// </summary>
        /// <param name="categoriesGen">CategoriesGenʵ�����</param>
        /// <returns>״̬����</returns>
        int DeleteCategoriesGen(CategoriesGen categoriesGen);
        /// <summary>
        /// ����������ȡCategoriesGen��Ϣ
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns>CategoriesGen��Ϣ</returns>
        CategoriesGen FindByPk(int categoryID);
        /// <summary>
        /// ��ȡ����CategoriesGen��Ϣ
        /// </summary>
        /// <returns>CategoriesGen�б�</returns>
        IList<CategoriesGen> GetAll();
        /// <summary>
        /// ȡ���ܼ�¼��
        /// </summary>
        /// <returns>��¼��</returns>
        long Count();
        /// <summary>
        ///  ��������CategoriesGen
        /// </summary>
        /// <param name="categoriesGen">CategoriesGenʵ������б�</param>
        /// <returns>״̬����</returns>
        bool BulkInsertCategoriesGen(IList<CategoriesGen> categoriesGenList);
        /// <summary>
        ///  ����CategoriesGen������ҳ
        /// </summary>
        /// <param name="obj">CategoriesGenʵ������������</param>
        /// <param name="pagesize">ÿҳ��¼��</param>
        /// <param name="pageNo">ҳ��</param>
        /// <returns>�������</returns>
        IList<CategoriesGen> GetListByPage(CategoriesGen obj, int pagesize, int pageNo);


        }
}