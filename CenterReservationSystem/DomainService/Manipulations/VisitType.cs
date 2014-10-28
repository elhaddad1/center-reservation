using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using CenterReservation.DL.Entity;
using CenterReservation.DL.DomainModel;
//using CenterReservation.BL.DataContract;


namespace CenterReservation.BL.Manipulations
{
    public class VisitType
    {
        public CenterReservationEntities _contextDatabase;
        public int VisitTypeID { get; set; }
        public string VisitTypeName { get; set; }
        public VisitType()
        {
            this._contextDatabase = new CenterReservationEntities();
        }

        public string addBDVisitType(VisitType _visitType)
        {
            try
            {
                var Query = _contextDatabase.BDVisitTypes.Where(a => a.VisitTypeID == _visitType.VisitTypeID).FirstOrDefault();
                if (Query != null)
                {
                    Query.VisitTypeName = _visitType.VisitTypeName;
                    _contextDatabase.SaveChanges();
                    return "Added sucsessfully";
                }
                else
                {
                    BDVisitType _bDVisitType = new BDVisitType();
                    _bDVisitType.VisitTypeName = _visitType.VisitTypeName;
                    _contextDatabase.BDVisitTypes.Add(_bDVisitType);
                    _contextDatabase.SaveChanges();
                    return "Edited succesfuy";
                }
            }
            catch (Exception ex)
            {
                return "Erorr on add";
                throw;
            }
        }

        public List<BDVisitType> SelectAllBDVisitType()
        {
            return _contextDatabase.BDVisitTypes.ToList();
        }

        public string deleteBDVisitType(VisitType _visitType)
        {
            try
            {
                var _bDvisitType = _contextDatabase.BDVisitTypes.Single(a => a.VisitTypeID == _visitType.VisitTypeID);
                _contextDatabase.BDVisitTypes.Remove(_bDvisitType);
                _contextDatabase.SaveChanges();
                return "Sucessfully deleted";
            }
            catch (Exception ex)
            {
                return "Error on delete";
            }
        }
    }
}
