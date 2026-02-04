using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetasMermer.Services.Galleries;

public interface IGalleryService
{
    Task<List<GalleryDto>> GetAll();
    Task<string> Add(IFormFile Photo);
    Task Delete(List<int> selectedPhotoIds);
}
