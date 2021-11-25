using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class AnimationListOneCol : MonoBehaviour
	{
		public List<SimpleAnimationCell> animationCells;

		[SerializeField]
		private bool _autoExcuteAnimationInStart;

		[SerializeField]
		private float _startCellAlpha;

		private bool keepingTouchGuard;

		public bool autoExcuteAnimationInStart
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float startCellAlpha
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		private void OnDisable()
		{
		}

		public void ClearAnimationCells()
		{
		}

		public void AddAnimationCell(SimpleAnimationCell animationCell, int delayIndex)
		{
		}

		public void StartEnterAnimation(bool isTableView = false, float delayTime = 0f)
		{
		}

		private IEnumerator ExecuteEnterAnimation(bool isTableView, float delayTime)
		{
			return null;
		}

		public void StartExitAnimation(bool isTableView = false, float delayTime = 0f, bool isEnableTouchGuardOnAnimation = false)
		{
		}

		private IEnumerator ExecuteExitAnimation(bool isTableView, float delayTime, bool isEnableTouchGuardOnAnimation = false)
		{
			return null;
		}

		public bool IsOnAnimation()
		{
			return default(bool);
		}

		public void EnableResetPositionBeforeStartAnimation(bool enable)
		{
		}
	}
}
