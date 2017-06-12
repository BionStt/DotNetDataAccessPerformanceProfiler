﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPagedList.cs" company="Megadotnet">
//   Copyright (c) 2010-2011 Petter Liu.  All rights reserved. 
// </copyright>
// <summary>
//   The i paged list.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Runtime.Serialization;
namespace IronFramework.Utility.UI
{
    /// <summary>
    /// The i paged list.
    /// </summary>
    public interface IPagedList
    {
        #region Properties

        /// <summary>
        /// Gets a value indicating whether IsNextPage.
        /// </summary>
        bool IsNextPage { get; }

        /// <summary>
        /// Gets a value indicating whether IsPreviousPage.
        /// </summary>
        bool IsPreviousPage { get; }

        /// <summary>
        /// Gets or sets PageIndex.
        /// </summary>
         [DataMember]
        int PageIndex { get; set; }

        /// <summary>
        /// Gets or sets PageSize.
        /// </summary>
        [DataMember]
        int PageSize { get; set; }

        /// <summary>
        /// Gets or sets TotalCount.
        /// </summary>
         [DataMember]
        int TotalCount { get; set; }

        /// <summary>
         /// Just for Serializable JSON data by JSON.net
        /// </summary>
         /// <returns>IPagedList</returns>
        /// <see cref="http://stackoverflow.com/questions/10870618/newtonsoft-json-serialization-of-pagedlistt-is-not-including-some-properties"/>
        IPagedList GetMetaData();

        #endregion
    }
}