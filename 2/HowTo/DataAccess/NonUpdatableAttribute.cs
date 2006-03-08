using System;

using NUnit.Framework;

using BLToolkit.Data;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;

namespace HowTo.DataAccess
{
	[TestFixture]
	public class NonUpdatable
	{
		public enum Gender
		{
			[MapValue("F")] Female,
			[MapValue("M")] Male,
			[MapValue("U")] Unknown,
			[MapValue("O")] Other
		}

		public class Person
		{
			[MapField("PersonID"), PrimaryKey, /*[a]*/NonUpdatable/*[/a]*/]
			public int    ID;

			public string LastName;
			public string FirstName;
			public string MiddleName;
			public Gender Gender;
		}

		[Test]
		public void Test()
		{
			DataAccessor da = new DataAccessor();

			Person person = new Person();

			person.FirstName = "Crazy";
			person.LastName  = "Frog";
			person.Gender    = Gender.Other;

			da./*[a]*/InsertSql(person)/*[/a]*/;
		}
	}
}
