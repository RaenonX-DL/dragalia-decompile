/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactDragon : MonoBehaviour
	{
		// Fields
		public const int ContactArrayMaxSize = 10;
		private GameObject dragonObj;
		private Animator dragonMainAnimator;
		private Animator[] dragonAnimListWithDeco;
		[CompilerGenerated]
		private GameObject _traceBoneForEmotion_k__BackingField;
		private GameObject shadowObj;
		private ContactAsset contactAsset;
		public const string animationStateNameIdle = "90_01 idle";
		public const string animationStateNameHappy = "90_04 happy";
		public const string animationTriggerIdleToJoy = "idleToJoy";
		public const string animationTriggerIdleToHappy = "idleToHappy";
		public const string animationTriggerJoyToHappy = "joyToHappy";
		public const string animationTriggerJoyToIdle = "joyToIdle";
		private const string appearingEffectDispBone = "jHip";
		private const string appearingEffectName = "EFF_FOR_SDR_003";
		private bool _isAppearingEffectAlreadyPlayed;
		private const string changeDragonSEName = "SE_DC_0009";
		public ContactFacialExpression facialExpression;
		protected Dictionary<int, AttachObject> attachObjects;
		private const int stageEffectMax = 2;
		private EffectObject[] stageEffects;
		private bool isPlayingStageEffect;
		[HideInInspector]
		public DragonStrokeMain strokeMain;
	
		// Properties
		public GameObject traceBoneForEmotion { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isAppearingEffectAlreadyPlayed { get; set; }
	
		// Constructors
		public ContactDragon();
	
		// Methods
		public void Initialize();
		private void OnDestroy();
		public void Clear();
		public ContactAsset GetContactAsset();
		public void SetActive(bool active);
		public bool LoadDragon(int dragonID, Transform parentNode, bool enableEffect = true);
		public GameObject RecursiveFindChild(string name);
		public static GameObject RecursiveFindChild(GameObject root, string name);
		public bool IsIdleMotion();
		public void PlayAppearingEffect();
		public void SetTriggerJoyToIdle();
		public void SetTriggerIdleToJoy();
		public void SetTriggerIdleToHappy();
		public void SetTriggerJoyToHappy();
		public bool IsEndHappyAnimation();
		public bool IsWalkerEndHappyAnimation();
		public bool IsIdleAnimation();
		public GameObject GetMainObject();
		private void AttachDragonDecoration(int decoId);
		[CompilerGenerated]
		private void _LoadDragon_b__34_0();
	}
}
