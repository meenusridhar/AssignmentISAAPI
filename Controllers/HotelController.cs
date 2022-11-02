using AssignmentISAAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssignmentISAAPI.Model;
using Microsoft.AspNetCore.Authorization;

namespace AssignmentISAAPI.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class HotelController : Controller
    {
        private readonly HotelDbContext hotelDbContext;

        public HotelController(HotelDbContext hotelDbContext)
        {
            this.hotelDbContext = hotelDbContext;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public async Task<List<HotelDetail>> GetHotels()
        {
            try
            {

                var hotels = await hotelDbContext.HotelDetails.ToListAsync();
                return hotels;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        [HttpPost]
        [Route("/{Id}")]
        public async Task<HotelDetail> GetHotelById(int Id)
        {
            try
            {
                var hotel = await hotelDbContext.HotelDetails.FirstOrDefaultAsync(x => x.HotelCode == Id);
                return hotel;
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
