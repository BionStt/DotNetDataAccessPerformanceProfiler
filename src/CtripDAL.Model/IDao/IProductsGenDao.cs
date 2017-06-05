using System;
using System.Collections.Generic;
using CtripDAL.Model.Entity.DataModel;

namespace CtripDAL.Model.Interface.IDao
{
        public partial interface IProductsGenDao
        {

        /// <summary>
        ///  ����ProductsGen
        /// </summary>
        /// <param name="productsGen">ProductsGenʵ�����</param>
        /// <returns>״̬����</returns>
		int InsertProductsGen(ProductsGen productsGen);
        /// <summary>
        /// �޸�ProductsGen
        /// </summary>
        /// <param name="productsGen">ProductsGenʵ�����</param>
        /// <returns>״̬����</returns>
        int UpdateProductsGen(ProductsGen productsGen);
        /// <summary>
        /// ɾ��ProductsGen
        /// </summary>
        /// <param name="productsGen">ProductsGenʵ�����</param>
        /// <returns>״̬����</returns>
        int DeleteProductsGen(ProductsGen productsGen);
        /// <summary>
        /// ����������ȡProductsGen��Ϣ
        /// </summary>
        /// <param name="productID"></param>
        /// <returns>ProductsGen��Ϣ</returns>
        ProductsGen FindByPk(int productID);
        /// <summary>
        /// ��ȡ����ProductsGen��Ϣ
        /// </summary>
        /// <returns>ProductsGen�б�</returns>
        IList<ProductsGen> GetAll();
        /// <summary>
        /// ȡ���ܼ�¼��
        /// </summary>
        /// <returns>��¼��</returns>
        long Count();
        /// <summary>
        ///  ��������ProductsGen
        /// </summary>
        /// <param name="productsGen">ProductsGenʵ������б�</param>
        /// <returns>״̬����</returns>
        bool BulkInsertProductsGen(IList<ProductsGen> productsGenList);
        /// <summary>
        ///  ����ProductsGen������ҳ
        /// </summary>
        /// <param name="obj">ProductsGenʵ������������</param>
        /// <param name="pagesize">ÿҳ��¼��</param>
        /// <param name="pageNo">ҳ��</param>
        /// <returns>�������</returns>
        IList<ProductsGen> GetListByPage(ProductsGen obj, int pagesize, int pageNo);


        }
}