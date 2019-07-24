// <copyright file="Family.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.DefiningClasses.Person
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Family Class for Definig Classes Exercise
    /// </summary>
    public class Family
    {
        private List<Person> members = new List<Person>();
        /// <summary>
        /// Gets or sets family person
        /// </summary>
        public List<Person> Members
        {
            get => this.members;

            set
            {
                this.members = new List<Person>(value);
            }
        }

        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }

        public Person GetOldestMember()
        {
            var oldestMember = new Person();

            foreach (var member in this.Members)
            {
                if (member.Age >= oldestMember.Age)
                {
                    oldestMember = member;
                }
            }

            return oldestMember;
        }
    }
}