namespace Pre.ExtensionMethods.Introduction.Cons.Methods;

public static class StringExtensions
{
   
   /// <summary>
   /// This is a test
   /// </summary>
   /// <param name="emailAddress"></param>
   /// <returns></returns>
   public static bool IsValidEmailAddress(this string emailAddress)
   {
      return emailAddress.EndsWith("@howest.be");
   } 
}