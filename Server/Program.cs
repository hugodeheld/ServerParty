﻿using System;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {

        static void Main(string[] args)
        {
            ConnectionManager c = new ConnectionManager();
            c.Start();
        }
    }
}
