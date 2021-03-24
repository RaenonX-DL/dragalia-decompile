/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DungeonBgArtistBgMaterialGroup : MonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private GameObject productionObject;
		[SerializeField]
		[Tooltip]
		private List<MaterialGroupData> _materialGroupDataList;
		private static int[] materialPropertyIDArray;
	
		// Properties
		public List<MaterialGroupData> materialGroupDataList { get; }
	
		// Nested types
		public enum MaterialGroupID
		{
			A = 0,
			B = 1,
			C = 2,
			D = 3,
			E = 4,
			H = 5,
			G = 6,
			I = 7,
			J = 8,
			K = 9,
			L = 10,
			M = 11,
			N = 12,
			O = 13,
			P = 14,
			Q = 15,
			R = 16,
			S = 17,
			T = 18,
			U = 19,
			V = 20,
			W = 21,
			X = 22,
			Y = 23,
			Z = 24
		}
	
		public enum MaterialPropertyLabel
		{
			Color = 0,
			SubTextureAlpha = 1,
			SubPaletteAlpha = 2
		}
	
		[Serializable]
		public class MaterialGroupData
		{
			// Fields
			[Tooltip]
			public string name;
			[Tooltip]
			public MaterialGroupID id;
			[Tooltip]
			public List<Material> materialList;
			[NonSerialized]
			public List<Material> materialsWorkList;
	
			// Constructors
			public MaterialGroupData();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__12 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__12(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DungeonBgArtistBgMaterialGroup();
		static DungeonBgArtistBgMaterialGroup();
	
		// Methods
		public void SetFloat(MaterialGroupID groupID, MaterialPropertyLabel propertyLabel, float value);
		public void SetVector(MaterialGroupID groupID, MaterialPropertyLabel propertyLabel, Vector4 vec);
		public void SetColor(MaterialGroupID groupID, MaterialPropertyLabel propertyLabel, Color color);
		private void Awake();
		[IteratorStateMachine]
		public IEnumerator Start();
	}
}
