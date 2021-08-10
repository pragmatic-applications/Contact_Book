using System;
using System.Threading.Tasks;

using AppConfigSettings;

using Constants;

using DTOs;

using Extensions;

using Interfaces;

using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

using PageFeatures;

namespace Controllers
{
    public class ContactEntitiesController : ApiBaseController
    {
        public ContactEntitiesController(AppSettings options, IUnitOfWork unitOfWork) : base(options, unitOfWork)
        {
        }

        // POST: api/ContactEntities
        [HttpPost(Name = nameof(Post))]
        public async Task<ActionResult<ContactEntityDto>> Post([FromBody] ContactEntityDtoCreate model)
        {
            try
            {
                if(model == null)
                {
                    return this.BadRequest("Model is null");
                }

                if(!this.ModelState.IsValid)
                {
                    return this.BadRequest("Invalid Model");
                }

                var modelToCreate = model.Map();
                await this.UnitOfWork.ContactEntityRepository.PostRangeAsync(modelToCreate);
                await this.UnitOfWork.SaveChangesAsync();

                var createdModel = modelToCreate.MapDefault();

                return this.CreatedAtAction(nameof(GetDetail), new { id = createdModel.Id }, createdModel);
            }
            catch(Exception)
            {
                return this.StatusCode(500, "Internal server error");
            }
        }

        // GET: api/ContactEntities
        [HttpGet(Name = nameof(Get))]
        public async Task<ActionResult<PagedList<ContactEntityDto>>> Get([FromQuery] PagingEntity entityParameter)
        {
            try
            {
                var items = await this.UnitOfWork.ContactEntityRepository.GetPagedList(entityParameter);

                if(items is null)
                {
                    return this.NotFound();
                }

                this.Response.Headers.Add(HttpConstant.X_Pagination, JsonConvert.SerializeObject(items.PagerData));

                return this.Ok(items.Map());
            }
            catch(Exception)
            {
                return this.StatusCode(500, "Internal server error");
            }
        }

        // GET: api/ContactEntities/{id}
        [HttpGet("{id}", Name = nameof(GetDetail))]
        public async Task<ActionResult<ContactEntityDto>> GetDetail(int id)
        {
            try
            {
                var model = await this.UnitOfWork.ContactEntityRepository.GetAsync(id);

                return model is null ? this.NotFound() : this.Ok(model.Map());
            }
            catch(Exception)
            {
                return this.StatusCode(500, "Internal server error");
            }
        }

        // PUT: api/ContactEntities/{id}
        [HttpPut("{id}", Name = nameof(Put))]
        public async Task<ActionResult> Put(int id, [FromBody] ContactEntityDtoUpdate model)
        {
            try
            {
                if(model == null)
                {
                    return this.BadRequest("Model is null");
                }

                var modelToUpdate = await this.UnitOfWork.ContactEntityRepository.FindAsync(id);

                if(modelToUpdate is null)
                {
                    return this.NotFound();
                }

                if(string.IsNullOrWhiteSpace(model.ContactName))
                {

                    model.ContactName = modelToUpdate.ContactName;
                }
                if(string.IsNullOrWhiteSpace(model.FirstName))
                {
                    model.FirstName = modelToUpdate.FirstName;
                }
                if(string.IsNullOrWhiteSpace(model.LastName))
                {
                    model.LastName = modelToUpdate.LastName;
                }
                if(string.IsNullOrWhiteSpace(model.Email))
                {
                    model.Email = modelToUpdate.Email;
                }
                if(string.IsNullOrWhiteSpace(model.Phone))
                {
                    model.Phone = modelToUpdate.Phone;
                }
                if(string.IsNullOrWhiteSpace(model.Address))
                {
                    model.Address = modelToUpdate.Address;
                }
                if(string.IsNullOrWhiteSpace(model.Image))
                {
                    model.Image = modelToUpdate.Image;
                }
                if(model.IsChecked is null)
                {
                    model.IsChecked = modelToUpdate.IsChecked;
                }
                if(model.ContactEntityCategoryId is null)
                {
                    model.ContactEntityCategoryId = modelToUpdate.ContactEntityCategoryId;
                }

                await this.UnitOfWork.ContactEntityRepository.PutRangeAsync(model.Map(modelToUpdate));
                await this.UnitOfWork.SaveChangesAsync();

                return this.NoContent();
            }
            catch(Exception)
            {
                return this.StatusCode(500, "Internal server error");
            }
        }

        // DELETE: api/ContactEntities/{id}
        [HttpDelete("{id}", Name = nameof(Delete))]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var modelToDelete = await this.UnitOfWork.ContactEntityRepository.FindAsync(id);

                if(modelToDelete == null)
                {
                    return this.NotFound();
                }

                await this.UnitOfWork.ContactEntityRepository.DeleteRangeAsync(modelToDelete);
                await this.UnitOfWork.SaveChangesAsync();

                return this.NoContent();
            }
            catch(Exception)
            {
                return this.StatusCode(500, "Internal server error");
            }
        }
    }
}
