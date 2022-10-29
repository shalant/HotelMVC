using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Services
{
    public interface IRoomTypeService
    {
        PagedResult<RoomTypeViewModel> GetAllRoomTypes(int pageNumber, int pageSize);
    }
}
