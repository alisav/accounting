﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting.Application.Wrappers
{
    public class BaseResponse
    {
        public Guid Id { get; set; }

        public String Message { get; set; }

        public bool IsSuccess { get; set; } = true;
    }
}
