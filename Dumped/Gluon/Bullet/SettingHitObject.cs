using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Dungeon.Gimmick;
using UnityEngine;

namespace Gluon.Bullet
{
	public class SettingHitObject : BulletBase
	{
		private enum State
		{
			Init,
			Delay,
			MarkerSet,
			Charge,
			Start,
			Run,
			End,
			Delete
		}

		public enum BasePosition
		{
			OWNER,
			TARGET,
			MARKER,
			AREA_ANCHOR,
			OWNER_SYNC
		}

		private SettingHitData _data;

		private State _state;

		private CharacterBase _owner;

		private Vector3 _direction;

		private float _lifeTime;

		private float _delayTime;

		private float _chargeTime;

		private float _restTime;

		private int _actionId;

		private int _skillId;

		private CollisionHitAttribute _hitAttribute;

		private HitException _hitException;

		private EffectObject _effectObject;

		private EffectObject _markerEeffectObject;

		private MarkerData _markerData;

		private ChargeMarker _marker;

		private MarkerData _markerDataOnLowSetting;

		private ChargeMarker _markerOnLowSetting;

		private int bulletUniqueId;

		private List<CharacterBase> _getOutCharas;

		private bool _deleteEffectImmediately;

		private bool needClearance;

		private List<CharacterBase> needClearanceCharaList;

		private SettingHitData.ShareMode shareMode;

		private List<CharacterBase> keepInvalidToCharaList;

		private BuffFieldManager.FieldType fieldType;

		private long _buffFieldId;

		private List<CharacterBase> _tmpHitCharas;

		private WarpRoom.RoomGroup startWarpRoomGroupId;

		public CharacterBase owner => null;

		public int conditionId => default(int);

		public int actionProductId => default(int);

		public string hitAttrLabel
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int maxLimit => default(int);

		public override bool AutoDeleteOnAreaChange => default(bool);

		protected virtual void Clear()
		{
		}

		public void Initialize(SettingHitData data, long dataId, Vector3 position, Quaternion rotation, CharacterBase owner, int actionId, int skillId, int productId, float delayTime, bool needClearance, SettingHitData.ShareMode shareMode, ActionStartParameter actionStartParameter, long buffFieldId)
		{
		}

		public bool IsValidField()
		{
			return default(bool);
		}

		private void ProcStart()
		{
		}

		private void OnDestroy()
		{
		}

		protected override void OnDisable()
		{
		}

		public override void FastUpdate()
		{
		}

		private void RemoveCharaByRule()
		{
		}

		private void AddPlayerToKeepInvalidToCharaList(CharacterBase chara)
		{
		}

		private void UpdatePositionAndRotation(Vector3 pos, Quaternion rot)
		{
		}

		private bool OnUpdate()
		{
			return default(bool);
		}

		private void CheckFieldBuff()
		{
		}

		private void OnFieldBuffRemoved(CharacterBase chara)
		{
		}

		private bool IsCheckCollisionOnDefenceSide()
		{
			return default(bool);
		}

		private bool UpdateDurationTime()
		{
			return default(bool);
		}

		public CollisionHitAttribute GetHitAttribute()
		{
			return null;
		}

		public override void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public override void OnNotCollided(CharacterBase chara)
		{
		}

		public override bool IsExcept(CharacterBase chara)
		{
			return default(bool);
		}

		public override void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}

		protected void PlayEffect()
		{
		}

		public void SetEffectVisibility(bool v)
		{
		}

		public void StopEffect(bool immediately = false)
		{
		}

		public void PauseEffect(bool isPause)
		{
		}

		public void RestoreEffect()
		{
		}

		protected void PlaySE()
		{
		}

		protected void PlayHitSE()
		{
		}

		private void SetupCollisionParameter()
		{
		}

		public void ForceDelete(bool deleteEffectImmediately = false)
		{
		}

		public bool IsStateFinish()
		{
			return default(bool);
		}

		public Vector3 GetCenterPos()
		{
			return default(Vector3);
		}

		private List<CharacterBase> GetCollisionCheckerHitCharas(bool toOriginalChara)
		{
			return null;
		}
	}
}
