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
   public  class Patient
    {
          public CenterReservationEntities _contextDatabase;

          public Patient()
        {
            this._contextDatabase = new CenterReservationEntities();
        }

        public string addACPatient(ACPatient patient)
        {
            try
            {
                var Query = _contextDatabase.ACPatients.Where(a => a.PatientID == patient.PatientID).FirstOrDefault();
                if (Query != null)
                {
                    Query.PatientName = patient.PatientName;
                    Query.DOB = patient.DOB;
                    Query.Phone = patient.Phone;
                    Query .Mobile= patient .Mobile ;
                    Query .Address=patient.Address ;
                    Query .Notes= patient .Notes ;
                    _contextDatabase.SaveChanges();
                    return "تم الحفظ بنجاح";
                }
                else
                {
                    ACPatient _bDPatient = new ACPatient();
                    _bDPatient.PatientName = patient.PatientName;
                    _bDPatient.DOB = patient.DOB;
                    _bDPatient.Phone = patient.Phone;
                    _bDPatient.Mobile = patient.Mobile;
                    _bDPatient.Address = patient.Address;
                    _bDPatient.Notes = patient.Notes;
                    _contextDatabase.ACPatients.Add(_bDPatient);
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

        public List<ACPatient > SelectAllBDPatient()
        {
            return _contextDatabase.ACPatients.ToList();
        }
        public ACPatient SelectPatientByID(int patientID)
        {
            return _contextDatabase.ACPatients.Where (p=>p.PatientID == patientID).FirstOrDefault() ;
        }
        public string deleteDBPhysician(int patientID)
        {
            try
            {
                var _bDPatient = _contextDatabase.ACPatients.Single(a => a.PatientID == patientID);
                _contextDatabase.ACPatients.Remove(_bDPatient);
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
