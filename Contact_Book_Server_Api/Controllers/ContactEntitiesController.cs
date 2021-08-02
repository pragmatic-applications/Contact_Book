using System.Collections.Generic;
using System.Threading.Tasks;
using System;

using DTOs;

using Extensions;

using Interfaces;

using Microsoft.AspNetCore.Mvc;
using AppConfigSettings;
using Constants;
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
        [HttpPost]
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
                await this.UnitOfWork.ContactEntityRepository.PostAsync(modelToCreate);
                await this.UnitOfWork.SaveChangesAsync();

                var createdModel = modelToCreate.Map();

                return this.CreatedAtAction(nameof(Get), new { id = createdModel.Id }, createdModel);
            }
            catch(Exception ex)
            {
                return this.StatusCode(500, "Internal server error");
            }
        }

        //nn
        // GET: api/ContactEntities
        [HttpGet]
        public async Task<ActionResult<PagedList<ContactEntityDto>>> Get([FromQuery] PagingEntity entityParameter)
        {
            //var items = await this.UnitOfWork.ContactEntityRepository.GetPagedList(entityParameter);

            //if(items is null)
            //{
            //    return this.NotFound();
            //}

            //this.Response.Headers.Add(HttpConstant.X_Pagination, JsonConvert.SerializeObject(items.PagerData));

            //return this.Ok(items.MapList());


            try
            {
                var items = await this.UnitOfWork.ContactEntityRepository.GetPagedList(entityParameter);

                if(items is null)
                {
                    return this.NotFound();
                }

                this.Response.Headers.Add(HttpConstant.X_Pagination, JsonConvert.SerializeObject(items.PagerData));

                return this.Ok(items.MapList());
            }
            catch(Exception ex)
            {
                return this.StatusCode(500, "Internal server error");
            }
        }
        //nn

        //// Orig
        //// GET: api/ContactEntities
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<ContactEntityDto>>> Get()
        //{
        //    try
        //    {
        //        var models = await this.UnitOfWork.ContactEntityRepository.GetAllAsync();

        //        return models is null ? this.NotFound() : this.Ok(models.MapList());

        //    }
        //    catch(Exception ex)
        //    {
        //        return this.StatusCode(500, "Internal server error");
        //    }
        //}

        // GET: api/ContactEntities/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactEntityDto>> Get(int id)
        {
            try
            {
                var model = await this.UnitOfWork.ContactEntityRepository.GetAsync(id);

                return model is null ? this.NotFound() : this.Ok(model.Map());
            }
            catch(Exception ex)
            {
                return this.StatusCode(500, "Internal server error");
            }
        }

        // S Orig using class
        // PUT: api/ContactEntities/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ContactEntityDtoUpdate model)
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

                var modelToUpdate = await this.UnitOfWork.ContactEntityRepository.GetAsync(id);

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

                this.UnitOfWork.ContactEntityRepository.Put(model.Map(modelToUpdate));
                await this.UnitOfWork.SaveChangesAsync();

                return this.NoContent();
            }
            catch(Exception ex)
            {
                return this.StatusCode(500, "Internal server error");
            }
        }
        // E Orig using class

        // DELETE: api/ContactEntities/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var modelToDelete = await this.UnitOfWork.ContactEntityRepository.GetAsync(id);

                if(modelToDelete == null)
                {
                    return this.NotFound();
                }

                this.UnitOfWork.ContactEntityRepository.Delete(modelToDelete);
                await this.UnitOfWork.SaveChangesAsync();

                return this.NoContent();
            }
            catch(Exception ex)
            {
                return this.StatusCode(500, "Internal server error");
            }
        }
    }
}
