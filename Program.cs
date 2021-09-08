using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;

/*
 * Notes:  each question is scripted as a function and can be called from main 
 * please uncomment the function calls in the  for running specific question 
 * inputs can be requested in the main and also the constraints can be changed in the function
 * for example the length/size please refer to notes below
 * 
 */

namespace DIS_Assignmnet1_Fall_2021
{
    class Program
    {
        static void Main(string[] args)
        {


            Program questions = new Program();
            /*
                       // 4,5,6,7,0,2,1,3

                                    // calling the function here for question 1

                                                string inputVal_question1;
                                                Console.Write("Please enter val question 2 :");
                                                inputVal_question1 = Console.ReadLine();
                                                bool f_reslut = questions.HalvesAreAlike(inputVal_question1);
                                                Console.WriteLine("The result for input :  "+ inputVal_question1 + " : " +"is  "+ f_reslut + "<------note:  if result is false  then the strings are not alike");
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*

            // calling the function here for question 2
            string inputVal_question2;
                        Console.Write("Please enter val for question 2 :");
                        inputVal_question2 = Console.ReadLine();
                        bool result2 = questions.CheckIfPangram(inputVal_question2);
                        Console.WriteLine("Result  :  " + result2);
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // hari

            /* 
             * 
                        change values in the part of the code in the function

                             * MaximumWealth[0] = new int[] { 1, 2 };

                            MaximumWealth[1] = new int[3];

                            MaximumWealth[2] = new int[3];
                             */
            /*
            // calling the function here for question 3
            int[][] a = JaggedReturn();
                         MaximumWealth(a);
            */

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////          

          /*  
            //calling the function here for calling q4 

            string jewels;
            Console.Write("Please enter val for jewels:");
            jewels = Console.ReadLine();
            string stones;
            Console.Write("Please enter val for stones:");
            stones = Console.ReadLine();

            int result = questions.NumJewelsInStones(jewels, stones);
            Console.WriteLine("The result for input :  " + jewels +"  &&   "+ stones+ "    " + "is  " + result);
            */

 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////            

/*
            //calling question5
            string result3 = "codeleet";  // you can change the value here & indices = [4,5,6,7,0,2,1,3] as input

            List<string> indicesList = new List<string> { };
            int[] indices = new int[result3.Length];
            int count = 0;
            do
            {
                Console.WriteLine("Please Enter val : ");
                string val = Console.ReadLine();
                if (indicesList.Contains(val))
                {
                    Console.WriteLine("Please Enter new val : ");
                    val = Console.ReadLine();
                }
                indicesList.Add(val);
                count++;
            } while (count < result3.Length);
            for (int i = 0; i < indicesList.Count; i++)
            {
                indices[i] = Int32.Parse(indicesList[i]);
            }
            string input = questions.RestoreString(result3, indices);
            Console.WriteLine(result3);

            */

 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            
            ///calling questn 6


            int[] nums = new int[5]; //index = [0,1,2,2,1]
            nums[0] = 0;
            nums[1] = 1;
            nums[2] = 2;
            nums[3] = 3;
            nums[4] = 4;
            List<string> indexList = new List<string> { };
            int[] index = new int[nums.Length];
          
            int count1 = 0;

            do
            {
                Console.WriteLine("Please Enter val : ");
                string val = Console.ReadLine();

                indexList.Add(val);
                count1++;
            } while (count1 < nums.Length);

            for (int i = 0; i < indexList.Count; i++)
            {
                index[i] = Int32.Parse(indexList[i]);
            }

            int[] output = questions.CreateTargetArray(nums, index);
            Console.WriteLine(nums);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            IDictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(6225, "ISM");
            dict.Add(6226, "ISM6225");
            dict.Add(6227, "ISM6225");



        }

        // question 1
        public bool HalvesAreAlike(string input)
            {

            try
            {

                //     input = "book";
                string vowels = "aAeEiIoOuU";
                string a = input.Substring(0, input.Length / 2);
                string b = input.Substring(input.Length / 2);

                int a_vowelscount = 0;
                int b_vowelscount = 0;
                foreach (char letter in vowels)
                {

                    if (a.Contains(letter))
                        a_vowelscount++;

                    if (b.Contains(letter))
                        b_vowelscount++;
                }

                if (a_vowelscount == 0 || b_vowelscount == 0)
                {

                    return false;
                }
                else
                {
                    return a_vowelscount == b_vowelscount;

                }

                return a_vowelscount == b_vowelscount;

            }
            catch (Exception) {

                throw;
            }
                
            }


            //// question 2
            public bool CheckIfPangram(string sentence) {

            try
            {

                int sizel = 0;
                int sizeu = 0;


                string lower = "abcdefghijklmnopqrstuvwxyz";
                string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


                List<string> aplha_list = new List<string> { };
                List<int> aplha_list_pos = new List<int> { };


                for (int i = 0; i < sentence.Length; i++)
                {

                    for (int j = 0; j < 26; j++)
                    {
                        if (sentence[i] == lower[j])
                        {
                            aplha_list_pos.Add(lower[j] - 'a' + 1);
                            sizel++;
                        }

                        if (sentence[i] == upper[j])
                        {
                            aplha_list_pos.Add(upper[j] - 'A' + 1);
                            sizeu++;
                        }

                    }

                }

                List<int> final = aplha_list_pos.Distinct().ToList();
                return final.Count == 26;
            }

            catch (Exception) {
                throw;
            }
              
            }


            /// QUESTION 3: 


            static void MaximumWealth(int[][] accounts)
            {
            try
            {

                // int[,] total = new int[3,3];
                List<int> maxnuber = new List<int> { };
                for (int i = 0; i < accounts.Length; i++)
                {
                    //  int i, j, sum = 0;
                    int sum2 = 0;
                    for (int j = 0; j < accounts[i].Length; j++)
                    {
                        Console.Write($"{accounts[i][j]}\t");



                        sum2 = sum2 + accounts[i][j];

                    }

                    Console.Write("\n");

                    maxnuber.Add(sum2);

                }
                int maxVal = maxnuber.Max();
                int lineNo = maxnuber.IndexOf(maxVal) + 1;
                Console.Write("customer  number : " + lineNo + "    is wealthiest with Max val : " + maxVal);

            }

            catch (Exception) {

                throw;
            }

            }
            static int[][] JaggedReturn()
            {
            try
            {
                int[][] MaximumWealth = new int[3][];

                MaximumWealth[0] = new int[] { 1, 2 };

                MaximumWealth[1] = new int[3];

                MaximumWealth[2] = new int[3];


                MaximumWealth[1][0] = 3;
                MaximumWealth[1][1] = 4;
                MaximumWealth[1][2] = 15;

                MaximumWealth[2][0] = 6;
                MaximumWealth[2][1] = 8;
                MaximumWealth[2][2] = 9;


                return MaximumWealth;

            }

            catch (Exception) {
                throw;
            }

            }


        /// Question 4:

        public int NumJewelsInStones(string jewels, string stones)
        {

            try {
                int count = 0;
                string final_jewels = jewels.Substring(0, Math.Min(50, jewels.Length));
                string final_stones = stones.Substring(0, Math.Min(50, stones.Length));


                for (int i = 0; i < final_jewels.Length; i++)
                {

                    for (int j = 0; j < final_stones.Length; j++)
                    {

                        if (final_jewels[i] == final_stones[j])
                        {
                            count++;


                        }


                    }
                }
                return count;
            }

            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }


        }


        // Question 5:
        // "codeleet", indices = [4,5,6,7,0,2,1,3]


        public string RestoreString(string s ,int[] indices) {
            try {

                s = s.Substring(0, Math.Min(100, s.Length));
                char[] final = new char[s.Length];

                //Random ranNum = new Random(s.Length );

                for (int i = 0; i < s.Length; i++)
                {
                    int j = indices[i];
                    // Debug.WriteLine(s[j]);
                    final[j] = s[i];
                }
                Console.WriteLine(final);
                return "hello";

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }




        }

        // Question 6:
        public int[] CreateTargetArray(int[] nums, int[] index)
        {

            /*
            nums[0] = 0;
            nums[1] = 1;
            nums[2] = 2;

            index[0] = 0;
            index[1] = 1;
            index[2] = 2;
            */


            //  nums = Enumerable.Range(0, nums.Length).ToArray();
            // index = Enumerable.Range(0, nums.Length).ToArray();
            try
            {
                List<int> output = new List<int> { };
                for (int i = 0; i < nums.Length; i++)
                {
                    int j = index[i];

                    output.Insert(j, nums[i]);
                }
                for (int k = 0; k < output.Count; k++)
                {
                    Debug.WriteLine(output[k]);
                    Console.WriteLine("o/p   "+output[k]);
                }
                return index;
            }

            catch (Exception) {
                throw;
            }

        }

        

    }
}

