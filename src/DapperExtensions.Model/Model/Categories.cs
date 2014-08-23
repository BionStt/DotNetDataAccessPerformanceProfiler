﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DapperExtensions.Model
{
    public class Categories
    {
        #region Constants and Fields

        /// <summary>
        /// The category name.
        /// </summary>
        private string categoryName = string.Empty;

        /// <summary>
        /// The description.
        /// </summary>
        private string description = string.Empty;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets CategoryID.
        /// </summary>
        public int CategoryID { get; set; }

        /// <summary>
        /// Gets or sets CategoryName.
        /// </summary>
        public string CategoryName
        {
            get
            {
                return this.categoryName;
            }

            set
            {
                this.categoryName = value;
            }
        }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.description = value;
            }
        }

        /// <summary>
        /// Gets or sets Picture.
        /// </summary>
        public byte[] Picture { get; set; }

        #endregion
    }
}
