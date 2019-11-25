using Microsoft.Extensions.Configuration;

namespace MediaBrowser.Controller.Extensions
{
    /// <summary>
    /// Configuration extensions for <c>MediaBrowser.Controller</c>.
    /// </summary>
    public static class ConfigurationExtensions
    {
        /// <summary>
        /// The key for the FFmpeg probe size option.
        /// </summary>
        public const string FfmpegProbeSizeKey = "FFmpeg_probesize";

        /// <summary>
        /// The key for the FFmpeg analyse duration option.
        /// </summary>
        public const string FfmpegAnalyzeDurationKey = "FFmpeg_analyzeduration";

        /// <summary>
        /// Retrieves the FFmpeg probe size from the <see cref="IConfiguration" />.
        /// </summary>
        /// <param name="configuration">This configuration.</param>
        /// <returns>The FFmpeg probe size option.</returns>
        public static string GetProbeSize(this IConfiguration configuration)
            => configuration[FfmpegProbeSizeKey];

        /// <summary>
        /// Retrieves the FFmpeg analyse duration from the <see cref="IConfiguration" />.
        /// </summary>
        /// <param name="configuration">This configuration.</param>
        /// <returns>The FFmpeg analyse duration option.</returns>
        public static string GetAnalyzeDuration(this IConfiguration configuration)
            => configuration[FfmpegAnalyzeDurationKey];
    }
}
