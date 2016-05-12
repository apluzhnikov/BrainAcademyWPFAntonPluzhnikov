using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelExample
{
    class AirportModel : IAirportModel
    {
        List<Flight> _flights;

        public IEnumerable<Flight> flights => _flights;

        public AirportModel() {
            _flights = new List<Flight>
            {
                new Flight {ID=1, City="London", Number="1111", Type=true },
                new Flight {ID=2, City="Kiev", Number="2222", Type=false },
                new Flight {ID=3, City="Berlin", Number="3333", Type=true },
                new Flight {ID=4, City="New York", Number="4444", Type=false }
            };
        }
    }

}
