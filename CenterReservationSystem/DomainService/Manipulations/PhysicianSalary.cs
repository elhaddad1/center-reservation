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
    public class PhysicianSalaryModel
    {

        private CenterReservationEntities _contextDatabase;

        public PhysicianSalaryModel()
        {
            this._contextDatabase = new CenterReservationEntities();
        }

        public BDPhysicianSalary Add(BDPhysicianSalary _bDPhysicianSalary)
        {
            return _contextDatabase.BDPhysicianSalaries.Add(_bDPhysicianSalary);
        }

        public IQueryable<BDPhysicianSalary> GetAll()
        {
            return _contextDatabase.BDPhysicianSalaries;
        }

        public IQueryable<BDPhysicianSalary> FindByPhysicianCode(int code)
        {
            return _contextDatabase.BDPhysicianSalaries.Where(a => a.PhysicianID == code).OrderBy(a => a.PhysicianPriceID);
        }


        public BDPhysicianSalary Find(int code)
        {
            return _contextDatabase.BDPhysicianSalaries.Find(code);
        }


    }

}
