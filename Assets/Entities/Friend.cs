//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace AssemblyCSharp.Entities
{
    public enum Gender { BOY, GIRL}
    public enum FriendType { }
	public class Friend
	{
        public Guid UniqueId { get; set; }

        public ContactInfo ContactInfo { get; set; }
        public StatInfo StatInfo { get; set; }

        public List<Skill> Skills { get; set; }
        public List<Type> Types { get; set; }

        public int Level { get; set; }
        public string Nickname { get; set; }

        public Gender Gender { get; set; }

        public string Description { get; set; }
        public string CatchPhrase { get; set; }

        public double Experience { get; set; }

		public Friend ()
		{
            UniqueId = Guid.NewGuid();
		}
	}
}

