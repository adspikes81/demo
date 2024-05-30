using demoDomainLayer.Entities;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace demo.Pages
{
    public partial class TestBase : ComponentBase
    {     
        protected override void OnInitialized()
        {
            PopulateIndexViewModel();
        }
   
        public IndexViewModel Tract;

        public int selectedGroup = 1;
        public int selectedLeaseId = 0;

        public void PopulateIndexViewModel() {

            Tract = new IndexViewModel {

                TractId = "TX001-001",
                TotalAcreage = 152.54683521,
                isActive = false,
                Location = "Texas",
                Leases = new List<TractLeaseConnection> {
                    
                    new TractLeaseConnection { 
                        TractLeaseConnectionId = 1,
                        TractId = "TX001-001-01", 
                        LeaseId = "TX001-ABC-001",
                        Location = "TX"
                    },
                     
                    new TractLeaseConnection {
                        TractLeaseConnectionId = 2,
                        TractId = "TX001-001-02", 
                        LeaseId = "TX001-ABC-001",
                        Location = "TX"
                    },
                     
                    new TractLeaseConnection {
                        TractLeaseConnectionId = 3,
                        TractId = "TX001-001-03", 
                        LeaseId = "TX001-ABC-001",
                        Location = "TX"
                    }
                }
            };
        }    

        //// TODO: FIX TABLE TO ALLOW MODEL TO FOR OTHER ACREAGE TYPES
        //public List<TractLeaseConnection> TractLeaseAcreage { get; set; }
        //public double TotalAcreage => TractLeaseAcreage.Sum(TractLeaseAcreage => TractLeaseAcreage.);
    }
}
