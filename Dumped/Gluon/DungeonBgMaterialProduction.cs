using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class DungeonBgMaterialProduction : MonoBehaviour
	{
		[Serializable]
		private class MaterialProductionCommon
		{
			[Tooltip("æ\u009c\u0089å\u008a¹ã\u0081\u008b")]
			public bool enable;

			[Tooltip("æ\u0093\u008dä½\u009cã\u0082\u0092è¡\u008cã\u0081\u0086ã\u0083\u009eã\u0083\u0086ã\u0083ªã\u0082¢ã\u0083«ã\u0082°ã\u0083«ã\u0083¼ã\u0083\u0097ID")]
			public DungeonBgArtistBgMaterialGroup.MaterialGroupID materialGroupID;

			[Tooltip("æ\u0093\u008dä½\u009cã\u0082\u0092è¡\u008cã\u0081\u0086ã\u0083\u0091ã\u0083\u0086ã\u0083ªã\u0082¢ã\u0083«ã\u0081®ã\u0083\u0097ã\u0083­ã\u0083\u0091ã\u0083\u0086ã\u0082£ã\u0083©ã\u0083\u0099ã\u0083«")]
			public DungeonBgArtistBgMaterialGroup.MaterialPropertyLabel materialPropertyLabel;
		}

		[Serializable]
		private class MaterialProductionFloat : MaterialProductionCommon
		{
			[Tooltip("æµ®å\u008b\u0095å°\u008fæ\u0095°ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0082«ã\u0083¼ã\u0083\u0096")]
			public AnimationCurve curveF;
		}

		[Serializable]
		private class MaterialProductionVector : MaterialProductionCommon
		{
			[Tooltip("Xã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0082«ã\u0083¼ã\u0083\u0096")]
			public AnimationCurve curveX;

			[Tooltip("Yã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0082«ã\u0083¼ã\u0083\u0096")]
			public AnimationCurve curveY;

			[Tooltip("Zã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿ã\u0082«ã\u0083¼ã\u0083\u0096")]
			public AnimationCurve curveZ;
		}

		[Serializable]
		private class MaterialProductionColor : MaterialProductionCommon
		{
			[Tooltip("ã\u0082«ã\u0083©ã\u0083¼ã\u0082°ã\u0083©ã\u0083\u0087ã\u0083¼ã\u0082·ã\u0083§ã\u0083³")]
			public Gradient gradient;
		}

		[Serializable]
		private class MaterialProductionData
		{
			[Tooltip("ã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³å\u0090\u008dï¼\u0088ã\u0082³ã\u0083¡ã\u0083³ã\u0083\u0088ç\u009a\u0084ã\u0081ªã\u0082\u0082ã\u0081®ï¼\u0089")]
			public string name;

			[Tooltip("æ\u009c\u0089å\u008a¹ã\u0081\u008b")]
			public bool enable;

			[Tooltip("ã\u0082¿ã\u0082¤ã\u0083\u00a0ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«")]
			public float timeScale;

			[Tooltip("å\u00af¾è±¡ã\u0081®æ¼\u0094å\u0087ºID")]
			public DungeonBgModelProduction.ChangeBgTextureProductionKind productionKind;

			[Tooltip("æµ®å\u008b\u0095å°\u008fæ\u0095°ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿é\u0085\u008då\u0088\u0097")]
			public MaterialProductionFloat[] floatDataArray;

			[Tooltip("ã\u0083\u0099ã\u0082\u00afã\u0082¿ã\u0083¼å\u009e\u008bã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿é\u0085\u008då\u0088\u0097")]
			public MaterialProductionVector[] vectorDataArray;

			[Tooltip("ã\u0082«ã\u0083©ã\u0083¼å\u009e\u008bã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿é\u0085\u008då\u0088\u0097")]
			public MaterialProductionColor[] colorDataArray;

			public float endTime
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

			public void CalcEndTime()
			{
			}
		}

		[SerializeField]
		[Tooltip("ONã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³")]
		private DungeonBgModelProduction.ChangeBgTextureProductionKind actionOn;

		[SerializeField]
		[Tooltip("Onã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ã\u0081®æ\u008c\u0087å®\u009aã\u0082¿ã\u0082¤ã\u0083\u00a0(0ï½\u009e1)")]
		private float actionOnEvaluateTime;

		[SerializeField]
		[Tooltip("çµ\u0082äº\u0086ã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³")]
		private DungeonBgModelProduction.ChangeBgTextureProductionKind actionOff;

		[SerializeField]
		[Tooltip("Offã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ã\u0081®æ\u008c\u0087å®\u009aã\u0082¿ã\u0082¤ã\u0083\u00a0(0ï½\u009e1)")]
		private float actionOffEvaluateTime;

		[SerializeField]
		[Tooltip("ã\u0083\u009eã\u0083\u0086ã\u0083ªã\u0082¢ã\u0083«æ\u0093\u008dä½\u009cã\u0082\u0092è¡\u008cã\u0081\u0086çµ±æ\u008b¬ã\u0083\u0087ã\u0083¼ã\u0082¿ã\u0081®é\u0085\u008då\u0088\u0097")]
		private MaterialProductionData[] materialProductionDataArray;

		public DungeonBgArtistBgMaterialGroup dungeonBgArtistBgMaterialGroup
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void CalcEndTime()
		{
		}

		public bool SetBgTextureParam(DungeonBgModelProduction.ChangeBgTextureProductionKind srcKind, float time)
		{
			return default(bool);
		}

		private void Start()
		{
		}
	}
}
