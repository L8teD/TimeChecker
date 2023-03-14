﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeChecker.Model.Calendar
{
    public class ModelMonth
    {
        private List<ModelDay> _days;
        
        private Months _month;

        public Months Month => _month;

        public List<ModelDay> Days => _days;

        public ModelMonth(int monthNumber)
        {
             Enum.TryParse(Enum.GetName(typeof(Months), monthNumber - 1), out _month); 

            _days = new List<ModelDay>();
        }

        public void AddDay(TypeOfDay type, DateTime date) => _days.Add(new ModelDay(type, date.Day, date.Month));
        
    }
}
