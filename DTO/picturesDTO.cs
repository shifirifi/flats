using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class picturesDTO
    {
        public int pictureId { get; set; }
        public int? flatId { get; set; }
        public string pathToFile { get; set; }

        public static picturesDTO ToDtopictures(DAL.picture t)
        {

            return new picturesDTO()
            {
                pictureId = t.pictureId,
                flatId = t.flatId,
                pathToFile = t.pathToFile
            };
        }
        public static DAL.picture ToDalpicture(picturesDTO t)
        {

            return new DAL.picture()
            {
                pictureId = t.pictureId,
                flatId = t.flatId,
                pathToFile = t.pathToFile
            };


        }
    }
}
