using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Pages
{
    public  class CounterBase : ComponentBase
    {
        protected int currentCount = 0;

        protected bool UseIncrementParameter;

        protected int parameterAmount = 1;

        [Parameter]
        public int IncrementAmount
        {
            get
            {
                if (UseIncrementParameter)
                    return parameterAmount;
                return 1;
            }
            set
            {
                parameterAmount = value;
            }
        }

        protected void IncrementCount()
        {
            currentCount += IncrementAmount;
        }

        protected override void OnInitialized()
        {
            parameterAmount *= 1000;
            base.OnInitialized();
        }
    }
}
