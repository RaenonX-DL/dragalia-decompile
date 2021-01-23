/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class DungeonBgArtistSwitchTransform : ProductionTimeCallback
	{
		// Fields
		public static readonly int dataIdReset;
		[SerializeField]
		private int dataIdProductionTime;
		public List<SwitchData> switchDataList;
		private static List<DungeonBgArtistSwitchTransform> scrList;
	
		// Nested types
		public enum UpdateKind
		{
			None = 0,
			World = 1,
			Local = 2
		}
	
		[Serializable]
		public class SwitchData
		{
			// Fields
			public int id;
			public UpdateKind posKind;
			public Vector3 setPos;
			public UpdateKind rotKind;
			public Vector3 setRot;
	
			// Constructors
			public SwitchData();
		}
	
		// Constructors
		public DungeonBgArtistSwitchTransform();
		static DungeonBgArtistSwitchTransform();
	
		// Methods
		protected override void Awake();
		public SwitchData GetOriginalData(bool fullSet);
		private void OnDestroy();
		public static void SetSwitchId(int id);
		public void SetData(int id);
		private void SetData(SwitchData tempData);
		public override void OnProductionTime();
	}
}
