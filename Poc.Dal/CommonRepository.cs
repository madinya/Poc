using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Poc.Dal.Interfaces;

namespace Poc.Dal;

public class CommonRepository<T> : ICommonRepository<T> where T : class
{
    private readonly PocDbContext _context;
    private readonly DbSet<T> _table;

    public CommonRepository(PocDbContext context)
    {
        _context = context;
        _table = _context.Set<T>();
    }

    public List<T> GetAll()
    {
        return _table.ToList();
    }

    public T Get(int id)
    {
        return _table.Find(id);
    }

    public void Insert(T item)
    {
        _table.Add(item);
    }

    public void Update(T item)
    {
        _table.Attach(item);
        _context.Entry(item).State = EntityState.Modified;
    }

    public void Delete(T item)
    {
        _table.Remove(item);
    }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
}