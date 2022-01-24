using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class CharacterSelector : FastUpdateMonoBehaviour, ICollideCallback
	{
		public enum Type
		{
			Human,
			Dragon
		}

		private enum FinishTransformPhase
		{
			DefaultColor,
			StopEffect,
			End
		}

		private Type currentType;

		private FinishTransformPhase finishPhase;

		private float dragonRadius;

		private CapsuleCollider dragonCollider;

		private Vector3 dragonColliderCenter;

		private bool isExecCancelTransform;

		private bool isCancelTransformReserved;

		private const float CommonTouchInterval = 10f;

		private DateTime _lastStartTime;

		private HitException _hitException;

		private CollisionHitAttribute _hitAttribute;

		public HumanCharacter human
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DragonCharacter dragon
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public PlayerCharacter currentCharacter
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool infiniteDragon
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isFinishTransform
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int dragonTransformCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsExecFinalAttack
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

		public int OriginalPosition
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Dictionary<int, DragonCharacter> reserveDragonsDict
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isDead => default(bool);

		public bool isServant => default(bool);

		public event Action<Type, bool> OnChangeCharacter
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Initialize(int originalPosition, HumanCharacter human, DragonCharacter dragon)
		{
		}

		public void InitializeRenderState()
		{
		}

		public void ChangeCharacter(Type type, bool withRestartEffect = true, bool withCheckAbility = true)
		{
		}

		private void CallServant(Type type)
		{
		}

		public void CalledServant(Type type)
		{
		}

		public void SetFollower(FollowerController controller)
		{
		}

		public void SetNextControlCharacterFlag(bool flag)
		{
		}

		public void SetDungeonPartyIndex(int dpIdx)
		{
		}

		public void SetDungeonPartyPosition(int dpPos)
		{
		}

		public override void FastUpdate()
		{
		}

		public HumanCharacter GetHuman()
		{
			return null;
		}

		public bool IsDragon()
		{
			return default(bool);
		}

		private Vector3 CalcDragonPosition()
		{
			return default(Vector3);
		}

		public bool EnableChargeAction()
		{
			return default(bool);
		}

		public void SetMeshVisibility(bool visible, bool withAnimator = true)
		{
		}

		public static void SetMeshVisibilityCore(Transform t, bool visible, bool withAnimator)
		{
		}

		public static void RefreshSetServantMeshVisibility(DragonCharacter servant)
		{
		}

		public void SetEnableCollider(bool enable)
		{
		}

		public PlayerEventReceiver GetPlayerEventReceiverComponent()
		{
			return null;
		}

		public void GetHumanDamageRecord(out int total, out int skill, out int dot, out int critical, out int enchant)
		{
		}

		public void GetDragonDamageRecord(out int total, out int skill, out int dot, out int critical, out int enchant)
		{
		}

		private void GetDamageRecord(CharacterBase chara, out int total, out int skill, out int dot, out int critical, out int enchant)
		{
		}

		private void UpdateTouch()
		{
		}

		public void SetupFootprints()
		{
		}

		public void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}

		public void OnNotCollided(CharacterBase chara)
		{
		}

		public bool IsExcept(CharacterBase chara)
		{
			return default(bool);
		}

		public bool IsOhterCharacter()
		{
			return default(bool);
		}

		public void AddReserveDragon(int dragonId)
		{
		}

		public bool UseReserveDragon(int dragonId)
		{
			return default(bool);
		}

		public void ApplyNewWeaponParameter(int hp, int atk, int def)
		{
		}

		public void ApplyNewAmuletParameter(int hp, int atk)
		{
		}

		public void ReserveCancelTransform()
		{
		}

		public void ResetCancelTransform()
		{
		}

		public bool IsServantDragonActive()
		{
			return default(bool);
		}
	}
}
