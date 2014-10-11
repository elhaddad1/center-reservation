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

        public BDPhysicianSalary PhysicianSalarySaveChange(BDPhysicianSalary _bDPhysicianSalary)
        {
            try
            {
                // BDPhysicianSalary operation add & edit

                var dbPhysicianSalary = _contextDatabase.BDPhysicianSalaries.SingleOrDefault(s => s.PhysicianPriceID == _bDPhysicianSalary.PhysicianPriceID);
                if (dbPhysicianSalary != null)
                {
                    // Update BDPhysicianSalary
                    _contextDatabase.Entry(dbPhysicianSalary).CurrentValues.SetValues(_bDPhysicianSalary);
                    _contextDatabase.BDPhysicianSalaries.Attach(dbPhysicianSalary);
                    return dbPhysicianSalary;
                }
                else
                {
                    // Insert BDPhysicianSalary into the database 
                    _contextDatabase.BDPhysicianSalaries.Add(_bDPhysicianSalary);
                    return _bDPhysicianSalary;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;
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


        public bool Delete(int code)
        {
            try
            {
                // BDPhysicianSalary operation remove

                var dbPhysicianSalary = _contextDatabase.BDPhysicianSalaries.SingleOrDefault(s => s.PhysicianPriceID == code);
                if (dbPhysicianSalary != null)
                {
                    _contextDatabase.BDPhysicianSalaries.Remove(dbPhysicianSalary);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return false;
        }


    }

}
