using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCartService _service;
        public ShoppingCartController(IShoppingCartService service)
        {
            _service = service;
        }

        //GetAll
        public ActionResult<IEnumerable<ShoppingItem>> Get()
        {
            var items = _service.GetAll();
            if(items == null)
            {
                return NotFound();
            }
            return Ok(items);
        }


        //Get
        [HttpGet(Name ="id")]
        public ActionResult Get(Guid id)
        {
            var item = _service.GetShoppingItemById(id);
            if(item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }


        //Post
        [HttpPost]
        public ActionResult<ShoppingItem> Post([FromBody] ShoppingItem newItem)
        {
            if(ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var addedItem = _service.Add(newItem);
            return CreatedAtAction("Get", new { id = addedItem.ID },addedItem);
        }


        //Remove
        public ActionResult Remove(Guid id)
        {
            var item = _service.GetShoppingItemById(id);
            if( item == null)
            {
                return NotFound();
            }
            _service.Remove(id);
            return Ok();
        }
    }
}