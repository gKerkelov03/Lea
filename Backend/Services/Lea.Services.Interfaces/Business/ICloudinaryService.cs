using Lea.Common.Conventions;
using Microsoft.AspNetCore.Http;

namespace Lea.Services.Interfaces.Business; 

public interface ICloudinaryService : ITransientService
{
    Task<string> UploadPictureAsync(IFormFile pictureFile, string fileName);
}
