// <copyright file="Family.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.DefiningClasses.Person
{
    using System.Collections.Generic;

    /// <summary>
    /// Family Class for Defining Classes Exercise
    /// </summary>
    public class Family
    {
        /// <summary>
        /// List of Person objects
        /// </summary>
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

        /// <summary>
        /// Adds a member to the list of members
        /// </summary>
        /// <param name="member">List of members</param>
        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }

        /// <summary>
        /// Gets oldest member object
        /// </summary>
        /// <returns>Person object</returns>
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

        /// <summary>
        /// Gets members over 30 years old
        /// </summary>
        /// <returns>List of Person objects</returns>
        public List<Person> GetMembersOverThirty()
        {
            var membersOverThirty = new List<Person>();

            foreach (var member in this.Members)
            {
                if (member.Age >= 30)
                {
                    membersOverThirty.Add(member);
                }
            }

            return membersOverThirty;
        }
    }
}