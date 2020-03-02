using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleJWTAuthMvcCoreWebAPI.Models
{
    public class Invoice
    {
        public string FactoryId { get; set; }
        public string PackingTypeId {get;set;}
        public string EFactoryName { get; set; }
        public string Mark { get; set; }
        public string MarkId { get; set; }
        public string InvoiceYear { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceDate { get; set; }
        public string NoOfChests { get; set; }
        public string NoOfCheststRecivied { get; set; }
        public string WeightPerChests { get; set; }
        public string GrossWeight { get; set; }
        public string NetWeight { get; set; }
        public string MfgDate { get; set; }
        public string IsRACertified { get; set; }
        public string GradeId { get; set; }
        public string CategoryId { get; set; }
        public string Remark { get; set; }

    }

    public class InvoiceContext
    {
        public Invoice Find(string InvoiceNo)
        {
            var invoices = Get();
            return invoices.Where(i => i.InvoiceNo.Equals(InvoiceNo)).SingleOrDefault();
        }

        public List<Invoice> Get()
        {
            return new List<Invoice>();
        }

        public void Add()
        { 

        }

        public void Edit() 
        { 

        }
    }
}
