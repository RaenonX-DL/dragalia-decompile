using System;

namespace Gluon
{
	[Serializable]
	public class AIScriptValue
	{
		public enum ValueType
		{
			String,
			Int,
			Float
		}

		public string valString;

		public int valInt;

		public float valFloat;

		public ValueType valType;

		public string[] splitValStrings;

		public ValueType Type => default(ValueType);

		public AIScriptValue(string str)
		{
		}

		public AIScriptValue(int val)
		{
		}

		public AIScriptValue(float val)
		{
		}

		public void SetValue(string str, bool isParser = false)
		{
		}

		public void SetValue(int val)
		{
		}

		public void SetValue(float val)
		{
		}

		public void SetValue(AIScriptValue value)
		{
		}

		public void AddValue(AIScriptValue value)
		{
		}

		public void SubValue(AIScriptValue value)
		{
		}

		public void MulValue(AIScriptValue value)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
