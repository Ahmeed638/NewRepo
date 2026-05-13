using System;

List<int> inputs = new List <int> { };

string choices = "";


do
 {
    Console.WriteLine("P. print numbers"); // 
    Console.WriteLine("A. Add numbers"); // 
    Console.WriteLine("M. display the average of the numbers"); //
    Console.WriteLine("S. display the smallest number"); //
    Console.WriteLine("L. display the largest number"); //
    Console.WriteLine("F. find a number"); //
    Console.WriteLine("C. Clear the whole list"); //
    Console.WriteLine("Q. Quit");

    Console.WriteLine("Enter your choices");
    choices = Console.ReadLine().ToUpper();

    switch (choices)
    {
        case "A":
            Console.WriteLine("Enter numbers seperated with spaces");
            string[] nums = Console.ReadLine().Split(" ");

            for (int i = 0; i < nums.Length; i++ )
            {
                int num = 0;
                if (int.TryParse(nums[i],out num))
                {
                    inputs.Add(num);

                }
                else
                {
                    Console.WriteLine("Invalid number");
                }
           

            }


          
            break;


        case "P":
            if (inputs.Count == 0)
            {
                Console.WriteLine("No numbers found");
            }
            else
            {
               

                for (int i = 0; i< inputs.Count; i++)
                {
                    Console.WriteLine(inputs[i]);

                }


            }
         
            break;


        case "M":

            if (inputs.Count==0)
            {
                Console.WriteLine("No numbers found");
            }
            else
            {
                int sum = 0;

                for (int i = 0;i< inputs.Count; i++)
                {

                    sum += inputs[i];


                }

                 int average = sum / inputs.Count;

                Console.WriteLine(average);


            }
            break;

        case "S":
            if (inputs.Count == 0)
            {
                Console.WriteLine("No numbers found");
            }
            else
            {
                int smallest = inputs[0]; // [1 , 5 , 7 , 9 , ....]

                for (int i = 0; i < inputs.Count; i++)

                {

                    if (smallest >  inputs[i])
                    {
                        smallest = inputs[i];
                    }

                }

                Console.WriteLine(smallest);

            }
            break;


        case "L":
            if (inputs.Count == 0)
            {
                Console.WriteLine("No numbers found");
            }
            else
            {
                int largest = inputs[0];

                for (int i = 0; i < inputs.Count; i++)
                {
                    if (largest < inputs[i])
                    {
                        largest = inputs[i];
                    }

                }
                Console.WriteLine(largest);

            }

            break;


        case "F":
            Console.WriteLine("Enter number");
            int search = Convert.ToInt32(Console.ReadLine());

            if (inputs.Contains(search))
            {
                Console.WriteLine("Number found");
            }
            else
            {
                Console.WriteLine("Number not found");
            }
            break;

        case "C":
            inputs.Clear();
            Console.WriteLine("List cleared");
            break;



    }


    }

while (choices != "Q");


































