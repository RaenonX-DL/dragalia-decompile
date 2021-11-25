using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Serialization;

namespace Gluon.Dungeon.Gimmick
{
	public class Warp : GimmickBase
	{
		public enum DirectionType
		{
			Idle,
			Warp_Start1,
			Warp_Start2,
			Warp_Player,
			Warp_Move,
			Warp_Out,
			ReturnToIdle,
			EnumMax
		}

		public enum WaitSecForMeType
		{
			Start1,
			Out1,
			Out2,
			Out3,
			EnumMax
		}

		public enum WaitSecForOthersType
		{
			Start1,
			Out1,
			Out2,
			EnumMax
		}

		[Serializable]
		public class DirectionData
		{
			public string normalEffectLabel;

			public int normalEffectTriggerId;

			public string notDispEffectLabel1;

			public int notDispEffectTriggerId1;

			public EffectObject.EraseType notDispEffectType1;

			public string notDispEffectLabel2;

			public int notDispEffectTriggerId2;

			public EffectObject.EraseType notDispEffectType2;

			public string soundLabel;

			public DirectionData([Optional] string normalEffectLabel, int normalEffectTriggerId = 0, [Optional] string soundLabel, [Optional] string notDispEffectLabel1, int notDispEffectTriggerId1 = 0, EffectObject.EraseType notDispEffectType1 = EffectObject.EraseType.STOP, [Optional] string notDispEffectLabel2, int notDispEffectTriggerId2 = 0, EffectObject.EraseType notDispEffectType2 = EffectObject.EraseType.STOP)
			{
			}
		}

		protected class TargetData
		{
			public CharacterBase hitChara;

			public List<CharacterSelector> selectorList;

			public List<CharacterBase> currentCharaList;
		}

		[Serializable]
		public class FogData
		{
			public enum ChangeType
			{
				Disable,
				Enable,
				ResetToDefault
			}

			public ChangeType changeType;

			public Color fogColor;

			public float startValue;

			public float endValue;
		}

		public enum WarpedOptionType
		{
			None,
			AddDragonNgFlag,
			RemoveDragonNgFlag
		}

		protected DirectionData[] directionDataArray;

		protected string screenEffectLabel;

		protected int screenEffectTriggerId;

		protected string screenSoundLabel;

		protected float[] waitSecForMeArray;

		protected float[] waitSecForOthersArray;

		[SerializeField]
		protected FogData warpOutFogData;

		[SerializeField]
		private float ignoreDamageSec;

		[HideInInspector]
		public GimmickWarpObj type;

		[FormerlySerializedAs("index")]
		public int myWarpIndex;

		[FormerlySerializedAs("targetIndex")]
		public int jumpToWarpIndex;

		private HashSet<int> victim;

		protected Transform jumpToTransform;

		protected Warp targetWarp;

		private GimmickWarpObjElement variation;

		protected EffectObject effectObject;

		private EffectObject effectObjectScreen;

		[SerializeField]
		private bool ignoreDirectionEffectFlag;

		[SerializeField]
		private bool ignoreDirectionSoundFlag;

		[SerializeField]
		private bool enableWarpJump;

		[SerializeField]
		private bool warpIsOnceFlag;

		[SerializeField]
		private bool dragonCantWarpFlag;

		[SerializeField]
		private WarpedOptionType warpedOptionType;

		[Lock]
		public List<CharacterBase> warpedCharaList;

		[SerializeField]
		private bool cantReEntryFlag;

		protected static List<CharacterBase> ignoreHitCharaList;

		public bool IsFinishedWarp
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

		public CharacterSelector WarpOtherTarget
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

		public bool IsEnableWarp()
		{
			return default(bool);
		}

		public virtual void SetEnableWarp(bool enableFlag)
		{
		}

		protected virtual void AddWarpedCharaList(CharacterBase chara)
		{
		}

		public static void RemoveReEntryList(CharacterBase tempChara)
		{
		}

		protected override void Awake()
		{
		}

		protected virtual void InitJumpToTransform()
		{
		}

		protected Warp GetLinkWarpScript(int targetIndex)
		{
			return null;
		}

		public void AddVictim(int id)
		{
		}

		public bool IsVictim(int id)
		{
			return default(bool);
		}

		public void SetWarp(CharacterBase chara, bool checkIsDead, bool isForceReturn)
		{
		}

		public void SetWarp(Collider other, bool checkIsDead, bool isForceReturn)
		{
		}

		public bool IsWarpOK(Collider other)
		{
			return default(bool);
		}

		public bool IsWarpOK(CharacterBase chara, bool drawMessage = false)
		{
			return default(bool);
		}

		public virtual void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		protected CharacterBase GetCharaFromCollider(Collider other)
		{
			return null;
		}

		protected virtual IEnumerator StartWarp(int id, Collider other, bool checkIsDead)
		{
			return null;
		}

		protected virtual IEnumerator StartWarpOther(GameObject target)
		{
			return null;
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}

		public virtual void OnFinishWarp()
		{
		}

		protected virtual void SetWarpedCharaDataPre(TargetData targetData)
		{
		}

		protected virtual void SetWarpedCharaData(TargetData targetData)
		{
		}

		protected void CancelDragonTransform(CharacterBase tempChara)
		{
		}

		private float GetCameraFollowRateFunc()
		{
			return default(float);
		}

		protected virtual IEnumerator InitDirection()
		{
			return null;
		}

		protected virtual void SetDirection(DirectionType type, [Optional] CharacterBase chara)
		{
		}

		protected virtual void SetDirection(DirectionType type, List<CharacterBase> charas)
		{
		}
	}
}
