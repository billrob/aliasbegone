using System;

namespace Brage.AliasBeGone.Infrastructure
{
    public interface IMap
    {
        /// <summary>
        ///     Contains the alias to convert from
        /// </summary>
        String Alias { get; }

        /// <summary>
        ///     Contains the alias to convert too
        /// </summary>
        String ClrType { get; }
    }
}