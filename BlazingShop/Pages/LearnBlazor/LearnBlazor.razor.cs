﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Pages.LearnBlazor
{
    public class LearnBlazorBase : ComponentBase
    {
        protected string name;
        protected string WelcomeText = "Time to learn Blazor!";

        protected void GetName()
        {
            name = "Blazor Learner";
        }
    }
}
