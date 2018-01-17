﻿using BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonPayModel
{
    public class Payment : Base
    {
        public int PaymentId { get; set; }

        public string DateOfPayment { get; set; }
        public decimal AmountReceived { get; set; }
    }
}