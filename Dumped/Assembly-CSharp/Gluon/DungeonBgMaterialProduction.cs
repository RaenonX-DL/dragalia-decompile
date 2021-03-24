/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DungeonBgMaterialProduction : MonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private DungeonBgModelProduction.ChangeBgTextureProductionKind actionOn;
		[Range]
		[SerializeField]
		[Tooltip]
		private float actionOnEvaluateTime;
		[SerializeField]
		[Tooltip]
		private DungeonBgModelProduction.ChangeBgTextureProductionKind actionOff;
		[Range]
		[SerializeField]
		[Tooltip]
		private float actionOffEvaluateTime;
		[SerializeField]
		[Tooltip]
		private MaterialProductionData[] materialProductionDataArray;
		[CompilerGenerated]
		private DungeonBgArtistBgMaterialGroup _dungeonBgArtistBgMaterialGroup_k__BackingField;
	
		// Properties
		public DungeonBgArtistBgMaterialGroup dungeonBgArtistBgMaterialGroup { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[Serializable]
		private class MaterialProductionCommon
		{
			// Fields
			[Tooltip]
			public bool enable;
			[Tooltip]
			public DungeonBgArtistBgMaterialGroup.MaterialGroupID materialGroupID;
			[Tooltip]
			public DungeonBgArtistBgMaterialGroup.MaterialPropertyLabel materialPropertyLabel;
	
			// Constructors
			public MaterialProductionCommon();
		}
	
		[Serializable]
		private class MaterialProductionFloat : MaterialProductionCommon
		{
			// Fields
			[Tooltip]
			public AnimationCurve curveF;
	
			// Constructors
			public MaterialProductionFloat();
		}
	
		[Serializable]
		private class MaterialProductionVector : MaterialProductionCommon
		{
			// Fields
			[Tooltip]
			public AnimationCurve curveX;
			[Tooltip]
			public AnimationCurve curveY;
			[Tooltip]
			public AnimationCurve curveZ;
	
			// Constructors
			public MaterialProductionVector();
		}
	
		[Serializable]
		private class MaterialProductionColor : MaterialProductionCommon
		{
			// Fields
			[Tooltip]
			public Gradient gradient;
	
			// Constructors
			public MaterialProductionColor();
		}
	
		[Serializable]
		private class MaterialProductionData
		{
			// Fields
			[Tooltip]
			public string name;
			[Tooltip]
			public bool enable;
			[Tooltip]
			public float timeScale;
			[Tooltip]
			public DungeonBgModelProduction.ChangeBgTextureProductionKind productionKind;
			[Tooltip]
			public MaterialProductionFloat[] floatDataArray;
			[Tooltip]
			public MaterialProductionVector[] vectorDataArray;
			[Tooltip]
			public MaterialProductionColor[] colorDataArray;
			[CompilerGenerated]
			private float _endTime_k__BackingField;
	
			// Properties
			public float endTime { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public MaterialProductionData();
	
			// Methods
			public void CalcEndTime();
		}
	
		// Constructors
		public DungeonBgMaterialProduction();
	
		// Methods
		private void CalcEndTime();
		public bool SetBgTextureParam(DungeonBgModelProduction.ChangeBgTextureProductionKind srcKind, float time);
		private void Start();
	}
}
