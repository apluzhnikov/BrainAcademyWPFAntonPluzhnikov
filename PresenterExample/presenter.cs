using ModelExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresenterExample
{
    public class FlightsEventArgs : EventArgs
    {
        public IEnumerable<Flight> flights;
    }

    public class Presenter
    {
        IView _view;
        IAirportModel _airportModel;

        public Presenter(IView view) {
            _view = view;
            _airportModel = AirportModelFactory.CreateArportModel();
            _view.PopulateFlightsEventRaised += PopulateFlightsEventHandler;
            _view.DeleteFlightsEventRaised += DeleteFlightsEventRaised;
        }

        private void DeleteFlightsEventRaised(object sender, FlightsEventArgs e) {
            _view.UpdateFlights(null);
            _airportModel.Remove(e.flights);
            _view.UpdateFlights(_airportModel.flights);
        }

        private void PopulateFlightsEventHandler(object sender, EventArgs e) {
            _view.UpdateFlights(_airportModel.flights);
        }
    }
}
