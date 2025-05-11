using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Clean_System {
    internal class CustomerClass {
        public string customerName {  get; set; }
        public long phoneNumber { get; set; }
        public int customerID { get; set; }
        public string customerCar {  get; set; }
        public CustomerClass() { } 
        public CustomerClass(string customerName, long phoneNumber, int customerID, string customerCar) {
            this.customerName = customerName;
            this.phoneNumber = phoneNumber;
            this.customerID = customerID;
            this.customerCar = customerCar;
        }
    }
}
