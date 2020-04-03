namespace Constellation {
	public class LessCondition : ICondition {
		Ray var1;
		Ray var2;

		public LessCondition(Ray _var1, Ray _var2)
		{
			var1 = _var1;
			var2 = _var2;
		}
		public bool isConditionMet () {
			if(var1.GetFloat() < var2.GetFloat())
				return true;
			else 
				return false;
		}
	}
}