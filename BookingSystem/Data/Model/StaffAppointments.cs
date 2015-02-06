using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class StaffAppointments
    {
        public int StaffId { get; set; }

        public int TreatmentId { get; set; }

        public virtual StaffModel Staff { get; set; }

        public virtual TreatmentModel Treatment { get; set; }

    }
}
