using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace RickLocalization.Api.Extensions
{
    public static class ResponseCompressionExtension
    {
        public static void AddResponseCompressionExtension(this IServiceCollection services)
        {
            services.AddResponseCompression(options =>
            {
                options.EnableForHttps = true;
                options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] {
                               "image/svg+xml",
                               "application/atom+xml",
                               "x-font/otf",
                               "x-font/ttf",
                               "x-font/eot",
                               "x-font/woff",
                               "x-font/woff2",
                               "image/jpg",
                               "image/jpeg",
                               "image/x-icon",
                               "image/png",
                               "image/gif"
                            });
                options.Providers.Add<BrotliCompressionProvider>();
            });

            services.Configure<BrotliCompressionProviderOptions>(options => options.Level = System.IO.Compression.CompressionLevel.Optimal);

        }

        public static void UseResponseCompressionExtension(this IApplicationBuilder app)
        {
            app.UseResponseCompression();
        }
    }
}
