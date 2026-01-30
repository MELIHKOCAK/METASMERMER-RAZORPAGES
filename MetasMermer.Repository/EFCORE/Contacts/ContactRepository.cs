using MetasMermer.Repositories.EFCORE;

namespace MetasMermer.Repositories.EFCORE.Contacts;

public class ContactRepository(MetasMermerDbContext context) : GenericRepository<Contact>(context), IContactRepository
{
    public void UpdateList(List<Contact> entity)
    {
        foreach (var item in entity)
            context.Set<Contact>().Update(item);
    }
}
