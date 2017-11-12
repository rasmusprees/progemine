using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller
{
    
    public class DiceRoller

    {

        public List<DiceRoll> Roll(List<Dice> dices)
        {
            var result = new List<DiceRoll>();

            foreach(var dice in dices)
            {
                result.Add(new DiceRoll(dice.Description, dice.Roll()));
            }

            return result;
        }

    }
    
}
