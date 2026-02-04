using Mapster;
using MetasMermer.Repositories;
using MetasMermer.Repositories.EFCORE.Galleries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace MetasMermer.Services.Galleries;

public class GalleryService(IGalleryRepository _repository, IUnitOfWork _unitOfWork) : IGalleryService
{

    public async Task<string> Add(IFormFile Photo)
    {
        var fileName = $"{Guid.NewGuid()}{Path.GetExtension(Photo.FileName)}";
        var uploadFolder = @".\wwwroot\img\gallery";

        var filePath = Path.Combine(uploadFolder, fileName);
        using var stream = new FileStream(filePath, FileMode.Create);
        await Photo.CopyToAsync(stream);

        var gallery = new Gallery { ImageLink = "/img/gallery/" + fileName };

        await _repository.Add(gallery);
        await _unitOfWork.SaveChangeAsync();
        return gallery.ImageLink;

    }

    public async Task Delete(List<int> selectedPhotosIds)
    {
        // Checkboxlar boşsa Fast Fail
        if (selectedPhotosIds == null || !selectedPhotosIds.Any())
            return;

        foreach (var id in selectedPhotosIds)
        {
            var photo = await _repository.GetByIdAsync(id); // DB'den çek

            var dummyPhoto = photo.Adapt<Gallery>();
            if (dummyPhoto != null)
            {

                _repository.Delete(dummyPhoto.Id);
                await _unitOfWork.SaveChangeAsync();
            }
        }
    }

    public async Task<List<GalleryDto>> GetAll()
    {
        var galleryList = await _repository.GetAll(false).ToListAsync();

        return galleryList.Adapt<List<GalleryDto>>();
    }
}