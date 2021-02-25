/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyEquipCrest : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private GameObject type1Slot;
		[SerializeField]
		private GameObject type2Slot;
		[SerializeField]
		private GameObject type3Slot;
		[SerializeField]
		private Image crestIcon;
		[SerializeField]
		private CommonUnionIcon crestUnionIcon;
		[SerializeField]
		private UnityEngine.UI.Text releaseCount;
		[SerializeField]
		private UnityEngine.UI.Text ability;
		[SerializeField]
		private Image unionIcon;
		[SerializeField]
		private GameObject lockObject;
		[SerializeField]
		private GameObject emptyObject;
		[SerializeField]
		private GameObject crestInfoObject;
		[SerializeField]
		private Button button;
		[SerializeField]
		private GameObject eventBonusIcon;
		[SerializeField]
		private GameObject noneUnionGameObject;
		[SerializeField]
		private FlashPlayerManager flashPlayerManager;
		private const string unionBonusFlashPath = "Prefabs/OutGame/Party/Flash/{0}";
		private Dictionary<string, FlashPlayer> effectDictionary;
		private int crestId;
		private int slotType;
		private int slotIndex;
		private Action onChangedCallback;
		private bool isSupportFriend;
		public static PartyEquipCrestSelectPopup crestSelectPopup;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__30_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnChangeButtonPressed_b__30_0();
		}
	
		// Constructors
		public PartyEquipCrest();
	
		// Methods
		private void OnDestroy();
		public void Setup(int slotIndex, int slotType, int crestId, Action onChangedCallback, bool isSupportFriend = false);
		public void PlayUnionBonusEffect(string effectName);
		private void PrepareFlash(string effectName);
		private void ResetFlash(string effectName);
		public void SetupLock(int slotIndex, int slotType);
		private void SetupSlot(int slotType);
		public void OnChangeButtonPressed();
		public void OpenDetailScene();
		public void SetupCrestSetCell(int slotIndex, int slotType, int crestId, bool isLockSlot);
		[CompilerGenerated]
		private void _OnChangeButtonPressed_b__30_1();
	}
}
