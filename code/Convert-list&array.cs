	 var numberListX = endx.ToList();
                var numberListY = endy.ToList();

                int endxdelete = 0;

                for (int i = 1; i < endx.Length; i++)
                {
                    if (Math.Abs(Convert.ToInt32(endx[i]) - Convert.ToInt32(endx[i - 1])) != 0 && Math.Abs(Convert.ToInt32(endx[i]) - Convert.ToInt32(endx[i - 1])) < (numericUpDown3.Value) / 2 &&     Math.Abs(Convert.ToInt32(endy[i]) - Convert.ToInt32(endy[i - 1])) < (numericUpDown4.Value) / 2)
                  
                    {
                        numberListX.RemoveAt(i);
                        numberListY.RemoveAt(i);
                        endxdelete += 2;
                        patterncnt -= 1;
                    }
                }

                endx = numberListX.ToArray();
                endy = numberListY.ToArray();
