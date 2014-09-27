using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using CenterReservation.DL.Entity;
using CenterReservation.DL.DomainModel;
namespace CenterReservation.BL.Manipulations
{
    class Physician
    {


        private CenterReservationEntities _contextDatabase;

        Physician()
        {
            this._contextDatabase = new CenterReservationEntities();
        }

        public BDPhysician addBDPhysician(BDPhysician _bDPhysician)
        {
            return _contextDatabase.BDPhysicians.Add(_bDPhysician);
        }

    }

}
