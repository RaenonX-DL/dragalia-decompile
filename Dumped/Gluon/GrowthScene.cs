using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class GrowthScene : SceneBase
	{
		public enum CharaType
		{
			None = -1,
			Elphyllis,
			Ranzarve,
			Rosina
		}

		public delegate void OnGrowCharaListPress(GiftType buttonType, int inventoryId);

		public CharaType charaType;

		public Camera mainCamera;

		public GrowthCharaTalkSelector charaTalkSelector;

		public static string prefabDir;

		private GrowthUICanvas mainCanvas;

		private GrowthCharaCanvas charaCanvas;

		private bool isTutorialRequired;

		private bool isTutorialStory;

		private const string charaVoiceGroupName1 = "VO_CHR_100002_01_OUT";

		private const string charaVoiceGroupName2 = "VO_CHR_100003_01_OUT";

		private const string charaVoiceGroupName3 = "VO_CHR_110263_02_OUT";

		private string charaCanvasPrefabName;

		private string charaVoiceGroupName;

		private GameObject charaCanvasPrefab;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		public override void OnPresentReceived()
		{
		}

		public void OnCharaPressed()
		{
		}

		private void CheckTutorialState()
		{
		}

		private void SetupTutorialState()
		{
		}

		private void StartTutorial()
		{
		}

		private void Tutorial_1_1()
		{
		}

		private IEnumerator Tutorial_1_1_Coroutine()
		{
			return null;
		}

		private void Tutorial_1_2()
		{
		}

		private IEnumerator Tutorial_1_2_Coroutine()
		{
			return null;
		}

		private void Tutorial_1_2_ToGrowthAmulet()
		{
		}

		private void Tutorial_1_4()
		{
		}

		private IEnumerator Tutorial_1_4_Coroutine()
		{
			return null;
		}

		private void Tutorial_2_6_2()
		{
		}

		private void TutorialGrowthDragon()
		{
		}

		private IEnumerator TutorialGrowthDragonCoroutine()
		{
			return null;
		}

		public void OnGrowthCharacterButtonPressed()
		{
		}

		public void OnGrowthManaCircleButtonPressed()
		{
		}

		public void OnGrowthDragonButtonPressed()
		{
		}

		public void OnGrowthWeaponButtonPressed()
		{
		}

		public void OnGrowthAmuletButtonPressed()
		{
		}

		public void OnGrowthCraftButtonPressed()
		{
		}
	}
}
