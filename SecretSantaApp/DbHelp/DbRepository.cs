using System.Security.Cryptography;
using System;

namespace SecretSantaApp.DbHelp
{
    public class DbRepository<T> : IRepository<T>
        where T : User
    {
        protected readonly UserContext Ctx;

        public DbRepository(UserContext ctx)
        {
            Ctx = ctx;
        }

        public T Create(T entity)
        {
            if (Ctx.Set<T>() == null)
            {
                return null;
            }

            var a = Ctx.Set<T>().Add(entity);
            Ctx.SaveChanges();

            return a.Entity;
        }

        public List<T> ReadAll()
        {
            if (Ctx.Set<T>() == null)
            {
                return null;
            }

            var list = Ctx.Set<T>().ToList();

            return list;
        }

        public T ReadById(int id)
        {
            if (Ctx.Set<T>() == null)
            {
                return null;
            }

            var entity = Ctx.Set<T>().FirstOrDefault(en => en.UserId.Equals(id));
            return entity;
        }

        public T Update(T entity)
        {
            if (Ctx.Set<T>() == null)
            {
                return null;
            }

            var a = Ctx.Set<T>().Update(entity);
            Ctx.SaveChanges();

            return a.Entity;
        }

        public T Delete(T entity)
        {
            if (Ctx.Set<T>() == null)
            {
                return null;
            }

            Ctx.Set<T>().Remove(entity);

            Ctx.SaveChanges();

            return entity;
        }

        public T DeleteById(int id)
        {
            var entity = ReadById(id);
            Ctx.Set<T>().Remove(entity);

            Ctx.SaveChanges();

            return entity;
        }

        public bool IsExists(int id)
        {
            return Ctx.Set<T>().Any(entity => entity.UserId.Equals(id));
        }

    }
}
