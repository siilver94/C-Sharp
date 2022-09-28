int diff = 0;
                int near = 0;
                int[] arr2 = new int[200];
                int[] arr4 = new int[200];

                for (int i = 0; i < endx.Length; i++)
                {
                    if (endx[i] > 0)
                    {
                        diff = Convert.ToInt32( endx[i]) - 0;
                    }
                    else
                    {
                        diff = 0 - Convert.ToInt32(endx[i]);
                    }

                    arr2[i] = diff;
                    arr4[i] = diff;
                }

                Array.Sort(arr2, endx);
                Array.Sort(arr4, endy);

                Console.WriteLine("---------------");
                for (int i = 0; i < endx.Length; i++)
                {
                    Console.WriteLine(endx[i]);
                }
                Console.WriteLine("---------------");
                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.WriteLine(arr2[i]);
                }
                Console.WriteLine("---------------");
                for (int i = 0; i < endy.Length; i++)
                {
                    Console.WriteLine(endy[i]);
                }
