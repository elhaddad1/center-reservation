using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using CenterReservation.DL.Entity;
using CenterReservation.DL.DomainModel;
using CenterReservation.BL.DataContract;
namespace CenterReservation.BL.Manipulations
{
    public class Physician
    {


        public CenterReservationEntities _contextDatabase;

        public Physician()
        {
            this._contextDatabase = new CenterReservationEntities();
        }

        public BDPhysician addBDPhysician(BDPhsycian Physician)
        {
            BDPhysician _bDPhysician = new BDPhysician();
            _bDPhysician.PhysicianName = Physician.PhysicianName;
            return _contextDatabase.BDPhysicians.Add(_bDPhysician);
        }

        public List<BDPhysician> SelectAllBDPhysician()
        {
            return _contextDatabase.BDPhysicians.ToList();
        }


    }

}
