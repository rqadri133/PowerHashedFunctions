// See https://aka.ms/new-console-template for more information



       
long maxSum = CalculateHashed.GenerateHashed("cAr1");

Console.WriteLine($"The Calculated Hashed is {maxSum}");
long maxSum2 = CalculateHashed.GenerateHashed("000A");
Console.WriteLine($"The Calculated Hashed is {maxSum2}");

long maxSum3 = CalculateHashed.GenerateHashed("HelloCinderall@199");
Console.WriteLine($"The Calculated Hashed is {maxSum2}");


class Pod 
{
   public int PodId 
   {
      get;
      set;
   }
   public string PodName 
   {
      get;
      set;
   }

   public string TenenantID 
   {
      get;
      set;
   }

   public string PodKey
   {
      get;
      set;
   }
   public bool PodAvailable 
   {
      get;
      set;

   }

   public bool PodDeActivated
   {
      get;
      set;
   }

   public int MaxMemoryAvailable 
   {
      get;
      set;
   }


   public int MemoryLeft 
   {
      get;
      set;

   }


}

class CalculateHashed
{

   public static long GenerateHashed(string pass)
   {
         int maxpowerhash =  pass.Length ;
         long sumMax = 0;
          Console.WriteLine($"For the Formuale f'(C) * 131 to the powermax accumulate till the powermax 0");
              
         for(int i=0 ; i < pass.Length ; i++ )
         {
            int selected = (int) pass[i];
             if(maxpowerhash > 0 )
             {
                Console.WriteLine($"Current select valaue is for the character {pass[i]} == {selected} and power sum {(long) ( (double) selected  * (Math.Pow(131, (double) maxpowerhash )))}");
                sumMax =  sumMax + ( (long) ( (double) selected  * (Math.Pow(131, (double) maxpowerhash ))));
                
             }
             else 
             {
               sumMax = sumMax + (long) selected;

             }
              
              maxpowerhash = maxpowerhash - 1;
           


         }    
         return sumMax;

         




   }

   



}

