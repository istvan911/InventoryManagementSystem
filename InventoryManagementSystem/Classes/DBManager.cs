    using InventoryManagementSystem.Classes;
using InventoryManagementSystem.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Manager
{
    internal class DBManager
    {
        // Comment 1
        Adatbazis AB = new Adatbazis();
        public void ABmentesHandler(String Tablanev)
        {
            AB.SaveChanges();
        }
        public DBManager()
        {
            FormCustomers FC = new FormCustomers();
            FC.SaveEvent += this.ABmentesHandler;

            FormProducts FP = new FormProducts();
            FP.SaveEvent += this.ABmentesHandler;

            FormCategories FCA = new FormCategories();
            FCA.SaveEvent += this.ABmentesHandler;

            FormOrders FO = new FormOrders();
            FO.SaveEvent += this.ABmentesHandler;

            FormUsers FU = new FormUsers();
            FU.SaveEvent += this.ABmentesHandler;

            FormOrderDGV FOR = new FormOrderDGV();
            FOR.SaveEvent += this.ABmentesHandler;

        }
    }
}
