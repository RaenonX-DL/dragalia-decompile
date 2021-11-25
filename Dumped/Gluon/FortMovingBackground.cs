using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class FortMovingBackground : MonoBehaviour
	{
		[Serializable]
		public class MovingCurve
		{
			public AnimationCurve x;

			public AnimationCurve y;

			public AnimationCurve z;
		}

		[SerializeField]
		private bool isEnabled;

		[SerializeField]
		[Header("ç§»å\u008b\u0095ã\u0081\u0095ã\u0081\u009bã\u0082\u008bã\u0083\u0097ã\u0083¬ã\u0083\u008fã\u0083\u0096å\u0090\u008d(Prefabs/OutGame/Fort/Layout/3D/ä»¥ä\u00b8\u008b)")]
		private string[] movingObjectName;

		private List<GameObject> movingObjectInstanceList;

		[SerializeField]
		[Header("ä\u00b8\u008aè\u00a8\u0098ã\u0083\u0097ã\u0083¬ã\u0083\u008fã\u0083\u0096ã\u0081®ã\u0082¢ã\u0082¿ã\u0083\u0083ã\u0083\u0081å\u00a0\u00b4æ\u0089\u0080")]
		private GameObject[] movingObjectRoot;

		[SerializeField]
		[Header("åº§æ\u00a8\u0099å¤\u0089å\u008c\u0096ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0082«ã\u0083¼ã\u0083\u0096(æ\u00a8ªè»\u00b8ç\u00af\u0084å\u009b²ã\u0081\u00afå¿\u0085ã\u0081\u009a0ï½\u009e1ã\u0081«ã\u0081\u0099ã\u0082\u008b)")]
		private MovingCurve[] movingCurve;

		[SerializeField]
		[Header("ç§»å\u008b\u0095ã\u0081«ã\u0081\u008bã\u0081\u0091ã\u0082\u008bæ\u0099\u0082é\u0096\u0093")]
		private float[] movingDuration;

		private float[] movingTimer;

		[SerializeField]
		[Header("ç§»å\u008b\u0095é\u0096\u008bå§\u008bæ\u0099\u0082ã\u0081®ä½\u008dç½®(å\u0088\u009dæ\u009c\u009fä½\u008dç½®0.0ï½\u009eç§»å\u008b\u0095é\u0099\u0090ç\u0095\u008cå\u0080¤1.0)")]
		private float[] movingStartRatio;

		private List<Vector3> initialPositionList;

		private const string prefabFolderPath = "Prefabs/OutGame/Fort/Layout/3D/";

		private void Start()
		{
		}

		private IEnumerator LoadMovingObjectAsync()
		{
			return null;
		}

		private void Update()
		{
		}
	}
}
