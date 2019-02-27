using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace katalogos
{
    class GreekEncoder
    {
        private Dictionary<char, char> pairings;

        public GreekEncoder()
        {
            this.setupPairings();
        }

        private void setupPairings()
        {
            this.pairings = new Dictionary<char, char>();
            this.pairings['a'] = 'α';
            this.pairings['b'] = 'β';
            this.pairings['c'] = 'ψ';
            this.pairings['d'] = 'δ';
            this.pairings['e'] = 'ε';
            this.pairings['f'] = 'φ';
            this.pairings['g'] = 'γ';
            this.pairings['h'] = 'η';
            this.pairings['i'] = 'ι';
            this.pairings['j'] = 'ξ';
            this.pairings['k'] = 'κ';
            this.pairings['l'] = 'λ';
            this.pairings['m'] = 'μ';
            this.pairings['n'] = 'ν';
            this.pairings['o'] = 'ο';
            this.pairings['p'] = 'π';
            //this.pairings['q'] = '';
            this.pairings['r'] = 'ρ';
            this.pairings['s'] = 'σ';
            this.pairings['t'] = 'τ';
            this.pairings['u'] = 'θ';
            this.pairings['v'] = 'ω';
            this.pairings['w'] = 'ς';
            this.pairings['x'] = 'χ';
            this.pairings['y'] = 'υ';
            this.pairings['z'] = 'ζ';
        }

        // Get the matching key or value from pairings dictionary
        private char getPair(char input)
        {
            input = char.ToLower(input);
            char result = ' ';
            if (this.pairings.ContainsKey(input))
            {
                result = this.pairings[input];
            } else if (this.pairings.ContainsValue(input))
            {
                foreach (KeyValuePair<char, char> pair in this.pairings)
                {
                    if (pair.Value == input)
                    {
                        result =  pair.Key;
                    }
                }
            }
            return result;
        }

        public string resolveInput(string userInput)
        {
            string result = "";

            foreach (char c in userInput)
            {
                result = result + this.getPair(c);
            }

            return result;
        }
    }
}
