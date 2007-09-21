using System.Collections.Generic;
using Lucene.Net.Highlight;

namespace CS2.Core.Searching
{
    public interface ISearchService
    {
        /// <summary>
        /// Gets or sets the formatter.
        /// </summary>
        /// <value>The formatter.</value>
        Formatter Formatter { get; set; }

        /// <summary>
        /// Gets or sets the fragmenter.
        /// </summary>
        /// <value>The fragmenter.</value>
        Fragmenter Fragmenter { get; set; }

        /// <summary>
        /// Gets or sets the encoder.
        /// </summary>
        /// <value>The encoder.</value>
        Encoder Encoder { get; set; }

        /// <summary>
        /// Searches for a query using a with query parser and returning
        /// results with a snippet containing highlighted terms.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>An iterator containing the results of the search.</returns>
        IEnumerable<SearchResult> SearchWithQueryParser(string query);
    }
}