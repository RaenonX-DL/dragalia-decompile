using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DropCoinGlitter : MonoBehaviour
	{
		[Serializable]
		public class GlitterData
		{
			public Image image;

			public RectTransform rectTrans;

			private float originPos;

			private float targetPos;

			private float originRot;

			private float targetRot;

			private float originScale;

			private float targetScale;

			private const float movePosY = 32f;

			private Vector3 _vec;

			public void Initalize()
			{
			}

			public void SetParam()
			{
			}

			public void OnUpdate(float v)
			{
			}
		}

		public class Parameter
		{
			public Vector3 position;

			public float scale;

			public float time;

			public void SetValue(Vector3 p, float s, float t)
			{
			}
		}

		[SerializeField]
		[Header("component")]
		private GlitterData[] glitterData;

		private RectTransform rectTransform;

		private Tweener tweener;

		private bool isActive;

		private void Visible(bool b, bool force = false)
		{
		}

		public static DropCoinGlitter Create(GameObject parent, GameObject prefab)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public void UpdateParam()
		{
		}

		public void Release()
		{
		}

		public bool IsVisible()
		{
			return default(bool);
		}

		public void Display(Parameter param)
		{
		}

		public void Stop()
		{
		}

		private void OnUpdateAnim(float v)
		{
		}

		private void OnCompleteAnim()
		{
		}
	}
}
