﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Views
{
    public interface IMainView
    {

        event EventHandler ShowLoginForm;
        event EventHandler ShowRegisterForm;
    }
}
