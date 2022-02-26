using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting.Application.Wrappers
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
