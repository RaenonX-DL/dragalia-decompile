using Cute.Core;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	public class PartsTextureScroll : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0082\u00afã\u0083­ã\u0083¼ã\u0083«ç\u0094\u00a8ã\u0081®ã\u0083\u0087ã\u0083¼ã\u0082¿")]
		private PartsTextureScrollData[] _partsTextureScrollData;

		[SerializeField]
		[Tooltip("ã\u0082¤ã\u0083³ã\u0082²ã\u0083¼ã\u0083\u00a0æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢æ¼\u0094å\u0087ºã\u0081®å½±é\u009f¿ã\u0082\u0092å\u008f\u0097ã\u0081\u0091ã\u0082\u008b")]
		private bool enableStopProduction;

		private RenderPartsData _renderPartsData;

		private float _startTime;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		protected void Reset()
		{
		}

		public override void FastUpdate()
		{
		}
	}
}
