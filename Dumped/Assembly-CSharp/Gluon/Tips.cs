/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using FLATOUT.Main;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class Tips : MonoBehaviour
	{
		// Fields
		private readonly string[] prefabResourcePath;
		private readonly string[] imageResourcePath;
		private readonly string prefabFTUPath;
		private TipsObject tipsObject;
		public static bool isGameOver;
		public Transform flashParent;
		private const int selectedIdMax = 6;
		public static List<int> selectedTipsIdList;
		private GameObject charaTips;
		private GameObject tipsTitle;
		private FlMotion charaTipsMotion;
		private FlMotion tipsTitleMotion;
		[Header]
		[SerializeField]
		private float charaTipsDelay;
		private Image[] tipsCharaImages;
		private static int changeLayoutType;
		public const int MaxTipsPage = 3;
		private List<Tweener> updateTweens;
		private FlPlane[] charaFlPlanes;
		private FlText[] charaFlTexts;
		private Dictionary<int, Material> charaTipsMaterialDict;
		private string oldTipsTitle;
		public bool isOnCharaAnimation;
	
		// Nested types
		public enum TipsLayoutType
		{
			None = -1,
			Word = 0,
			Image = 1,
			Chara = 2,
			World = 3,
			Max = 4
		}
	
		private enum TipsType
		{
			General = 0,
			GameOver = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public int loadAsyncCount;
			public Tips __4__this;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _SetData_b__3(GameObject prefab);
			internal void _SetData_b__0(GameObject titlePrefab);
			internal void _SetData_b__1(GameObject charaPrefab);
			internal bool _SetData_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_1
		{
			// Fields
			public bool isLoading;
			public __c__DisplayClass24_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass24_1();
	
			// Methods
			internal void _SetData_b__4(Material mat);
			internal bool _SetData_b__5();
		}
	
		[CompilerGenerated]
		private sealed class _SetData_d__24 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Tips __4__this;
			public LoadingTipsElement tipsData;
			private __c__DisplayClass24_0 __8__1;
			private TipsLayoutType _type_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetData_d__24(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public Tips __4__this;
			public LoadingTipsElement tipsData;
			public TipsLayoutType type;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _ReloadTipsData_b__0();
			internal void _ReloadTipsData_b__1();
			internal void _ReloadTipsData_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_1
		{
			// Fields
			public string path;
			public __c__DisplayClass25_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass25_1();
	
			// Methods
			internal void _ReloadTipsData_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public Material shaderHolder;
			public Tips __4__this;
	
			// Constructors
			public __c__DisplayClass30_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_1
		{
			// Fields
			public LoadingTipsElement tipsData;
			public __c__DisplayClass30_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass30_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_2
		{
			// Fields
			public bool isLoading;
			public __c__DisplayClass30_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass30_2();
	
			// Methods
			internal void _LoadCharaMaterial_b__0(Material mat);
			internal bool _LoadCharaMaterial_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadCharaMaterial_d__30 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Tips __4__this;
			public LoadingTipsElement[] tipsDatas;
			private __c__DisplayClass30_0 __8__1;
			private LoadingTipsElement[] __7__wrap1;
			private int __7__wrap2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadCharaMaterial_d__30(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public bool isLoading;
			public Tips __4__this;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal void _SetupTipsTitleFTU_b__0(GameObject prefab);
			internal bool _SetupTipsTitleFTU_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _SetupTipsTitleFTU_d__31 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Tips __4__this;
			public string title;
			public bool isCharaTips;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupTipsTitleFTU_d__31(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public bool isLoading;
			public Tips __4__this;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _SetupCharaTipsFTU_b__0(GameObject prefab);
			internal bool _SetupCharaTipsFTU_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _SetupCharaTipsFTU_d__32 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Tips __4__this;
			public int imageId;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupCharaTipsFTU_d__32(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public Image image;
			public MeshRenderer renderer;
			public Tweener updateTween;
			public UnityAction callback;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _CreateUpdateTween_b__0(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public Tips __4__this;
			public LoadingTipsElement tipsData;
	
			// Constructors
			public __c__DisplayClass40_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_1
		{
			// Fields
			public int prevIndex;
			public __c__DisplayClass40_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass40_1();
	
			// Methods
			internal void _ChangeCharaTips_b__0();
		}
	
		// Constructors
		public Tips();
		static Tips();
	
		// Methods
		[IteratorStateMachine]
		public IEnumerator SetData(LoadingTipsElement tipsData);
		public void ReloadTipsData(LoadingTipsElement tipsData);
		public static LoadingTipsElement GetLoadingTipsDataFromID(int targetId);
		public static LoadingTipsElement[] GetLoadingTipsDatas(TargetTipsType type, int targetId);
		private void SetDefault();
		public void ReleaseResources();
		[IteratorStateMachine]
		public IEnumerator LoadCharaMaterial(LoadingTipsElement[] tipsDatas);
		[IteratorStateMachine]
		public IEnumerator SetupTipsTitleFTU(string title, bool isCharaTips);
		[IteratorStateMachine]
		public IEnumerator SetupCharaTipsFTU(int imageId);
		private void LoadAsyncTipsTitleFTU(Action<GameObject> onLoad);
		private void LoadAsyncCharaTipsFTU(Action<GameObject> onLoad);
		public void StartCharaTips();
		public float GetCharaTipsDelay();
		private void SetCharaImage(int imageId, FlPlane flPlane);
		private void CreateUpdateTween(Image image, MeshRenderer renderer, UnityAction callback = null);
		public void ExitCharaTips();
		public void ChangeCharaTips(LoadingTipsElement tipsData, bool isToLeft);
		public void ChangeTipsTitle(LoadingTipsElement tipsData, bool isToLeft);
		public static string GetTipsDir();
		private string GetTipsPrefabPath(TipsLayoutType type);
		private void OnDestroy();
		[CompilerGenerated]
		private void _ExitCharaTips_b__39_0();
	}
}
