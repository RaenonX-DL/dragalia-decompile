using System.Collections;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MenuPlayerInfoPopup : CommonPopup
	{
		[SerializeField]
		private Text profileText;

		[SerializeField]
		private Text stampText;

		[SerializeField]
		private Text achievementText;

		[SerializeField]
		private Image achievementImage;

		[SerializeField]
		private Sprite googleAchievementImage;

		[SerializeField]
		private Sprite appleAchievementImage;

		[SerializeField]
		private Button missionDrillButton;

		[SerializeField]
		private Button logoutButton;

		public MenuPopup menuPopup;

		private bool isAchievementOn;

		private Coroutine checkSigninOutCoroutine;

		public static MenuPlayerInfoPopup Create()
		{
			return null;
		}

		public void InitSetting()
		{
		}

		public void OnProfileButtonPressed()
		{
		}

		public void OnStampButtonPressed()
		{
		}

		public void OnAchievementButtonPressed()
		{
		}

		public void OnLogoutButtonPressed()
		{
		}

		public void OnDrillMissionButtonPressed()
		{
		}

		private void SocailLoginFailedPopup()
		{
		}

		private void GetAchievementList()
		{
		}

		private void OnSuccess(PlatformAchievementGetPlatformAchievementListResponse res)
		{
		}

		private void ReleaseAllAchievement(PlatformAchievementGetPlatformAchievementListResponse res)
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		private IEnumerator CheckSignInOut()
		{
			return null;
		}
	}
}
