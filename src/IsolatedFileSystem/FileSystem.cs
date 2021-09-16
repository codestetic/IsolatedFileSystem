using System;
using System.IO.Abstractions;
using System.Security.AccessControl;

namespace IsolatedFileSystem
{
    /// <summary>
    /// Implementation of <see cref="System.IO.Abstractions.IFileSystem"/>, that
    /// allows to lock file system within specified physical folder.
    /// </summary>
    public class FileSystem : IFileSystem
    {
        private readonly string _rootFolderPath;
        private readonly IFileSystem _physicalFileSystem = new System.IO.Abstractions.FileSystem();
        
        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="rootFolderPath">Root folder where file system will be locked</param>
        public FileSystem(string rootFolderPath)
        {
            if (string.IsNullOrWhiteSpace(_rootFolderPath))
            {
                throw new ArgumentException("Root folder was not specified.");
            }
            
            _rootFolderPath = rootFolderPath;
            
            if (!_physicalFileSystem.Directory.Exists(_rootFolderPath))
            {
                _physicalFileSystem.Directory.CreateDirectory(_rootFolderPath);
            }

            Path = new Path(_rootFolderPath, _physicalFileSystem);
        }

        #region Implementation of IFileSystem

        /// <inheritdoc />
        public IFile File { get; }

        /// <inheritdoc />
        public IDirectory Directory { get; }

        /// <inheritdoc />
        public IFileInfoFactory FileInfo { get; }

        /// <inheritdoc />
        public IFileStreamFactory FileStream { get; }

        /// <inheritdoc />
        public IPath Path { get; }

        /// <inheritdoc />
        public IDirectoryInfoFactory DirectoryInfo { get; }

        /// <inheritdoc />
        public IDriveInfoFactory DriveInfo { get; }

        /// <inheritdoc />
        public IFileSystemWatcherFactory FileSystemWatcher { get; }

        #endregion
    }
}
