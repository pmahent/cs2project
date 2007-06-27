using System.IO;
using CS2.Model;
using Directory=Lucene.Net.Store.Directory;

namespace CS2.Services.Indexing
{
    public interface IIndexingService
    {
        /// <summary>
        /// The directory where the index is located.
        /// </summary>
        Directory IndexDirectory { get; }

        bool IsWaitingForFilesToBeIndexed
        {
            get;
        }

        /// <summary>
        /// Requests the indexing of the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        void RequestIndexing(FileInfo file);

        /// <summary>
        /// Requests the indexing of the specified directory, optionally using recursion and looking for files which match the supplied pattern.
        /// </summary>
        /// <param name="directory">The directory.</param>
        /// <param name="searchOption">The search option.</param>
        /// <param name="searchPattern">The search pattern.</param>
        void RequestIndexing(DirectoryInfo directory, SearchOption searchOption, string searchPattern);

        /// <summary>
        /// Requests the indexing of the specified directory, optionally using recursion and looking for files of the specified language.
        /// </summary>
        /// <param name="directory">The directory.</param>
        /// <param name="searchOption">The search option.</param>
        /// <param name="language">The language.</param>
        void RequestIndexing(DirectoryInfo directory, SearchOption searchOption, IProgrammingLanguage language);

        /// <summary>
        /// Requests the indexing of all the files contained in the specified directory, optionally using recursion.
        /// </summary>
        /// <param name="directory">The directory.</param>
        /// <param name="searchOption">The search option.</param>
        void RequestIndexing(DirectoryInfo directory, SearchOption searchOption);

        /// <summary>
        /// Requests the indexing of all the files contained in the specified directory and all its subdirectories.
        /// </summary>
        /// <param name="directory">The directory.</param>
        void RequestIndexing(DirectoryInfo directory);

        /// <summary>
        /// Triggers update operations on the index, removing no longer existing documents, updating changed documents and adding new documents which have been explicitly required to be indexed.
        /// </summary>
        void UpdateIndex();
    }
}