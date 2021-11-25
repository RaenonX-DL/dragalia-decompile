using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class StoryImage
	{
		public Vector3 completePosition;

		public Vector3 completeScale;

		public bool completeVisible;

		public Color completeColor;

		public float completeRotate;

		public Image image;

		public CanvasGroup group;

		public Vector2 initPos;

		public List<Tweener> currentTweenList;

		public virtual void SetCompleteData()
		{
		}

		public virtual void SetVisible(bool visible)
		{
		}

		public virtual void SetColor(Color color)
		{
		}

		public void SetPosition(Vector3 position)
		{
		}

		public void SetScale(Vector3 scale)
		{
		}

		public void SetRotate(float rotate)
		{
		}

		public void KillTweenList(bool complete = false)
		{
		}
	}
}
