using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	public class GraphicUtility
	{
		public static void InstantiateMaterial(GameObject gameObject, bool isMaterialShared)
		{
		}

		public static void SetLerpRimParam(float statusLerpRimWidth, float statusLerpRimMax, float statusLerpRimSpeed, float statusLerpRimOffset)
		{
		}

		public static void SetCharaColor(MaterialPropertyBlock materialPropertyBlock, CharacterColor colorCtrl, bool isStatusColorSet)
		{
		}

		public static void SetMixingPropertyRatio(MaterialPropertyBlock materialPropertyBlock, int propertyID, float ratio, float min = 0f, float max = 1f)
		{
		}

		public static void SetMixingTexture(MaterialPropertyBlock materialPropertyBlock, int preId, Texture2D preImage, int postId, Texture2D postImage, int preSTId, Vector2 scale, Vector2 offset)
		{
		}

		public static void SetMixingTextureRatio(MaterialPropertyBlock materialPropertyBlock, float ratio)
		{
		}

		public static void SetAuraCutoutRaito(MaterialPropertyBlock materialPropertyBlock, float ratio)
		{
		}

		public static void SetAuraColorRaito(MaterialPropertyBlock materialPropertyBlock, float ratio)
		{
		}

		public static void SetAntiAliasing(AntiAliasingLabel label)
		{
		}

		public static AntiAliasingLabel GetAntiAliasing()
		{
			return default(AntiAliasingLabel);
		}
	}
}
