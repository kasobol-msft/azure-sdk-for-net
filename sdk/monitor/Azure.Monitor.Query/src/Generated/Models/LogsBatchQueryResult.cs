// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Contains the tables, columns &amp; rows resulting from a query. </summary>
    public partial class LogsBatchQueryResult : LogsQueryResult
    {
        /// <summary> Initializes a new instance of LogsBatchQueryResult. </summary>
        /// <param name="tables"> The list of tables, columns and rows. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tables"/> is null. </exception>
        internal LogsBatchQueryResult(IEnumerable<LogsQueryResultTable> tables) : base(tables)
        {
            if (tables == null)
            {
                throw new ArgumentNullException(nameof(tables));
            }
        }

        /// <summary> Initializes a new instance of LogsBatchQueryResult. </summary>
        /// <param name="tables"> The list of tables, columns and rows. </param>
        /// <param name="Statistics"> Any object. </param>
        /// <param name="Visualization"> Any object. </param>
        /// <param name="Error"> Any object. </param>
        internal LogsBatchQueryResult(IReadOnlyList<LogsQueryResultTable> tables, JsonElement Statistics, JsonElement Visualization, JsonElement Error) : base(tables, Statistics, Visualization, Error)
        {
        }
    }
}
