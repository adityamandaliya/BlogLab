using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace BlogLab.Services
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);

        public Task<DeletionResult> DeletePhotoAsync(string publicId);
    }
}
