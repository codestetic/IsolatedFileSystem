using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Abstractions;
using System.Security.AccessControl;
using System.Text;

namespace IsolatedFileSystem
{
    class Directory : IDirectory
    {
        private readonly IFileSystem _physicalFileSystem;

        public Directory(IFileSystem physicalFileSystem)
        {
            _physicalFileSystem = physicalFileSystem;
        }

        #region Implementation of IDirectory

        /// <inheritdoc />
        public IDirectoryInfo CreateDirectory(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IDirectoryInfo CreateDirectory(string path, DirectorySecurity directorySecurity)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Delete(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Delete(string path, bool recursive)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool Exists(string path)
        {
            var physicalPath = _physicalFileSystem.Path.Combine()
            return _physicalFileSystem.Directory.Exists()
        }

        /// <inheritdoc />
        public DirectorySecurity GetAccessControl(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public DateTime GetCreationTime(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public DateTime GetCreationTimeUtc(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string GetCurrentDirectory()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string[] GetDirectories(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string[] GetDirectories(string path, string searchPattern)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string GetDirectoryRoot(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string[] GetFiles(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string[] GetFiles(string path, string searchPattern)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string[] GetFileSystemEntries(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string[] GetFileSystemEntries(string path, string searchPattern)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public DateTime GetLastAccessTime(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public DateTime GetLastAccessTimeUtc(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public DateTime GetLastWriteTime(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public DateTime GetLastWriteTimeUtc(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string[] GetLogicalDrives()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IDirectoryInfo GetParent(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Move(string sourceDirName, string destDirName)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void SetAccessControl(string path, DirectorySecurity directorySecurity)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void SetCreationTime(string path, DateTime creationTime)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void SetCurrentDirectory(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateDirectories(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateFiles(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateFiles(string path, string searchPattern)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateFileSystemEntries(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IFileSystem FileSystem { get; }

        #endregion
    }
}
