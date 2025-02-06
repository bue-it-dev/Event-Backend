using Event.EventModel;
using Event.Repository.Implementations;
using Event.Repository.Interfaces;

public class UnitOfWork : IUnitOfWork
{
    private readonly EventContext _context;
    private Dictionary<Type, object> _repositories;


    public IGenericRepository<ItcomponentEvent> ItcomponentEvent { get; private set; }


    public UnitOfWork(EventContext context)
    {
        _context = context;
        _repositories = new Dictionary<Type, object>();

        ItcomponentEvent = new GenericRepository<ItcomponentEvent>(_context, this);
    }

    public IGenericRepository<T> GetRepository<T>() where T : class
    {
        if (!_repositories.ContainsKey(typeof(T)))
        {
            var repositoryInstance = new GenericRepository<T>(_context, this);
            _repositories.Add(typeof(T), repositoryInstance);
        }

        return (IGenericRepository<T>)_repositories[typeof(T)];
    }


    public async Task<int> Save()
    {
        try {
            return await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

 
}
