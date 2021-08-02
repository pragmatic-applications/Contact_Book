using System.Collections.Generic;
using System.Threading.Tasks;
using System;

using DTOs;

using Extensions;

using Interfaces;

using Microsoft.AspNetCore.Mvc;
using AppConfigSettings;

namespace Controllers
{
    public class ContactEntityCategoriesController : ApiBaseController
    {
        public ContactEntityCategoriesController(AppSettings options, IUnitOfWork unitOfWork) : base(options, unitOfWork)
        {
        }

        // POST: api/ContactEntityCategories
        [HttpPost]
        public async Task<ActionResult<ContactEntityCategoryDto>> Post([FromBody] ContactEntityCategoryDtoCreate model)
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
                await this.UnitOfWork.ContactEntityCategoryRepository.PostAsync(modelToCreate);
                await this.UnitOfWork.SaveChangesAsync();

                var createdModel = modelToCreate.Map();

                return this.CreatedAtAction(nameof(Get), new { id = createdModel.Id }, createdModel);
            }
            catch(Exception ex)
            {
                return this.StatusCode(500, "Internal server error");
            }
        }

        // GET: api/ContactEntityCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactEntityCategoryDto>>> Get()
        {
            try
            {
                var models = await this.UnitOfWork.ContactEntityCategoryRepository.GetAsync();

                return models is null ? this.NotFound() : this.Ok(models.MapList());

            }
            catch(Exception ex)
            {
                return this.StatusCode(500, "Internal server error");
            }
        }

        // GET: api/ContactEntityCategories/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactEntityCategoryDto>> Get(int id)
        {
            try
            {
                var model = await this.UnitOfWork.ContactEntityCategoryRepository.GetAsync(id);

                return model is null ? this.NotFound() : this.Ok(model.Map());
            }
            catch(Exception ex)
            {
                return this.StatusCode(500, "Internal server error");
            }
        }

        // PUT: api/ContactEntityCategories/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ContactEntityCategoryDtoUpdate model)
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

                var modelToUpdate = await this.UnitOfWork.ContactEntityCategoryRepository.GetAsync(id);

                if(modelToUpdate is null)
                {
                    return this.NotFound();
                }

                if(string.IsNullOrWhiteSpace(model.Name))
                {
                    model.Name = modelToUpdate.Name;
                }

                this.UnitOfWork.ContactEntityCategoryRepository.Put(model.Map(modelToUpdate));
                await this.UnitOfWork.SaveChangesAsync();

                return this.NoContent();
            }
            catch(Exception ex)
            {
                return this.StatusCode(500, "Internal server error");
            }
        }

        // DELETE: api/ContactEntityCategories/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var modelToDelete = await this.UnitOfWork.ContactEntityCategoryRepository.GetAsync(id);

                if(modelToDelete == null)
                {
                    return this.NotFound();
                }

                this.UnitOfWork.ContactEntityCategoryRepository.Delete(modelToDelete);
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
