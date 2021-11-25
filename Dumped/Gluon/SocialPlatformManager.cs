using System;
using System.Runtime.InteropServices;
using Cute.Social;

namespace Gluon
{
	public class SocialPlatformManager
	{
		private Achievement achievement;

		private const string SOCIAL_ACCOUNT_SIGNIN = "SOCIAL_ACCOUNT_SIGNIN";

		private static SocialPlatformManager instance;

		public static SocialPlatformManager Instance => null;

		public void Initialize()
		{
		}

		public void SignIn([Optional] Action<bool> callback)
		{
		}

		public void SignOut([Optional] Action callback)
		{
		}

		public void SetUserSignInStatusbySocailAccount()
		{
		}

		private bool IsUserSignedInFromSocialPlatform()
		{
			return default(bool);
		}

		public void SetUserSigninStatus(bool signin)
		{
		}

		public bool IsUserSignedIn()
		{
			return default(bool);
		}

		public void ShowAchievementUI(Action AchievementCheckEvent, Action SignInFailedEvent)
		{
		}

		public void ReleaseAchievement(string achievement_id, double progress, Action onSuccess, Action onfailed)
		{
		}
	}
}
