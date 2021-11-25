using System.Collections;
using System.Collections.Generic;
using Cutt;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	public class SimpleCharacterModel : MonoBehaviour
	{
		public enum FacialControlKind
		{
			NotAvailable = -1,
			Eye,
			Mouth,
			Nof
		}

		public enum ShadowCastMethod
		{
			TexturedQuad,
			TextureProjection,
			MaxNum
		}

		private Renderer[] renderers;

		private MaterialPropertyBlock _materialPropertyBlock;

		private bool isSwitchTexture;

		private SkinnedMeshRenderer[] skinnedMeshRendererList;

		private MaterialPropertyBlock textureSwitchMaterialPropertyBlock;

		public Transform weaponNodeR;

		public Transform weaponNodeL;

		public Transform modelCenter;

		private bool renderDestroyFlg;

		public bool isDummyModel;

		private CuttCharacterFaceData faceData;

		private List<Material>[] facialMaterialListArray;

		private SimpleCharacterFacialControlInterface[] facialControls;

		public const int cuttDefaultTextureIndexEye = 0;

		public const int cuttDefaultTextureIndexMouth = 0;

		public bool isBlinkEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool isMouthAnimationEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool IsFacialControlEnabled(FacialControlKind kind)
		{
			return default(bool);
		}

		public void SetFacialControlEnabled(FacialControlKind kind, bool f)
		{
		}

		public void SetTriggerToFacialControl(FacialControlKind kind, string triggerName)
		{
		}

		public void SetCharaFace(CharaFaceEye eye, CharaFaceMouth mouth)
		{
		}

		private void Awake()
		{
		}

		public void DestroyWeapon()
		{
		}

		private IEnumerator GetRenderersDelay()
		{
			return null;
		}

		public void SetupDefaultFacialTexture()
		{
		}

		public void SetDefaultFacialAnimation()
		{
		}

		public void SetupFacialMaterials()
		{
		}

		private List<Material> GetInstantiatedMaterialByName(string materialNamePrefix)
		{
			return null;
		}

		public void SetFacialTextureByIndex(FacialControlKind kind, int cuttTextureIndex)
		{
		}

		public void SetFacialTextureOffset(FacialControlKind kind, Vector2 offset)
		{
		}

		private void SetDefaultBlinkAnimation(bool isPlay)
		{
		}

		private void SetDefaultMouthAnimation(bool isPlay)
		{
		}

		public void SetFacialControl(FacialControlKind kind, SimpleCharacterFacialControlInterface control, bool isPlay = true)
		{
		}

		private void SetProperties(MaterialPropertyBlock materialPropertyBlock, Color color)
		{
		}

		public void SetColor(Color color)
		{
		}

		private void LateUpdate()
		{
		}

		public void SwitchModelTexture(RenderPartsData.PartsNo changePartsNo)
		{
		}

		public static Transform FindOptimizedChildTransform(Transform parent, string path)
		{
			return null;
		}
	}
}
