using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterDesignPattern
{
      public class Socket
        {
            public Volt volts;

            /// <summary>
            /// Initializes a new instance of the <see cref="Socket"/> class.
            /// </summary>
            public Socket()
            {
                volts = new Volt();
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="Socket"/> class.
            /// </summary>
            /// <param name="volt">The volt.</param>
            public Socket(int volt)
            {
                volts = new Volt(volt);
            }

            /// <summary>
            /// returs the volts
            /// </summary>
            /// <returns></returns>
            public Volt GetSocket()
            {
                return this.volts;
            }
        }
}
