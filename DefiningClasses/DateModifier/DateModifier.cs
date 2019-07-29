// <copyright file="DateModifier.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.DefiningClasses.DateModifier
{
    using System;
    using System.Globalization;
    using System.Linq;

    /// <summary>
    /// Date Modifier Class for Defining Classes Exercise
    /// </summary>
    public class DateModifier
    {
        /// <summary>
        /// First date
        /// </summary>
        private string firstDate;

        /// <summary>
        /// Second date
        /// </summary>
        private string secondDate;

        /// <summary>
        /// Initializes a new instance of the DateModifier class with default firstDate and secondDate.
        /// </summary>
        public DateModifier()
        {
            this.FirstDate = "0001 01 01";
            this.SecondDate = "1990 01 01";
        }

        /// <summary>
        /// Initializes a new instance of the DateModifier class with user defined firstDate and secondDate.
        /// </summary>
        /// <param name="firstDate">First date</param>
        /// <param name="secondDate">Second date</param>
        public DateModifier(string firstDate, string secondDate)
        {
            this.FirstDate = firstDate;
            this.SecondDate = secondDate;
        }

        /// <summary>
        /// Gets or sets first date
        /// </summary>
        public string FirstDate
        {
            get => this.firstDate;
            set
            {
                Func<string, bool> isNumber = x => x.All(char.IsDigit);

                if (value.Split().Length != 3)
                {
                    throw new ArgumentException("Invalid input date format. Eg: 1990 01 31");
                }

                string year = value.Split()[0];
                string month = value.Split()[1];
                string day = value.Split()[2];

                if (year.Length != 4
                    || month.Length != 2
                    || day.Length != 2
                    || !isNumber(year)
                    || !isNumber(month)
                    || !isNumber(day)
                    || int.Parse(year) <= 0
                    || int.Parse(month) <= 0 
                    || int.Parse(month) > 12
                    || int.Parse(day) <= 0 
                    || int.Parse(day) > 31)
                {
                    throw new ArgumentException("Invalid input date format. Eg: 1990 01 31");
                }

                this.firstDate = value;
            }
        }

        /// <summary>
        /// Gets or sets second date
        /// </summary>
        public string SecondDate
        {
            get => this.secondDate;
            set
            {
                Func<string, bool> isNumber = x => x.All(char.IsDigit);

                if (value.Split().Length != 3)
                {
                    throw new ArgumentException("Invalid input date format. Eg: 1990 01 31");
                }

                string year = value.Split()[0];
                string month = value.Split()[1];
                string day = value.Split()[2];

                if (year.Length != 4
                    || month.Length != 2
                    || day.Length != 2
                    || !isNumber(year)
                    || !isNumber(month)
                    || !isNumber(day)
                    || int.Parse(year) <= 0
                    || int.Parse(month) <= 0
                    || int.Parse(month) > 12
                    || int.Parse(day) <= 0
                    || int.Parse(day) > 31)
                {
                    throw new ArgumentException("Invalid input date format. Eg: 1990 01 31");
                }

                this.secondDate = value;
            }
        }

        /// <summary>
        /// Returns the difference between two first and second date.
        /// </summary>
        /// <returns>Double number</returns>
        public double DaysDifference()
        {
            var startDate = DateTime.ParseExact(this.FirstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(this.SecondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

            return Math.Abs((endDate - startDate).TotalDays);
        }
    }
}
