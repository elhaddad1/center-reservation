using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenterReservation.DL.Entity;
using CenterReservation.DL.DomainModel;
namespace CenterReservation.BL.Manipulations
{
    public class Reservasion
    {
        public CenterReservationEntities _contextDatabase;

        #region DataProbirity

        public int VisitID { get; set; }

        public int PatientID { get; set; }

        public int PhysicianID { get; set; }
        public string PhysicianName { get; set; }
        public decimal PhysicianSalary { get; set; }

        public string VisitName { get; set; }
        public int VisitTypeID { get; set; }
        public decimal VisitPrice { get; set; }

        public DateTime VisitDate { get; set; }



        public decimal TotalVisitPrice { get; set; }
        public decimal PaiedPrice { get; set; }
        public decimal RestPrice { get; set; }

        public int VisitsCount { get; set; }

        public TimeSpan TimeFrom { get; set; }

        public TimeSpan TimeTo { get; set; }

        public string Notes { get; set; }
        #endregion

        public Reservasion()
        {
            this._contextDatabase = new CenterReservationEntities();
        }

        public List<ACPatient> GetPatinetByNameORByPhoneNumber(string _patinetName, string _phoneNumber)
        {
            try
            {
                List<ACPatient> Query = _contextDatabase.ACPatients.Where(a => a.PatientName.Contains(_patinetName) || a.Phone == _phoneNumber || a.Mobile == _phoneNumber).ToList();
                return Query;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Reservasion> GetAllReservationsByPatinetID(int _patientID)
        {
            try
            {
                var query = (from Trv in _contextDatabase.TRANVisits
                             join Ph in _contextDatabase.BDPhysicians on Trv.PhysicianID equals Ph.PhysicianID
                             join VType in _contextDatabase.BDVisitTypes on Trv.VisitTypeID equals VType.VisitTypeID
                             where Trv.PatientID == _patientID
                             select new Reservasion
                             {
                                 VisitID = Trv.VisitID,
                                 PhysicianID = Ph.PhysicianID,
                                 PhysicianName = Ph.PhysicianName,
                                 VisitName = VType.VisitTypeName,
                                 VisitDate = Trv.VisitDate,
                                 VisitPrice = Trv.VisitPrice + Trv.PhysicianSalary,
                                 TotalVisitPrice = Trv.TotalVisitPrice,
                                 VisitsCount = Trv.VisitsCount,
                                 TimeFrom = Trv.TimeFrom,
                                 TimeTo = Trv.TimeTo,
                                 Notes = Trv.Notes

                             }).ToList();
                return query;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Reservasion GetReservationByVisitID(int _visitID)
        {
            try
            {
                TRANVisit _tranVisit = _contextDatabase.TRANVisits.Where(a => a.VisitID == _visitID).SingleOrDefault();

                this.VisitID = _tranVisit.VisitID;
                this.PatientID = _tranVisit.PatientID;
                this.PhysicianID = _tranVisit.PhysicianID;
                this.PhysicianSalary = _tranVisit.PhysicianSalary;
                this.VisitTypeID = _tranVisit.VisitTypeID;
                this.VisitDate = _tranVisit.VisitDate;
                this.VisitPrice = _tranVisit.VisitPrice + _tranVisit.PhysicianSalary;
                this.TotalVisitPrice = _tranVisit.TotalVisitPrice;
                this.VisitsCount = _tranVisit.VisitsCount;
                this.TimeFrom = _tranVisit.TimeFrom;
                this.TimeTo = _tranVisit.TimeTo;
                this.Notes = _tranVisit.Notes;
                this.PaiedPrice = _tranVisit.Paiedprice;
                this.RestPrice = _tranVisit.RestPrice;

                return this;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool AddNewReservation(Reservasion _reservation)
        {
            try
            {
                TRANVisit tr = new TRANVisit();

                tr.PatientID = _reservation.PatientID;
                tr.PhysicianID = _reservation.PhysicianID;
                tr.VisitTypeID = _reservation.VisitTypeID;
                tr.VisitDate = _reservation.VisitDate;
                tr.TimeFrom = _reservation.TimeFrom;
                tr.TimeTo = _reservation.TimeTo;
                tr.VisitsCount = _reservation.VisitsCount;
                tr.VisitPrice = _reservation.VisitPrice;
                tr.PhysicianSalary = _reservation.PhysicianSalary;
                tr.Paiedprice = _reservation.PaiedPrice;
                tr.RestPrice = _reservation.RestPrice;
                tr.TotalVisitPrice = _reservation.TotalVisitPrice;
                tr.Notes = _reservation.Notes;

                _contextDatabase.TRANVisits.Add(tr);
                _contextDatabase.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool EditReservation(Reservasion _reservation)
        {
            try
            {
                TRANVisit tr = _contextDatabase.TRANVisits.Where(a => a.VisitID == _reservation.VisitID).SingleOrDefault();

                tr.PatientID = _reservation.PatientID;
                tr.PhysicianID = _reservation.PhysicianID;
                tr.VisitTypeID = _reservation.VisitTypeID;
                tr.VisitDate = _reservation.VisitDate;
                tr.TimeFrom = _reservation.TimeFrom;
                tr.TimeTo = _reservation.TimeTo;
                tr.VisitsCount = _reservation.VisitsCount;
                tr.VisitPrice = _reservation.VisitPrice;
                tr.PhysicianSalary = _reservation.PhysicianSalary;
                tr.Paiedprice = _reservation.PaiedPrice;
                tr.RestPrice = _reservation.RestPrice;
                tr.TotalVisitPrice = _reservation.TotalVisitPrice;
                tr.Notes = _reservation.Notes;
                _contextDatabase.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
