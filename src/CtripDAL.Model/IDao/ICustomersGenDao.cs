using System;
using System.Collections.Generic;
using CtripDAL.Model.Entity.DataModel;

namespace CtripDAL.Model.Interface.IDao
{
        public partial interface ICustomersGenDao
        {

        /// <summary>
        ///  ����CustomersGen
        /// </summary>
        /// <param name="customersGen">CustomersGenʵ�����</param>
        /// <returns>״̬����</returns>
		int InsertCustomersGen(CustomersGen customersGen);
        /// <summary>
        /// �޸�CustomersGen
        /// </summary>
        /// <param name="customersGen">CustomersGenʵ�����</param>
        /// <returns>״̬����</returns>
        int UpdateCustomersGen(CustomersGen customersGen);
        /// <summary>
        /// ɾ��CustomersGen
        /// </summary>
        /// <param name="customersGen">CustomersGenʵ�����</param>
        /// <returns>״̬����</returns>
        int DeleteCustomersGen(CustomersGen customersGen);
        /// <summary>
        /// ����������ȡCustomersGen��Ϣ
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns>CustomersGen��Ϣ</returns>
        CustomersGen FindByPk(string customerID);
        /// <summary>
        /// ��ȡ����CustomersGen��Ϣ
        /// </summary>
        /// <returns>CustomersGen�б�</returns>
        IList<CustomersGen> GetAll();
        /// <summary>
        /// ȡ���ܼ�¼��
        /// </summary>
        /// <returns>��¼��</returns>
        long Count();
        /// <summary>
        ///  ��������CustomersGen
        /// </summary>
        /// <param name="customersGen">CustomersGenʵ������б�</param>
        /// <returns>״̬����</returns>
        bool BulkInsertCustomersGen(IList<CustomersGen> customersGenList);
        /// <summary>
        ///  ����CustomersGen������ҳ
        /// </summary>
        /// <param name="obj">CustomersGenʵ������������</param>
        /// <param name="pagesize">ÿҳ��¼��</param>
        /// <param name="pageNo">ҳ��</param>
        /// <returns>�������</returns>
        IList<CustomersGen> GetListByPage(CustomersGen obj, int pagesize, int pageNo);


        }
}