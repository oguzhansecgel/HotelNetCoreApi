﻿using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomservice;
        private readonly IMapper _mapper;

        public Room2Controller(IRoomService roomservice, IMapper mapper)
        {
            _roomservice = roomservice;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _roomservice.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult addRoom(RoomAddDto roomAddDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(roomAddDto);
            _roomservice.TInsert(values);
 

            return Ok();
        }

        [HttpPut]
        public IActionResult updateRoom(UpdateRoomDto updateRoomDto)
        {
            if(!ModelState.IsValid) 
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(updateRoomDto);
            _roomservice.TUpdate(values);
            return Ok("Başarıyla Güncellendi");
        }
    }
}
