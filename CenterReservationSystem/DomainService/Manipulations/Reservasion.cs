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

        public int PhysicianID { get; set; }

        public string PhysicianName { get; set; }

        public string VisitName { get; set; }

        public string VisitDate { get; set; }

        public string VisitPrice { get; set; }

        public string TotalVisitPrice { get; set; }

        public string VisitsCount { get; set; }

        public string TimeFrom { get; set; }

        public string TimeTo { get; set; }

        public string Notes { get; set; }
        #endregion

        public Reservasion()
        {
            this._contextDatabase = new CenterReservationEntities();
        }

        public List<ACPatient> GetPatinetByNameORByPhoneNumber(string _patinetName, string _phoneNumber)
        {
            List<ACPatient> Query = _contextDatabase.ACPatients.Where(a => a.PatientName.Contains(_patinetName) || a.Phone == _phoneNumber || a.Mobile == _phoneNumber).ToList();
            return Query;
        }

        public List<Reservasion> GetAllReservationsByPatinetID(int _patientID)
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
                             VisitDate = Trv.VisitDate.ToString(),
                             VisitPrice = (Trv.VisitPrice + Trv.PhysicianSalary).ToString(),
                             TotalVisitPrice = Trv.TotalVisitPrice.ToString(),
                             VisitsCount = Trv.VisitsCount.ToString(),
                             TimeFrom = Trv.TimeFrom.Hour.ToString(),
                             TimeTo = Trv.TimeTo.Hour.ToString(),
                             Notes = Trv.Notes

                         }).ToList();
            return query;
        }
    }
}
