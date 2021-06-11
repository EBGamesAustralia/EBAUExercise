namespace EBAUExercise.Services
{
	public class CountingService
	{
		private static int requestCount = 0;
		
		public static void Reset()
		{
			requestCount = 0;
		}
		
		public static void Increment()
		{
			requestCount += 1;
		}
		
		public static int Get()
		{
			return requestCount;
		}
	}
}