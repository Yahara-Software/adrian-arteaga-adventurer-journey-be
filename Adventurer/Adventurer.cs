namespace Adventurer
{
    public class Adventurer
    {
        public int xPos;
        public int yPos;

        // Constructor using a 2D array as position of Adventurer
        public Adventurer()
        {
            xPos = 0;
            yPos = 0;
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
                int numSteps = int.Parse(stepVal);

                if (i < input.Length)
                {
                    char direction = input[i];
                    i++;

                    // Get direction and move
                    switch (direction)
                    {
                        case 'F':
                            yPos += numSteps;
                            break;
                        case 'B':
                            yPos -= numSteps;
                            break;
                        case 'L':
                            xPos -= numSteps;
                            break;
                        case 'R':
                            xPos += numSteps;
                            break;
                        default:
                            Console.WriteLine("The direction given is not valid. Last given instruction skipped.");
                            break;
                    }
                }
            }
        }

        // Get Euclidean distance from start to end
        public static double getEuclidean(Adventurer adventurer)
        {
            return Math.Sqrt(adventurer.xPos * adventurer.xPos + adventurer.yPos * adventurer.yPos);
        }
    }
}