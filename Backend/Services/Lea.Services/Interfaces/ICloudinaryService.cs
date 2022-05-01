using Lea.Common.Conventions;
using Microsoft.AspNetCore.Http;

namespace Lea.Services.Interfaces;

public interface ICloudinaryService : ITransientService
{
    Task<string> UploadPictureAsync(IFormFile pictureFile, string fileName);
}
