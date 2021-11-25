using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class UIFollowTarget : MonoBehaviour
	{
		private RectTransform rectTransform;

		private FortScene fortScene;

		private Camera mainCamera;

		[SerializeField]
		[Header("ã\u0082«ã\u0083¡ã\u0083©ã\u0081\u008cä\u00b8\u0080ç\u0095ªè¿\u0091ã\u0081\u0084æ\u0099\u0082ã\u0081\u00a8é\u0081\u00a0ã\u0081\u0084æ\u0099\u0082ã\u0080\u0081gaugeã\u0081®æ\u008b¡ç\u00b8®å\u009b\u00a0å­\u0090")]
		public Vector2 gaugeScaleRange;

		public bool needChangeScale;

		public Vector3 positionOffset
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Transform target
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

		public void OnInit(FortScene scene, [Optional] Transform transTarget)
		{
		}

		public void OnInit(FortScene scene, Vector3 offset, [Optional] Transform transTarget)
		{
		}

		protected void LateUpdate()
		{
		}

		public void UpdatePosition()
		{
		}
	}
}
