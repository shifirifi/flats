using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class flatsDTO
    {
        public int flatId { get; set; }
        public string adress { get; set; }
        public double? longtitude { get; set; }
        public double? latitude { get; set; }
        public int? numBeds { get; set; }
        public int? numRooms { get; set; }
        public int? numFloor { get; set; }
        public double? price { get; set; }
        public int? flatOwnerId { get; set; }
        public static flatsDTO ToDtoFlat(DAL.flat t)
        {

            return new flatsDTO()
            {
                flatId = t.flatId,
                adress=t.adress,
                longtitude = t.longtitude,
                latitude = t.latitude,
                numBeds = t.numBeds,
                numRooms = t.numRooms,
                numFloor = t.numFloor,
                price = t.price,
                flatOwnerId = t.flatOwnerId
            };
        }
        public static DAL.flat ToDalFlat(flatsDTO t)
        {

            return new DAL.flat()
            {
                flatId = t.flatId,
                adress = t.adress,
                longtitude = t.longtitude,
                latitude = t.latitude,
                numBeds = t.numBeds,
                numRooms = t.numRooms,
                numFloor = t.numFloor,
                price = t.price,
                flatOwnerId = t.flatOwnerId
            };


        }
    }
}
