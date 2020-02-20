using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterDesignPattern
{
    class SocketAdapterImplementation : SocketAdapterInterface
    {
        Socket socket = new Socket();
        public Volt Get120Volts()
        {
          return socket.GetVolt();
        }

        public Volt Get12Volts()
        {
            Volt volt = socket.GetVolt();
            return ConvertVolts(volt, 10);
        }

        public Volt Get3Volts()
        {
            Volt volt = socket.GetVolt();
            return ConvertVolts(volt, 40);
        }
        public Volt ConvertVolts(Volt volt, int i)
        {
            return new Volt(volt.GetVolts() / i);
        }
    }
}
