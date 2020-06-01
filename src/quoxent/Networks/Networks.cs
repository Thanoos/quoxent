using NBitcoin;

namespace quoxent.Networks
{
   public static class Networks
   {
      public static NetworksSelector quoxent
      {
         get
         {
            return new NetworksSelector(() => new quoxentMain(), () => new quoxentTest(), () => new quoxentRegTest());
         }
      }
   }
}
