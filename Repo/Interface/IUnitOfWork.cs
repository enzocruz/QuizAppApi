


namespace Repo.Interfaces{
public interface IUnitOfWork
{
        
    void CreateTransaction();
    void Commit();
    void Rollback();
    void Save();
}
}