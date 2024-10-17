﻿using Microsoft.AspNetCore.Authorization;
using System.Runtime.CompilerServices;

namespace SpendSmart.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public string? Description { get; set; }
    }
}
