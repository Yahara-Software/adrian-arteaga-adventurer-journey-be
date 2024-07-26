namespace Adventurer
{
    public class Adventurer
    {
        public int[] position;

        // Constructor using a 2D array as position of Adventurer
        public Adventurer()
        {
            position = new int[] { 0, 0 };
        }

        // Update position of Adventurer based on input
        public void updatePosition(string input)
        {
            int i = 0;
            while (i < input.Length)
            {
                // Get number of steps per direction input
                string stepVal = string.Empty;
                while (i < input.Length && Char.IsDigit(input[i]))
                {
                    stepVal += input[i];
                    i++;
                }

                // Typecast stepVal to int
                /**
                 Error: typecast is not parsing the string to int
                 */
                int totalSteps = int.Parse(stepVal);

                // Get direction input
                if (double.TryParse(input[i].ToString(), out double num))
                {
                    // Move in the x direction
                    if (input[i] == 'R')
                    {
                        position[0] += totalSteps;
                    }
                    else if (input[i] == 'L')
                    {
                        position[0] -= totalSteps;
                    }
                }
                else
                {
                    // Move in the y direction
                    if (input[i] == 'F')
                    {
                        position[1] += totalSteps;
                    }
                    else if (input[i] == 'B')
                    {
                        position[1] -= totalSteps;
                    }
                }   
            }
        }

        // Get Euclidean distance from start to end
        public double getEuclidean()
        {
            int dx = 0 - this.position[0];
            int dy = 0 - this.position[1];
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}