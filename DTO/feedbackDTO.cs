using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class feedbackDTO
    {
        public int feedbackId { get; set; }
        public int? flatUserId { get; set; }
        public System.DateTime? dateComing { get; set; }
        public string text { get; set; }
        public static feedbackDTO ToDtofeedback(DAL.feedback t)
        {

            return new feedbackDTO()
            {
                feedbackId = t.feedbackId,
                flatUserId = t.flatUserId,
                dateComing = t.dateComing,
                text = t.text
            };
        }
        public static DAL.feedback ToDalfeedback(feedbackDTO t)
        {

            return new DAL.feedback()
            {
                feedbackId = t.feedbackId,
                flatUserId = t.flatUserId,
                dateComing = t.dateComing,
                text = t.text
            };


        }
    }
}
