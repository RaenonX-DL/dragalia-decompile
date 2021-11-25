using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class InGameCanvas : MonoBehaviour
	{
		private ChangeResolutionCanvas _changeResolution;

		public Canvas canvas
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public RectTransform rectTransform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void GetCanvasComponent()
		{
		}

		private void Awake()
		{
		}

		public void InitializeCanvas(CameraGroup inGameUICameraGroup, CameraGroup mainCameraGroup)
		{
		}

		public void UpdateCanvas(InGameFooterUI footer)
		{
		}
	}
}
