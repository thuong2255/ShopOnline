﻿using System;
using System.Collections.Generic;
using TeduShop.Data.Infratructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;
using System.Linq;

namespace TeduShop.Service
{
    public interface IPostService
    {
        void Add(Post post);

        void Update(Post post);

        void Detete(int id);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);

        Post GetById(int id);

        IEnumerable<Post> GetAllbyTag(string tag, int pageIndex, int pageSize, out int totalRow);

        IEnumerable<Post> GetAllbyCategory(int categoryId, int pageIndex, int pageSize, out int totalRow);

        void SaveChanges();
    }

    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Detete(int id)
        {
            _postRepository.Detete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllbyCategory(int categoryId, int pageIndex, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status && x.CategoryID == categoryId, out totalRow, pageIndex, pageSize, new string[] { "PostCategory"});
        }

        public IEnumerable<Post> GetAllbyTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            return _postRepository.GetAllbyTag(tag, pageIndex, pageSize, out totalRow);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}