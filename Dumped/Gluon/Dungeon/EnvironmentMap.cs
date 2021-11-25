using System;
using System.Runtime.CompilerServices;
using Gluon.GraphicParameter;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon
{
	[ExecuteInEditMode]
	public class EnvironmentMap : MonoBehaviour
	{
		public enum ModelType
		{
			None = -1,
			High,
			Low
		}

		private MapCulling _mapCulling;

		[SerializeField]
		public Vector3 _reflectionRotateSpeed;

		[NonSerialized]
		public float _reflectionRotateFrame;

		[HideInInspector]
		public Texture2D charaShaderTex;

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

		[SerializeField]
		[HideInInspector]
		private Vector3 _mapTransformAxisX;

		[SerializeField]
		[HideInInspector]
		private Vector3 _mapTransformAxisZ;

		private static readonly string[] _modelRootObjectNames;

		private GameObject[] _modelTypeRootObjects;

		private bool _isEnableReflectionRotate;

		public MapCulling mapCulling => null;

		public float fogStartDistance
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float fogEndDistance
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 mapTransformAxisX => default(Vector3);

		public Vector3 mapTransformAxisZ => default(Vector3);

		private void UpdateFogDistance()
		{
		}

		public void SetFogDistance(float start, float end)
		{
		}

		public void SetActiveModelType(ModelType type)
		{
		}

		public void InitializeMapCulling()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void SetupFromMasterAreaData(OutDungeonAreaDesignerDataElement designerAreaData, DungeonManager.eStageDifficulty stageDifficulty)
		{
		}

		public void SetupFromMasterAreaData(DungeonAreaDesignerDataElement designerAreaData, DungeonCharacterShaderDataElement charaShaderDataElem)
		{
		}

		private void SetupCharacterShaderFromMasterData(DungeonCharacterShaderDataElement charaShaderDataElem)
		{
		}

		public void SetShaderParam()
		{
		}

		public void SetTiltShiftParam()
		{
		}
	}
}
