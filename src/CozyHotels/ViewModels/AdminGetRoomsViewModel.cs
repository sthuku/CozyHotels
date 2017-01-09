using CozyHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyHotels.ViewModels
{
    public class AdminGetRoomsViewModel
    {
        private IEnumerable<Room> _rooms;
        private IEnumerable<RoomType> _roomTypes;

        public AdminGetRoomsViewModel(IEnumerable<Room> rooms, IEnumerable<RoomType> roomTypes)
        {
            _rooms = rooms;
            _roomTypes = roomTypes;
        }

        public IEnumerable<Room> Rooms()
        {
            return _rooms;
        }

        public RoomType GetRoomType(int id)
        {
            return _roomTypes.Single(q => q.RoomTypeId == id);
        }
    }
}
