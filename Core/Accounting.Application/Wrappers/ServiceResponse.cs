using System;
using System.Collections.Generic;
using System.Text;

namespace App.Application.Wrappers
{
    public class ServiceResponse<T>: BaseResponse
    {
        public T Value { get; set; }

        public ServiceResponse(T value)
        {
            Value = value;
        }
    }
}
