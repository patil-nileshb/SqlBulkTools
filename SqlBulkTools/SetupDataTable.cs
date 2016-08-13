﻿using System.Collections.Generic;

namespace SqlBulkTools
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SetupDataTable<T>
    {
        private readonly BulkOperations _ext;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ext"></param>
        public SetupDataTable(BulkOperations ext)
        {
            _ext = ext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public DataTableColumns<T> ForCollection(IEnumerable<T> list)
        {
            return new DataTableColumns<T>(list, _ext);
        }
    }
}