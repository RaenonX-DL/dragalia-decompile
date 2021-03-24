/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.GraphicParameter;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	[ExecuteInEditMode]
	public class EnvironmentMap : MonoBehaviour
	{
		// Fields
		private MapCulling _mapCulling;
		[SerializeField]
		public Vector3 _reflectionRotateSpeed;
		[NonSerialized]
		public float _reflectionRotateFrame;
		[HideInInspector]
		public Texture2D charaShaderTex;
		[CompilerGenerated]
		private float _fogStartDistance_k__BackingField;
		[CompilerGenerated]
		private float _fogEndDistance_k__BackingField;
		[NonSerialized]
		public Color bgColor;
		[NonSerialized]
		public Color silhouetteBaseColor;
		[NonSerialized]
		public Color silhouetteRimColor;
		[NonSerialized]
		public BackgroundShaderParameter backgroundShaderParameter;
		[NonSerialized]
		public CharaShaderParameter charaShaderParameter;
		[NonSerialized]
		public TiltShiftBloomParam tiltShiftBloomParam;
		[HideInInspector]
		[SerializeField]
		private Vector3 _mapTransformAxisX;
		[HideInInspector]
		[SerializeField]
		private Vector3 _mapTransformAxisZ;
		private static readonly string[] _modelRootObjectNames;
		private GameObject[] _modelTypeRootObjects;
		private bool _isEnableReflectionRotate;
	
		// Properties
		public MapCulling mapCulling { get; }
		public float fogStartDistance { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float fogEndDistance { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Vector3 mapTransformAxisX { get; }
		public Vector3 mapTransformAxisZ { get; }
	
		// Nested types
		public enum ModelType
		{
			None = -1,
			High = 0,
			Low = 1
		}
	
		// Constructors
		public EnvironmentMap();
		static EnvironmentMap();
	
		// Methods
		private void UpdateFogDistance();
		public void SetFogDistance(float start, float end);
		public void SetActiveModelType(ModelType type);
		public void InitializeMapCulling();
		private void Awake();
		private void OnDestroy();
		private void Start();
		private void Update();
		public void SetupFromMasterAreaData(OutDungeonAreaDesignerDataElement designerAreaData, DungeonManager.eStageDifficulty stageDifficulty);
		public void SetupFromMasterAreaData(DungeonAreaDesignerDataElement designerAreaData, DungeonCharacterShaderDataElement charaShaderDataElem);
		private void SetupCharacterShaderFromMasterData(DungeonCharacterShaderDataElement charaShaderDataElem);
		public void SetShaderParam();
		public void SetTiltShiftParam();
	}
}
