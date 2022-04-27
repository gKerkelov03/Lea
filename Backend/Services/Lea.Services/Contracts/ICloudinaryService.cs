
using Lea.Common.Conventions;
using Microsoft.AspNetCore.Http;

namespace Lea.Services.Contracts;

public interface ICloudinaryService : ITransientService
{
    Task<string> UploadPictureAsync(IFormFile pictureFile, string fileName);
}
