/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DungeonBgModelProduction : MonoBehaviour
	{
		// Fields
		private ChronosProductionData chronosProductionData;
		[CompilerGenerated]
		private DungeonBgMaterialProduction _dungeonBgMaterialProduction_k__BackingField;
		private List<Coroutine> stopProductionCoroutineList;
		private List<Coroutine> changeBgGroupCoroutineList;
		private List<Coroutine> changeBgTextureCoroutineList;
		private BgModelGroupData[] bgModelGroupDataArray;
		private BgModelGroup currentBgModelGroup;
		private CameraGroupCtrl _cameraGroupCtrl;
	
		// Properties
		public DungeonBgMaterialProduction dungeonBgMaterialProduction { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum ChangeBgTextureProductionKind
		{
			Off = -2,
			On = -1,
			ActionA = 0,
			ActionB = 1,
			ActionC = 2,
			ActionD = 3,
			ActionE = 4,
			ActionF = 5,
			ActionG = 6,
			ActionH = 7,
			ActionI = 8,
			ActionJ = 9,
			EnumMax = 10
		}
	
		public enum ChangeBgProductionKind
		{
			Default = 0,
			ChronosBefore = 1,
			ChronosAfter = 2
		}
	
		public enum BgModelGroup
		{
			GroupA = 0,
			GroupB = 1,
			EnumMax = 2
		}
	
		public class BgModelGroupData
		{
			// Fields
			public List<Renderer> rendererList;
			public List<Animator> animatorList;
			public List<TextureScroll> textureScrollList;
	
			// Constructors
			public BgModelGroupData();
	
			// Methods
			public void SetEnable(bool enableFlag);
		}
	
		public class ChronosProductionData
		{
			// Fields
			public AnimationCurve curveGear;
			public float delayGear;
			public float delayImageEffect;
	
			// Constructors
			public ChronosProductionData();
		}
	
		[CompilerGenerated]
		private sealed class _CoChronosStopProduction_d__26 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool stopFlag;
			public float productionDelay;
			public DungeonBgModelProduction __4__this;
			private float _waitSec_5__2;
			private float _fadeTimeMax_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoChronosStopProduction_d__26(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CoChangeBgTexture_d__30 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DungeonBgModelProduction __4__this;
			public ChangeBgTextureProductionKind kind;
			private float _waitSec_5__2;
			private bool _isEnd_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoChangeBgTexture_d__30(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CoChangeBgModelGroupChronosBefore_d__33 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DungeonBgModelProduction __4__this;
			private float _waitSec_5__2;
			private ImageEffectCtrlCronos _imageEffectCtrl_5__3;
			private float _fadeTimeMax_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoChangeBgModelGroupChronosBefore_d__33(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CoChangeBgModelGroupChronosBeforeGear_d__34 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DungeonBgModelProduction __4__this;
			private float _waitSec_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoChangeBgModelGroupChronosBeforeGear_d__34(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CoChangeBgModelGroupChronosAfter_d__35 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DungeonBgModelProduction __4__this;
			public BgModelGroup groupId;
			private float _waitSec_5__2;
			private ImageEffectCtrlCronos _imageEffectCtrl_5__3;
			private float _fadeTimeMax_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoChangeBgModelGroupChronosAfter_d__35(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DungeonBgModelProduction();
	
		// Methods
		public void ClearCoroutineList(List<Coroutine> list);
		public void ClearStopProductionCoroutineList();
		public void ClearChangeBgGroupCoroutineList();
		private void Start();
		private void OnDestroy();
		public void SetQuestStart();
		public void SetWinProduction();
		public void EntryBgModelGroupObject(BgModelGroup groupId, GameObject entryObj);
		public bool ContainsBgModelGroup(Renderer tempRenderer);
		public void SetChronosStopProduction(bool stopFlag, float productionDelay);
		[IteratorStateMachine]
		private IEnumerator CoChronosStopProduction(bool stopFlag, float productionDelay);
		public ImageEffectCtrlCronos GetImageEffectCtrl();
		public void FadeStopTimeEffect(float fadeValue, bool isFadeIn);
		public void ChangeBgTexture(ChangeBgTextureProductionKind kind);
		[IteratorStateMachine]
		private IEnumerator CoChangeBgTexture(ChangeBgTextureProductionKind kind);
		public void ChangeBgModelGroup(ChangeBgProductionKind kind, BgModelGroup groupId);
		public void SetChronosProductionData(float delayImageEffect, float delayGear, AnimationCurve curveGear);
		[IteratorStateMachine]
		private IEnumerator CoChangeBgModelGroupChronosBefore(BgModelGroup groupId);
		[IteratorStateMachine]
		private IEnumerator CoChangeBgModelGroupChronosBeforeGear();
		[IteratorStateMachine]
		private IEnumerator CoChangeBgModelGroupChronosAfter(BgModelGroup groupId);
		private void SetActiveBgModelGroup(BgModelGroup groupId);
	}
}
