using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Clean_System {
    internal class StaffClass {
        public string name {  get; set; } 
        public long staffID {  get; set; }
        public decimal salary {  get; set; }
        public decimal bonus {  get; set; }
        public DateTime hireDate { get; set; }
        public string password { get; set; }
        public int isManager { get; set; }
        public StaffClass() { }

        public StaffClass(string name, long staffID, string Password) {
            this.name = name;
            this.staffID = staffID;
            this.password = Password;
            this.isManager = 1;
        }
    }
}
