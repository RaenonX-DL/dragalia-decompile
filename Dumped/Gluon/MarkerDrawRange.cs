using System;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	public class MarkerDrawRange
	{
		[Tooltip("è¥¿å\u0081\u00b4ã\u0081®è¡\u00a8ç¤ºé\u0099\u0090ç\u0095\u008cå\u0080¤")]
		public float minX;

		[Tooltip("æ\u009d±å\u0081\u00b4ã\u0081®è¡\u00a8ç¤ºé\u0099\u0090ç\u0095\u008cå\u0080¤")]
		public float maxX;

		[Tooltip("å\u008d\u0097å\u0081\u00b4ã\u0081®è¡\u00a8ç¤ºé\u0099\u0090ç\u0095\u008cå\u0080¤")]
		public float minZ;

		[Tooltip("å\u008c\u0097å\u0081\u00b4ã\u0081®è¡\u00a8ç¤ºé\u0099\u0090ç\u0095\u008cå\u0080¤")]
		public float maxZ;

		[Tooltip("ä\u00b8­å¿\u0083ã\u0081\u008bã\u0082\u0089ã\u0081®è¡\u00a8ç¤ºé\u0099\u0090ç\u0095\u008cå\u0080¤")]
		public float radius;

		public void Set(MarkerDrawRange src)
		{
		}
	}
}
