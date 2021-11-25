using System.Collections;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;

namespace Gluon
{
	public class PartyScene : SceneBase
	{
		public Camera mainCamera;

		public Camera render3dCamera;

		public QuestCharacterCtrl[] characterCtrls;

		public PartyObjectsSettings objectsSettings;

		public AudioPlayback bgmPlayback;

		private PartyUICanvas mainCanvas;

		private bool isTutorialRequired;

		private bool isGoPartyCharacter;

		private const string prefabPath = "Prefabs/OutGame/Party/Party/";

		public bool isEditSkillTutorialRunning
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

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		private bool SetupTutorialState()
		{
			return default(bool);
		}

		public void StartTutorial()
		{
		}

		private void StartTutorialIfNeeded()
		{
		}

		private void Tutorial_1_1()
		{
		}

		private IEnumerator Tutorial_1_1_Coroutine(TouchGuardObject touchGuard)
		{
			return null;
		}

		private void Tutorial_StartEditSkill()
		{
		}

		private void Tutorial_EndEditSkill()
		{
		}

		private void Tutorial_Party_Attr()
		{
		}

		private IEnumerator Tutorial_Party_Attr_Coroutine(TouchGuardObject touchGuard)
		{
			return null;
		}

		public void ReloadAllCharacterModels(bool isAutoSelect = false)
		{
		}

		public void ReloadCharacterModel(int index, PartyReloadCharaAnimationType animationType = PartyReloadCharaAnimationType.LandAnimationNotDelay)
		{
		}

		public void OnOrganizeButtonPressed()
		{
		}

		public void OnEquipChangeButtonPressed()
		{
		}

		private bool IsValidPlayFlow()
		{
			return default(bool);
		}

		private void FooterButtonPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		private void GoFooterScene(string tabName, Footer.MenuTab tabType)
		{
		}

		private void FooterButtonLongPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		private void DetachFooterCallback()
		{
		}

		public static void ReplaceAttributeMatchEffects(PartyUIStatus[] partyStatus)
		{
		}
	}
}
