using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class DungeonBgModelProduction : MonoBehaviour
	{
		public enum ChangeBgTextureProductionKind
		{
			Off = -2,
			On,
			ActionA,
			ActionB,
			ActionC,
			ActionD,
			ActionE,
			ActionF,
			ActionG,
			ActionH,
			ActionI,
			ActionJ,
			EnumMax
		}

		public enum ChangeBgProductionKind
		{
			Default,
			ChronosBefore,
			ChronosAfter
		}

		public enum BgModelGroup
		{
			GroupA,
			GroupB,
			EnumMax
		}

		public class BgModelGroupData
		{
			public List<Renderer> rendererList;

			public List<Animator> animatorList;

			public List<TextureScroll> textureScrollList;

			public void SetEnable(bool enableFlag)
			{
			}
		}

		public class ChronosProductionData
		{
			public AnimationCurve curveGear;

			public float delayGear;

			public float delayImageEffect;
		}

		private ChronosProductionData chronosProductionData;

		private List<Coroutine> stopProductionCoroutineList;

		private List<Coroutine> changeBgGroupCoroutineList;

		private List<Coroutine> changeBgTextureCoroutineList;

		private BgModelGroupData[] bgModelGroupDataArray;

		private BgModelGroup currentBgModelGroup;

		private CameraGroupCtrl _cameraGroupCtrl;

		public DungeonBgMaterialProduction dungeonBgMaterialProduction
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

		public void ClearCoroutineList(List<Coroutine> list)
		{
		}

		public void ClearStopProductionCoroutineList()
		{
		}

		public void ClearChangeBgGroupCoroutineList()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetQuestStart()
		{
		}

		public void SetWinProduction()
		{
		}

		public void EntryBgModelGroupObject(BgModelGroup groupId, GameObject entryObj)
		{
		}

		public bool ContainsBgModelGroup(Renderer tempRenderer)
		{
			return default(bool);
		}

		public void SetChronosStopProduction(bool stopFlag, float productionDelay)
		{
		}

		private IEnumerator CoChronosStopProduction(bool stopFlag, float productionDelay)
		{
			return null;
		}

		public ImageEffectCtrlCronos GetImageEffectCtrl()
		{
			return null;
		}

		public void FadeStopTimeEffect(float fadeValue, bool isFadeIn)
		{
		}

		public void ChangeBgTexture(ChangeBgTextureProductionKind kind)
		{
		}

		private IEnumerator CoChangeBgTexture(ChangeBgTextureProductionKind kind)
		{
			return null;
		}

		public void ChangeBgModelGroup(ChangeBgProductionKind kind, BgModelGroup groupId)
		{
		}

		public void SetChronosProductionData(float delayImageEffect, float delayGear, AnimationCurve curveGear)
		{
		}

		private IEnumerator CoChangeBgModelGroupChronosBefore(BgModelGroup groupId)
		{
			return null;
		}

		private IEnumerator CoChangeBgModelGroupChronosBeforeGear()
		{
			return null;
		}

		private IEnumerator CoChangeBgModelGroupChronosAfter(BgModelGroup groupId)
		{
			return null;
		}

		private void SetActiveBgModelGroup(BgModelGroup groupId)
		{
		}
	}
}
