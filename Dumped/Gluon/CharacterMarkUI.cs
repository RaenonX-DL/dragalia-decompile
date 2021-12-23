using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class CharacterMarkUI : MonoBehaviour
	{
		public enum DisplayType
		{
			None,
			QuestHP,
			Targeting,
			UnTargeting
		}

		protected bool isVisible;

		public virtual void Show(DisplayType type, [Optional] CharacterBase target)
		{
		}

		public virtual void UpdatePosition(bool interpolation = true)
		{
		}

		public static Vector2 GetScreenPos(Vector3 pos)
		{
			return default(Vector2);
		}

		public virtual void SetPlayerNo(int no, bool own)
		{
		}

		public virtual void SetVisible(bool visible)
		{
		}

		public virtual bool IsVisible()
		{
			return default(bool);
		}

		public virtual void CreateCircleGaugeUI(CharaCircleGaugeUI.Type type)
		{
		}

		public virtual void ShowCircleGaugeUI(CharaCircleGaugeUI.Type type)
		{
		}

		public virtual void HideCircleGaugeUI(CharaCircleGaugeUI.Type type)
		{
		}

		public virtual void SetCircleGaugeUIGaugeTimer(CharaCircleGaugeUI.Type type, float time, float initialTime)
		{
		}

		public virtual void SetCircleGaugeUICount(CharaCircleGaugeUI.Type type, int count)
		{
		}

		public virtual void SetCircleGaugeUIAdjustPos(CharaCircleGaugeUI.Type type, Vector3 pos)
		{
		}

		public virtual void SetCircleGaugeUIAdjustScale(CharaCircleGaugeUI.Type type, float scale)
		{
		}

		public virtual bool IsVisibleCircleGauge()
		{
			return default(bool);
		}

		public virtual EnemyAbilityHeadGaugeUI CreateEnemyAbilityHeadGaugeUI(EnemyAbilityHeadGaugeUI.IconType type)
		{
			return null;
		}

		public virtual VesselBombUI CreateVesselBombUI()
		{
			return null;
		}

		protected bool CheckVisible()
		{
			return default(bool);
		}

		public virtual void OnUpdateHpGaugeShineGaugeFade(float value)
		{
		}

		public virtual void OnUpdateHpGaugeShineLocalPosX(float value)
		{
		}
	}
}
