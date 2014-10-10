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

        public string addBDPhysician(BDPhsycian Physician)
        {
            try
            {
                var Query = _contextDatabase.BDPhysicians.Where(a => a.PhysicianID == Physician.PhysicianID).FirstOrDefault();
                if (Query != null)
                {
                    Query.PhysicianName = Physician.PhysicianName;
                    _contextDatabase.SaveChanges();
                    return "تم الحفظ بنجاح";
                }
                else
                {
                    BDPhysician _bDPhysician = new BDPhysician();
                    _bDPhysician.PhysicianName = Physician.PhysicianName;
                    _contextDatabase.BDPhysicians.Add(_bDPhysician);
                    _contextDatabase.SaveChanges();
                    return "تم الحفظ بنجاح";
                }
            }
            catch (Exception ex)
            {
                return "Erorr on save";
                throw;
            }
        }

        public List<BDPhysician> SelectAllBDPhysician()
        {
            return _contextDatabase.BDPhysicians.ToList();
        }

        public string deleteDBPhysician(BDPhsycian Physician)
        {
            try
            {
                var _bDPhysician = _contextDatabase.BDPhysicians.Single(a => a.PhysicianID == Physician.PhysicianID);
                _contextDatabase.BDPhysicians.Remove(_bDPhysician);
                _contextDatabase.SaveChanges();
                return "تم الحذف بنجاح";
            }
            catch (Exception ex)
            {
                return "Error on delete";
            }
        }


    }

}
