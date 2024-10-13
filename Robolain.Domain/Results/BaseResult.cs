﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robolain.Domain.Results
{
    public class BaseResult
    {
        public bool IsSuccess => ErrorMessage == null;

        public string ErrorMessage { get; set; }

        public int ErrorCode { get; set; }

        public string Message { get; set; }

    }

    public class BaseResult<T> : BaseResult
    {
        public T Data { get; set; }
    }
}
