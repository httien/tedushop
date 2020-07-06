using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Respositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);
        IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow);
        Post GetById(int id);
        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totaRow);
        void SaveChanges();
    }
    public class PostService : IPostService
    {
        IPostRepository _postReposity;
        IUnitOfWork _unitOfwork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postReposity = postRepository;
            this._unitOfwork = unitOfWork;
        }

        public void Add(Post post)
        {
            _postReposity.Add(post);
        }

        public void Delete(int id)
        {
            _postReposity.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postReposity.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow)
        {
            return _postReposity.GetMultiPaging(x => x.Status && x.CategoryID == categoryId, out totalRow, page, pageSize, new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            // TODO: Select all post tag
            return _postReposity.GetAllByTag(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postReposity.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Post GetById(int id)
        {
            return _postReposity.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfwork.Commit();
        }

        public void Update(Post post)
        {
            _postReposity.Update(post);
        }
    }
}
