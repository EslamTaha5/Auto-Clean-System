using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Clean_System {
    internal class Merchant {
        public string name { get; set; }
        public int cost { get; set; }
        public long id { get; set; }
        public string dealName { get; set; }
        public DateTime time { get; set; }
        public Merchant() { }
        public Merchant(string name, string dealName, int cost, long id, DateTime time) {
            this.name = name;
            this.dealName = dealName;
            this.cost = cost;
            this.id = id;
            this.time = time;
        }
    }
}
