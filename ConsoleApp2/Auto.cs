using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Auto
    {
		private string _brand;

		public string Brand
		{
			get { return _brand; }
			set { _brand = value; }
		}

		private string _model;

		public string Model
		{
			get { return _model; }
			set { _model = value; }
		}

		private string _licensePlate;

		public string LicensePlate
		{
			get { return _licensePlate; }
			set { _licensePlate = value; }
		}

		public Auto(string merk, string nummerplaat)
		{
			Brand = merk;
			LicensePlate = nummerplaat; //1
			//_licensePlate = nummerplaat; //2
		}

		//....
	}
}
