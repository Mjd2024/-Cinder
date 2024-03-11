
using Microsoft.OpenApi.Extensions;
using Swashbuckle.AspNetCore.Swagger;

namespace _Cinder;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
public static class SwaggerExtensions
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static void SaveSwaggerYaml(this IServiceProvider provider)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
    ISwaggerProvider sw = provider.GetRequiredService<ISwaggerProvider>();
    var doc = sw.GetSwagger("v1", null, "/");
    var swaggerFile = doc.SerializeAsYaml(Microsoft.OpenApi.OpenApiSpecVersion.OpenApi3_0);
    File.WriteAllText("swaggerfile.yaml", swaggerFile);
  }

}
