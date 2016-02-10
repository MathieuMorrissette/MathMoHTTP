﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpServer.websites.mathieu_morrissette.controllers
{
    class Home : IController
    {
        public bool HandleRequest(Client client, params string[] args)
        {
            if (!client.Connected)
            {
                client.Redirect("../login");
                return true;
            }

            client.Send(File.ReadAllText(WebSite.WEBSITE_ROOT_PATH + "html/home.html"));

            return true;
        }
    }
}