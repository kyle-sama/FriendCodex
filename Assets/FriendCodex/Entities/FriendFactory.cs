using System;

//Class to initialize friend object
namespace AssemblyCSharp.Entities
{
	public class FriendFactory
	{
		private static Random random= new Random();
		private Friend friend;

		public FriendFactory(Friend friend)
		{
			this.friend = friend;
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
