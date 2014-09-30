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
    public class PhysicianSalary
    {


        public CenterReservationEntities _contextDatabase;

        public PhysicianSalary()
        {
            this._contextDatabase = new CenterReservationEntities();
        }

        public BDPhysicianSalary Add(BDPhsycian PhysicianSalary)
        {
            BDPhysicianSalary _bDPhysicianSalary = new BDPhysicianSalary();
            return _contextDatabase.BDPhysicianSalaries.Add(_bDPhysicianSalary);
        }

        public IQueryable<BDPhysicianSalary> GetAll()
        {
            return _contextDatabase.BDPhysicianSalaries;
        }

        public BDPhysicianSalary Find(params object[] keyValues)
        {
            return _contextDatabase.BDPhysicianSalaries.Find(keyValues);
        }


    }

}
