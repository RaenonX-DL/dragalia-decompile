/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingRoomCellStatusControl : MonoBehaviour
	{
		// Fields
		public GameObject editingParent;
		public GameObject readyParent;
		public GameObject waitingParent;
		public FlashPlayerManager flashPlayerManager;
		private MatchingReadyState currentState;
		private Animator iconRecruitementAnimator;
		private Animator iconCheckingAnimator;
		private FlashPlayer partyEditingFlashPlayer;
		private FlashPlayer readyFlashPlayer;
	
		// Properties
		private string flashPathBase { get; }
	
		// Constructors
		public MatchingRoomCellStatusControl();
	
		// Methods
		private void Awake();
		private void Start();
		private void OnDestroy();
		public void SwitchToState(MatchingReadyState state, bool withSE);
		private static Animator CreateAnimator(string path, GameObject parent);
	}
}
