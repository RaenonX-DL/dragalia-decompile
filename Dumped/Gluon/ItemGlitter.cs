using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ItemGlitter : MonoBehaviour
	{
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
		private Image imageGlitter;

		private RectTransform rectTransform;

		private Tweener tweener;

		private bool isActive;

		private void Visible(bool b, bool force = false)
		{
		}

		public static ItemGlitter Create(GameObject parent, GameObject prefab)
		{
			return null;
		}

		private void Initialize()
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

		public void DisplayLocal(Parameter param)
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
