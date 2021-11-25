using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class InGameGradationManager : FastUpdateMonoBehaviour
	{
		public enum GradationType
		{
			ChainSkillButton
		}

		[SerializeField]
		[Header("parameter")]
		[Tooltip("é\u0080£æ\u0090ºã\u0082¹ã\u0082­ã\u0083«ç\u0094\u00a8ã\u0081®ã\u0082¹ã\u0082­ã\u0083«ã\u0083\u009cã\u0082¿ã\u0083³ã\u0082°ã\u0083©ã\u0083\u0087ã\u0083¼ã\u0082·ã\u0083§ã\u0083³")]
		private Gradient _chainSkillButtonGradient;

		private Material[] _materialList;

		private Texture2D[] _textureList;

		public static readonly int enumGradationTypeCount;

		public void Setup(GradationType type)
		{
		}

		private void OnDestroy()
		{
		}

		public void UpdateMaterialParam(GradationType type, float value)
		{
		}

		public Material GetMaterial(GradationType type)
		{
			return null;
		}

		public Texture2D GetTexture(GradationType type)
		{
			return null;
		}
	}
}
