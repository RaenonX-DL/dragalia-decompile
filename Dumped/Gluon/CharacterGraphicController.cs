using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class CharacterGraphicController : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("ã\u0083¡ã\u0082¤ã\u0083³ã\u0083\u0091ã\u0083¼ã\u0083\u0084ã\u0081\u008bã\u0082\u0089é\u0099¤å¤\u0096ã\u0081\u0099ã\u0082\u008bã\u0083¬ã\u0083³ã\u0083\u0080ã\u0083©ã\u0083¼")]
		private List<Renderer> _ignoreMainRenderers;

		public bool IsIgnoreMainRenderer(Renderer renderer)
		{
			return default(bool);
		}
	}
}
