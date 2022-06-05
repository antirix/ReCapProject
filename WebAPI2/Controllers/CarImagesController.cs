using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WebAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImagesService _carImagesService;
        public CarImagesController(ICarImagesService carImagesService)
        {
            _carImagesService = carImagesService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImagesService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getcarimageid")]
        public IActionResult GetCarImageId(int id)
        {
            var result = _carImagesService.GetByCarImagesId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
       
        [HttpGet("getcarimageid")]
        public IActionResult GetByCarId(int id)
        {
            var result = _carImagesService.GetByCarImagesId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] int carId, [FromForm] IFormFile file)
        {
            var result = _carImagesService.Add(carId,file);
            if (result.Success)
            {
                return Ok(result);
            }
           return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update([FromForm] int id, [FromForm] IFormFile file)
        {
            var result = _carImagesService.Update(id,file);
            if (result.Success)
            {
                return Ok(result);
            }
           return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete([FromForm] int carId)
        {
            var result = _carImagesService.Delete(carId);
            if (result.Success)
            {
                return Ok(result);
            }
           return BadRequest(result);
        }



        //[HttpPost]
        //public async Task<string> UploderImage(IList<IFormFile> files)
        //{
        //    try
        //    {

        //        var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        //        var webRootPath = config["AppSettings:urunResimPath"].ToString();

        //        var filelist = files;
        //        var yeniisim = Guid.NewGuid().ToString();

        //        if (filelist.Count > 0)
        //        {
        //            foreach (var item in filelist)
        //            {
        //                string[] sn = item.FileName.Split('.');
        //                yeniisim = yeniisim + "." + sn[sn.Length - 1];
        //                var fileName = "Photos\\" + yeniisim;
        //                var fileContent = ContentDispositionHeaderValue.Parse(item.ContentDisposition);
        //                using (var fileStream = new FileStream(webRootPath + "\\" + fileName, FileMode.Create))
        //                {
        //                    await item.CopyToAsync(fileStream);
        //                }

        //            }
        //        }
        //        return yeniisim;
        //    }
        //    catch (Exception)
        //    {

        //        return null;
        //    }
        //}



    }
}
