namespace ImperativeVsDeclarative
{
    public class Exercise
    {
        /* The new requirement says that the score of the word
         * should now be equal to the number of characters that are
         * different than 'a'.
         */

        public static int CalculateScore(string word)
        {
            // Imperative paradigm - focus is on how, because we are
            // encouraged to directly implement the algorithm - the "how" part

            var score = 0;

            foreach (var character in word)
                if (character != 'a')
                    score++;

            return score;
        }

        public static int WordScore(string word)
        {
            // declarative paradigm - focus is on what, not how

            return word.Count(character => character != 'a');
        }
    }
}