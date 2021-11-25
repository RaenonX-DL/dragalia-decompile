using UnityEngine;

namespace Gluon
{
	public class SafetyZoneComponent : MonoBehaviour
	{
		public enum Shape
		{
			None,
			Sphere,
			Cube
		}

		[SerializeField]
		[Tooltip("ç\u0084¡å\u008a¹å\u008c\u0096ã\u0081\u0099ã\u0082\u008bã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ã\u0081®ID")]
		private int _invalidActionId;

		[SerializeField]
		[Tooltip("ç\u0084¡å\u008a¹å\u008c\u0096ã\u0081\u0099ã\u0082\u008bã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ã\u0081®ID(è¤\u0087æ\u0095°è\u00a8­å®\u009aç\u0094\u00a8)")]
		private int[] _invalidActionIdArray;

		[SerializeField]
		[Tooltip("å½¢ç\u008a¶")]
		private Shape _shape;

		[SerializeField]
		[Tooltip("å\u008d\u008aå¾\u0084 or é\u0095·ã\u0081\u0095)")]
		private float _length;

		[SerializeField]
		[Tooltip("å¹\u0085(ã\u0082­ã\u0083¥ã\u0083¼ã\u0083\u0096ç\u0094\u00a8)")]
		private float _width;

		[SerializeField]
		[Tooltip("é«\u0098ã\u0081\u0095(ã\u0082­ã\u0083¥ã\u0083¼ã\u0083\u0096ç\u0094\u00a8)")]
		private float _height;

		[SerializeField]
		[Tooltip("ã\u0082³ã\u0083ªã\u0082\u00b8ã\u0083§ã\u0083³ã\u0081®å\u0090\u0091ã\u0081\u008fæ\u0096¹å\u0090\u0091ã\u0081«safetyZoneã\u0082\u0092ç\u0094\u009fæ\u0088\u0090ã\u0081\u0095ã\u0081\u009bã\u0082\u008bã\u0083\u0095ã\u0083©ã\u0082°")]
		private bool _isCheckHitCollisionForward;

		public int invalidActionId => default(int);

		public int[] invalidActionIdList => null;

		public Shape shape => default(Shape);

		public float length => default(float);

		public float width => default(float);

		public float height => default(float);

		public bool isCheckHitByCollisionForward => default(bool);
	}
}
