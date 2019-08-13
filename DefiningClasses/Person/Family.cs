// <copyright file="Family.cs" company="Yosifov">
// Copyright (c) Yosifov. All rights reserved.
// </copyright>
namespace Advanced.DefiningClasses.Person
{
    using System.Collections.Generic;
    using System.Linq;

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
            return this.members
                .OrderByDescending(x => x.Age)
                .FirstOrDefault();
        }

        /// <summary>
        /// Gets members over 30 years old
        /// </summary>
        /// <returns>List of Person objects</returns>
        public List<Person> GetMembersOverThirty()
        {
            return this.members.Where(x => x.Age >= 30).OrderBy(y => y.Name).ToList();
        }
    }
}