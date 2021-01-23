/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CraftEvolutionBaseFrame : MonoBehaviour
	{
		// Fields
		public Image weaponIcon;
		public Image skillIcon;
		public Image[] abilityIcons;
		public UnityEngine.UI.Text skillText;
		public UnityEngine.UI.Text[] abilityText;
		public UnityEngine.UI.Text weaponName;
		public UnityEngine.UI.Text hpParam;
		public UnityEngine.UI.Text atkParam;
		public UnityEngine.UI.Text hpParamText;
		public UnityEngine.UI.Text atkParamText;
		public LimitStarBase limit;
		public UnityEngine.UI.Text plusParam;
		public GameObject sortDecoAttachNode;
		public UnityEngine.UI.Text selfCountText;
		private ulong weaponId;
		private int skillLv;
		private WeaponDataElement weaponData;
		private bool isSelfInBox;
		[SerializeField]
		private GameObject skillBase;
		[SerializeField]
		private GameObject[] abilityBase;
		[SerializeField]
		private Transform[] starEffectBase;
		private GameObject originEffectObj;
		private bool isPlayLimitEffect;
	
		// Nested types
		[CompilerGenerated]
		private struct _SetupLimitBreakMaxEffect_d__31 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public CraftEvolutionBaseFrame __4__this;
			private int _i_5__2;
			private UniTask<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public CraftEvolutionBaseFrame();
	
		// Methods
		private void Awake();
		public void SetupBaseInfo(ulong keyId);
		public void SetupBaseInfoByMasterId(int masterId, int takeOverHpPlusParam = 0, int takeOverAtkPlusParam = 0);
		public void OnSkillButtonPressed();
		public void OnAbilityButtonPressed(int intex);
		public void OnIconButtonPressed();
		public void SetCraftCountText(long count);
		private void SetupFromMasterData(WeaponDataElement masterWeaponData);
		private async void SetupLimitBreakMaxEffect();
		private void DestoryLimitBreakMaxEffect();
	}
}
