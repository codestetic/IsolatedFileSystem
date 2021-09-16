using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Text;

namespace IsolatedFileSystem
{
    internal class Path : IPath
    {
        #region Fields

        private readonly string _rootFolderPath;
        private readonly IFileSystem _physicalFileSystem;
        private readonly IPath _physicalPath;

        #endregion

        #region .ctor

        public Path(string rootFolderPath, IFileSystem physicalFileSystem)
        {
            _rootFolderPath = rootFolderPath;
            _physicalFileSystem = physicalFileSystem;
            _physicalPath = physicalFileSystem.Path;
        }

        #endregion

        #region Implementation of IPath

        /// <inheritdoc />
        public string ChangeExtension(string path, string extension)
        {
            return _physicalPath.ChangeExtension(path, extension);
        }

        /// <inheritdoc />
        public string Combine(params string[] paths)
        {
            var rootedPaths = new List<string> { _rootFolderPath };
            rootedPaths.AddRange(paths);
            return _physicalPath.Combine(rootedPaths.ToArray());
        }

        /// <inheritdoc />
        public string Combine(string path1, string path2)
        {
            var rootedPaths = new List<string> { _rootFolderPath, path1, path2 };
            return _physicalPath.Combine(rootedPaths.ToArray());
        }

        /// <inheritdoc />
        public string Combine(string path1, string path2, string path3)
        {
            var rootedPaths = new List<string> { _rootFolderPath, path1, path2, path3 };
            return _physicalPath.Combine(rootedPaths.ToArray());
        }

        /// <inheritdoc />
        public string Combine(string path1, string path2, string path3, string path4)
        {
            var rootedPaths = new List<string> { _rootFolderPath, path1, path2, path3, path4 };
            return _physicalPath.Combine(rootedPaths.ToArray());
        }

        /// <inheritdoc />
        public string GetDirectoryName(string path)
        {
            return _physicalPath.GetDirectoryName(path);
        }

        /// <inheritdoc />
        public string GetExtension(string path)
        {
            return _physicalPath.GetExtension(path);
        }

        /// <inheritdoc />
        public string GetFileName(string path)
        {
            return _physicalPath.GetFileName(path);
        }

        /// <inheritdoc />
        public string GetFileNameWithoutExtension(string path)
        {
            return _physicalPath.GetFileNameWithoutExtension(path);
        }

        /// <inheritdoc />
        public string GetFullPath(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string GetFullPath(string path, string basePath)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public char[] GetInvalidFileNameChars()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public char[] GetInvalidPathChars()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string GetPathRoot(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string GetRandomFileName()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string GetTempFileName()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string GetTempPath()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool HasExtension(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool IsPathRooted(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool IsPathFullyQualified(string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string GetRelativePath(string relativeTo, string path)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, Span<char> destination, out int charsWritten)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, out int charsWritten)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public char AltDirectorySeparatorChar { get; }

        /// <inheritdoc />
        public char DirectorySeparatorChar { get; }

        /// <inheritdoc />
        public IFileSystem FileSystem { get; }

        /// <inheritdoc />
        public char PathSeparator { get; }

        /// <inheritdoc />
        public char VolumeSeparatorChar { get; }

        /// <inheritdoc />
        public char[] InvalidPathChars { get; }

        #endregion
    }
}
