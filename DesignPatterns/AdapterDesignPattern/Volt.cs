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
			this.volts = 240;
		}

		public Volt(int v)
		{
			this.volts = v;
		}

		public int getVolts()
		{
			return volts;
		}

		public void setVolts(int volts)
		{
			this.volts = volts;
		}

	}
}


