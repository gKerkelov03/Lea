
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace Services;

public class CloudinaryService : ICloudinaryService
{
    private readonly Cloudinary cloudinaryUtility;

    public CloudinaryService(Cloudinary cloudinaryUtility)
        => this.cloudinaryUtility = cloudinaryUtility;


    public async Task<string> UploadPictureAsync(IFormFile pictureFile, string fileName)
    {
        byte[] destinationData;

        using (var ms = new MemoryStream())
        {
            await pictureFile.CopyToAsync(ms);
            destinationData = ms.ToArray();
        }

        UploadResult uploadResult = null;

        using (var ms = new MemoryStream(destinationData))
        {
            ImageUploadParams uploadParams = new ImageUploadParams
            {
                Folder = "MusicX",
                File = new FileDescription(fileName, ms)
            };

            uploadResult = cloudinaryUtility.Upload(uploadParams);
        }

        return uploadResult?.SecureUrl.AbsoluteUri;
    }
}
