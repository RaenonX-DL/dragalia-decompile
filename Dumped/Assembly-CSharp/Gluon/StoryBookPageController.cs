/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryBookPageController : FastUpdateMonoBehaviour
	{
		// Fields
		public const int numOfPages = 7;
		public GameObject[] pageObjects;
		public List<GameObject> textPageObjects;
		public List<StoryTextManager.LogData> textPageLogs;
		public const int maxBreakType = 3;
		public GameObject[] textPageObjectsOriginal;
		public const float renderWait = 0.1f;
		private const string texturePath = "Images/Story/BookPage/";
		public const string pageMainTexture = "sty_3d_0001_{0:D2}";
		public const string pageBackTexture = "sty_3d_0001_00";
		public bool isTextPage;
		public int textSize;
		public Color textColor;
		private int currentPageIndex;
		private Animation pageAnimation;
		private State pageState;
		private Camera mainCamera;
		private Camera textCamera;
		public StoryBookTextCanvas canvasScript;
		private RenderTexture renderTexture;
		private StoryBookPageSettings settings;
		[CompilerGenerated]
		private static StoryBookPageController _instance_k__BackingField;
	
		// Properties
		public static StoryBookPageController instance { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		private enum State
		{
			None = 0,
			Idle = 1,
			Proceeding = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0
		{
			// Fields
			public GameObject pageObject;
			public Vector3 startPos;
			public StoryBookPageController __4__this;
	
			// Constructors
			public __c__DisplayClass36_0();
	
			// Methods
			internal void _AdvancePage_b__0(float x);
			internal void _AdvancePage_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public StoryBookPageController __4__this;
			public Vector3[] startPos;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal void _AdjustPagesPositionOnAdvance_b__0(float x);
			internal void _AdjustPagesPositionOnAdvance_b__1(float x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public StoryBookPageController __4__this;
			public Vector3[] unreadedStartPos;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _AdjustTextPagesPositionOnAdvance_b__0(float x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0
		{
			// Fields
			public GameObject pageObject;
			public Vector3 startPos;
			public StoryBookPageController __4__this;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal void _StartPageDown_b__0(float x);
		}
	
		// Constructors
		public StoryBookPageController();
	
		// Methods
		public static StoryBookPageController Create();
		public static bool IsInstanceEmpty();
		private void Awake();
		public void StartProloguePage();
		public void StartTextPage();
		public void Finish();
		public void StartPageControl();
		private GameObject CreatePageObject(int index);
		public void AddTextPageObject(string fileName = "");
		public void ChangeBookTexture();
		public void AdvancePage();
		private void AdjustPagesPositionOnAdvance();
		private void AdjustTextPagesPositionOnAdvance();
		private void StartPageDown(GameObject pageObject);
		public override void FastUpdate();
		public bool CanProcessPage();
	}
}
