﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App.Application.Wrappers
{
    public class PagedResponse<T>: ServiceResponse<T>
    {

        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public PagedResponse(T value, int pageSize, int pageNumber): base(value)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
        }
    }
}
