using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Clean_System {
    internal class ServiceClass {
        public string serviceName {  get; set; }
        public int serviceId { get; set; }
        public decimal serviceCost { get; set; }

        public ServiceClass() {
        }
        public ServiceClass(int serviceId, string serviceName, decimal serviceCost) {
            this.serviceId = serviceId;
            this.serviceName = serviceName;
            this.serviceCost = serviceCost;

        }

    }
}
