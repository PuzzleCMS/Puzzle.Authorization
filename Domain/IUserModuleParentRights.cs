using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Core.Interfaces.Data
{
    /// <summary>
    /// Which rights the user should have for a specific module.
    /// </summary>
    public interface IUserModuleParentRights
    {
        /// <summary>
        /// Foreign key to <see cref="IUser"/>.
        /// </summary>
        public Guid UserID { get; }

        /// <summary>
        /// <see cref="Guid"/> of a specific module.
        /// </summary>
        public Guid ModuleID { get; }
    }
}
