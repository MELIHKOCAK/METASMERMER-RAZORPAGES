using Mapster;
using MetasMermer.Repositories;
using MetasMermer.Repositories.EFCORE.Galleries;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace MetasMermer.Services.Galleries;

public class GalleryService(IGalleryRepository _repository, IUnitOfWork _unitOfWork) : IGalleryService
{
    public void Add(Gallery gallery)
    {
        _repository.Add(gallery);
        _unitOfWork.SaveChangeAsync();
    }

    public async Task Add(IFormFile Photo)
    {
        var fileName = $"{Guid.NewGuid()}{Path.GetExtension(Photo.FileName)}";
        var uploadFolder = @".\wwwroot\img\gallery";

        var filePath = Path.Combine(uploadFolder, fileName);
        using var stream = new FileStream(filePath, FileMode.Create);
        await Photo.CopyToAsync(stream);

        var gallery = new Gallery { ImageLink = filePath };

        await _repository.Add(gallery);
        await _unitOfWork.SaveChangeAsync();
    }

    public async Task Delete(int id)
    {
        var gallery = await _repository.GetByIdAsync(id);
        _repository.Delete(gallery.Id);
        await _unitOfWork.SaveChangeAsync();
    }

    public async Task<List<GalleryDto>> GetAll()
    {
        var galleryList = await _repository.GetAll(false).ToListAsync();

        return galleryList.Adapt<List<GalleryDto>>();
    }
}
