﻿using System;
using System.Reflection;

namespace lageant.Utils
{
    /// <summary>
    ///     Helper class to show retrieve the application version.
    /// </summary>
    public static class VersionUtilities
    {
        /// <summary>
        ///     Get the current Application version.
        /// </summary>
        public static string PublishVersion
        {
            get
            {
                try
                {
                    var version = Assembly.GetExecutingAssembly().GetName().Version;
                    return string.Format("{0}.{1}.{2}", version.Major, version.Minor, version.Build);
                }
                catch (FormatException)
                {
                    return "0";
                }
                catch (ArgumentNullException)
                {
                    return "0";
                }
            }
        }
    }
}