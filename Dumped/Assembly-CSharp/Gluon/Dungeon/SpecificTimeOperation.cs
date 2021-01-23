/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class SpecificTimeOperation : MonoBehaviour
	{
		// Fields
		public static string[] SpecificTimeID_String;
		[EnumFlags]
		[SerializeField]
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
	
		// Nested types
		[Flags]
		public enum SpecificTimeID
		{
			BossStartTiming = 1,
			BossWinTiming = 2,
			BossWinTiming1 = 4,
			BossWinTiming2 = 8
		}
	
		[Flags]
		public enum Operation
		{
			None = 0,
			ScaleX = 1,
			ScaleY = 2,
			ScaleZ = 4,
			PosX = 8,
			PosY = 16,
			PosZ = 32,
			RotX = 64,
			RotY = 128,
			RotZ = 256,
			FogStart = 512,
			FogEnd = 1024,
			FogColor = 2048,
			ColorRate = 4096,
			ActiveGameObject = 8192,
			EffectStartTimer = 16384,
			AnimationStart = 32768,
			DofFocalSize = 65536,
			DofFocalLength = 131072,
			DofSmoothness = 262144
		}
	
		[Serializable]
		public class TargetParams : ICloneable
		{
			// Fields
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
	
			// Constructors
			public TargetParams();
	
			// Methods
			public virtual object Clone();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public SpecificTimeID timeId;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal bool _FindComponentsInScenes_b__0(SpecificTimeOperation elem);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<SpecificTimeOperation, bool> __9__24_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _FindComponentsInScenesApplying_b__24_0(SpecificTimeOperation elem);
		}
	
		// Constructors
		public SpecificTimeOperation();
		static SpecificTimeOperation();
	
		// Methods
		private void Awake();
		public void Initialize();
		private void Update();
		private void SetPeudoActive(bool b);
		private Transform GetTargetTransform();
		private void SetTransform(Transform dstTransform, Vector3 translate, Vector3 rotateEuler, Vector3 scale);
		public static SpecificTimeOperation[] FindComponentsInScenes();
		public static SpecificTimeOperation[] FindComponentsInScenes(SpecificTimeID timeId);
		public static SpecificTimeOperation[] FindComponentsInScenesApplying();
		public static void WillOperationInScenes(SpecificTimeID timeId);
		public static void DidOperationInScenes(SpecificTimeID timeId);
		public static void ApplySubSceneDesignerAreaData();
		public static void RevertSubSceneDesignerAreaData();
		public static void BeginOperationWhenStartBoss();
		public static void EndOperationWhenStartBoss();
		public static void BeginOperationWhenWinBoss1();
		public static void BeginOperationWhenWinBoss2();
		public bool IsTimeId(SpecificTimeID f);
		public void SetTimeId(SpecificTimeID t, bool enable, bool exclusiveCheck = true);
		public static SpecificTimeID GetExclusiveTimeId(SpecificTimeID prevTimeId, SpecificTimeID newTimeId);
		public bool IsEnableOperation(Operation ope);
		public void SetEnableOperation(Operation ope, bool enable);
		public bool IsDoingOperation();
		public bool IsAttachedLightmapNode();
		public bool IsAttachedDungeonEffectObjectNode();
		public void OnWillOperation();
		private void RestartAllAnimation();
		public void OnDidOperation();
	}
}
