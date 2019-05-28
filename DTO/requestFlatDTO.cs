using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class requestFlatDTO
    {
        public int requestId { get; set; }
        public int? flatId { get; set; }
        public int? userRequestId { get; set; }
        public System.DateTime? fromDate { get; set; }
        public System.DateTime? untilDate { get; set; }
        public System.DateTime? dateRequest { get; set; }
        public bool? isOK { get; set; }
        public int? numPoeple { get; set; }
        public int? numChildren { get; set; }
        public string commands { get; set; }
        public bool? isMeal { get; set; }

        public static requestFlatDTO ToDtorequestFlat(DAL.requestFlat t)
        {

            return new requestFlatDTO()
            {
                requestId = t.requestId,
                flatId = t.flatId,
                userRequestId = t.userRequestId,
                fromDate = t.fromDate,
                untilDate = t.untilDate,
                dateRequest = t.dateRequest,
                isOK = t.isOK,
                numPoeple = t.numPoeple,
                numChildren = t.numChildren,
                commands = t.commands,
                isMeal = t.isMeal
            };
        }
        public static DAL.requestFlat ToDalrequestFlat(requestFlatDTO t)
        {

            return new DAL.requestFlat()
            {
                requestId = t.requestId,
                flatId = t.flatId,
                userRequestId = t.userRequestId,
                fromDate = t.fromDate,
                untilDate = t.untilDate,
                dateRequest = t.dateRequest,
                isOK = t.isOK,
                numPoeple = t.numPoeple,
                numChildren = t.numChildren,
                commands = t.commands,
                isMeal = t.isMeal
            };


        }
    }
}
