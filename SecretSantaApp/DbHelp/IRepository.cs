using System.Security.Cryptography;

namespace SecretSantaApp.DbHelp
{
    public interface IRepository<T>
        where T : User
    {

        public T Create(T entity);
        public List<T> ReadAll();
        public T ReadById(int id);
        public T Update(T entity);
        public T Delete(T entity);
        public T DeleteById(int id);
        public bool IsExists(int id);

    }
}
