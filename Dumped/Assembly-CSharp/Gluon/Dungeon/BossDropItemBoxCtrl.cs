/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class BossDropItemBoxCtrl : MonoBehaviour
	{
		// Fields
		public DropItemBox.TreasureBoxKind boxKind;
		private const int maxBox = 6;
		[SerializeField]
		private int normalNum;
		[SerializeField]
		private int normalTreasureTimeNum;
		[SerializeField]
		private int hardNum;
		[SerializeField]
		private int hardTreasureTimeNum;
		[SerializeField]
		private int veryHardNum;
		[SerializeField]
		private int veryHardTreasureTimeNum;
		[SerializeField]
		private int extremeNum;
		[SerializeField]
		private int extremeTreasureTimeNum;
		[SerializeField]
		private int hellNum;
		[SerializeField]
		private int hellTreasureTimeNum;
		[SerializeField]
		private int variation6Num;
		[SerializeField]
		private int variation6TreasureTimeNum;
		[SerializeField]
		private int variation7Num;
		[SerializeField]
		private int variation7TreasureTimeNum;
		[SerializeField]
		private int variation8Num;
		[SerializeField]
		private int variation8TreasureTimeNum;
		[SerializeField]
		private int variation9Num;
		[SerializeField]
		private int variation9TreasureTimeNum;
		[SerializeField]
		private int variation10Num;
		[SerializeField]
		private int variation10TreasureTimeNum;
		[SerializeField]
		private PositionData[] positionData01;
		[SerializeField]
		private PositionData[] positionData02;
		[SerializeField]
		private PositionData[] positionData03;
		[SerializeField]
		private PositionData[] positionData04;
		[SerializeField]
		private PositionData[] positionData05;
		[SerializeField]
		private PositionData[] positionData06;
		private List<PositionData[]> positionDataList;
		private List<BossDropItemBox> bossDropItemBoxList;
		private int bossDropItemBoxIndex;
		private int bossDropItemBoxUseCount;
		private int bossDropItemBoxOpenCount;
		private int bossDropItemBoxNumMax;
		private bool needAssignSerialNumberOnStart;
		private static readonly string[] boxPrefabNameArray;
	
		// Nested types
		[Serializable]
		private class PositionData
		{
			// Fields
			public Vector3 position;
			public float rotY;
	
			// Constructors
			public PositionData();
		}
	
		[CompilerGenerated]
		private sealed class _DisplayBossItemBox_d__42 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BossDropItemBoxCtrl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DisplayBossItemBox_d__42(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BossDropItemBoxCtrl();
		static BossDropItemBoxCtrl();
	
		// Methods
		private void Start();
		public void SetParent(Transform parent);
		private void SetBossItem(DropItemUI.Parameter param);
		public void SetBossItemBox(DropItemUI.Parameter param);
		public void Display();
		[IteratorStateMachine]
		public IEnumerator DisplayBossItemBox();
		public void OnOpenBossItemBox();
		public bool IsOpenBossItemBox();
		public void AssignSerialNumbers();
	}
}
