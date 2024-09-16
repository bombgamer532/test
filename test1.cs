using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = Count(new int[] {11, 5, 8}, 2);
            Console.WriteLine(count);
        }
        
        public static int Count(int[] population, int desiredColor)
        {
            int count = 0;
            if(desiredColor == 0)
            {
                if(population[1]==0 && population[2]==0)
                {
                    return -1;
                }
                if(population[1] < population[2])
                {
                    while(population[0]>=0 && population[2]>=0)
                    {
                        if(population[1] == population[2])
                        {
                            count += population[1];
                            return count;
                        }
                        population[0]--;
                        population[2]--;
                        population[1] += 2;
                        count++;
                    }
                    return -1;
                }
                else if(population[1] > population[2])
                {
                    while(population[0]>0 && population[1]>0)
                    {
                        if(population[1] == population[2])
                        {
                            count += population[1];
                            return count;
                        }
                        population[0]--;
                        population[1]--;
                        population[2] += 2;
                        count++;
                    }
                    return -1;
                }
                else
                {
                    return population[1]*2;
                }
            }
            else if(desiredColor == 1)
            {
                if(population[0]==0 && population[2]==0)
                {
                    return -1;
                }
                if(population[0] < population[2])
                {
                    while(population[1]>=0 && population[2]>=0)
                    {
                        if(population[0] == population[2])
                        {
                            count += population[0];
                            return count;
                        }
                        population[1]--;
                        population[2]--;
                        population[0] += 2;
                        count++;
                    }
                    return -1;
                }
                else if(population[0] > population[2])
                {
                    while(population[1]>=0 && population[0]>=0)
                    {
                        if(population[0] == population[2])
                        {
                            count += population[0];
                            return count;
                        }
                        population[1]--;
                        population[0]--;
                        population[2] += 2;
                        count++;
                    }
                    return -1;
                }
                else
                {
                    return population[0];
                }
            }
            else if(desiredColor == 2)
            {
                if(population[0]==0 && population[1]==0)
                {
                    return -1;
                }
                if(population[0] < population[1])
                {
                    while(population[2]>=0 && population[1]>=0)
                    {
                        if(population[0] == population[1])
                        {
                            count += population[0];
                            return count;
                        }
                        population[2]--;
                        population[1]--;
                        population[0] += 2;
                        count++;
                    }
                    return -1;
                }
                else if(population[0] > population[1])
                {
                    while(population[2]>=0 && population[0]>=0)
                    {
                        if(population[0] == population[1])
                        {
                            count += population[0];
                            return count;
                        }
                        population[2]--;
                        population[0]--;
                        population[1] += 2;
                        count++;
                    }
                    return -1;
                }
                else
                {
                    return population[0];
                }
            }
            return -1;
        }
    }
}