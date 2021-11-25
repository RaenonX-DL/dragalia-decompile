using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class SpecificTimeOperation : MonoBehaviour
	{
		[Flags]
		public enum SpecificTimeID
		{
			BossStartTiming = 0x1,
			BossWinTiming = 0x2,
			BossWinTiming1 = 0x4,
			BossWinTiming2 = 0x8
		}

		[Flags]
		public enum Operation
		{
			None = 0x0,
			ScaleX = 0x1,
			ScaleY = 0x2,
			ScaleZ = 0x4,
			PosX = 0x8,
			PosY = 0x10,
			PosZ = 0x20,
			RotX = 0x40,
			RotY = 0x80,
			RotZ = 0x100,
			FogStart = 0x200,
			FogEnd = 0x400,
			FogColor = 0x800,
			ColorRate = 0x1000,
			ActiveGameObject = 0x2000,
			EffectStartTimer = 0x4000,
			AnimationStart = 0x8000,
			DofFocalSize = 0x10000,
			DofFocalLength = 0x20000,
			DofSmoothness = 0x40000
		}

		[Serializable]
		public class TargetParams : ICloneable
		{
			public Vector3 scale;

			public Vector3 translate;

			public Vector3 rotateEuler;

			public float fogStart;

			public float fogEnd;

			public Color fogColor;

			public Color colorRate;

			public bool activeGameObject;

			public float effectStartTimer;

			public float dofFocalSize;

			public float dofFocalLength;

			public float dofSmoothness;

			public float dofSmoothStepMin;

			public float dofSmoothStepMax;

			public int postEffectFilterType;

			public bool postEffectEnableDof;

			public bool inactiveOnPlaying;

			public bool animationStopOnPlaying;

			public virtual object Clone()
			{
				return null;
			}
		}

		public static string[] SpecificTimeID_String;

		[SerializeField]
		[EnumFlags]
		private SpecificTimeID _timeId;

		[SerializeField]
		private Operation _operation;

		[SerializeField]
		private TargetParams _localParam;

		private TargetParams _originalParam;

		private float _operationElapsedTime;

		private int _colorRateId;

		private Renderer _renderer;

		private MaterialPropertyBlock _materialPropertyBlock;

		private bool _playedEffect;

		private bool _initialized;

		private bool _pseudoActive;

		private List<Renderer> _disableRendererList;

		private void Awake()
		{
		}

		public void Initialize()
		{
		}

		private void Update()
		{
		}

		private void SetPeudoActive(bool b)
		{
		}

		private Transform GetTargetTransform()
		{
			return null;
		}

		private void SetTransform(Transform dstTransform, Vector3 translate, Vector3 rotateEuler, Vector3 scale)
		{
		}

		public static SpecificTimeOperation[] FindComponentsInScenes()
		{
			return null;
		}

		public static SpecificTimeOperation[] FindComponentsInScenes(SpecificTimeID timeId)
		{
			return null;
		}

		public static SpecificTimeOperation[] FindComponentsInScenesApplying()
		{
			return null;
		}

		public static void WillOperationInScenes(SpecificTimeID timeId)
		{
		}

		public static void DidOperationInScenes(SpecificTimeID timeId)
		{
		}

		public static void ApplySubSceneDesignerAreaData()
		{
		}

		public static void RevertSubSceneDesignerAreaData()
		{
		}

		public static void BeginOperationWhenStartBoss()
		{
		}

		public static void EndOperationWhenStartBoss()
		{
		}

		public static void BeginOperationWhenWinBoss1()
		{
		}

		public static void BeginOperationWhenWinBoss2()
		{
		}

		public bool IsTimeId(SpecificTimeID f)
		{
			return default(bool);
		}

		public void SetTimeId(SpecificTimeID t, bool enable, bool exclusiveCheck = true)
		{
		}

		public static SpecificTimeID GetExclusiveTimeId(SpecificTimeID prevTimeId, SpecificTimeID newTimeId)
		{
			return default(SpecificTimeID);
		}

		public bool IsEnableOperation(Operation ope)
		{
			return default(bool);
		}

		public void SetEnableOperation(Operation ope, bool enable)
		{
		}

		public bool IsDoingOperation()
		{
			return default(bool);
		}

		public bool IsAttachedLightmapNode()
		{
			return default(bool);
		}

		public bool IsAttachedDungeonEffectObjectNode()
		{
			return default(bool);
		}

		public void OnWillOperation()
		{
		}

		private void RestartAllAnimation()
		{
		}

		public void OnDidOperation()
		{
		}
	}
}
