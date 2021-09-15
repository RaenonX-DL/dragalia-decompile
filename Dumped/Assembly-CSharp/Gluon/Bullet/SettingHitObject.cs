/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using Gluon.Dungeon.Gimmick;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class SettingHitObject : BulletBase
	{
		// Fields
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
		[CompilerGenerated]
		private string _hitAttrLabel_k__BackingField;
		private bool _deleteEffectImmediately;
		private bool needClearance;
		private List<CharacterBase> needClearanceCharaList;
		private SettingHitData.ShareMode shareMode;
		private List<CharacterBase> keepInvalidToCharaList;
		private BuffFieldManager.FieldType fieldType;
		private long _buffFieldId;
		private List<CharacterBase> _tmpHitCharas;
		private WarpRoom.RoomGroup startWarpRoomGroupId;
	
		// Properties
		public CharacterBase owner { get; }
		public int conditionId { get; }
		public int actionProductId { get; }
		public string hitAttrLabel { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int maxLimit { get; }
		public override bool AutoDeleteOnAreaChange { get; }
	
		// Nested types
		private enum State
		{
			Init = 0,
			Delay = 1,
			MarkerSet = 2,
			Charge = 3,
			Start = 4,
			Run = 5,
			End = 6,
			Delete = 7
		}
	
		public enum BasePosition
		{
			OWNER = 0,
			TARGET = 1,
			MARKER = 2,
			AREA_ANCHOR = 3,
			OWNER_SYNC = 4
		}
	
		// Constructors
		public SettingHitObject();
	
		// Methods
		protected virtual void Clear();
		public void Initialize(SettingHitData data, long dataId, Vector3 position, Quaternion rotation, CharacterBase owner, int actionId, int skillId, int productId, float delayTime, bool needClearance, SettingHitData.ShareMode shareMode, ActionStartParameter actionStartParameter, long buffFieldId);
		public bool IsValidField();
		private void ProcStart();
		private void OnDestroy();
		protected override void OnDisable();
		public override void FastUpdate();
		private void RemoveCharaByRule();
		private void AddPlayerToKeepInvalidToCharaList(CharacterBase chara);
		private void UpdatePositionAndRotation(Vector3 pos, Quaternion rot);
		private bool OnUpdate();
		private void CheckFieldBuff();
		private void OnFieldBuffRemoved(CharacterBase chara);
		private bool IsCheckCollisionOnDefenceSide();
		private bool UpdateDurationTime();
		public CollisionHitAttribute GetHitAttribute();
		public override void OnCollided(GameObject target, bool isPropagation);
		public override void OnNotCollided(CharacterBase chara);
		public override bool IsExcept(CharacterBase chara);
		public override void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		protected void PlayEffect();
		public void SetEffectVisibility(bool v);
		public void StopEffect(bool immediately = false);
		public void PauseEffect(bool isPause);
		public void RestoreEffect();
		protected void PlaySE();
		protected void PlayHitSE();
		private void SetupCollisionParameter();
		public void ForceDelete(bool deleteEffectImmediately = false);
		public bool IsStateFinish();
		public Vector3 GetCenterPos();
		private List<CharacterBase> GetCollisionCheckerHitCharas(bool toOriginalChara);
	}
}
