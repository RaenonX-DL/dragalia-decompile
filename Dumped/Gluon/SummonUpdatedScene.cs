using System.Collections;
using System.Collections.Generic;
using Cute.Cri;
using FLATOUT.Main;
using UnityEngine;

namespace Gluon
{
	public class SummonUpdatedScene : SceneBase
	{
		public Camera mainCamera;

		[SerializeField]
		private Transform overlayParent;

		private SummonUpdatedCanvas mainCanvas;

		private static string movieFileName;

		private MoviePlayerHandle movie;

		private GameObject summonUpdatedEffect;

		private bool isMovieSkip;

		private static int summonId;

		private static PlatinumLegendOpeningSetting platinumLegendOpeningSetting;

		private GameObject platinumLegendOpening;

		private FlMotion platinumLegendOpeningMotion;

		private EffectObject bgEffect;

		private string prevLabel;

		private const int bgEffectShowTrigger = 8;

		private const float bgEffectPosY = 200f;

		private const float bgEffectScale = 100f;

		private const string prefabDir = "Prefabs/OutGame/SummonUpdated/";

		private const string moviePathPrefix = "SummonUpdated/SummonUpdate_";

		private const string prefsKeyLatestSummonUpdatedDateKey = "LatestSummonUpdatedDate";

		private const string platinumLegendSettingPrefix = "PlatinumLegendOpeningSetting/PlatinumLegendOpeningSetting_";

		private const string prefsKeyLatestPlatinumLegendSummonUpdatedDateKey = "LatestPlatinumLegendSummonUpdatedDate";

		private const string bgEffectGroupId = "EFF_SMN";

		private const string bgEffectId = "EFF_SMN_029";

		private const string seGroupId = "SUMMON_PLATINUM";

		private const string oldPrefsKeyLatestSummonUpdatedKey = "LatestSummonUpdated";

		private const string oldPrefsKeyLatestPlatinumLegendSummonUpdatedKey = "LatestPlatinumLegendSummonUpdated";

		[SerializeField]
		private float delayTime;

		private bool isFinish;

		private bool isInitialized;

		private HashSet<string> downloadAssets;

		private void Start()
		{
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		private IEnumerator PlaySummonUpdateMovie()
		{
			return null;
		}

		private IEnumerator PlayPlatinumLegendSummonOpening()
		{
			return null;
		}

		public static bool IsSummonUpdate(out int encounterStoryId)
		{
			return default(bool);
		}

		private static bool CheckSummonUpdate(string prevLatestSummonDataCommenceDate, out int encounterStoryId)
		{
			return default(bool);
		}

		public static bool CheckPlatinumLegendSummonUpdate(string prevLatestSummonGroupCommenceDate)
		{
			return default(bool);
		}

		public void OnSkip()
		{
		}

		private void GotoNextPage()
		{
		}

		private static bool IsGotoUnitStory(int encounterStoryId)
		{
			return default(bool);
		}

		public static void GotoUnitStory(int encounterStoryId)
		{
		}

		private void GotoMyPage()
		{
		}

		private IEnumerator GotoLottery()
		{
			return null;
		}

		public IEnumerator DownloadMovieAssets()
		{
			return null;
		}

		public static bool ExistsMovieAsset(string path)
		{
			return default(bool);
		}

		private void SetSummonUpdatedEffect()
		{
		}

		private void SetPlatinumLegendOpening()
		{
		}

		private void SetPlatinumLegendOpeningPickup(FlPlane flPlane, PlatinumLegendOpeningSetting.ShowPickup setting)
		{
		}

		private void ClearMovie()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
