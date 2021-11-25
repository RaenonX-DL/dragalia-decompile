using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class MyPageTutorial : MonoBehaviour
	{
		public MyPageScene scene;

		private bool isMultiPlayTutorialRequired;

		private TouchGuardObject tutorialTouchGuardObject;

		public bool isTutorialRequired
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isGrowthCrestTutorialRunning
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isWeaponCraftTutorialRunning
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool SetupTutorialState()
		{
			return default(bool);
		}

		public void StartTutorialIfNeeded()
		{
		}

		private void Tutorial_1_1_Summon()
		{
		}

		private IEnumerator Tutorial_1_1_Summon_Coroutine()
		{
			return null;
		}

		private void GoPartyScene()
		{
		}

		private void Tutorial_1_1_Quest()
		{
		}

		private IEnumerator Tutorial_1_1_Quest_Coroutine()
		{
			return null;
		}

		private void Tutorial_1_1_Quest_OnFooterPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		public void StartGuildTutorial()
		{
		}

		private IEnumerator GuildTotorialCoroutine()
		{
			return null;
		}

		public void Tutorial_Drill()
		{
		}

		private IEnumerator Tutorial_Drill_Coroutine()
		{
			return null;
		}

		private void StartEditSkillTutorial()
		{
		}

		private void StartDragonSphereTutorial()
		{
		}

		private void StartWeaponCraftTutorial()
		{
		}

		private void StartGrowthCrestTutorial()
		{
		}

		public bool IsPopupOpenedTutorial()
		{
			return default(bool);
		}
	}
}
