using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Clean_System {
    internal class OrderPage {
        public string employeeName {  get; set; }
        public string customerName { get; set; }
        public long customerPhone { get; set; }
        public string carName {  get; set; }
        public long employeeID;
        public decimal cost { get; set; }
        public decimal discount {  get; set; }
        public decimal totalCost {  get; set; }
        public string ServiceName { get; set; }
        public void calculateTotal() {
            totalCost = cost - cost * discount / 100;
        }
    }
}
