using System;
namespace Egeroro.Entity.Concrete
{
	public class Fleet
	{
		public int Id { get; set; }
		public string ShipName { get; set; }
		public string Image { get; set; }
		public string Flag { get; set; }
		public string PortofRegistry { get; set; }
		public string PassengerCapacity { get; set; }
		public int GrossRegisterTonnage { get; set; }
		public int DeadweightTonnage { get; set; }
		public decimal OverallLength { get; set; }
		public decimal Beam { get; set; }
		public decimal MaxSpeed { get; set; }
		public string MainPageImage { get; set; }
		public Fleet()
		{
		}
	}
}

