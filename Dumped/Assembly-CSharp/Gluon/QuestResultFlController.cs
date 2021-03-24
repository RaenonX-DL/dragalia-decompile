/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultFlController
	{
		// Fields
		private FlashPlayer _flashPlayer;
		private FlMotion rootMotion;
		private FlMotion _effectTriggerMotion;
		private FlMotion numberTargetMotion;
		private int flashNumberValue;
		private List<FlMotion> effectFlMotionList;
		[CompilerGenerated]
		private bool _isInit_k__BackingField;
	
		// Properties
		public FlashPlayer flashPlayer { get; set; }
		public bool isInit { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FlMotion effectTriggerMotion { get; set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public QuestResultFlController __4__this;
			public int sortingOrder;
			public string numberTargetName;
			public string triggerName;
			public string[] effects;
			public int numberValue;
			public int numberTargetValue;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _LoadFlashPrefab_b__0(int index);
			internal void _LoadFlashPrefab_b__1();
		}
	
		// Constructors
		public QuestResultFlController();
	
		// Methods
		private FlMotion GetMotion(string motionName);
		private void SetEffectFlMotion(string trigger, string[] effects);
		public bool LoadFlashPrefab(string path, Transform parent, string triggerName, string[] effects, int numberValue, string numberTargetName, int numberTargetValue, int sortingOrder);
		public void FlEnter();
		public void FlExit();
		public void FlEffectStart();
		public void FlEffectReset();
	}
}
