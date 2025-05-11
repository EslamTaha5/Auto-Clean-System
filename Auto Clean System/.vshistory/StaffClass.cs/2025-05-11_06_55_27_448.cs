using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Clean_System {
    public class StaffClass {
        public string name {  get; set; } 
        public long staffID {  get; set; }
        public int salary {  get; set; }
        public int bonus {  get; set; }
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
        public StaffClass(string name, long staffID, int salary, int bonus, DateTime hireDate, string password, int isManager) {
            this.name = name;
            this.staffID = staffID;
            this.salary = salary;
            this.bonus = bonus;
            this.hireDate = hireDate;
            this.password = password;
            this.isManager = isManager;
        }

        public override string ToString() {
            return $"Name: {name} " +
                $"ID : {staffID}" +
                $"Is Manager : {isManager}" +
                $"Password : {password}";
        }
    }
}
