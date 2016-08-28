﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using TcpUdpTool.Model.Data;

namespace TcpUdpTool.Model.Formatter
{
    public interface IFormatter
    {

        Paragraph Format(Piece msg, Encoding encoding = null);

    }
}
