namespace MetasMermer.Repositories.EFCORE.Contacts;

public interface IContactRepository : IGenericRepository<Contact>
{
    void UpdateList(List<Contact> entity);
}
