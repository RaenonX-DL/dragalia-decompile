/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterSelector : FastUpdateMonoBehaviour, ICollideCallback
	{
		// Fields
		[CompilerGenerated]
		private HumanCharacter _human_k__BackingField;
		[CompilerGenerated]
		private DragonCharacter _dragon_k__BackingField;
		[CompilerGenerated]
		private PlayerCharacter _currentCharacter_k__BackingField;
		[CompilerGenerated]
		private Action<Type, bool> OnChangeCharacter;
		private Type currentType;
		private FinishTransformPhase finishPhase;
		[CompilerGenerated]
		private bool _infiniteDragon_k__BackingField;
		[CompilerGenerated]
		private bool _isFinishTransform_k__BackingField;
		[CompilerGenerated]
		private int _dragonTransformCount_k__BackingField;
		private float dragonRadius;
		private CapsuleCollider dragonCollider;
		private Vector3 dragonColliderCenter;
		[CompilerGenerated]
		private bool _IsExecFinalAttack_k__BackingField;
		private const float CommonTouchInterval = 10f;
		private DateTime _lastStartTime;
		private HitException _hitException;
		private CollisionHitAttribute _hitAttribute;
	
		// Properties
		public HumanCharacter human { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public DragonCharacter dragon { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public PlayerCharacter currentCharacter { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool infiniteDragon { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isFinishTransform { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int dragonTransformCount { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsExecFinalAttack { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isDead { get; }
	
		// Events
		public event Action<Type, bool> OnChangeCharacter {
			add;
			remove;
		}
	
		// Nested types
		public enum Type
		{
			Human = 0,
			Dragon = 1
		}
	
		private enum FinishTransformPhase
		{
			DefaultColor = 0,
			StopEffect = 1,
			End = 2
		}
	
		// Constructors
		public CharacterSelector();
	
		// Methods
		public void Initialize(HumanCharacter human, DragonCharacter dragon);
		public void InitializeRenderState();
		public void ChangeCharacter(Type type, bool withRestartEffect = true, bool withCheckAbility = true);
		private void CallServant(Type type);
		public void CalledServant(Type type);
		public void SetFollower(FollowerController controller);
		public void SetNextControlCharacterFlag(bool flag);
		public void SetDungeonPartyIndex(int dpIdx);
		public void SetDungeonPartyPosition(int dpPos);
		public override void FastUpdate();
		public HumanCharacter GetHuman();
		public bool IsDragon();
		private Vector3 CalcDragonPosition();
		public bool EnableChargeAction();
		public void SetMeshVisibility(bool visible, bool withAnimator = true);
		public static void SetMeshVisibilityCore(Transform t, bool visible, bool withAnimator);
		public static void RefreshSetServantMeshVisibility(DragonCharacter servant);
		public void SetEnableCollider(bool enable);
		public PlayerEventReceiver GetPlayerEventReceiverComponent();
		public void GetHumanDamageRecord(out int total, out int skill, out int dot, out int critical, out int enchant);
		public void GetDragonDamageRecord(out int total, out int skill, out int dot, out int critical, out int enchant);
		private void GetDamageRecord(CharacterBase chara, out int total, out int skill, out int dot, out int critical, out int enchant);
		private void UpdateTouch();
		public void SetupFootprints();
		public void OnCollided(GameObject target, bool isPropagation);
		public void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		public void OnNotCollided(CharacterBase chara);
		public bool IsExcept(CharacterBase chara);
		[CompilerGenerated]
		private bool _UpdateTouch_b__66_0(CharacterBase c);
	}
}
