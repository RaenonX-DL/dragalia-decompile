using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeQuestPreparePage : DmodePageBase
	{
		public class DmodeSkipFloorData : SceneModelBase
		{
			public int selectedCharaId;

			public int destinationFloorNum;

			public int selectedEditSkill1CharaId;

			public int selectedEditSkill2CharaId;

			public DmodeServitorType selectedServitorType;

			public DmodeSkipFloorData(int selectedCharaId, int destinationFloorNum, int selectedEditSkill1CharaId, int selectedEditSkill2CharaId, DmodeServitorType selectedServitorType)
			{
			}
		}

		[SerializeField]
		[Header("UI")]
		private ButtonWithSelectedImage questStartButtonSelectedImage;

		[SerializeField]
		private TabBase tabBase;

		[SerializeField]
		private Button skipFloorButton;

		[SerializeField]
		private Text skipRemainCountValueText;

		[SerializeField]
		[Header("Controller")]
		private DmodeListController dmodeListController;

		[SerializeField]
		private DmodePartyStatus partyStatus;

		private static readonly float bgGrayOutDuration;

		private static readonly int startFloorNum;

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		private void OnBackButtonTouched()
		{
		}

		public void GoToGrowthServitor()
		{
		}

		public void OnCharacterModelLongPressed()
		{
		}

		private void ReloadIconList(CommonIconListType type)
		{
		}

		private void ReloadCharacterModel(int charaId, bool isPlayVoice, PartyReloadCharaAnimationType animationType)
		{
		}

		private void OnSelectedTab(int index)
		{
		}

		private void ShowSkillDetailPopup(int editSkillIndex)
		{
		}

		public void QuestStartButtonPressed()
		{
		}

		public void ShowSkipFloorPopup()
		{
		}

		private void StartDungeonQuest()
		{
		}

		private bool CheckSkipableFloor()
		{
			return default(bool);
		}

		private void ResetQuestButtonImage()
		{
		}

		private void LoadModels()
		{
		}

		private void UpdateEquipData()
		{
		}
	}
}
