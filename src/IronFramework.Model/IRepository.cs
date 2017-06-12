﻿
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRepository.cs" company="Megadonet">
//   Copyright (c) 2010-2015 Petter Liu.  All rights reserved. 
// </copyright>
// <summary>
//   a interface of data acccess repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace IronFramework.Model
{
    using System;
    using System.Collections.Generic;
	using System.Linq;
    using System.Linq.Expressions;
	using System.Threading.Tasks;

    using IronFramework.Utility.UI;

    /// <summary>
    /// A Interface of data acccess repository.
    /// </summary>
    /// <typeparam name="T">entity</typeparam>
    public interface IRepository<T>
    {
        #region Public Methods

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        void Add(T entity);

        /// <summary>
        /// Get all dataset
        /// </summary>
        /// <returns>
        /// collection of entits
        /// </returns>
        IQueryable<T> All();

        /// <summary>
        /// Attaches the specified entity.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        void Attach(T entity);

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        void Delete(T entity);

        /// <summary>
        /// Finds the specified expression.
        /// </summary>
        /// <param name="expression">
        /// The expression.
        /// </param>
        /// <returns>
        /// IEmunerable entites
        /// </returns>
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        /// <summary>
        /// FindAsync
        /// </summary>
        /// <param name="expression">expression</param>
        /// <returns>async task  IEmunerable entites</returns>
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression);
		
		
		/// <summary>
        /// FindAsync
        /// </summary>
        /// <param name="expression">expression</param>
        /// <returns>async task  IEmunerable entites</returns>
		Task<IEnumerable<T>> FindAsync<K>(
           Expression<Func<T, bool>> expression, Expression<Func<T, K>> orderExpression, bool isOrderByDesc
        );

		        /// <summary>
        /// Finds the specified where expression
        /// </summary>
        /// <typeparam name="K">
        /// K is Key type of sort column  
        /// </typeparam>
        /// <param name="whereExpression">
        /// The where expression.
        /// </param>
        /// <param name="orderexpression">
        /// The orderexpression.
        /// </param>
        /// <param name="pageIndex">
        /// Index of the page.
        /// </param>
        /// <param name="pageSize">
        /// Size of the page.
        /// </param>
        /// <returns>
        /// List of entitis 
        /// </returns>
        Task<PagedList<T>> FindAsync<K>(
            Expression<Func<T, bool>> whereExpression,
            Expression<Func<T, K>> orderexpression,
            int? pageIndex,
            int pageSize);

        /// <summary>
        /// Finds the specified expression.
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="expression">The expression.</param>
        /// <param name="orderExpression">The order expression.</param>
        /// <param name="isOrderByDesc">if set to <c>true</c> [is order by desc].</param>
        /// <param name="pageIndex">Index of the page.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>Entities paged list</returns>
        Task<PagedList<T>> FindAsync<K>(
        Expression<Func<T, bool>> expression, Expression<Func<T, K>> orderExpression
        , bool isOrderByDesc, int? pageIndex, int pageSize);


        /// <summary>
        /// Finds the specified where expression
        /// </summary>
        /// <typeparam name="K">
        /// K is Key type of sort column  
        /// </typeparam>
        /// <param name="whereExpression">
        /// The where expression.
        /// </param>
        /// <param name="orderexpression">
        /// The orderexpression.
        /// </param>
        /// <param name="pageIndex">
        /// Index of the page.
        /// </param>
        /// <param name="pageSize">
        /// Size of the page.
        /// </param>
        /// <returns>
        /// List of entitis 
        /// </returns>
        PagedList<T> Find<K>(
            Expression<Func<T, bool>> whereExpression, 
            Expression<Func<T, K>> orderexpression, 
            int? pageIndex, 
            int pageSize);

	    /// <summary>
        /// Finds the specified where expression
        /// </summary>
        /// <typeparam name="K">
        /// K is Key type of sort column  
        /// </typeparam>
        /// <param name="whereExpression">
        /// The where expression.
        /// </param>
        /// <param name="orderexpression">
        /// The orderexpression.
        /// </param>
        /// <param name="pageIndex">
        /// Index of the page.
        /// </param>
        /// <param name="pageSize">
        /// Size of the page.
        /// </param>
        /// <returns>
        /// IEnumerable of entitis 
        /// </returns>
IEnumerable<T> Find<K>(
                Expression<Func<T, bool>> expression, Expression<Func<T, K>> orderExpression, bool isOrderByDesc
                );

		/// <summary>
        /// Finds the specified expression.
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="expression">The expression.</param>
        /// <param name="orderExpression">The order expression.</param>
        /// <param name="isOrderByDesc">if set to <c>true</c> [is order by desc].</param>
        /// <param name="pageIndex">Index of the page.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>Entities paged list</returns>
        PagedList<T> Find<K>(
                Expression<Func<T, bool>> expression, Expression<Func<T, K>> orderExpression
                , bool isOrderByDesc, int? pageIndex, int pageSize);

        /// <summary>
        /// Saves this instance.
        /// </summary>
        void Save();

		/// <summary>
        /// Saves with async.
        /// </summary>
        Task<int> SaveAsync();

        /// <summary>
        /// Singles the specified where.
        /// </summary>
        /// <param name="where">
        /// The where.
        /// </param>
        /// <returns>
        /// Single entity
        /// </returns>
        T Single(Expression<Func<T, bool>> where);

        #endregion
    }
}

