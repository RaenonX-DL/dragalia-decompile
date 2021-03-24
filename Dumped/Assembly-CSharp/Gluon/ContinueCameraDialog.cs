/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContinueCameraDialog : InGameDialogBase
	{
		// Fields
		[Header]
		[SerializeField]
		protected RectTransform frameRt;
		[SerializeField]
		protected Button stampUIButton;
		[SerializeField]
		protected Button changeButton;
		[SerializeField]
		protected Button backButton;
		[SerializeField]
		protected UnityEngine.UI.Text cameraText;
		protected Action<ContinueCameraDialog> backButtonFunction;
		private RectTransform rootRt;
		private EventTrigger trigger;
		private int currentActorId;
		private int currentTargetPartytId;
		private int currentTargetMemberId;
	
		// Nested types
		public class Param
		{
			// Fields
			public Action<ContinueCameraDialog> backButtonFunction;
	
			// Constructors
			public Param();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction<BaseEventData> __9__13_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Initialize_b__13_0(BaseEventData data);
		}
	
		// Constructors
		public ContinueCameraDialog();
	
		// Methods
		public static ContinueCameraDialog Create(GameObject parent);
		protected virtual void Initialize();
		private void InitializeCamera();
		private void OnDestroy();
		private void Update();
		public void Open(Param param);
		public void Close();
		public void OnChangeButtonPressed();
		private void ExecChangeButtonPressed();
		public void OnBackButtonPressed();
		private void ExecBackButtonPressed();
		private void SetCamera(int targetPartyId, int targetMemberId);
		private void SetPlayerLabel(int actorId);
		private CharacterBase GetActorIdToPartyMemberIndex(int actorId, ref int partyId, ref int memberId);
		private CharacterBase GetActorIdToControlledChara(int actorId);
		private void GetCharacterToPartyMemberIndex(CharacterBase chara, ref int partyId, ref int memberId);
		private bool IsEnablePress();
		private void SetEnableButtons(bool b);
		[CompilerGenerated]
		private void _Initialize_b__13_1();
		[CompilerGenerated]
		private void _Open_b__17_0();
		[CompilerGenerated]
		private void _Close_b__18_0();
	}
}
