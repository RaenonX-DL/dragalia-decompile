/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class PlayerBulletTemplate : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public SpriteRenderer image;
		public Transform tf;
		[Header]
		[SerializeField]
		public Sprite[] fadeOutSprites;
		public Sprite[] animationSprites;
		[Header]
		[SerializeField]
		public float r;
		public float ezR;
		[SerializeField]
		public LevelData[] levelData;
	
		// Nested types
		[Serializable]
		public class PlayerBulletData
		{
			// Fields
			public int angle;
			public float speed;
			public float power;
			public int timeMod;
			public int timeModVal;
			public float xOffset;
			public float yOffset;
			public int delayIndex;
	
			// Constructors
			public PlayerBulletData();
	
			// Methods
			public void CopyFrom(PlayerBulletData otherData);
		}
	
		[Serializable]
		public class LevelData
		{
			// Fields
			public PlayerBulletData[] data;
			public int seOffset;
	
			// Constructors
			public LevelData();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public LevelData l;
			public PlayerBulletTemplate __4__this;
			public int v;
			public PlayerBulletData d;
			public int ci;
			public int[] timeModRanges;
			public float r;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _AdjustLevelData_b__0(int c);
			internal void _AdjustLevelData_b__1(int c, int angle, int timeMod);
		}
	
		// Constructors
		public PlayerBulletTemplate();
	
		// Methods
		public void Init();
		private void FillBuildData();
		private void AddCenter(int bunch);
		private void AddSide(int bunch, int beginIndex);
		public void AdjustLevelData(PlayerBulletData baseData, int[] centerCounts, int[] sideACounts, int[] sideBCounts, int[] timeModRanges, int[] timeModARanges, int[] timeModBRanges, int[] angleSet);
	}
}
