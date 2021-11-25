using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class Clb01EventInfoCtrl : EventInfoCtrlBase
	{
		[SerializeField]
		private Text[] materialTexts;

		[SerializeField]
		private Image[] materialIcons;

		[SerializeField]
		private Text friendlyPointText;

		[SerializeField]
		private Text hintText;

		[SerializeField]
		private Text hintTitleText;

		[SerializeField]
		[Header("MiniChara")]
		public Transform[] miniCharaParentNodes;

		public Button[] miniCharaButtons;

		public Transform miniCharaInvalidParentNode;

		public FlashPlayerManager flashPlayerManager;

		private FlashPlayer[] miniCharaFlashPlayers;

		private int[] miniCharaFlashPlayerIds;

		private readonly Vector3 defaultMiniCharaSize;

		private const int specialMinicharaId = 3;

		private int hidingIndex;

		private int index1;

		private int index2;

		public const string miniCharaFlashPrefabPathTemplate = "Prefabs/OutGame/EventQuest/{0}/pf_EventQuestMiniCharacter{1:D3}";

		public const int miniCharaCount = 3;

		[SerializeField]
		private Gauge gauge;

		public static Clb01EventInfoCtrl Create(Transform parent)
		{
			return null;
		}

		protected override void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public List<int> GetMiniCharaFlashPlayerList()
		{
			return null;
		}

		public static string GetMiniCharaFlashPlayerPath(int eventId, int charaIndex)
		{
			return null;
		}

		private void LoadMiniChara(List<int> miniCharaIdList)
		{
		}

		public void InitBindMiniChara(List<int> enabledMiniCharaList)
		{
		}

		private void InitBindMiniChara(int hidingIndex, int index1, int index2)
		{
		}

		public void OnMiniCharaTouched(int posIndex)
		{
		}

		public override void OnResetTopImageAndTalk()
		{
		}

		private void DoChangeMiniChara(int posIndex, int incomingIndex)
		{
		}

		public override void SetEventInfo()
		{
		}

		private void SetEventHintText()
		{
		}
	}
}
