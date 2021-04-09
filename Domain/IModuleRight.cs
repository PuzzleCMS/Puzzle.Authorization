using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Core.Interfaces.Data
{
    public interface IModuleRight
    {
        /// <summary>
        /// <see cref="Guid"/> of a specific module.
        /// </summary>
        public Guid ModuleID { get; }

        /// <summary>
        /// If creation is allowed.
        /// </summary>
        public bool Create { get; }

        /// <summary>
        /// If insertion is allowed.
        /// </summary>
        public bool Insert { get; }

        /// <summary>
        /// If updating is allowed.
        /// </summary>
        public bool Update { get; }

        /// <summary>
        /// If deletion is allowed.
        /// </summary>
        public bool Delete { get; }
    }
}
