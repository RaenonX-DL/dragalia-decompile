using System;
using System.Runtime.InteropServices;
using UnityEngine.SocialPlatforms;

namespace Cute.Social
{
	public class Achievement
	{
		public void ShowDefaultAchievementCompletionBanner(bool show)
		{
		}

		public void ShowAchievementsUI([Optional] Action successCallback, [Optional] Action failedCallback)
		{
		}

		public void ReleaseAchievement(string id, double progress, Action<bool> onFinish)
		{
		}

		public void ProceedAchievement(string id, float value)
		{
		}

		public void ResetAchievements(Action<bool> callback)
		{
		}

		public void LoadAchievements(Action<IAchievement[]> callback)
		{
		}

		public void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback)
		{
		}
	}
}
