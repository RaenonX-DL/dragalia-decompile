using Gluon.GraphicParameter;
using UnityEngine;
using UnityEngine.Serialization;

namespace Gluon
{
	[DisallowMultipleComponent]
	public class ObjectLodStatus : MonoBehaviour
	{
		[Tooltip("ã\u0083¡ã\u0083\u008bã\u0083¥ã\u0083¼ > ã\u0082ªã\u0083\u0097ã\u0082·ã\u0083§ã\u0083³ > ã\u0082²ã\u0083¼ã\u0083\u00a0 > ã\u0082°ã\u0083©ã\u0083\u0095ã\u0082£ã\u0083\u0083ã\u0082\u00afã\u0081®æ¼\u0094å\u0087ºå\u008a¹æ\u009e\u009cã\u0081®è\u00a8­å®\u009aæ\u0099\u0082ã\u0081«ã\u0082ªã\u0083\u0096ã\u0082\u00b8ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081®è¡\u00a8ç¤º/é\u009d\u009eè¡\u00a8ç¤ºã\u0082\u0092å¤\u0089ã\u0081\u0088ã\u0082\u008b\nLow3 > ç°¡æ\u0098\u0093è¡\u00a8ç¤º, Low2 > ã\u0081µã\u0081¤ã\u0081\u0086, Low1 > ã\u0081\u008dã\u0082\u008cã\u0081\u0084...etc.")]
		[FormerlySerializedAs("disableLodLevel")]
		public LodLevel lodLevel;
	}
}
