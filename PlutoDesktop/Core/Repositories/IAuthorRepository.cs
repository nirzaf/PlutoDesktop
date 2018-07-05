using PlutoDesktop.Core.Domain;

namespace PlutoDesktop.Core.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorWithCourses(int id);
    }
}