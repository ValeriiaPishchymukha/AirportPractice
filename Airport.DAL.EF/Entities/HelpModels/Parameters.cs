﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Entities.HelpModels
{
    public class Parameters
    {
        const int maxPageSize = 30;
        public int PageNumber { get; set; } = 1;

        private int _pageSize = 10;
        public int PageSize
        {
            get
            {
                return _pageSize;
            } 
            set
            {
                _pageSize = (value >  maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
