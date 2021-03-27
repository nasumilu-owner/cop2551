using System;
using System.Collections.Generic;

namespace Project6
{
    /// <summary>
    /// Very simple service interface.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDataProvider<T>
    {

        /// <summary>
        /// Provides some data as a List.
        /// </summary>
        List<T> Data { get; }

    }
}
