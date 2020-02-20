namespace DesignPatterns.AdapterDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
	public class Volt
	{

		private int volts;
		public Volt()
		{
			this.volts = 120;
		}

		public Volt(int v)
		{
			this.volts = v;
		}

		public int GetVolts()
		{
			return volts;
		}

		public void SetVolts(int volts)
		{
			this.volts = volts;
		}

	}
}


