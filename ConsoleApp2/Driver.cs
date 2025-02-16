using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Driver
    {
		private string _naam;

		public string Naam
		{
			get { return _naam; }
			set { _naam = value; }
		}

		private int _leeftijd;

		public int Leeftijd
		{
			get { return _leeftijd; }
			set { _leeftijd = value; }
		}

		private int _schoenmaat;

		public int Schoenmaat
		{
			get { return _schoenmaat; }
			set { _schoenmaat = value; }
		}

		private Auto _mijnAuto;

		public Auto MijnAuto
		{
			get { return _mijnAuto; }
			set { _mijnAuto = value; }
		}

		public Driver(string naam, int leeftijd, string autoMerk, string nummerplaat)
        {
			_naam = naam;
			_leeftijd = leeftijd;
			_mijnAuto = new Auto(autoMerk, nummerplaat);
        }

        public override string ToString()
        {
			return $"Driver {Naam.ToUpper()} drives {MijnAuto.Brand}";
        }
    }
}
