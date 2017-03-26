using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Model.Models;
using TeduShop.Service;
using TeduShop.Web.Infrastructure.Core;
using AutoMapper;
using System.Collections.Generic;
using TeduShop.Web.Models;
using TeduShop.Web.Infrastructure.Extensions;

namespace TeduShop.Web.API
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        private IPostCategoryService _postCategoryService;

        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) :
            base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage requestMessage, PostCategoryViewModel postCategoryVm)
        {
            return CreateHttpResponse(requestMessage, () =>
            {
                HttpResponseMessage responseMessage = null;
                if (ModelState.IsValid)
                {
                    requestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    PostCategory newPostCategory = new PostCategory();
                    newPostCategory.UpdatePostCategory(postCategoryVm);
                    var category = _postCategoryService.Add(newPostCategory);
                    _postCategoryService.Save();
                    responseMessage = requestMessage.CreateResponse(HttpStatusCode.Created, category);
                }

                return responseMessage;
            });
        }

        public HttpResponseMessage Put(HttpRequestMessage requestMessage, PostCategoryViewModel postCategoryVm)
        {
            return CreateHttpResponse(requestMessage, () =>
            {
                HttpResponseMessage responseMessage = null;
                if (ModelState.IsValid)
                {
                    requestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var postCategoryDb = _postCategoryService.GetById(postCategoryVm.ID);
                    postCategoryDb.UpdatePostCategory(postCategoryVm);
                    _postCategoryService.Update(postCategoryDb);
                    _postCategoryService.Save();
                    responseMessage = requestMessage.CreateResponse(HttpStatusCode.OK);
                }

                return responseMessage;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage requestMessage, int id)
        {
            return CreateHttpResponse(requestMessage, () =>
            {
                HttpResponseMessage responseMessage = null;
                if (ModelState.IsValid)
                {
                    requestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Delete(id);
                    _postCategoryService.Save();
                    responseMessage = requestMessage.CreateResponse(HttpStatusCode.Created);
                }

                return responseMessage;
            });
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listPostCategory = _postCategoryService.GetAll();
                var listPostCategoryVm = Mapper.Map<List<PostCategoryViewModel>>(listPostCategory);

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listPostCategoryVm);

                return response;
            });
        }
    }
}