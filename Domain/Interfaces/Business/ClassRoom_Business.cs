using Domain.Business;
using Domain.Entities;
using Domain.Interfaces.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Business
{
    public class ClassRoom_Business : IClassRoom_Business
    {
        private readonly ILogger _logger;
        private readonly IClassRoomDAL _classRoomDAL;

        public ClassRoom_Business(ILogger logger, IClassRoomDAL classRoomDAL)
        {
            _logger = logger;
            _classRoomDAL = classRoomDAL;
        }

        public void RegisterClassRoom(ClassRoom classRoom)
        {
            try
            {
                _classRoomDAL.RegisterClass(classRoom);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error RegisterClassRoom: {ex}");
            } 
        }

        public List<ClassRoom> ListClassRooms(School school)
        {
            return _classRoomDAL.ListClass();
        }
    }
}
