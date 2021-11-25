using UnityEngine;

namespace Gluon
{
	public class GradientCell : MonoBehaviour
	{
		protected bool isGradientShaderSetted;

		private QuestListCellShaderExchanger _shaderExchanger;

		public QuestListCellShaderExchanger shaderExchanger => null;

		public virtual bool SetGradientShader()
		{
			return default(bool);
		}
	}
}
