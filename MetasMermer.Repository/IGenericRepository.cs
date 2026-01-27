namespace MetasMermer.Repositories;

public interface IGenericRepository<T> where T: class
{
    /*
     Genellikle Repository patterni uygularken generic kısmında tüm crud işlemleri bulunur.
     Lakin bu projede ekleme ve silme sadece admin panelinde galeri sayfasında olduğu eklenmemesi gerektiğine kanaat ettim.
     */

    IQueryable<T> GetAll(bool isChangeTrackerActive);//Projede 3 kısımda kullanılıyor o yüzden burada olmasını uygun gördüm.

    ValueTask<T> GetByIdAsync(int id);

    void Update(T entity);//Admin Panelinde tüm sayfalarda kullanıldığı için generic kısmına ekledim.
}
