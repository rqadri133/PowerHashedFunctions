// See https://aka.ms/new-console-template for more information




using stronglyhashed.Classes.Util;

CalculateHashed.RunTestCases();

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
    public static void RunTestCases()
    {
        List<Line> lines = FileContextReader.ReadFile(@"/Users/syedqadri/Documents/Development/stronglyhashed/TestData/input001.txt");
        List<long> hashedList = new List<long>();
        List<int> hashedInts = new List<int>();
        foreach (Line l in lines)
        {
           string[] inputData = l.LineContent.Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
           if(inputData[0] == "setPassword")
           {
               long hashed = GenerateHashed(inputData[1]);
               Console.WriteLine($"hashed map is {hashed % 10000000007}");
               hashedList.Add((hashed % 10000000007));
               for(char k = '0' ; k < 'Z' ; k++)
               {
                 // string str = inputData[1] + k.ToString();
                  long rehashed = hashed + 1;
                  Console.WriteLine($"Re hashed is {rehashed % 1000000007}");
                  hashedList.Add((rehashed % 10000000007)); 
               }   
           }
           else 
           {

              long hashedFound = Convert.ToInt64(inputData[1]);
              // authorize (
               if(hashedList.Contains(hashedFound))
               {
                  hashedInts.Add(1);

               }
               else 
               {
                  hashedInts.Add(0);
               }
           }
         }
           for(int i =0 ; i < hashedInts.Count ; i++)
           {
              Console.WriteLine(hashedInts[i]);
           }
        

    }
      

   public static long GenerateHashed(string pass)
   {
         int maxpowerhash =  pass.Length -1  ;
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
         return sumMax ;

         




   }

   



}

