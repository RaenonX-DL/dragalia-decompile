using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gluon
{
	public class ContinueCameraDialog : InGameDialogBase
	{
		public class Param
		{
			public Action<ContinueCameraDialog> backButtonFunction;
		}

		[SerializeField]
		[Header("components")]
		protected RectTransform frameRt;

		[SerializeField]
		protected Button stampUIButton;

		[SerializeField]
		protected Button changeButton;

		[SerializeField]
		protected Button backButton;

		[SerializeField]
		protected Text cameraText;

		protected Action<ContinueCameraDialog> backButtonFunction;

		private RectTransform rootRt;

		private EventTrigger trigger;

		private int currentActorId;

		private int currentTargetPartytId;

		private int currentTargetMemberId;

		public static ContinueCameraDialog Create(GameObject parent)
		{
			return null;
		}

		protected virtual void Initialize()
		{
		}

		private void InitializeCamera()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void Open(Param param)
		{
		}

		public void Close()
		{
		}

		public void OnChangeButtonPressed()
		{
		}

		private void ExecChangeButtonPressed()
		{
		}

		public void OnBackButtonPressed()
		{
		}

		private void ExecBackButtonPressed()
		{
		}

		private void SetCamera(int targetPartyId, int targetMemberId)
		{
		}

		private void SetPlayerLabel(int actorId)
		{
		}

		private CharacterBase GetActorIdToPartyMemberIndex(int actorId, ref int partyId, ref int memberId)
		{
			return null;
		}

		private CharacterBase GetActorIdToControlledChara(int actorId)
		{
			return null;
		}

		private void GetCharacterToPartyMemberIndex(CharacterBase chara, ref int partyId, ref int memberId)
		{
		}

		protected override void SetEnableButtons(bool b)
		{
		}
	}
}
