/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-scope
this code may need to run in the hackerrank online ide to work correctly
*****************************/
public Difference(int[] elements)
        {
            this.elements = elements;
        }


        public void computeDifference()
        {
            int? maxAbsoluteValue=null;

            for(int i = 0; i < elements.Count(); i++)
            {
                for(int x = i; x < elements.Count(); x++)
                {
                    int tmpAbsoluteValue = Math.Abs(elements[i] - elements[x]);
                    if (!maxAbsoluteValue.HasValue || tmpAbsoluteValue > maxAbsoluteValue)
                    {
                        maxAbsoluteValue = tmpAbsoluteValue;
                    }
                }
            }

            maximumDifference = maxAbsoluteValue.Value;
        }