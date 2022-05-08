using Common.Conventions;
using Microsoft.AspNetCore.Http;

namespace Business.Interfaces;

public interface ICloudinaryService : ITransientService
{
    Task<string> UploadPictureAsync(IFormFile pictureFile, string fileName);
}
