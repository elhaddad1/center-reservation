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

        public void addBDPhysician(BDPhsycian Physician)
        {
            var Query = _contextDatabase.BDPhysicians.Where(a => a.PhysicianID == Physician.PhysicianID).First();
            if (Query != null)
            {
                Query.PhysicianName = Physician.PhysicianName;
                _contextDatabase.SaveChanges();
            }
            else
            {
                BDPhysician _bDPhysician = new BDPhysician();
                _bDPhysician.PhysicianName = Physician.PhysicianName;
                _contextDatabase.BDPhysicians.Add(_bDPhysician);
                _contextDatabase.SaveChanges();
            }
        }

        public List<BDPhysician> SelectAllBDPhysician()
        {
            return _contextDatabase.BDPhysicians.ToList();
        }

        //  public 


    }

}
