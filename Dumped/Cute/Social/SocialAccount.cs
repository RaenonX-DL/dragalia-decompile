using System;
using System.Runtime.InteropServices;

namespace Cute.Social
{
	public class SocialAccount
	{
		private string socialServiceUserId;

		private bool isLoggedIn;

		private static SocialAccount instance;

		public string SocialServiceUserId => null;

		public static SocialAccount Instance => null;

		public void Initialize()
		{
		}

		public void SignIn(Action<bool> callback)
		{
		}

		public void SignOut([Optional] Action callback)
		{
		}

		public bool IsLoggedIn()
		{
			return default(bool);
		}
	}
}
