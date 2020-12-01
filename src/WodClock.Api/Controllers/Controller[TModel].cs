using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WodClock.Api.Abstractions;
using WodClock.Core.Abstractions;
using WodClock.Infrastructure.Abstractions;

namespace WodClock.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Controller<TModel> : IController<TModel>
        where TModel : class, IModel
    {
        private readonly IService<TModel> service;

        public Controller(IService<TModel> service) => this.service = service;

        [HttpDelete]
        public virtual void DeleteAsync(Guid id) => service.DeleteAsync(id);

        [HttpGet]
        public virtual IEnumerable<TModel> Get() => service.Get();


        [HttpGet("{id:guid}")]
        public virtual async Task<TModel> GetAsync(Guid id) => await service.GetAsync(id);

        [HttpPut]
        [HttpPatch]
        public virtual async Task<bool> SaveAsync(TModel model) => await service.SaveAsync(model);
    }
}
