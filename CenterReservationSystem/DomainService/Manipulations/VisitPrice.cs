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
    public class VisitPriceModel
    {

        private CenterReservationEntities _contextDatabase;

        public VisitPriceModel()
        {
            this._contextDatabase = new CenterReservationEntities();
        }

        public BDVisitPrice VisitPriceSaveChange(BDVisitPrice _bDVisitPrice)
        {
            try
            {
                // BDVisitPrice operation add & edit

                var dbVisitPrice = _contextDatabase.BDVisitPrices.SingleOrDefault(s => s.VisitPriceID == _bDVisitPrice.VisitPriceID);
                if (dbVisitPrice != null)
                {
                    // Update BDVisitPrice
                    _contextDatabase.Entry(dbVisitPrice).CurrentValues.SetValues(_bDVisitPrice);
                    _contextDatabase.BDVisitPrices.Attach(dbVisitPrice);
                    _contextDatabase.SaveChanges();
                    return dbVisitPrice;
                }
                else
                {
                    // Insert BDVisitPrice into the database 
                    _contextDatabase.BDVisitPrices.Add(_bDVisitPrice);
                    _contextDatabase.SaveChanges();
                    return _bDVisitPrice;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;
        }


        public IQueryable<BDVisitPrice> FindByVisitPriceCode(int code)
        {
            return _contextDatabase.BDVisitPrices.Where(a => a.VisitTypeID == code).OrderBy(a => a.VisitPriceID);
        }

        public IQueryable<BDVisitPrice> GetAll()
        {
            return _contextDatabase.BDVisitPrices;
        }



        public BDVisitPrice Find(int code)
        {
            return _contextDatabase.BDVisitPrices.Find(code);
        }


        public bool Delete(int code)
        {
            try
            {
                // BDVisitPrice operation remove

                var dbVisitPrice = _contextDatabase.BDVisitPrices.SingleOrDefault(s => s.VisitPriceID == code);
                if (dbVisitPrice != null)
                {
                    _contextDatabase.BDVisitPrices.Remove(dbVisitPrice);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return false;
        }

        public bool ValidateVisitPrice(BDVisitPrice _bDVisitPrice)
        {
            try
            {
                var query = _contextDatabase.BDVisitPrices.AsQueryable();
                if (_bDVisitPrice.VisitPriceID != null && _bDVisitPrice.VisitPriceID > 0)
                    query = query.Where(a => a.VisitPriceID != _bDVisitPrice.VisitPriceID).AsQueryable();
                query = query.Where(a => a.VisitTypeID == _bDVisitPrice.VisitTypeID).AsQueryable();
                query = query.Where(a => (a.FromDate >= _bDVisitPrice.ToDate && a.ToDate <= _bDVisitPrice.ToDate) || (a.FromDate <= _bDVisitPrice.FromDate && a.ToDate >= _bDVisitPrice.FromDate)).AsQueryable();
                return !query.Any();
            }
            catch (Exception ex)
            {
                throw;
            }
            return false;
        }


    }

}
