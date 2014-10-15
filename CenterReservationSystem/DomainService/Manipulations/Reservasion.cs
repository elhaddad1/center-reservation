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

        public Reservasion()
        {
            this._contextDatabase = new CenterReservationEntities();
        }

        public List<ACPatient> GetPatinetByNameORByPhoneNumber(string _patinetName, string _phoneNumber)
        {
            List<ACPatient> Query = _contextDatabase.ACPatients.Where(a => a.PatientName.Contains(_patinetName) || a.Phone == _phoneNumber).ToList();
            return Query;
        }
    }
}
