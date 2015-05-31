using System;

//Class to initialize friend object
namespace AssemblyCSharp.Entities
{
	public class FriendFactory
	{
		Random random;
		Friend friend;

		public FriendFactory(Friend friend)
		{
			this.friend = friend;
			random = new Random ();
			InitStats ();
		}

		public int RandomNumber(int min,int max)
		{	//Random number for stat
			return random.Next (min, max);
		}
		
		public void InitStats()
		{

		}
	}
}
